using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prtest8
{
  public  class volume
    {
        public double Reactan(double a, double b)
        {
            double s = Math.Pow(a, 3);
            return s;
        }
        public int parallelepiped(int a, int b, int h)
        {
            int s = a * b * h;
            return s;
        }
    }
}
