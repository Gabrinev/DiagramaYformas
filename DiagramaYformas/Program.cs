using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaYformas
{
    class Program
    {
        static void Main(string[] args)
        {
            Diagrama d = new Diagrama();

            Formas rect = new Rectangulo("rojo","rectangulo",8,4);
            Formas romb = new Rombo("azul", "rombo", 8, 4, 2);
            d.añadirForma(rect);
            d.añadirForma(romb);

            Console.WriteLine(d.calcTotalAreas());
            Console.WriteLine(d.calcTotalPerimetros());
        }
    }
}
