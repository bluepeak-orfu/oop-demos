using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOArvDemo
{
    class ElectricCar : Car
    {
        public void ConnectToCharger()
        {
            Console.WriteLine("Connected to charger");
        }
        public override void Start()
        {
            Console.WriteLine("Car is silent!");
        }
    }
}
