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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace prj126
{   
    [Serializable]

    public partial class Form1 : Form
    {
        private List<Etudient> gr = new List<Etudient>();

        public List<Etudient> Gr
        {
            get { return gr; }
            set { gr = value; }
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.Text = "Inscreption";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("groupe.bin")) throw new Exception("Fichier ' Groupe.bin ' n'existe pas ... ");
                FileStream fs = new FileStream("groupe.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.gr = (List<Etudient>)bf.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK);
            }
            this.cmbBac.Items.Add("Sc Maths");
            this.cmbBac.Items.Add("Sc Phy");
            this.cmbBac.Items.Add("Sc SVT");
            this.cmbSec.Items.Add("TDI");
            this.cmbSec.Items.Add("TRI");
            this.missAjour(this.gr);
            this.chargerPrg(this.prgTDI, "TDI");
            this.chargerPrg(this.prgTRI, "TRI");
        }

        private void missAjour(List <Etudient> grl)
        {
            this.grdEtudient.Rows.Clear();
            for(int i = 0; i < grl.Count; i++)
            {
                this.grdEtudient.Rows.Add((i + 1).ToString(), (grl[i].Ide).ToString(), (grl[i].Nom), (grl[i]).Dn.ToShortDateString(), (grl[i].Bac), (grl[i].Sec), (grl[i].Note).ToString());
            }
        }

        public Etudient find(Etudient et)
        {
            foreach(Etudient val in this.gr)
            {
                if (val.Equals(et))
                    return val;
            }
            return null;
        }

        private void chargerPrg(ProgressBar bar,string sec)
        {
            bar.Minimum = 0;
            bar.Maximum = 20;
            bar.Step= 1;
            int nb = this.lstGr(sec).Count;
            for (int i = 1; i <= nb; i++)
            {
                bar.PerformStep();
            }

        }

        private void txtIde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (char.IsControl(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)))
                e.Handled = false;
            else e.Handled = true;
        }

        public List<Etudient> lstGr(string sec)
        {
            List<Etudient> l = new List<Etudient>();
            foreach(Etudient et in this.gr)
            {
                if(et.Sec.CompareTo(sec) == 0)
                    l.Add(et);
            }
            return l;
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.txtIde.Text == "") || (this.txtNom.Text == "") || (this.txtNote.Text == "")) throw new Exception("Saisir touts les donnees ...");
                int ide = int.Parse(this.txtIde.Text);
                if (this.find(new Etudient(ide)) != null) throw new Exception("Un Etudient avec le meme ide deja existe ");
                string nom = (string)this.txtNom.Text;
                DateTime dn = this.dateTimePicker1.Value;
                if ((DateTime.Now.Year - dn.Year) > 26) throw new Exception("Too old ...");
                string bac = (string)this.cmbBac.SelectedItem;
                string sec = (string)this.cmbSec.SelectedItem;
                if ((this.lstGr(sec).Count) == 20) throw new Exception(sec + " 3mra ");
                double note = double.Parse(this.txtNote.Text);
                if ((note < 0) || (note > 20)) throw new Exception("La nore est inccorect ...");
                if (note < 10) throw new Exception("note < 10 ???");
                if (( bac == "Sc SVT") & ( sec == "TDI")) throw new Exception("ohhho ...");
                if ((bac == "Sc Phy") & (sec == "TDI") & (note < 12)) throw new Exception("12 ...");
                this.gr.Add(new Etudient(ide, nom, dn, bac, sec, note));
                this.missAjour(this.gr);
                this.txtIde.Text = "";
                this.txtNom.Text = "";
                this.txtNote.Text = "";
                if (sec == "TDI") this.prgTDI.PerformStep();
                if (sec == "TRI") this.prgTRI.PerformStep();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !", MessageBoxButtons.OK);
            }
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Etes vous sur ?", "Fermer !", MessageBoxButtons.YesNo);
            if(ans == DialogResult.Yes)
            {
                FileStream fs = new FileStream("Groupe.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this.gr);
                fs.Close();
            }
            Environment.Exit(0);
        }

        private void btOperation_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this, this.gr);
            f2.Show();
        }
    }
}
