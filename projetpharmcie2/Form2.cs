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
    public partial class Form2 : Form
    {
       
        Form1 m;
        public Form2(Form1 m):this()
        {
            this.m = m;
            
        }

        public Form2()
        {

            
            InitializeComponent();
            //this.ph = new Pharmacie("Malak", "127 rue resistance");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.m.Show();

            this.Dispose();
            
            
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MiseCambo();
        }

        private void rdpharmacie_CheckedChanged(object sender, EventArgs e)
        {
            this.MiseCambo();
            this.cmbProduits.Text = "";

        }
        public void MiseCambo()
        {

            if (this.rdpharmacie.Checked)
            {
                this.cmbProduits.Items.Clear();
                foreach (KeyValuePair<string, Produit> p in this.m.Ph.Produits1)
                {
                    if (p.Value is Medicamment)
                        this.cmbProduits.Items.Add(p.Value.Ref1);
                }
            }
            else if (this.rdparapharmacie.Checked)
            {
                this.cmbProduits.Items.Clear();
                foreach (KeyValuePair<string, Produit> p in this.m.Ph.Produits1)
                {
                    if (p.Value is ProdParaPharm)
                        this.cmbProduits.Items.Add(p.Value.Ref1);
                }
            }
            else
            {
                this.cmbProduits.Items.Clear();
                foreach (KeyValuePair<string, Produit> p in this.m.Ph.Produits1)
                {
                    this.cmbProduits.Items.Add(p.Value.Ref1);
                }
            }

        }


        

        private void rdparapharmacie_CheckedChanged(object sender, EventArgs e)
        {
            this.MiseCambo();
            this.cmbProduits.Text = "";
        }

        private void rdlesdeux_CheckedChanged(object sender, EventArgs e)
        {
            this.MiseCambo();
            this.cmbProduits.Text = "";
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.txtnom.Text;
                string prenom = this.textprenom.Text;
                int chifa = int.Parse(this.txtchifa.Text);
                if (chifa <= 0) throw new Exception("chifa est invalide");
                int qte = int.Parse(this.txtqte.Text);
                if (qte <= 0) throw new Exception("quabtite invalide est invalide");
                this.m.Ph.achat(new Client(nom, prenom, chifa), this.m.Ph.Produits1[(string)this.cmbProduits.SelectedItem], qte);
                MessageBox.Show("operation success!");

                this.txtqte.Text = "";
                this.txtchifa.Text = "";
                this.txtnom.Text = "";
                this.textprenom.Text = "";
                this.cmbProduits.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
