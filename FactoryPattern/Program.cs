namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick 2 or 4 wheels");
            int wheels = Int32.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(wheels);
            vehicle.Drive();
            
        }
    }
}
