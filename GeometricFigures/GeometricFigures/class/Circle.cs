using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Circle : GeometricFigures
    {
        public virtual void AreaCircle()
        {
            Console.Write("Ingrese el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del círculo es: " + base.AreaCircle(radio));
        }
    }
}
