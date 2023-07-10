namespace FactoryPattern
{
    public class Program
    {
       
        public static void Main()
        {
            
            var instance = VehicleFactory.GetVehicle(4);
           instance.Drive();

            
        }
    }
}
