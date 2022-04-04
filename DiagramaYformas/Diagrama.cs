using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaYformas
{
    class Diagrama
    {
        private List<Formas> list;
        private double perimetroTotal;
        private double areaTotal;

        public Diagrama()
        {
            list = new List<Formas>();
        }

        public void añadirForma(Formas f)
        {
            list.Add(f);           
            
        }

        public double calcTotalPerimetros()
        {

            foreach (Formas f in list)
            {
                perimetroTotal += f.getPerimetro();
            }

            return perimetroTotal;

        }

        public double calcTotalAreas()
        {

            foreach (Formas f in list)
            {
                areaTotal += f.getArea();
            }

            return areaTotal;

        }
    }
}
