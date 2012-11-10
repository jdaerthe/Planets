using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Vector
    {
        public float x;
        public float y;
        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getMagnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }
        public Vector times(float m) {
            return new Vector(x * m, y * m);
        }
        public Vector minus(Vector v)
        {
            return new Vector(x - v.x, y - v.y);
        }
        public Vector plus(Vector v)
        {
            return new Vector(x + v.x, y + v.y);
        }
    }
}
