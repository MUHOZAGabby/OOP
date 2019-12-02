using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2
{
    class Car
    {
        private string make;
        private string model;
        private Engine engine;

        public Car(string newMake, string newModel, double newDisplacement, double newAmountOfFuel, double newFuelTankCapacity) : this(newMake,newModel,new Engine(newDisplacement, newAmountOfFuel, newFuelTankCapacity))
        {

        }
        public Car(string newMake, string newModel, double newDisplacement, double newAmountOfFuel) : this(newMake,newModel,new Engine(newDisplacement, newAmountOfFuel))
        {

        }
        public Car(string newMake, string newModel, Engine newEngine)
        {
            this.make = newMake;
            this.model = newModel;
            this.engine = newEngine;
        }


        public void Go(double howManyKm)
        {
            Console.WriteLine("I am riding");
            while (howManyKm > 0)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Distance to ride : {0,4}", howManyKm);
                this.engine.Work();
                Thread.Sleep(100);
                howManyKm--;
            }

            Console.WriteLine("\nHere I am");

        }

    }
}
