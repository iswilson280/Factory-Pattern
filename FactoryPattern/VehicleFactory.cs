using System;
using static FactoryPattern.Program;

namespace FactoryPattern
{
	public class VehicleFactory
    {
		public static IVehicle GetVehicle(int numberOfTires)
		{
			switch (numberOfTires)
			{
				case 2:
					return new Motorcyle();
				case 4:
					return new Car();
				default:
					return new Car();
			}
		}
	}
}

