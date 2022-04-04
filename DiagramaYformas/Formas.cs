using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaYformas
{
    abstract class Formas
    {
        string color;
        string nombre;

        public Formas(string c, string n)
        {
            color = c;
            nombre = n;
        }

        public abstract double getPerimetro();
        public abstract double getArea();

        public override string ToString()
        {
            return "Color: " + this.color + " Nombre: " + this.nombre;        
        }
    }
}
