namespace Classi_figure_geometriche
{
    public partial class Form1 : Form
    {
        //int area = 0;
        //int perimetro = 0;
        //double diagonale = 0;
        //int lato = 0;
        Quadrato quadrato = new Quadrato();
        Cerchio cerchio = new Cerchio();
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
                txbRaggio.Enabled = false;
                txbDiametro.Enabled = false;
                txbCirconferenza.Enabled = false;
                txbAreaCerchio.Enabled = false;
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
                txbRaggio.Enabled = true;
                txbDiametro.Enabled = true;
                txbCirconferenza.Enabled = true;
                txbAreaCerchio.Enabled = true;
                txbArea.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
                txbCirconferenza.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbDiametro.Text = "";
                txbAreaCerchio.Text = "";
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
                txbRaggio.Enabled = false;
                txbDiametro.Enabled = false;
                txbCirconferenza.Enabled = false;
                txbAreaCerchio.Enabled = false;
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
                txbRaggio.Enabled = true;
                txbDiametro.Enabled = true;
                txbCirconferenza.Enabled = true;
                txbAreaCerchio.Enabled = true;
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
                txbCirconferenza.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbDiametro.Text = "";
                txbAreaCerchio.Text = "";
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
                txbRaggio.Enabled = false;
                txbDiametro.Enabled = false;
                txbCirconferenza.Enabled = false;
                txbAreaCerchio.Enabled = false;
                //try {perimetro = Convert.ToInt32(txbPerimetro.Text);} catch {perimetro = 0;} //STRUTTURA DEL TRY CATCH COMPATTATA
                try
                {
                    txbLato.Text = quadrato.lato(Convert.ToInt32(txbPerimetro.Text)).ToString();
                    txbArea.Text = quadrato.area(Convert.ToInt32(txbPerimetro.Text)).ToString();
                    txbDiagonale.Text = quadrato.diagonale(Convert.ToInt32(txbPerimetro.Text)).ToString(); //NON LEGGE IL METODO DIAGONALE CON PARAMETRO PERIMETRO NELLA CLASSE QUADRATO
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
                txbRaggio.Enabled = true;
                txbDiametro.Enabled = true;
                txbCirconferenza.Enabled = true;
                txbAreaCerchio.Enabled = true;
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbArea.Text = "";
                txbCirconferenza.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbDiametro.Text = "";
                txbAreaCerchio.Text = "";
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
                txbRaggio.Enabled = false;
                txbDiametro.Enabled = false;
                txbCirconferenza.Enabled = false;
                txbAreaCerchio.Enabled = false;
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
                txbRaggio.Enabled = true;
                txbDiametro.Enabled = true;
                txbCirconferenza.Enabled = true;
                txbAreaCerchio.Enabled = true;
                txbLato.Text = "";
                txbArea.Text = "";
                txbPerimetro.Text = "";
                txbCirconferenza.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbDiametro.Text = "";
                txbAreaCerchio.Text = "";
            }
        }

        private void txbCirconferenza_TextChanged(object sender, EventArgs e) //CIRCONFERENZA
        {
            if (txbCirconferenza.Text != "" && this.ActiveControl == txbCirconferenza) //letteralmente: se la textbox della circonferenza è vuota e il cursore indica che il controllo textbox della circonferenza è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbArea.Enabled = false; //quadrato
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                txbAreaCerchio.Enabled = false; //cerchio
                txbDiametro.Enabled = false;
                txbRaggio.Enabled = false;
                try //La struttura try-catch serve per prevenire errori non logici. Esempio: un utente che immette un carattere al posto di un numero intero previsto
                {
                    txbAreaCerchio.Text = cerchio.area(Convert.ToDouble(txbCirconferenza.Text)).ToString();
                    txbRaggio.Text = cerchio.raggio(Convert.ToDouble(txbCirconferenza.Text)).ToString();
                    txbDiametro.Text = cerchio.diametro(Convert.ToDouble(txbCirconferenza.Text)).ToString();
                }
                catch
                {
                    txbCirconferenza.Text = "";
                    //circonferenza = 0;
                }
            }
            else if (this.ActiveControl == txbCirconferenza)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbArea.Enabled = true; //quadrato
                txbLato.Enabled = true;
                txbDiagonale.Enabled = true;
                txbPerimetro.Enabled = true;
                txbAreaCerchio.Enabled = true; //cerchio
                txbRaggio.Enabled = true;
                txbDiametro.Enabled = true;
                txbArea.Text = ""; //quadrato
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
                txbAreaCerchio.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbDiametro.Text = "";
            }
        }

        private void txbRaggio_TextChanged(object sender, EventArgs e) //RAGGIO
        {
            if (txbRaggio.Text != "" && this.ActiveControl == txbRaggio) //letteralmente: se la textbox del raggio è vuota e il cursore indica che il controllo textbox del raggio è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbArea.Enabled = false; //quadrato
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                txbAreaCerchio.Enabled = false; //cerchio
                txbDiametro.Enabled = false;
                txbCirconferenza.Enabled = false;
                try //La struttura try-catch serve per prevenire errori non logici. Esempio: un utente che immette un carattere al posto di un numero intero previsto
                {
                    txbAreaCerchio.Text = cerchio.area(Convert.ToDouble(txbRaggio.Text)).ToString();
                    txbCirconferenza.Text = cerchio.circonferenza(Convert.ToDouble(txbRaggio.Text)).ToString();
                    txbDiametro.Text = cerchio.diametro(Convert.ToDouble(txbRaggio.Text)).ToString();
                }
                catch
                {
                    txbRaggio.Text = "";
                    //raggio = 0;
                }
            }
            else if (this.ActiveControl == txbRaggio)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbArea.Enabled = true; //quadrato
                txbLato.Enabled = true;
                txbDiagonale.Enabled = true;
                txbPerimetro.Enabled = true;
                txbAreaCerchio.Enabled = true; //cerchio
                txbCirconferenza.Enabled = true;
                txbDiametro.Enabled = true;
                txbArea.Text = ""; //quadrato
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
                txbAreaCerchio.Text = ""; //cerchio
                txbCirconferenza.Text = "";
                txbDiametro.Text = "";
            }
        }

        private void txbDiametro_TextChanged(object sender, EventArgs e) //DIAMETRO
        {
            if (txbDiametro.Text != "" && this.ActiveControl == txbDiametro) //letteralmente: se la textbox del diametro è vuota e il cursore indica che il controllo textbox del diametro è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbArea.Enabled = false; //quadrato
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                txbAreaCerchio.Enabled = false; //cerchio
                txbCirconferenza.Enabled = false;
                txbRaggio.Enabled = false;
                try //La struttura try-catch serve per prevenire errori non logici. Esempio: un utente che immette un carattere al posto di un numero intero previsto
                {
                    txbAreaCerchio.Text = cerchio.area(Convert.ToDouble(txbDiametro.Text)).ToString();
                    txbRaggio.Text = cerchio.raggio(Convert.ToInt32(txbDiametro.Text)).ToString();
                    //txbCirconferenza = cerchio.circonferenza(Convert.ToDouble(txbDiametro.Text)).ToString();
                }
                catch
                {
                    txbDiametro.Text = "";
                    //diametro = 0;
                }
            }
            else if (this.ActiveControl == txbDiametro)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbArea.Enabled = true; //quadrato
                txbLato.Enabled = true;
                txbDiagonale.Enabled = true;
                txbPerimetro.Enabled = true;
                txbAreaCerchio.Enabled = true; //cerchio
                txbRaggio.Enabled = true;
                txbCirconferenza.Enabled = true;
                txbArea.Text = ""; //quadrato
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
                txbAreaCerchio.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbCirconferenza.Text = "";
            }
        }

        private void txbAreaCerchio_TextChanged(object sender, EventArgs e) //AREA CERCHIO
        {
            if (txbAreaCerchio.Text != "" && this.ActiveControl == txbAreaCerchio) //letteralmente: se la textbox dell'area del cerchio è vuota e il cursore indica che il controllo textbox dell'area del cerchio è attivo...
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbArea.Enabled = false; //quadrato
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                txbCirconferenza.Enabled = false; //cerchio
                txbDiametro.Enabled = false;
                txbRaggio.Enabled = false;
                try //La struttura try-catch serve per prevenire errori non logici. Esempio: un utente che immette un carattere al posto di un numero intero previsto
                {
                    txbCirconferenza.Text = cerchio.circonferenza(Convert.ToDouble(txbAreaCerchio.Text)).ToString();
                    txbRaggio.Text = cerchio.raggio(Convert.ToDouble(txbAreaCerchio.Text)).ToString();
                    txbDiametro.Text = cerchio.diametro(Convert.ToDouble(txbAreaCerchio.Text)).ToString();
                }
                catch
                {
                    txbAreaCerchio.Text = "";
                    //areaCerchio = 0;
                }
            }
            else if (this.ActiveControl == txbAreaCerchio)
            {
                //sblocco le textbox per permettere all'utente di effettuare un nuovo calcolo e la pulizia delle stesse
                txbArea.Enabled = true; //quadrato
                txbLato.Enabled = true;
                txbDiagonale.Enabled = true;
                txbPerimetro.Enabled = true;
                txbCirconferenza.Enabled = true; //cerchio
                txbRaggio.Enabled = true;
                txbDiametro.Enabled = true;
                txbArea.Text = ""; //quadrato
                txbLato.Text = "";
                txbDiagonale.Text = "";
                txbPerimetro.Text = "";
                txbCirconferenza.Text = ""; //cerchio
                txbRaggio.Text = "";
                txbDiametro.Text = "";
            }
        }
    }
}