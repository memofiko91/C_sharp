using System.Drawing;
using System.Transactions;


namespace CarApp
{

    internal class Program
    {

        static void Main(string[] args)
        {

            // -------------- ohne Konstruktor instanziert -------------

            Car car1 = new()
            {
                color = "silver",
                maxSpeed = 250,
                model = "Tesla"
            };

            Console.WriteLine("Color: " + car1.color + ", " + "Model: " + car1.model + ", " + "MaxSpeed: " + car1.maxSpeed);

            // 2. Auto Objekt mit zu hohem maxSpeed Wert
            Car car2 = new()
            {
                color = "blue",
                maxSpeed = 320,
                model = "Volvo"
            };

            Console.WriteLine("Color: " + car2.color + ", " + "Model: " + car2.model + ", " + "MaxSpeed: " + car2.maxSpeed);
            Console.WriteLine();

            // car2.model = "Kia"; --> nicht möglich, da model setter init ist

            Car car3 = new()
            {
                color = "green",
                maxSpeed = 280,
                model = "Nissan"
            };

            car3.StartEngine();
            car3.Drive(70);
            Console.WriteLine($"Fuel Level {car3.model}: {car3.GetFuelLevel(out double maxDistance)} %");
            car3.Drive(56, 130);
            Console.WriteLine();



            Car car4 = new()
            {
                color = "red",
                maxSpeed = 270,
                model = "Ford",
                FuelEfficiency = 11
            };

            // double maxDistance = 0;  =>  muss hier oder direkt bei der Übergabe mit 0 initialisiert werden
            car4.StartEngine();
            car4.Drive(25);
            maxDistance = car4.GetFuelLevel(out maxDistance);
            double fuelLevel = car4.GetFuelLevel(out maxDistance);
            Console.WriteLine("Aktueller Tank: " + fuelLevel + ". Das Auto kann noch : " + maxDistance + " km weit fahren.");
            car3.Drive(56, 130);

            // --------------- mit Konstruktor erstellt -------------------
            Car car5 = new("gold", 255, "Opel", 9);

            Car car6 = new()
            {
                color = "black",
                model = "Audi",
                FuelEfficiency = 13
            }

            int allCars = car6.GetCarCount();
            Console.WriteLine(allCars);

        }
    }
