using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 0;
            do
            {
                select = 0;
                Console.Clear();
                Console.WriteLine("** Bienvenido al App de prueba de los 4 pilares de POO ***");
                Console.WriteLine("* Selecciones la opcion de la accion que desea realizar **");
                Console.WriteLine("* opcion 1 ver informacion del autor de este codigo     **");
                Console.WriteLine("* opcion 2 Calcular area de un cuadrado                 **");
                Console.WriteLine("* opcion 3 Calcular area de un rectangulo               **");
                Console.WriteLine("* opcion 4 Calcular area de un triangulo                **");
                Console.WriteLine("* opcion 5 Salir de la App                              **\n");
                try
                {

                    select = Int16.Parse(Console.ReadLine());
                }
                catch {
                    return;
                }
                
                

                switch (select)
                {
                    case 1: Autor();
                        break;
                    case 2: CalcularCuadrado();
                        break;
                    case 3: CalcularRectangulo();
                        break;
                    case 4: CalcularTriangulo();
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Gracias por utilizar esta app. \nPulse cualquier tecla para cerrar ventana...");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n Seleccion Erronea Vuelva a intentar");
                        Console.ReadKey();
                        break;
                }

            } while (select != 5);
            
        }

        static void Autor()
        {
            // Ejemplificando El pilar de la encapsulacion y Abstraccion
            Emilio emilio = new Emilio("Emilio", "Rosa", "20197562", "Isabelita"); // objeto con datos unicos de la clase Emilio
            Emilio Juan = new Emilio("Juan", "Rosa", "20187562", "Herrera"); // objeto con datos unicos de la clase Emilio
            Array misDatos = emilio.mostrarDatos(); // Interactuando con el objeto de forma abstracta

            Console.Clear();
            Console.WriteLine("Mis Datos Son:");
            foreach (string dato in misDatos)
            {
                Console.WriteLine(dato);
            }

            Console.ReadKey();
        }

        static void CalcularRectangulo()
        {
            int Base =0 , Altura = 0;
            FiguraRectangulo Rectangulo = new FiguraRectangulo();

            Console.Clear();
            Console.WriteLine("** Calcuar Area de un Rectangulo **\n");
            try
            {
                Console.Write("Introduzca la Base del rectangulo: ");
                Base = Int32.Parse(Console.ReadLine());
                Console.Write("Introduzca la Altura del rectangulo: ");
                Altura = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Error();
            }
            //int Resultado = Rectangulo.Area(Base, Altura);
            Console.WriteLine("\nEl Area del Rectangulo Es: " + Rectangulo.Area(Base, Altura));
            Console.ReadKey();
        }
        static void CalcularCuadrado()
        {
            int Lado = 0;
            FiguraCuadrado Cuadrado = new FiguraCuadrado(); //aplicando polimorfismo con las figuras
            Console.Clear();
            Console.WriteLine("** Calcuar Area de un Cuadrado **\n");
            try
            {
                Console.Write("Introduzca uno de los lados del  cuadrado: ");
                Lado = Int32.Parse(Console.ReadLine());
               
            }
            catch
            {
                Error();
            }
            //int Resultado = Rectangulo.Area(Base, Altura);
            Console.WriteLine("\nEl Area del Cuadrado Es: " + Cuadrado.Area(Lado, Lado));
            Console.ReadKey();


        }
        static void CalcularTriangulo()
        {
            int Base = 0, Altura = 0;
            FiguraTriangulo Triangulo = new FiguraTriangulo();
            Console.Clear();
            Console.WriteLine("** Calcuar Area de un Triangulo **\n");
            try
            {
                Console.Write("Introduzca la Base del triangulo: ");
                Base = Int32.Parse(Console.ReadLine());
                Console.Write("Introduzca la Altura del triangulo: ");
                Altura = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Error();
            }
            //int Resultado = Rectangulo.Area(Base, Altura);
            Console.WriteLine("\nEl Area del Triangulo Es: " + Triangulo.Area(Base, Altura));
            Console.ReadKey();


        }

        static void Error()
        {
            Console.Clear();
            Console.WriteLine("Ha Introducido un dato erroeneo.\nPulse cualquier tecla para volver a intentar");
            Console.ReadKey();
        }
    }

   
}
