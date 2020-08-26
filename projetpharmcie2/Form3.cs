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
    public partial class Form3 : Form
    {
        private Form1 f1;

        public Form1 F1
        {
            get { return f1; }
            set { f1 = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 f1):this()
        {
            this.f1 = f1;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.chargerData();
        }
        public void chargerData()
        {
            this.dtgclients.Rows.Clear();
            foreach (KeyValuePair<string, Produit> pr in this.f1.Ph.Produits1)
            {
                if(pr.Value is Medicamment)
                this.dtgclients.Rows.Add(pr.Value.Ref1, pr.Value.Prix, pr.Value.Qte,((Medicamment)pr.Value).Ordonnace, ((Medicamment)pr.Value).Generique,"_____");
                if(pr.Value is ProdParaPharm)
                    this.dtgclients.Rows.Add(pr.Value.Ref1, pr.Value.Prix, pr.Value.Qte,"_____","______",((ProdParaPharm)pr.Value).Type);
            }
        }

        private void dtgclients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = (int)this.dtgclients[2, this.dtgclients.CurrentCell.RowIndex].Value;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            this.Dispose();
            p.Show();
        }

    }
}
