using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOArvDemo
{
    class Motorcycle : Vehicle
    {
        public override int NumberOfWheels
        {
            get
            {
                return 2;
            }
        }

        public override void TurnLeft()
        {
            Console.WriteLine("The front wheels turned to the left");
        }
    }
}
