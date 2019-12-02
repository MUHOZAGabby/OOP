using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Engine
    {
        private const double Mile = 1.6;    // per km
        private const double Gallon = 3.78; // per 1ltr
        readonly public double DefaultFuelTankCapacity = 50; 
        readonly public double Displacement;
        readonly public double FuelTankCapacity;
        private double AmountOfFuel;
        
        public Engine(double newDisplacemnet, double newAmountOfFuel)
        {
            this.Displacement = newDisplacemnet;
            this.AmountOfFuel = newAmountOfFuel;
            if (newAmountOfFuel > DefaultFuelTankCapacity)
                throw new ArgumentException("Too Much Fuel");
            this.FuelTankCapacity = DefaultFuelTankCapacity;
        }
        public Engine(double newDisplacement, double newamountOfFuel, 
            double newFuelTankCapacity) : this(newDisplacement, newamountOfFuel)
        {
            this.FuelTankCapacity = newFuelTankCapacity;
        }

        public static double MPG2Lp100km(double MPG)
        {
            return (100 * Gallon) / (Mile * MPG);
        }
        public static double Lp100km2MPG(double Lp100km)
        {
            return (100 * Gallon) / (Mile * Lp100km);
        }
        public void Work()
        {
            this.AmountOfFuel -= (4*this.Displacement)/100;
            if (this.AmountOfFuel<=0) 
                throw new InvalidOperationException("I am dry");
	     }
        public void Refuel(double fuelAmount)
        {
            if(this.AmountOfFuel + fuelAmount > this.FuelTankCapacity)
                throw new ArgumentException("Fuel on Shoes");
            this.AmountOfFuel += fuelAmount; 
        }

    }
}
