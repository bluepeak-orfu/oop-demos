using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo2
{
    abstract class Fruit
    {
        public string Name { get; init; }
        public abstract string Taste { get; }
    }
}
