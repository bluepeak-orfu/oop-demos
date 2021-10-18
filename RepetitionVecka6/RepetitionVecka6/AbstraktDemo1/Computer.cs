using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo1
{
    class Computer : Character
    {
        public override void Move()
        {
            Random random = new Random();
            if (random.Next(0, 2) == 1)
            {
                // Go in X direction
                X += random.Next(-1, 2);
            }
            else
            {
                // Go in Y direction
                Y += random.Next(-1, 2);
            }
        }
    }
}
