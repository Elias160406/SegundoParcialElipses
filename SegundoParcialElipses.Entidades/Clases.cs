using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialElipses.Entidades
{

    public enum Bordes
    {
        Solido = 1,
        Punteado,
        Rayado,
        Doble
    }

    public enum ColorElipse
    {
        Rojo = 1,
        Verde,
        Azul,
        Amarillo,
        Negro
    }

    public class Trabajo
    {
        public double SemiejeMayor { get; set; }
        public double SemiejeMenor { get; set; }
        public Bordes Borde { get; set; }
        public ColorElipse Color { get; set; }


        public Trabajo(double semiejeMayor, double semiejeMenor, Bordes borde, ColorElipse color)
        {
            SemiejeMayor = semiejeMayor;
            SemiejeMenor = semiejeMenor;
            Borde = borde;
            Color = color;
        }
    }


        
}
