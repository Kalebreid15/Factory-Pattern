using Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Motorcycle : IVehicle
    {
        public string Color { get; set; } = string.Empty; // Initialize with a default value to avoid CS8618  
        public bool HasHandBreak { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vroom Vroom! I'm driving a motorcycle!");
        }
    }
}
