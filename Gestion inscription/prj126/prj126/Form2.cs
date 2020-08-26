using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj126
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 f1;

        private List<Etudient> l;

        public Form2(Form1 f1 ,List <Etudient> l) : this()
        {
            this.f1=f1;
            this.l = l;
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.rdTout.Checked = true;
            this.ControlBox = false;
            this.chargerData(l);
        }

        private void chargerData(List<Etudient> le) 
        {
            this.grdEtudient.Rows.Clear();
            for (int i = 0; i < le.Count; i++)
            {
                this.grdEtudient.Rows.Add((i+1).ToString() ,le[i].Ide.ToString(),le[i].Nom,le[i].Dn.ToShortDateString(),le[i].Bac,le[i].Sec,le[i].Note.ToString());
            }
        }

        private void rdTout_CheckedChanged(object sender, EventArgs e)
        {
            this.chargerData(this.f1.Gr);
        }

        private void rdTDI_CheckedChanged(object sender, EventArgs e)
        {
            this.chargerData(this.f1.lstGr("TDI"));
        }

        private void rdTRI_CheckedChanged(object sender, EventArgs e)
        {
            this.chargerData(this.f1.lstGr("TRI"));
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            try
            {
                int i = (int) this.grdEtudient.CurrentRow.Index;
                int ide = int.Parse(this.grdEtudient.Rows[i].Cells[1].Value.ToString());
                Etudient et = this.f1.find(new Etudient(ide));
                this.f1.Gr.Remove(et);
                Form2 f2 = null;
                if (this.rdTout.Checked) f2 = new Form2(this.f1, this.f1.Gr);
                if (this.rdTDI.Checked) f2 = new Form2(this.f1, this.f1.lstGr("TDI"));
                if (this.rdTRI.Checked) f2 = new Form2(this.f1, this.f1.lstGr("TRI"));
                f2.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
