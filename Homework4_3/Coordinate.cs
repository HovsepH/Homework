using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_3
{
    class Coordinate
    {
        public double X { get; }
        public double Y { get; }


        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator Vector(Coordinate coordinate)
        {
            return new Vector(coordinate.X, coordinate.Y);
        }
    }
}
