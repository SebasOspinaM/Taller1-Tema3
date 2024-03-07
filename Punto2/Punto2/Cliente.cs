using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    public class Cliente
    {
        private string Genero;
        private double suma, prom, aux = 0;
        public double Saldo;
        public string Nombre, NumCuenta;



        public Cliente(string NombreC, string GeneroC, string NumCuentaC, double SaldoC)
        {
            Nombre = NombreC;
            Genero = GeneroC;
            NumCuenta = NumCuentaC;
            Saldo = SaldoC;

        }

        public double CalcularPromedio(Cliente[] clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                suma += cliente.Saldo;

            }
            prom = suma / 5;
            return prom;
        }

        public double CalcularSNegativos(Cliente[] clientes)
        {
            foreach (Cliente cliente in clientes)
            {


                if (cliente.Saldo < 0)
                {
                    aux++;
                }

            }
            return aux;
        }

        public double CalcularSPositivos(Cliente[] clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Saldo >= 0)
                {
                    aux++;
                }
            }
            return aux;

        }

        public Cliente CalcularSMenor(Cliente[] clientes)
        {
            Cliente csmenor = clientes[0];
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Saldo < csmenor.Saldo)
                {
                    csmenor = cliente;
                }
            }
            return csmenor;

        }

        public Cliente CalcularSMayor(Cliente[] clientes)
        {
            Cliente csmayor = clientes[0];
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Saldo > csmayor.Saldo)
                {
                    csmayor = cliente;
                }
            }
            return csmayor;

        }

        public double CalcularPromedioMujeres(Cliente[] clientes)
        {
            double suma2 = 0, prom2 = 0, aux2 = 0;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Genero == "Femenino")
                {
                    suma2 += cliente.Saldo;
                    aux2++;

                }

            }
            prom2 = suma2 / aux2;
            return prom2;
        }

        public double CalcularPromedioHombres(Cliente[] clientes)
        {
            double suma3 = 0, prom3 = 0, aux3 = 0;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Genero == "Masculino")
                {
                    suma3 += cliente.Saldo;
                    aux3++;

                }

            }
            prom3 = suma3 / aux3;
            return prom;
        }



    }
}

