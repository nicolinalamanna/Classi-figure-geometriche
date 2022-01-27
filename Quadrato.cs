using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_figure_geometriche
{
    public class Quadrato
    {
        public double radiceQuadDue = 1.414213562373095;

        public int latoFromArea(int area)
        {
            int result = (int)Math.Sqrt(area);
            return result;
        }

        public double diagonaleFromLato(int lato)
        {
            double result = lato * radiceQuadDue;
            return result;
        }

        public int perimetroFromLato(int lato)
        {
            int result = lato * 4;
            return result;
        }









        public int area(int lato)
        {
            int result = lato * lato;
            return result;
        }
        public int area(int perimetro,string Perimetro = "Perimetro")
        {
            int result = perimetro / 4 * perimetro / 4;
            return result;
        }
        public int area(double diagonale)
        {
            int result = 0;
            return result;
        }


















        public int latoFromPerimetro(int perimetro)
        {
            int result = perimetro / 4;
            return result;
        }

        public int latoFromDiagonale(double diagonale)
        {
            int result = Convert.ToInt32(diagonale / radiceQuadDue);
            return result;
        }

        public int perimetroFromArea(int area)
        {
            int result = (int)Math.Sqrt(area)*4;
            return result;
        }
    }
}
