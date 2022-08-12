using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] Args)
        {
            Circle AreaCircle = new();
            Reactangle AreaRectangle = new();

            while (true)
            {
                try
                {
                    Console.WriteLine("Seleccione una figura para calcular su area:\n 1) Círculo \n 2) Rectangulo");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            AreaCircle.AreaCircle();
                            break;
                        case 2:
                            AreaRectangle.AreaReactangle();
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("El valor debe ser numerico\n");
                }
                catch (NullReferenceException )
                {
                    Console.WriteLine("No se aceptan valores nulos\n");
                }

            }
         
        }
    }
}
