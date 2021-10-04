using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOArvDemo
{
    class ChildClass : ParentClass
    {
        //public ChildClass() { } // <- Den finns även om vi inte deklarerar den

        public ChildClass() : base(3)
        {
            Console.WriteLine("Child skapades utan parametrar");
        }

        public ChildClass(int x) : base(x)
        {
            Console.WriteLine($"Child skapades med {x}");
        }

        public void AccessDemoChild()
        {
            //Console.WriteLine($"Private: {_privateField}");
            Console.WriteLine($"Protected: {_protectedField}");
            Console.WriteLine($"Public: {_publicField}");
        }
    }
}
