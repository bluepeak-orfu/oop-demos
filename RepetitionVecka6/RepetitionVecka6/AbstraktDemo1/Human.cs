using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo1
{
    class Human : Character
    {
        public override void Move()
        {
            Console.WriteLine("Where to go?");
            string direction = Console.ReadLine();
            switch (direction)
            {
                case "right":
                    X++;
                    break;
                case "left":
                    X--;
                    break;
                default:
                    Console.WriteLine("Unknown direction");
                    break;
            }
        }
    }
}
