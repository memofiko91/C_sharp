using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Car : Vehicle  // extends
    {
        public string color;
        public string model { get; init; }  // Modell kann nur einmalig gesetzt werden


        // man braucht 2 variablen maxSpeed, weil der Getter sich immer wieder selbst aufruft, wenn er die public aufruft (infinite loop) 
        // der Getter muss hier auf die private Variable zugreifen und auch die private Variable wird gesetzt
        private int _maxSpeed;

        public int maxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value <= 300)
                {
                    _maxSpeed = value;
                }
                else maxSpeed = 300;
            }
        }

        private double _fuelInTank = 58.4;

        public double FuelEfficiency { get; init; }  // km pro Liter - nach dem init nicht änderbar


        private int _carCount // zählt Gesamtanzahl der erstellten Car Objekte



        // Konstruktor 
    
    public Car(String color, int maxSpeed, String model, double FuelEfficiency int _carCount) : base(color, maxSpeed, model)
        {
            this.BatteryCapacity = BatteryCapacity;
            this._carCount = _carCount++;
        }


        // Konstruktoraufrufe umleiten
        public Car(String color, String model) : this(color, 150, model, 5);

        public Car(int maxSpeed, double Effciency String model) : this("weiß", maxSpeed, "Toyota", FuelEfficiency);





        public void StartEngine() { Console.WriteLine($"Der Motor von {model} wurde gestartet."); }

        public void Drive(int distance) { Console.WriteLine($"Das Auto { model} ist { distance} km gefahren."); }

        public void Drive(int distance, int speed) { Console.WriteLine($"Das Auto {model} ist mit einer Geschwindigkeit von { speed} km/h eine Strecke von {distance} km gefahren."); }


        // gibt Tankstand zurück UND max. Strecke zurück, die mit dem Tank gefahren werden kann
        public double GetFuelLevel(out double maxDistance)
        {
            maxDistance = FuelEfficiency * _fuelInTank;
            return _fuelInTank;
        }

        private int GetCarCount() { return _carCount; }
    }


}
