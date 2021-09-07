using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    class Motorcycle : IVehicle //A bicycle with a big motor! Two wheels.
    {
        public void Drive()
        {
            Console.WriteLine("Building a Motorcycle!"); ;
        }
    }
}
