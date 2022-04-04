using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaYformas
{
    class Rombo : Forma
    {
        int diagonalMayor;
        int diagonalMenor;
        int lado;

        public override double getArea()
        {
            return (diagonalMayor* diagonalMenor) /2;
        }
        public override double getPerimetro()
        {
            return lado*4;
        }

        public Rombo(string color, string nombre, int diagonalM, int diagonal, int l) : base(color, nombre)
        {
            diagonalMayor = diagonalM;
            diagonalMenor = diagonal;
            lado = l;
        }
    }
}
