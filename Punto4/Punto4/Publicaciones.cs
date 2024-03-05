using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto4
{
    public class Publicaciones
    {
        protected int NumHojas, ValorHoja, ValorHojaColor;
        protected string Titulo, FechaPubli;



        public Publicaciones(int numHojas, int valorHoja, int valorHojaColor, string titulo, string fechaPubli)
        {
            NumHojas = numHojas;
            ValorHoja = valorHoja;
            ValorHojaColor = valorHojaColor;
            Titulo = titulo;
            FechaPubli = fechaPubli;
        }
    }

    class Periodico : Publicaciones
    {
        public string NomPeriodico { get; set; }

        public Periodico(int numHojas, int valorHoja, int valorHojaColor, string titulo, string fechaPubli, string nomPeriodico)
            : base(numHojas, valorHoja, valorHojaColor, titulo, fechaPubli)
        {
            NomPeriodico = nomPeriodico;
        }
    }

    class Libro : Publicaciones
    {
        public string NomAutor { get; set; }
        public string TipoPortada { get; set; }

        public Libro(int numHojas, int valorHoja, int valorHojaColor, string titulo, string fechaPubli, string nomAutor, string tipoPortada)
            : base(numHojas, valorHoja, valorHojaColor, titulo, fechaPubli)
        {
            NomAutor = nomAutor;
            TipoPortada = tipoPortada;
        }
    }
}