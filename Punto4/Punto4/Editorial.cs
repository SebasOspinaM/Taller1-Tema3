using System;

namespace Punto4;
class Editorial
{
    static void Main(string[] args)
    {
        int opc;


        do
        {
            Console.WriteLine("\nIngrese 1 para los datos de un periodico");
            Console.WriteLine("Ingrese 2 para los datos de un libro");
            Console.WriteLine("Ingrese 0 para salir");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    int numHoja, valHoja, valHojaCol, valTotal;
                    string titulo, nomPeriodico, fechaPubli, bynocol;

                    Console.Write("\nIngrese el número de hojas del periodico: ");
                    numHoja = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el valor de las hojas en blanco y negro: ");
                    valHoja = Convert.ToInt32(Console.ReadLine());
                    valHojaCol = valHoja + 200;
                    Console.Write("Ingrese el título del periodico: ");
                    titulo = Console.ReadLine();
                    Console.Write("Ingrese el nombre del periodico: ");
                    nomPeriodico = Console.ReadLine();
                    Console.Write("Ingrese la fecha de publicacion (DD/MM/AA): ");
                    fechaPubli = Console.ReadLine();
                 

                    Periodico p = new Periodico(numHoja, valHoja, valHojaCol, titulo, fechaPubli, nomPeriodico);
                    bool b = true;
                    do
                    {
                        Console.Write("Es a color? (s para sí o n para no): ");
                        bynocol = Console.ReadLine();

                        if ((bynocol.Equals("S")) || (bynocol.Equals("s")))
                        {
                            valTotal = numHoja * valHojaCol;
                            Console.WriteLine(p.ToString() + " | con un valor de $" + valTotal);
                            b = false;
                        }
                        else if ((bynocol.Equals("N")) || (bynocol.Equals("n")))
                        {
                            valTotal = numHoja * valHoja;
                            Console.WriteLine(p.ToString() + " | con un valor de $" + valTotal);
                            b = false;
                        }
                        else
                        {
                            Console.WriteLine("\nDato no válido, por favor vuelva a intentar");
                        }
                    } while (b);

                    break;
                case 2:

                    break;

                case 0:
                    Console.WriteLine("Bye, Bye");
                    break;

                default:
                    Console.WriteLine("Parámetro no válido");
                    break;

            }
        } while (opc != 0);






    }
}