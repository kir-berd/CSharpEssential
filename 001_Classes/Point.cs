using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Classes
{
    class Point
    {
        public int A { get; }
        public int B { get; }
        public string Str { get; }

        public Point(int a, int b, string str)
        {
            this.A = a;
            this.B = b;
            this.Str = str;
        }
    }
}
