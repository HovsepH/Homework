using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_3
{
    class Vector
    {
        public double X { get; }
        public double Y { get; }


        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static explicit operator Coordinate(Vector vector)
        {
            return new Coordinate(vector.X, vector.Y);
        }

    }
}
