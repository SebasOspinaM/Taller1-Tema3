class Program
{
    static void Main(string[] args)
    {
        string Nom, Pass;
        int Amount;

        Console.WriteLine("*---------------- Bienvenido al Cajero Electronico ----------------*\n");

        bool aux1 = true;

        while (aux1)
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar y realizar su retiro");
            Console.ReadKey();
            Console.Write("\nIngrese su nombre: ");
            Nom = Console.ReadLine();
            Console.Write("\nIngrese su contraseña: ");
            Pass = Console.ReadLine();
            Console.Write("\nIngrese la cantidad a retirar: $");
            Amount = Int32.Parse(Console.ReadLine());


            Validacion(Amount);

            Console.Write("\n¿Desea realizar otra operación? (s/n): ");
            string aux2 = Console.ReadLine();

            if (aux2 != "s")
            {
                Console.WriteLine("\nGracias por usar nuestro servicio. ¡Tenga un buen día!");
                aux1 = false;
            }
        }
        




    }
    static void Validacion(int amount)
    {

        if (amount < 0)
        {

            Console.WriteLine("\nEl valor del retiro no puede ser un número negativo");


        }
        else if (amount == 0)
        {

            Console.WriteLine("\nEl valor del retiro no puede ser cero");


        }
        else if (amount > 600000)
        {

            Console.WriteLine("\nEl valor del retiro máximo es de $600.000");


        }
        else
        {
            float B50, B20, B10, B5;
            B50 = amount / 50000;
            amount %= 50000;
            B20 = amount / 20000;
            amount %= 20000;
            B10 = amount / 10000;
            amount %= 10000;
            B5 = amount / 5000;
            amount %= 5000;
            

            if ((amount >= 2500) && (amount <= 4999))
            {
                B5 += 1;
                Console.WriteLine($"\nSobrante redondeado a 5000 ({amount})");
                Console.WriteLine($"El cajero le dará {B50} billetes de $50000, {B20} de $20000, {B10} de $10000 y {B5} de $5000");

            }
            else if ((amount <= 2499) && (amount >= 1))
            {
                Console.WriteLine($"\nSobrante redondeado a 0 ({amount})");
                Console.WriteLine($"El cajero le dará {B50} billetes de $50000, {B20} de $20000, {B10} de $10000 y {B5} de $5000");
            }
            else
            {
                Console.WriteLine("\nNo hay sobrante");
                Console.WriteLine($"El cajero le dará {B50} billetes de $50000, {B20} de $20000, {B10} de $10000 y {B5} de $5000");
            }


        }



    }


}