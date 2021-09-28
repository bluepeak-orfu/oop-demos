using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGrunderDemo
{
    class Point
    {
        private readonly int _z;

        public int X
        {
            get;
        }
        public int Y
        {
            get;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            _z = 0;
        }

        public void TryChangeZ()
        {
            //_z += 2; // Fungerar inte
        }
    }
}
