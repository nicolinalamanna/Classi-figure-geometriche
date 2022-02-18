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

        //METODI LATO
        public int lato(int area) //from area
        {
            int result = (int)Math.Sqrt(area);
            return result;
        }
        public int lato(int perimetro, string Perimetro = "Perimetro") //from perimetro
        {
            int result = perimetro / 4;
            return result;
        }
        public int lato(double diagonale) //from diagonale
        {
            int result = Convert.ToInt32(diagonale / radiceQuadDue);
            return result;
        }
        //METODI AREA
        public int area(int lato) //from lato
        {
            int result = lato * lato;
            return result;
        }
        public int area(int perimetro,string Perimetro = "Perimetro") //from perimetro
        {
            int result = perimetro / 4 * perimetro / 4;
            return result;
        }
        public int area(double diagonale) //from diagonale
        {
            int result = Convert.ToInt32((diagonale * diagonale) / 2);
            return result;
        }
        //METODI PERIMETRO
        public int perimetro(int lato) //from lato
        {
            int result = lato * 4;
            return result;
        }
        public int perimetro(int area, string Perimetro = "Perimetro") //from area
        {
            int result = (int)Math.Sqrt(area)*4; //(int) è un altro modo per scrivere il Convert.ToInt32
            return result;
        }
        public int perimetro(double diagonale) //from diagonale
        {
            int result = Convert.ToInt32(2 * (radiceQuadDue * diagonale));
            return result;
        }
        //METODI DIAGONALE
        public double diagonale(int lato) //from lato
        {
            double result = Math.Sqrt(lato * lato + lato * lato);
            return result;
        }
        public double diagonale(int area, string Area = "Area") //from area
        {
            double result = Math.Sqrt(area * area);
            return result;
        }
        public double diagonale(int perimetro, bool Perimetro = false) //from perimetro
        {
            double result = (perimetro * Math.Sqrt(2)) / 4;
            return result;
        }
    }
}
