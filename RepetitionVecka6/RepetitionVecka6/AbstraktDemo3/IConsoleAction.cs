using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo3
{
    interface IConsoleAction
    {
        public bool CanDoAction(string value);
        public void DoAction();
    }
}
