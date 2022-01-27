namespace Classi_figure_geometriche
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbLato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDiagonale = new System.Windows.Forms.TextBox();
            this.txbPerimetro = new System.Windows.Forms.TextBox();
            this.txbArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLato
            // 
            this.txbLato.Location = new System.Drawing.Point(53, 80);
            this.txbLato.Name = "txbLato";
            this.txbLato.Size = new System.Drawing.Size(100, 23);
            this.txbLato.TabIndex = 0;
            this.txbLato.TextChanged += new System.EventHandler(this.txbLato_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagonale";
            // 
            // txbDiagonale
            // 
            this.txbDiagonale.Location = new System.Drawing.Point(53, 166);
            this.txbDiagonale.Name = "txbDiagonale";
            this.txbDiagonale.Size = new System.Drawing.Size(100, 23);
            this.txbDiagonale.TabIndex = 3;
            this.txbDiagonale.TextChanged += new System.EventHandler(this.txbDiagonale_TextChanged);
            // 
            // txbPerimetro
            // 
            this.txbPerimetro.Location = new System.Drawing.Point(219, 166);
            this.txbPerimetro.Name = "txbPerimetro";
            this.txbPerimetro.Size = new System.Drawing.Size(100, 23);
            this.txbPerimetro.TabIndex = 5;
            this.txbPerimetro.TextChanged += new System.EventHandler(this.txbPerimetro_TextChanged);
            // 
            // txbArea
            // 
            this.txbArea.Location = new System.Drawing.Point(219, 80);
            this.txbArea.Name = "txbArea";
            this.txbArea.Size = new System.Drawing.Size(100, 23);
            this.txbArea.TabIndex = 4;
            this.txbArea.TextChanged += new System.EventHandler(this.txbArea_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Perimetro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPerimetro);
            this.Controls.Add(this.txbArea);
            this.Controls.Add(this.txbDiagonale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbLato;
        private Label label1;
        private Label label2;
        private TextBox txbDiagonale;
        private TextBox txbPerimetro;
        private TextBox txbArea;
        private Label label3;
        private Label label4;
    }
}