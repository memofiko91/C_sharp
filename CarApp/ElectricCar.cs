using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class ElectricCar : Vehicle    //extends
    {
        public double BatteryCapacity { get; init; }  // kwh
        public double Energy Consumption { get; init; } // kwh/100km

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
    }

    // Konstruktor 
    public ElectricCar(String color, int maxSpeed, String model, double BatteryCapacity, double EnergyConsumption) : base (color, maxSpeed, model)
    {
        this.BatteryCapacity = BatteryCapacity;
        this.EnergyCosumption = EnergyConsumption;
    }

}

