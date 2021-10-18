using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionVecka6.AbstraktDemo2
{
    class Person
    {
        public void Eat(Fruit fruit)
        {
            string fruitTaste = fruit.Taste;
            Console.WriteLine($"The fruit tastes {fruitTaste}");

            //if (fruit.Name == "mango")
            //{
            //    Console.WriteLine("The fruit tastes sweet");
            //}
            //else if (fruit.Name == "lemon")
            //{
            //    Console.WriteLine("The fruit tastes sour");
            //}
        }
    }
}
