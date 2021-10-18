using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.EnumDemo
{
    class SteeringWheel
    {
        public Direction Steering { get; private set; }

        public SteeringWheel()
        {
            Steering = Direction.StraightAhead;
        }

        public void TurnLeft()
        {
            if (Steering == Direction.Right)
            {
                Steering = Direction.StraightAhead;
            }
            else if (Steering == Direction.StraightAhead)
            {
                Steering = Direction.Left;
            }
            else
            {
                Console.WriteLine("Can't go more left");
            }
        }

        public void TurnRight()
        {
            switch (Steering)
            {
                case Direction.Left:
                    Steering = Direction.StraightAhead;
                    break;
                case Direction.StraightAhead:
                    Steering = Direction.Right;
                    break;
                default:
                    Console.WriteLine("Can't go more right");
                    break;
            }
        }
    }
}
