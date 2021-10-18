using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo1
{
    abstract class Character
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public abstract void Move();
    }
}
