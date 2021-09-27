using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGrunderDemo
{
    class Car
    {
        private string _brand;
        public string _regNumber;
        private string _color;
        private int _age;

        public Car() : this("Volvo", "AAA111")
        {
            Console.WriteLine("No parameters");
        }

        public Car(string brand, string regNumber)
        {
            Console.WriteLine("Two parameters");
            _brand = brand;
            _regNumber = regNumber;
            _color = "White";
            _age = 0;
        }

        public void Repaint(string newColor)
        {
            _color = newColor;
        }

        public bool NeedService()
        {
            return _age > 5;
        }

        public string DisplayName(string prefix, string suffix)
        {
            if (prefix == "")
            {
                prefix = "$$$";
            }
            return $"{prefix} {_brand} {suffix}";
        }

        public void IncreaseAge()
        {
            _age++;
        }
    }
}
