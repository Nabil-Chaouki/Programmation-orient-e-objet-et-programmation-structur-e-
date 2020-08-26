using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace projetpharmcie2
{
    [Serializable()]
    public partial class Form1 : Form
    {
        private Pharmacie ph;


        public Pharmacie Ph
        {
            get { return ph; }
            set { ph = value; }
        }
        
        public Form1()
        {
            InitializeComponent();

            ph = new Pharmacie("oa","ia");
        }

        private void achatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2(this);
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream st= File.Create("Nabil.bin");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(st, this.ph);

            st.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Stream stream = File.Open("Nabil.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.ph = (Pharmacie)bf.Deserialize(stream);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void clientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            this.Hide();
            f3.Show();
        }

        private void produitsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            this.Hide();
            f4.Show();
        }

        private void ajouterUnProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            this.Hide();
            f5.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
