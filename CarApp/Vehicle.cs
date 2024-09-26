using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Vehicle
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

        public Vehicle(int maxSpeed, string model, string color)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
            this.color = color;
        }

        public void Drive(int distance) { Console.WriteLine($"{model} ist {distance} km gefahren."); }

        public void Drive(int distance, int speed) { Console.WriteLine($"{model} ist mit einer Geschwindigkeit von {speed} km/h eine Strecke von {distance} km gefahren."); }

    }

}