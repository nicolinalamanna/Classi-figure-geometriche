using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_figure_geometriche
{
    public class Cerchio
    {
        public double PiGreco = 3.14;

        //METODI RAGGIO
        public double raggio(double area) //from area
        {
            double result = Math.Sqrt(area/PiGreco);
            return result;
        }
        public double raggio(double circonferenza, string Circonferenza = "Circonferenza") //from circonferenza
        {
            double result = circonferenza / (2 * PiGreco);
            return result;
        }
        public double raggio(int diametro, string Diametro = "Diametro") //from diametro
        {
            double result = diametro / 2;
            return result;
        }
        //METODI AREA CERCHIO
        public double area(double raggio) //from raggio
        {
            double result = PiGreco * (raggio * raggio);
            return result;
        }
        public double area(double circonferenza, string Circonferenza = "Circonferenza") //from circonferenza
        {
            double result = (circonferenza * circonferenza) / 4 * PiGreco;
            return result;
        }
        public double area(double diametro, bool Diametro = false) //from diametro
        {
            double result = PiGreco * (diametro * diametro) / 4;
            return result;
        }
        //METODI CIRCONFERENZA
        public double circonferenza(double area) //from area
        {
            double result = Math.Sqrt((4 * PiGreco) * area);
            return result;
        }
        public double circonferenza(double raggio, string Raggio = "Raggio") //from raggio
        {
            double result = (2 * PiGreco) * raggio;
            return result;
        }
        public double circonferenza(double diametro, bool Diametro = false) //from diametro
        {
            double result = PiGreco * diametro;
            return result;
        }
        //METODI DIAMETRO
        public double diametro(double raggio) //from raggio
        {
            double result = 2 * raggio;
            return result;
        }
        public double diametro(double area, string Diametro = "Diametro") //from area
        {
            double result = Math.Sqrt((area * 4) / PiGreco);
            return result;
        }
        public double diametro(double circonferenza, bool Circonferenza = false) //from circonferenza
        {
            double result = circonferenza / PiGreco;
            return result;
        }
    }
}
