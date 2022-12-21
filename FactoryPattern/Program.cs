

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What vehicle shall we construct today? A car or a motorcycle?");
            string userInput = Console.ReadLine();

            
           IVehicle myCar = VehicleFactory.CreateVehicle(userInput);

            Console.WriteLine("That was fun. Shall we make another one?");
            userInput = Console.ReadLine();

            
        }
    }
}
