namespace projetpharmcie2
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdmedica = new System.Windows.Forms.RadioButton();
            this.rdparapharmacie = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtreff = new System.Windows.Forms.TextBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.checkordonance = new System.Windows.Forms.CheckBox();
            this.checkgenerique = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantite";
            // 
            // rdmedica
            // 
            this.rdmedica.AutoSize = true;
            this.rdmedica.Location = new System.Drawing.Point(15, 138);
            this.rdmedica.Name = "rdmedica";
            this.rdmedica.Size = new System.Drawing.Size(91, 17);
            this.rdmedica.TabIndex = 3;
            this.rdmedica.TabStop = true;
            this.rdmedica.Text = "Medicamment";
            this.rdmedica.UseVisualStyleBackColor = true;
            this.rdmedica.CheckedChanged += new System.EventHandler(this.rdmedica_CheckedChanged);
            // 
            // rdparapharmacie
            // 
            this.rdparapharmacie.AutoSize = true;
            this.rdparapharmacie.Location = new System.Drawing.Point(15, 161);
            this.rdparapharmacie.Name = "rdparapharmacie";
            this.rdparapharmacie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdparapharmacie.Size = new System.Drawing.Size(96, 17);
            this.rdparapharmacie.TabIndex = 4;
            this.rdparapharmacie.TabStop = true;
            this.rdparapharmacie.Text = "Parapharmacie";
            this.rdparapharmacie.UseVisualStyleBackColor = true;
            this.rdparapharmacie.CheckedChanged += new System.EventHandler(this.rdparapharmacie_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour au menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtreff
            // 
            this.txtreff.Location = new System.Drawing.Point(72, 24);
            this.txtreff.Name = "txtreff";
            this.txtreff.Size = new System.Drawing.Size(100, 20);
            this.txtreff.TabIndex = 6;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(72, 51);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(100, 20);
            this.txtprix.TabIndex = 7;
            // 
            // txtqte
            // 
            this.txtqte.Location = new System.Drawing.Point(72, 82);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(100, 20);
            this.txtqte.TabIndex = 8;
            // 
            // checkordonance
            // 
            this.checkordonance.AutoSize = true;
            this.checkordonance.Location = new System.Drawing.Point(15, 3);
            this.checkordonance.Name = "checkordonance";
            this.checkordonance.Size = new System.Drawing.Size(85, 17);
            this.checkordonance.TabIndex = 9;
            this.checkordonance.Text = "Ordonnance";
            this.checkordonance.UseVisualStyleBackColor = true;
            // 
            // checkgenerique
            // 
            this.checkgenerique.AutoSize = true;
            this.checkgenerique.Location = new System.Drawing.Point(127, 207);
            this.checkgenerique.Name = "checkgenerique";
            this.checkgenerique.Size = new System.Drawing.Size(75, 17);
            this.checkgenerique.TabIndex = 10;
            this.checkgenerique.Text = "Generique";
            this.checkgenerique.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(72, 112);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(100, 20);
            this.txttype.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkordonance);
            this.panel1.Location = new System.Drawing.Point(2, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 39);
            this.panel1.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetpharmcie2.Properties.Resources.modèle_sans_couture_de_pharmacie_en_vert_47122268;
            this.ClientSize = new System.Drawing.Size(341, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkgenerique);
            this.Controls.Add(this.txtqte);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.txtreff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdparapharmacie);
            this.Controls.Add(this.rdmedica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdmedica;
        private System.Windows.Forms.RadioButton rdparapharmacie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtreff;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.CheckBox checkordonance;
        private System.Windows.Forms.CheckBox checkgenerique;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Panel panel1;
    }
}