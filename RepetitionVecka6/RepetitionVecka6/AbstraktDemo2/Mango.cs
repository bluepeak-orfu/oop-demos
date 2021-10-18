using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo2
{
    class Mango : Fruit
    {
        public Mango()
        {
            Name = "mango";
        }

        public override string Taste
        {
            get
            {
                return "sweet";
            }
        }
    }
}
