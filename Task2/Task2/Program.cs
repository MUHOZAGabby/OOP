using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
           Car Subaru = new Car("Subaru", "Impreza", new Engine(2.0, 20));
            Subaru.Go(150);
            Car bmw = new Car("BMW", "No name", new Engine(3.0, 45));
            bmw.Go(20);
        }
    }
}
