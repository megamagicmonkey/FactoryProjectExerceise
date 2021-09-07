using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProjectExercise
{
    class BigRig : IVehicle //18 TIRES! WOW
    {
        public void Drive()
        {
            Console.WriteLine("Building a Big Rig! It took a lot of resources."); ;
        }
    }
}
 