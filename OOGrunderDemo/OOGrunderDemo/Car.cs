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
        private int _currentGear;

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
            _currentGear = 1;
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
            int _age = 1;
            this._age++;
        }

        public void IncreaseByTwo(int x)
        {
            x = x + 2;
        }

        public int ComputeStuff()
        {
            if (_age < 5)
            {
                return 123;
            }
            else
            {
                for (int i = 0; i < _age; i++)
                {
                    if (i == 2)
                    {
                        return 1;
                    }
                }
                return 456;
            }
        }

        public void ComputeMoreStuff()
        {
            for (int i = 0; i < _age; i++)
            {
                if (i == 2)
                {
                    return;
                }
            }
            // code
        }

        public int DoubleAge()
        {
            return 2 * _age;
        }

        public int DoubleAge2() => 2 * _age;

        public void ShiftUp()
        {
            ShiftUp(1);
        }

        public void ShiftUp(int increaseCount)
        {
            _currentGear += increaseCount;
        }

        public int X()
        {
            return 1;
        }

        //public double X()
        //{
        //    return 1.0;
        //}

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                age = 0;
            }
            if (age > 25)
            {
                age = 25;
            }
            _age = age;
        }
    }
}
