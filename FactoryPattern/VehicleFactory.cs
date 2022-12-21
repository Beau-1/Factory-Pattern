using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
        public static IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    Console.WriteLine("A car? Yes, right away!");
                    return new Car();
                    
                case "motorcycle":
                    Console.WriteLine("A motorcycle? Perfect, making one now!");
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }

    }
}
