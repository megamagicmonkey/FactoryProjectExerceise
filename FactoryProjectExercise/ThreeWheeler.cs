using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    class ThreeWheeler : IVehicle //This is a thing it seems. Three wheels, obviously.
    {
        public void Drive()
        {
            Console.WriteLine("Building a Three Wheeler!"); ;
        }
    }
}
