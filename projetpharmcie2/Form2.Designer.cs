namespace projetpharmcie2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtchifa = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdpharmacie = new System.Windows.Forms.RadioButton();
            this.rdparapharmacie = new System.Windows.Forms.RadioButton();
            this.rdlesdeux = new System.Windows.Forms.RadioButton();
            this.cmbProduits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnajouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txtchifa);
            this.panel1.Controls.Add(this.textprenom);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 241);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtchifa
            // 
            this.txtchifa.Location = new System.Drawing.Point(70, 103);
            this.txtchifa.Name = "txtchifa";
            this.txtchifa.Size = new System.Drawing.Size(100, 20);
            this.txtchifa.TabIndex = 5;
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(70, 65);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(100, 20);
            this.textprenom.TabIndex = 4;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(70, 25);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chifa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.txtqte);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rdpharmacie);
            this.panel2.Controls.Add(this.rdparapharmacie);
            this.panel2.Controls.Add(this.rdlesdeux);
            this.panel2.Controls.Add(this.cmbProduits);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(293, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 241);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(78, 114);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(121, 20);
            this.txtqte.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Qantité";
            // 
            // rdpharmacie
            // 
            this.rdpharmacie.AutoSize = true;
            this.rdpharmacie.Location = new System.Drawing.Point(236, 68);
            this.rdpharmacie.Name = "rdpharmacie";
            this.rdpharmacie.Size = new System.Drawing.Size(137, 17);
            this.rdpharmacie.TabIndex = 4;
            this.rdpharmacie.TabStop = true;
            this.rdpharmacie.Text = "Produits Medicamments";
            this.rdpharmacie.UseVisualStyleBackColor = true;
            this.rdpharmacie.CheckedChanged += new System.EventHandler(this.rdpharmacie_CheckedChanged);
            // 
            // rdparapharmacie
            // 
            this.rdparapharmacie.AutoSize = true;
            this.rdparapharmacie.Location = new System.Drawing.Point(97, 68);
            this.rdparapharmacie.Name = "rdparapharmacie";
            this.rdparapharmacie.Size = new System.Drawing.Size(137, 17);
            this.rdparapharmacie.TabIndex = 3;
            this.rdparapharmacie.TabStop = true;
            this.rdparapharmacie.Text = "Produits Parapharmacie";
            this.rdparapharmacie.UseVisualStyleBackColor = true;
            this.rdparapharmacie.CheckedChanged += new System.EventHandler(this.rdparapharmacie_CheckedChanged);
            // 
            // rdlesdeux
            // 
            this.rdlesdeux.AutoSize = true;
            this.rdlesdeux.Location = new System.Drawing.Point(21, 68);
            this.rdlesdeux.Name = "rdlesdeux";
            this.rdlesdeux.Size = new System.Drawing.Size(70, 17);
            this.rdlesdeux.TabIndex = 2;
            this.rdlesdeux.TabStop = true;
            this.rdlesdeux.Text = "Les Deux";
            this.rdlesdeux.UseVisualStyleBackColor = true;
            this.rdlesdeux.CheckedChanged += new System.EventHandler(this.rdlesdeux_CheckedChanged);
            // 
            // cmbProduits
            // 
            this.cmbProduits.FormattingEnabled = true;
            this.cmbProduits.Location = new System.Drawing.Point(78, 21);
            this.cmbProduits.Name = "cmbProduits";
            this.cmbProduits.Size = new System.Drawing.Size(121, 21);
            this.cmbProduits.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Produits";
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(12, 283);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(181, 51);
            this.btnajouter.TabIndex = 2;
            this.btnajouter.Text = "Acheter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Retour au Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetpharmcie2.Properties.Resources.modèle_sans_couture_de_pharmacie_en_vert_47122268;
            this.ClientSize = new System.Drawing.Size(750, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtchifa;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdpharmacie;
        private System.Windows.Forms.RadioButton rdparapharmacie;
        private System.Windows.Forms.RadioButton rdlesdeux;
        private System.Windows.Forms.ComboBox cmbProduits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button button1;

    }
}