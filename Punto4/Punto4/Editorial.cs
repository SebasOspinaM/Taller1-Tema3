using System;

namespace Punto4;
class Editorial
{
    static void Main(string[] args)
    {
        int opc;

        Console.WriteLine("Bienvenido/a a la 'Editorial Que Publica libros y periódicos'\n");

        do
        {
            Console.WriteLine("\nIngrese 1 para los datos de un periodico.");
            Console.WriteLine("Ingrese 2 para los datos de un libro.");
            Console.WriteLine("Ingrese 0 para salir.");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    int numHojap, valHojap, valHojaColp, valTotalp;
                    string titulop, nomPeriodicop, fechaPublip, bynocolp;

                    Console.Write("\nIngrese el número de hojas del periodico: ");
                    numHojap = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el valor de las hojas en blanco y negro: ");
                    valHojap = Convert.ToInt32(Console.ReadLine());
                    valHojaColp = valHojap + 200;
                    Console.Write("Ingrese el título del periodico: ");
                    titulop = Console.ReadLine();
                    Console.Write("Ingrese el nombre del periodico: ");
                    nomPeriodicop = Console.ReadLine();
                    Console.Write("Ingrese la fecha de publicacion (DD/MM/AA): ");
                    fechaPublip = Console.ReadLine();


                    Periodico p = new Periodico(numHojap, valHojap, valHojaColp, titulop, fechaPublip, nomPeriodicop);
                    bool aux1 = true;
                    do
                    {
                        Console.Write("Es a color? (s para sí o n para no): ");
                        bynocolp = Console.ReadLine();

                        if ((bynocolp.Equals("S")) || (bynocolp.Equals("s")))
                        {
                            valTotalp = numHojap * valHojaColp;
                            Console.WriteLine(p.ToString() + " | con un valor de $" + valTotalp);
                            aux1 = false;
                        }
                        else if ((bynocolp.Equals("N")) || (bynocolp.Equals("n")))
                        {
                            valTotalp = numHojap * valHojap;
                            Console.WriteLine(p.ToString() + " | con un valor de $" + valTotalp);
                            aux1 = false;
                        }
                        else
                        {
                            Console.WriteLine("\nSe ingresó un dato incorrecto, por favor, verifica y vuelve a intentarlo.");
                        }
                    } while (aux1);

                    break;
                case 2:

                    int numHojal, valHojal, valHojaColl, valTotall = 0;
                    string titulol, fechaPublil, bynocoll, tipoPort, autorl;

                    Console.Write("\nIngrese el número de hojas del libro: ");
                    numHojal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el valor de las hojas en blanco y negro: ");
                    valHojal = Convert.ToInt32(Console.ReadLine());
                    valHojaColl = valHojal + 200;
                    Console.Write("Ingrese el título del libro: ");
                    titulol = Console.ReadLine();
                    Console.Write("Ingrese el nombre del autor del libro: ");
                    autorl = Console.ReadLine();
                    Console.Write("Ingrese la fecha de publicacion (DD/MM/AA): ");
                    fechaPublil = Console.ReadLine();
                    bool aux2 = true;
                    do
                    {
                        Console.Write("Ingrese el tipo de portada (economica, normal o lujosa): ");
                        tipoPort = Console.ReadLine();

                        if (tipoPort.ToLower().Equals("economica"))
                        {
                            valTotall += 3000;
                            aux2 = false;
                        } else if (tipoPort.ToLower().Equals("normal"))
                        {
                            valTotall += 5000;
                            aux2 = false;
                        } else if (tipoPort.ToLower().Equals("lujosa"))
                        {
                            valTotall += 10000;
                            aux2 = false;
                        }
                        else
                        {
                            Console.WriteLine("\nSe ingresó un dato incorrecto, por favor, verifica y vuelve a intentarlo.");
                        }


                    } while (aux2);


                    Libro l = new Libro(numHojal, valHojal, valHojaColl, titulol, fechaPublil, autorl, tipoPort);
                    bool aux3 = true;
                    do
                    {
                        Console.Write("Es a color? (s para sí o n para no): ");
                        bynocoll = Console.ReadLine();

                        if ((bynocoll.Equals("S")) || (bynocoll.Equals("s")))
                        {
                            valTotall = valTotall + (numHojal * valHojaColl);
                            Console.WriteLine(l.ToString() + " | con un valor de $" + valTotall);
                            aux3 = false;
                        }
                        else if ((bynocoll.Equals("N")) || (bynocoll.Equals("n")))
                        {
                            valTotall = valTotall + (numHojal * valHojal) ;
                            Console.WriteLine(l.ToString() + " | con un valor de $" + valTotall);
                            aux3 = false;
                        }
                        else
                        {
                            Console.WriteLine("\nSe ingresó un dato incorrecto, por favor, verifica y vuelve a intentarlo.");
                        }
                    } while (aux3);


                    break;

                case 0:
                    Console.WriteLine("\n¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("\nParámetro no válido");
                    break;

            }
        } while (opc != 0);






    }
}