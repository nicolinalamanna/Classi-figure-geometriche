namespace Classi_figure_geometriche
{
    public partial class Form1 : Form
    {
        int area = 0;
        int perimetro = 0;
        double diagonale = 0;
        int lato = 0;
        Quadrato quadrato = new Quadrato();
        public Form1()
        {
            InitializeComponent();
        }
        private void txbLato_TextChanged(object sender, EventArgs e) //LATO
        { 
            if (txbLato.Text != "" && this.ActiveControl == txbLato) //letteralmente: se la textbox del lato è vuota e il cursore indica che il controllo textbox del lato è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbArea.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                try //La struttura try-catch serve per prevenire errori non logici. Esempio: un utente che immette un carattere al posto di un numero intero previsto
                {
                    //lato = Convert.ToInt32(txbLato.Text);
                    txbArea.Text = quadrato.area(Convert.ToInt32(txbLato.Text)).ToString();
                    txbPerimetro.Text = quadrato.perimetro(Convert.ToInt32(txbLato.Text)).ToString();
                    txbDiagonale.Text = quadrato.diagonale(Convert.ToInt32(txbLato.Text)).ToString();
                } catch
                {
                    txbLato.Text = "";
                    //lato = 0;
                }
                //area = quadrato.area(lato);
                //diagonale = quadrato.diagonale(lato);
                //perimetro = quadrato.perimetro(lato);
                //txbArea.Text= area.ToString();
                //txbDiagonale.Text = diagonale.ToString();
                //txbPerimetro.Text = perimetro.ToString();
            }
            else if (this.ActiveControl == txbLato)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbArea.Enabled = true;
                txbDiagonale.Enabled = true;
                txbPerimetro.Enabled = true;
                txbArea.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
            }
        }
        private void txbArea_TextChanged(object sender, EventArgs e) //AREA
        {
            if (txbArea.Text != "" && this.ActiveControl == txbArea) //letteralmente: se la textbox dell'area è vuota e il cursore indica che il controllo textbox dell'area è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                try
                {
                    //area = Convert.ToInt32(txbArea.Text);
                    txbLato.Text = quadrato.lato(Convert.ToInt32(txbArea.Text)).ToString();
                    txbPerimetro.Text = quadrato.perimetro(Convert.ToInt32(txbArea.Text)).ToString();
                    txbDiagonale.Text = quadrato.diagonale(Convert.ToInt32(txbArea.Text)).ToString();
                } catch
                {
                    txbArea.Text = "";
                    //area = 0;
                }
                //lato = quadrato.lato(area);
                //diagonale = quadrato.diagonale(lato);
                //perimetro = quadrato.perimetro(area); //quadrato.perimetro(lato);
                //txbLato.Text = lato.ToString();
                //txbDiagonale.Text = diagonale.ToString();
                //txbPerimetro.Text = perimetro.ToString();
            }
            else if (this.ActiveControl == txbArea)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbLato.Enabled = true;
                txbDiagonale.Enabled = true;
                txbPerimetro.Enabled = true;
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
            }
        }
        private void txbPerimetro_TextChanged(object sender, EventArgs e) //PERIMETRO
        {
            if (txbPerimetro.Text != "" && this.ActiveControl == txbPerimetro) //letteralmente: se la textbox del perimetro è vuota e il cursore indica che il controllo textbox del perimetro è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbArea.Enabled = false;
                //try {perimetro = Convert.ToInt32(txbPerimetro.Text);} catch {perimetro = 0;} //STRUTTURA DEL TRY CATCH COMPATTATA
                try
                {
                    txbLato.Text = quadrato.lato(Convert.ToInt32(txbPerimetro.Text)).ToString();
                    txbArea.Text = quadrato.area(Convert.ToInt32(txbPerimetro.Text)).ToString();
                   //txbDiagonale.Text = quadrato.diagonale(Convert.ToInt32(txbPerimetro.Text)).ToString(); //NON LEGGE IL METODO DIAGONALE CON PARAMETRO PERIMETRO NELLA CLASSE QUADRATO
                } catch
                {
                    txbPerimetro.Text = "";
                }
                //lato = quadrato.lato(perimetro);
                //diagonale = quadrato.diagonale(lato);
                //area = quadrato.arealato);
                //txbLato.Text = lato.ToString();
                //txbArea.Text = perimetro.ToString();
                //txbDiagonale.Text = diagonale.ToString();
            }
            else if (this.ActiveControl == txbPerimetro)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbLato.Enabled = true;
                txbDiagonale.Enabled = true;
                txbArea.Enabled = true;
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbArea.Text = "";
            }
        }
        private void txbDiagonale_TextChanged(object sender, EventArgs e) //DIAGONALE
        {
            if (txbDiagonale.Text != "" && this.ActiveControl == txbDiagonale) //letteralmente: se la textbox della diagonale è vuota e il cursore indica che il controllo textbox della diagonale è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbLato.Enabled = false;
                txbArea.Enabled = false;
                txbPerimetro.Enabled = false;
                try
                {
                    //diagonale = Convert.ToInt32(txbDiagonale.Text);
                    txbLato.Text = quadrato.lato(Convert.ToInt32(txbDiagonale.Text)).ToString();
                    txbArea.Text = quadrato.area(Convert.ToInt32(txbDiagonale.Text)).ToString();
                    txbPerimetro.Text = quadrato.perimetro(Convert.ToInt32(txbDiagonale.Text)).ToString();
                }
                catch
                {
                    //diagonale = 0;
                    txbDiagonale.Text = "";
                }
                //lato = quadrato.lato(diagonale);
                //area = quadrato.area(lato);
                //perimetro = quadrato.perimetro(lato);
                //txbLato.Text = lato.ToString();
                //txbPerimetro.Text = perimetro.ToString();
                //txbArea.Text = area.ToString();
            }
            else if (this.ActiveControl == txbDiagonale)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbLato.Enabled = true;
                txbArea.Enabled = true;
                txbPerimetro.Enabled = true;
                txbLato.Text = "";
                txbArea.Text = "";
                txbPerimetro.Text = "";
            }
        }
    }
}