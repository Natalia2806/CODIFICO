using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Reactangle : GeometricFigures
    {
        public virtual void AreaReactangle()
        {
           Console.Write("\nIngrese la base del rectángulo: ");
           double baseR = Convert.ToDouble(Console.ReadLine());
           Console.Write("\nIngrese la altura del rectángulo: ");
           double high = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("\nEl area del rectángulo es: " + base.Rectangle(baseR, high) + "\n");
        }
    }
}
