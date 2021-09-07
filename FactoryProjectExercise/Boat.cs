using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    class Boat : IVehicle //No tires. Shocking
    {
        public void Drive()
        {
            Console.WriteLine("Building a Boat! Might need another vehicle to get it to the water though."); ;
        }
    }
}
