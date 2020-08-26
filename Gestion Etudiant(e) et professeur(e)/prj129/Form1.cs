using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace prj129
{
    public partial class Form1 : Form
    {
        private List<Persone> lstPersone = new List<Persone>();

        private List<Prof> lstProf = new List<Prof>();
        private List<Etudient> lstEtudient = new List<Etudient>();

        private List<string> lstClasse = new List<string>();
        private List<string> lstMat = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rdEtudient.Checked = true;
            this.rdAlpha.Checked = true;
            this.source();
        }

        private void source()
        {
            this.lstClasse.Add("TDI 101");
            this.lstClasse.Add("TRI 102");
            this.lstClasse.Add("TMC 103");
            this.lstMat.Add("TDI");
            this.lstMat.Add("TRI");
            this.lstMat.Add("TMC");
        }

        private void misjour(List<Persone> tous,bool rep,string mc)
        {
            this.dataGridView1.Rows.Clear();
            Persone p = null;
            for(int i=0;i<tous.Count;i++)
            {
                if ((tous[i] is Prof) && (rep))
                {
                    p = new Persone(tous[i].Nom,tous[i].Prenom,tous[i].Age);
                    this.lstProf.Add(new Prof(p.Nom,p.Prenom,p.Age,mc));
                }
                else
                {
                    p = new Persone(tous[i].Nom, tous[i].Prenom, tous[i].Age);
                    this.lstEtudient.Add(new Etudient (p.Nom,p.Prenom,p.Age,mc));
                }
            }
           this.dataGridView1.Rows.Add(p.Nom,p.Prenom,p.Age,mc);
        }

        private void rdProf_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdProf.Checked)
                this.labelCM.Text = "Matiere :";
            else
                this.labelCM.Text = "Classe :";
        }

        private void btEnrg_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.txtNom.Text == "") || (this.txtPrenom.Text == "") || (this.txtAge.Text == "") || (this.txtClasse.Text == "")) throw new Exception("Sasi toutt les donnees");
                string nom = (string)this.txtNom.Text;
                string prenom = (string)this.txtPrenom.Text;
                int age  = int.Parse (this.txtAge.Text);
                string cm = (string)this.txtClasse.Text;
                if (this.rdEtudient.Checked)
                {
                    this.lstPersone.Add(new Persone(nom, prenom, age));
                    this.misjour(this.lstPersone, true, cm);
                }
                else 
                {
                    this.lstPersone.Add(new Persone(nom, prenom, age));
                    this.misjour(this.lstPersone, false, cm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK);
            }
        }
    }
}
