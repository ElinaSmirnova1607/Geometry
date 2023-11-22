using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTask_SmirFergs_
{
    public class Geometry
    {
        public double RectangleArea(int a, int h)
        {
            return Math.Round(Math.PI * (a * a) * h);
        }
    }
}
