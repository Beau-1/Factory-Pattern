using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Motorcycle : IVehicle
    {
        public string Color { get; set; }
        public bool HasHandbreak { get; set; }

        public void Drive() 
        {
            Console.WriteLine("Let's ride!");
        }
    }
}
