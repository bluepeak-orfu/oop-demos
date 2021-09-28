using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGrunderDemo
{
    class Square
    {
        //public int Width;

        public int Width
        {
            get;
            init;
        }

        public int Height
        {
            get;
            set;
        }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }

        public string Color
        {
            get;
            private set;
        }

        //private int _width;
        //private int _height;

        //public int Width
        //{
        //    get
        //    {
        //        return _width;
        //    }
        //    set
        //    {
        //        _width = value;
        //    }
        //}

        //public int Height
        //{
        //    get
        //    {
        //        return _height;
        //    }
        //    set
        //    {
        //        _height = value;
        //    }
        //}

        //public int Area
        //{
        //    get
        //    {
        //        return _width * _height;
        //    }
        //}

        public int Demo
        {
            set
            {
                Console.WriteLine($"Set-only {value}");
            }
        }

        //// Example with getters and setters
        //public int GetWidth()
        //{
        //    return _width;
        //}

        //public int GetHeight()
        //{
        //    return _height;
        //}

        //public void SetWidth(int width)
        //{
        //    _width = width;
        //}

        //public void SetHeight(int height)
        //{
        //    _height = height;
        //}

        public Square()
        {
            Color = "Black";
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }
    }
}
