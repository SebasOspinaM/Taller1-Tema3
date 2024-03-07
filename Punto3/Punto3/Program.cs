using Punto3;

class Program
{
    static void Main(string[] args)
    {
        int cod;
        int ammount;
        int opcion;
        double subtotal, descuento = 0, iva, total;


        Articulo[] a = new Articulo[5];


        a[0] = new Articulo { codigo = 111, nombre = "articulo 1", valor = 10000.00, cantidadE = 100 };
        a[1] = new Articulo { codigo = 222, nombre = "articulo 2", valor = 10500.00, cantidadE = 100 };
        a[2] = new Articulo { codigo = 333, nombre = "articulo 3", valor = 20000.00, cantidadE = 80 };
        a[3] = new Articulo { codigo = 444, nombre = "articulo 4", valor = 35000.00, cantidadE = 120 };
        a[4] = new Articulo { codigo = 555, nombre = "articulo 5", valor = 85600.00, cantidadE = 500 };
        do
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("A continuación se presenta la lista de articulos: " + a[i].ToString());
            }
            Console.Write("presione una tecla para continuar: ");
            Console.ReadKey();

            Console.WriteLine("Ingrese el código del articulo que desea: ");
            cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos que desea: ");
            ammount = Convert.ToInt32(Console.ReadLine());

            Articulo art = null;

            foreach (Articulo articulo in a)
            {
                if (articulo.codigo == cod)
                {
                    art = articulo;
                    break;
                }

            }

            if (art == null)
            {
                Console.WriteLine("Error. El articulo con ese codigo no fue encontrado");
            }
            else
            {
                if (art != null)
                {
                    if (ammount <= art.cantidadE)
                    {
                        subtotal = art.Calcularprecio(ammount);

                        if (ammount > 10)
                        {
                            descuento = art.valor * 0.10;
                            subtotal -= descuento;

                        }

                        iva = subtotal * 0.19;
                        total = subtotal + iva;

                        Console.WriteLine(art.ToString());

                        Console.WriteLine($"Cantidad: {ammount}, IVA: $ {iva}, Descuento: $ {descuento}, Subtotal: $ {subtotal}, Total: $ {total}");

                        art.cantidadE -= ammount;
                    }
                    else
                        Console.WriteLine("Lo sentimos. No hay suficiente cantidad del articulo");

                }


            }


            Console.WriteLine("¿Desea registrar más articulos?: 1. Si 2. No");
            opcion = Convert.ToInt32(Console.ReadLine());
        } while (opcion == 1);










    }
}