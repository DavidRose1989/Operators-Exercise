using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Methods
    {
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
