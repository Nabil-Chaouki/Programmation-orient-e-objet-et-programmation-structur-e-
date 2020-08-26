using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetpharmcie2
{
    public partial class Form5 : Form
    {

        private Form1 f1;

        public Form1 F1
        {
            get { return f1; }
            set { f1 = value; }
        }
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(Form1 f1):this()
        {
            
            // TODO: Complete member initialization
            this.f1 = f1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string reef = this.txtreff.Text;

                double prix = double.Parse(this.txtprix.Text);
                if (prix <= 0) throw new Exception("prix invalide");
                int qte = int.Parse(this.txtqte.Text);
                if (qte <= 0) throw new Exception("quantite invalide");
                if (this.rdmedica.Checked)
                {
                    bool ord = this.checkordonance.Checked;
                    bool gene = this.checkgenerique.Checked;
                    this.f1.Ph.Produits1.Add(reef, new Medicamment(reef, prix, qte, gene, ord));

                }
                else
                {
                    string type = this.txttype.Text;
                    this.f1.Ph.Produits1.Add(reef, new ProdParaPharm(reef, prix, qte, type));
                }

                //this.F2.MiseCambo();


                f1.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdmedica_CheckedChanged(object sender, EventArgs e)
        {
            this.txttype.Text = "";
            this.txttype.Enabled = false;
            this.label4.Enabled = false;
            
            this.checkgenerique.Enabled = true;
            this.checkordonance.Enabled = true;
        }

        private void rdparapharmacie_CheckedChanged(object sender, EventArgs e)
        {
            this.label4.Enabled = true;
            this.txttype.Enabled = true;

            this.checkgenerique.Checked = false;
            this.checkgenerique.Enabled = false;
            this.checkordonance.Checked = false;
            this.checkordonance.Enabled = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.txtreff.Select();
            this.rdmedica.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            this.Dispose();
            p.Show();
        }
    }
}
