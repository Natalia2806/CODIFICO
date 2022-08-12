using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
   public abstract class GeometricFigures
    {
        public virtual Double AreaCircle(double radio)
        {
            double pi = 3.1416; 
            return pi * Math.Pow(radio, 2);
        }

        public virtual Double Rectangle(double baseR, double high)
        {
            return baseR * high;
        }
    }
}
