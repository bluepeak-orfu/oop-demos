using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOArvDemo
{
    public abstract class Vehicle
    {
        public bool IsRunning { get; set; }
        public abstract int NumberOfWheels { get; }

        public abstract void TurnLeft();
    }
}
