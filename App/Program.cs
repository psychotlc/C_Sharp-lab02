using System;


namespace lab2
{
    class Program {
        static void Main(string[] args) {
            task1.solution();
            task2.solution();
            task3.solution();
        }
    }

    public class task1 {

        class Pupil {
            public virtual void Study(){
                Console.WriteLine("Pupil study");
            }

            public virtual void Write(){
                Console.WriteLine("Pupil write");
            }

            public virtual void Read(){
                Console.WriteLine("Pupil read");
            }

            public virtual void Relax(){
                Console.WriteLine("Pupil relax");
            }
        }

        class ExcellentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("ExcellentPupil study");
            }

            public override void Read()
            {
                Console.WriteLine("ExcellentPupil read");
            }

            public override void Write()
            {
                Console.WriteLine("ExcellentPupil write");
            }

            public override void Relax()
            {
                Console.WriteLine("ExcellentPupil relax");
            }
        }

        class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("GoodPupil study");
            }

            public override void Read()
            {
                Console.WriteLine("GoodPupil read");
            }

            public override void Write()
            {
                Console.WriteLine("GoodPupil write");
            }

            public override void Relax()
            {
                Console.WriteLine("GoodPupil relax");
            }
        }

        class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("BadPupil study");
            }

            public override void Read()
            {
                Console.WriteLine("BadPupil read");
            }

            public override void Write()
            {
                Console.WriteLine("BadPupil write");
            }

            public override void Relax()
            {
                Console.WriteLine("BadPupil relax");
            }
        }

        class ClassRoom {
            Pupil [] pupils;
            public ClassRoom(params Pupil [] pupils){
                if (pupils.Length < 2 || pupils.Length > 4){
                    throw new Exception("The class must consist of 2, 3 or 4 students");
                }
                this.pupils = pupils;
            }

            public void Study(){
                for (int i = 0; i < pupils.Length; i++){
                    pupils[i].Study();
                }
            }

            public void Write(){
                for (int i = 0; i < pupils.Length; i++){
                    pupils[i].Write();
                }
                
            }

            public void Read(){
                for (int i = 0; i < pupils.Length; i++){
                    pupils[i].Read();
                }
            }

            public void Relax(){
                for (int i = 0; i < pupils.Length; i++){
                    pupils[i].Relax();
                }
            }

        }

        static public void solution(){
            Console.WriteLine("///////////////task1///////////////");
            Pupil pupil1 = new ExcellentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new ExcellentPupil();

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            Console.WriteLine("Lesson:");
            classRoom.Study();
            Console.WriteLine("Reading:");
            classRoom.Read();
            Console.WriteLine("Writing:");
            classRoom.Write();
            Console.WriteLine("Relaxion:");
            classRoom.Relax();
        }

    }

    public class task2 {

        class Vehicle
        {
            private double[] Coordinates;
            private double Price;
            private double Speed;
            private int Year;

            public Vehicle(double[] Coordinates, double Price, double Speed, int Year)
            {
                this.Coordinates = Coordinates;
                this.Price = Price;
                this.Speed = Speed;
                this.Year = Year;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Coordinates: ({Coordinates[0]}, {Coordinates[1]})");
                Console.WriteLine($"Price: {Price:C}");
                Console.WriteLine($"Speed: {Speed} km/h");
                Console.WriteLine($"Year of Manufacture: {Year}");
            }
        }

        class Plane : Vehicle
        {
            private double Height;
            private int PassengerCount;

            public Plane(double[] Coordinates, double Price, double Speed, int Year, double Height, int PassengerCount)
                : base(Coordinates, Price, Speed, Year)
            {
                this.Height = Height;
                this.PassengerCount = PassengerCount;
            }

            public new void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Height: {Height} meters");
                Console.WriteLine($"Passenger Count: {PassengerCount}");
            }
        }

        class Car : Vehicle
        {
            public Car(double[] coordinates, double price, double speed, int year)
                : base(coordinates, price, speed, year)
            {
            }
        }

        class Ship : Vehicle
        {
            private int PassengerCount;
            private string PortOfRegistration;

            public Ship(double[] Coordinates, double Price, double Speed, int Year, int PassengerCount, string PortOfRegistration)
                : base(Coordinates, Price, Speed, Year)
            {
                this.PassengerCount = PassengerCount;
                this.PortOfRegistration = PortOfRegistration;
            }

            public new void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Passenger Count: {PassengerCount}");
                Console.WriteLine($"Port of Registration: {PortOfRegistration}");
            }
        }

        public static void solution()
        {
            Console.WriteLine("///////////////task2///////////////");
            double[] vehicleCoordinates = { 0, 0 };
            double planePrice = 1000000;
            double planeSpeed = 900;
            int planeYear = 2020;
            double planeAltitude = 12000;
            int planePassengerCount = 150;

            double carPrice = 30000;
            double carSpeed = 150;
            int carYear = 2022;

            double shipPrice = 2000000;
            double shipSpeed = 40;
            int shipYear = 2018;
            int shipPassengerCount = 500;
            string shipPort = "New York";

            Vehicle vehicle = new Vehicle(vehicleCoordinates, planePrice, planeSpeed, planeYear);
            Plane plane = new Plane(vehicleCoordinates, planePrice, planeSpeed, planeYear, planeAltitude, planePassengerCount);
            Car car = new Car(vehicleCoordinates, carPrice, carSpeed, carYear);
            Ship ship = new Ship(vehicleCoordinates, shipPrice, shipSpeed, shipYear, shipPassengerCount, shipPort);

            Console.WriteLine("Vehicle Information:");
            vehicle.ShowInfo();

            Console.WriteLine("\nPlane Information:");
            plane.ShowInfo();

            Console.WriteLine("\nCar Information:");
            car.ShowInfo();

            Console.WriteLine("\nShip Information:");
            ship.ShowInfo();
        }
        
    }

    public class task3 {

        class DocumentWorker
        {
            public void OpenDocument()
            {
                Console.WriteLine("Document is open");
            }

            public virtual void EditDocument()
            {
                Console.WriteLine("Document editing available in version Pro");
            }

            public virtual void SaveDocument()
            {
                Console.WriteLine("Document saving available in version Pro");
            }
        }

        class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Document have edited");
            }

            public override void SaveDocument()
            {
                Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
            }
        }

        class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Document have saved in new format");
            }
        }

        public static void solution()
        {
            Console.WriteLine("///////////////task3///////////////");
            string key = "pro";

            DocumentWorker documentWorker;

            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            Console.ReadLine();
        }


    }
}