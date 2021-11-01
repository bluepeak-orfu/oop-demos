using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo3
{
    class HelloAction : IConsoleAction
    {
        public bool CanDoAction(string actionCommand)
        {
            //if (actionCommand == "say hello")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return actionCommand == "say hello";
        }

        public void DoAction()
        {
            Console.WriteLine("Hello!");
        }
    }
}
