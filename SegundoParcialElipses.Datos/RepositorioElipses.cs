using SegundoParcialElipses.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialElipses.Datos
{
    public class Elipse
    {
        public double SemiejeMayor { get; set; }
        public double SemiejeMenor { get; set; }
        public string Color { get; set; }
        public string Borde { get; set; }

        // Constructor
        public Elipse(double semiejeMayor, double semiejeMenor, string color, string borde)
        {
            SemiejeMayor = semiejeMayor;
            SemiejeMenor = semiejeMenor;
            Color = color;
            Borde = borde;
        }
    }
}

