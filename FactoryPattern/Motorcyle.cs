using System;
using static FactoryPattern.Program;

namespace FactoryPattern
{
	public class Motorcyle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the motorcycle.");
        }
    }
}

