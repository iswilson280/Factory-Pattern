using System;
using static FactoryPattern.Program;

namespace FactoryPattern
{
	public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving the car.");
        }
    }
}

