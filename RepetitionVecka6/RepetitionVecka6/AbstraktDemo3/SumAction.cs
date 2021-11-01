using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo3
{
    class SumAction : IConsoleAction
    {
        public bool CanDoAction(string value)
        {
            return "add numbers" == value;
        }

        public void DoAction()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum: {x + y}");
        }
    }
}
