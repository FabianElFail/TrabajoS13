using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoS13
{
    public class Desayuno
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Dias { get; set; }

        public override string? ToString()
        {
            return $"Hola {Nombre} S/.{Precio}, servido los {Dias}";
        }


        public string[] ListaDias()
        {
            return Dias.Split(',');
        }

    }
} //SOY TAMAL DE POLLO
