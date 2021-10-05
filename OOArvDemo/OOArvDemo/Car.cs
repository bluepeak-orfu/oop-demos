using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOArvDemo
{
    public class Car : Vehicle, ICanBreak, ICanBreak2
    {
        public string RegNumber { get; init; }
        public string Color { get; init; }

        public override int NumberOfWheels
        {
            get
            {
                return 4;
            }
        }

        public virtual void Start()
        {
            IsRunning = true;
            Console.WriteLine("Car goes wrooom!");
        }

        public override void TurnLeft()
        {
            Console.WriteLine("Both front wheels turned to the left");
        }

        public override string ToString()
        {
            return $"Bil [{RegNumber}] of color {Color}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Car otherCar)
            {
                return RegNumber == otherCar.RegNumber;
            }
            else
            {
                return false;
            }
        }

        void ICanBreak.Break()
        {
            Console.WriteLine("Car is breaking 1");
        }

        void ICanBreak2.Break()
        {
            Console.WriteLine("Car is breaking 2");
        }

        public void ApplyHandbreak()
        {
            Console.WriteLine("Handbreak");
        }
    }
}
