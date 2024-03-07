using Punto2;

class Program
{
    static void Main(string[] args)
    {
        double prom, neg, pos, promMujeres, promHombres;

        Cliente ah1 = new Cliente("Laura Posada", "Femenino", "19283746", 1500000.00);
        Cliente ah2 = new Cliente("Milena Restrepo", "Femenino", "24681344", 4650000.00);
        Cliente ah3 = new Cliente("Juan Llano", "Masculino", "12334455", 700000.00);
        Cliente ah4 = new Cliente("Miguel Ortiz", "Masculino", "10293145", -9000);
        Cliente ah5 = new Cliente("Alexa Garcia", "Femenino", "99988123", 60200.00);

        Console.WriteLine("Sistema de ahorradores");

        prom = ah1.CalcularPromedio(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });


        Console.WriteLine($"Saldo promedio de los 5 ahorradores del banco: $ {prom}");

        neg = ah1.CalcularSNegativos(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });
        Console.WriteLine($"Saldos negativos de los 5 ahorradores del banco: $ {neg}");

        pos = ah1.CalcularSPositivos(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });
        Console.WriteLine($"Saldos positivos de los 5 ahorradores del banco: $ {pos}");



        Cliente CSMenor = ah1.CalcularSMenor(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });
        Console.WriteLine($"El Saldo menor entre  los 5 ahorradores del banco es : $ {CSMenor.Saldo}, del ahorrador: {CSMenor.Nombre}");


        Cliente CSMayor = ah1.CalcularSMayor(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });

        Console.WriteLine($"El Saldo mayor entre los 5 ahorradores del banco es: $ {CSMayor.Saldo}, del ahorrador: {CSMayor.Nombre}, con número de cuenta: {CSMayor.NumCuenta}");

        promMujeres = ah1.CalcularPromedioMujeres(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });
        Console.WriteLine($"El Saldo promedio de las mujeres es : $ {promMujeres}");

        promHombres = ah1.CalcularPromedioHombres(new Cliente[] { ah1, ah2, ah3, ah4, ah5 });
        Console.WriteLine($"El Saldo promedio de los hombres es : $ {promMujeres}");


    }
}
