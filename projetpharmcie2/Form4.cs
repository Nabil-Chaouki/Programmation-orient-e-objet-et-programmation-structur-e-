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
    public partial class Form4 : Form
    {
        private Form1 form1;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Form1 form1):this()
        {
            // TODO: Complete member initialization
            this.form1 = form1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.chargerDataGrid();
        }

        void chargerDataGrid()
        {
            this.dataGridView1.Rows.Clear();
            foreach (KeyValuePair<int,Client> cl in this.form1.Ph.Clients1)
            {
                this.dataGridView1.Rows.Add(cl.Value.Nom,cl.Value.Prenom,cl.Value.Chifa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Dispose();
            f.Show();
        }
    }
}
