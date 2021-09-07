using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    class Car : IVehicle //The golden standard. 4 wheels.
    {
        public void Drive()
        {
            Console.WriteLine("Building a Car!"); ;
        }
    }
}
