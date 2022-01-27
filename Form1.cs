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
            if (txbLato.Text != "" && this.ActiveControl == txbLato)
            {
                //blocco le textbox per non permettere all'utente l'alterazione dei calcoli effettuati
                txbArea.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                try
                {
                    //lato = Convert.ToInt32(txbLato.Text);
                    txbArea.Text = quadrato.area(Convert.ToInt32(txbLato.Text)).ToString();
                } catch
                {
                    txbLato.Text = "";
                    //lato = 0;
                }

                //area = quadrato.areaFromLato(lato);
                //diagonale = quadrato.diagonaleFromLato(lato);
                //perimetro = quadrato.perimetroFromLato(lato);
                //txbArea.Text= area.ToString();
                //txbDiagonale.Text = diagonale.ToString();
                //txbPerimetro.Text = perimetro.ToString();
            }
            else if (this.ActiveControl == txbLato)
            {
                //sblocco 
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
            if (txbArea.Text != "" && this.ActiveControl == txbArea)
            {
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbPerimetro.Enabled = false;
                try
                {
                    area = Convert.ToInt32(txbArea.Text);
                } catch
                {
                    area = 0;
                }
                lato = quadrato.latoFromArea(area);
                diagonale = quadrato.diagonaleFromLato(lato);
                perimetro = quadrato.perimetroFromArea(area);//quadrato.perimetroFromLato(lato);
                txbLato.Text = lato.ToString();
                txbDiagonale.Text = diagonale.ToString();
                txbPerimetro.Text = perimetro.ToString();
            }
            else if (this.ActiveControl == txbArea)
            {
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
            if (txbPerimetro.Text != "" && this.ActiveControl == txbPerimetro)
            {
                txbLato.Enabled = false;
                txbDiagonale.Enabled = false;
                txbArea.Enabled = false;
                try {perimetro = Convert.ToInt32(txbPerimetro.Text);} catch {perimetro = 0;} //STRUTTURA DEL TRY CATCH COMPATTATA
                lato = quadrato.latoFromPerimetro(perimetro);
                diagonale = quadrato.diagonaleFromLato(lato);
                area = quadrato.areaFromLato(lato);
                txbLato.Text = lato.ToString();
                txbArea.Text = perimetro.ToString();
                txbDiagonale.Text = diagonale.ToString();
            }
            else if (this.ActiveControl == txbPerimetro)
            {
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
            if (txbDiagonale.Text != "" && this.ActiveControl == txbDiagonale)
            {
                txbLato.Enabled = false;
                txbArea.Enabled = false;
                txbPerimetro.Enabled = false;
                try
                {
                    diagonale = Convert.ToInt32(txbDiagonale.Text);
                }
                catch
                {
                    diagonale = 0;
                }
                lato = quadrato.latoFromDiagonale(diagonale);
                area = quadrato.areaFromLato(lato);
                perimetro = quadrato.perimetroFromLato(lato);
                txbLato.Text = lato.ToString();
                txbPerimetro.Text = perimetro.ToString();
                txbArea.Text = area.ToString();
            }
            else if (this.ActiveControl == txbDiagonale)
            {
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