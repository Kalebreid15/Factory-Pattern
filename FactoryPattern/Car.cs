using System;


using System.Text;


namespace Factories
{
    class Car : IVehicle
    {
        public string Color { get; set; }
        public bool IsElectric { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Sorry I can't text I'm driving my {Color} car");
        }
    }
}
