using System;

namespace FactoryProjectExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            string input;
            
            Console.WriteLine("Welcome to the factory!");

            do
            {
                Console.WriteLine("How many tires does your vehicle have?");
                Console.WriteLine("[0], [1], [2], [3], [4], [18], or [terminate]");
                input = Console.ReadLine();
                
                switch (input.ToLower())
                {
                    case "0":
                        var vehicle = VehicleFactory.GetVehicle(0);
                        vehicle.Drive();
                        break;
                    case "1":
                        vehicle = VehicleFactory.GetVehicle(1);
                        vehicle.Drive();
                        break;
                    case "2":
                        vehicle = VehicleFactory.GetVehicle(2);
                        vehicle.Drive();
                        break;
                    case "3":
                        vehicle = VehicleFactory.GetVehicle(3);
                        vehicle.Drive();
                        break;
                    case "4":
                        vehicle = VehicleFactory.GetVehicle(4);
                        vehicle.Drive();
                        break;
                    case "18":
                        vehicle = VehicleFactory.GetVehicle(18);
                        vehicle.Drive();
                        break;
                    case "terminate":
                        cont = false;
                        Console.WriteLine("Shutting down");
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        break;
                }

                

            } while (cont);


        }
    }
}
