using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOtherDemo
{
    public static class StaticDemo
    {
        public static string _myStaticField;
        public static string MyStaticProperty { get; set; }

        static StaticDemo()
        {
            _myStaticField = "qq";
            MyStaticProperty = "ww";
        }

        public static void MyStaticMetod()
        {
        }
    }
}
