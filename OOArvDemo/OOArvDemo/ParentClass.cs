using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOArvDemo
{
    class ParentClass
    {
        private string _privateField;
        public string _publicField;
        protected string _protectedField;

        public string MyProp { get; set; }

        //public ParentClass() { } // <- Den finns även om vi inte deklarerar den

        public ParentClass(int x)
        {
            Console.WriteLine($"Parent skapades med {x}");
            _privateField = "private field";
            _publicField = "public field";
            _protectedField = "protected field";
        }

        public void MyMethod()
        {
            Console.WriteLine("parent method");
        }

        public void AccessDemoParent()
        {
            Console.WriteLine($"Private: {_privateField}");
            Console.WriteLine($"Protected: {_protectedField}");
            Console.WriteLine($"Public: {_publicField}");
        }
    }
}
