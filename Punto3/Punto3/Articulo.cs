using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    public class Articulo
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double valor { get; set; }
        public int cantidadE { get; set; }

        private double precioI, descuento, vdescuento, iva, subtotal, total;

        public Articulo()
        {

        }

        public double Calcularprecio(int cant)
        {
            precioI = valor * cant;
            return precioI;
        }


        public override string ToString()
        {
            //concatenar

            string mensaje = "\n Código:" + codigo + " " + "\n Nombre:" + nombre +
                "\n Valor:" + valor;
            return mensaje;
        }
    }



}

