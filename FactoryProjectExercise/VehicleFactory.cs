using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            switch (tires)
            {
                case 0:
                    return new Boat();
                case 1:
                    return new Monowheel();
                case 2:
                    return new Motorcycle();
                case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                case 18:
                    return new BigRig();
                default:
                    Console.WriteLine( "You shouldn't see this, but you get a boat." );
                    return new Boat();
            }
        }
    }
}
