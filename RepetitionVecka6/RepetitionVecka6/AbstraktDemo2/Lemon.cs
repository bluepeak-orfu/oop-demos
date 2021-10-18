using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo2
{
    class Lemon : Fruit
    {
        public Lemon()
        {
            Name = "lemon";
        }

        public override string Taste
        {
            get
            {
                return "sour";
            }
        }
    }
}
