using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    class Monowheel : IVehicle //One wheel. Looks fun. Probably dangerous.
    {
        public void Drive()
        {
            Console.WriteLine("Building a Monowheel! Be careful with it!"); ;
        }
    }
}
