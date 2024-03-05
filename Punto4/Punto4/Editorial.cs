using System;

namespace Punto4;
class Editorial
{
    static void Main(string[] args)
    {
        int opc;


        do
        {
            Console.WriteLine("Ingrese 1 para los datos de un periodico");
            Console.WriteLine("Ingrese 2 para los datos de un libro");
            Console.WriteLine("Ingrese 0 para salir");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    int numHoja, valHoja, valHojaCol;
                    string titulo, nomPeriodico, fechaPubli;

                    Console.Write("\nIngrese el número de páginas del periodico: ");
                    numHoja = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el valor de las paginas en blanco y negro: ");
                    valHoja = Convert.ToInt32(Console.ReadLine());
                    valHojaCol = valHoja + 200;
                    Console.Write("Ingrese el título del periodico: ");
                    titulo = Console.ReadLine();
                    Console.Write("Ingrese el nombre del periodico: ");
                    nomPeriodico = Console.ReadLine();
                    Console.Write("Ingrese la fecha de publicacion (DD/MM/AA): ");
                    fechaPubli = Console.ReadLine(); 

                    Periodico p = new Periodico(numHoja, valHoja, valHojaCol, titulo, fechaPubli, nomPeriodico);


                    


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