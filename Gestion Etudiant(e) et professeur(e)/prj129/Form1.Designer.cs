namespace prj129
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCM = new System.Windows.Forms.Label();
            this.rdEtudient = new System.Windows.Forms.RadioButton();
            this.rdProf = new System.Windows.Forms.RadioButton();
            this.btEnrg = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdAlpha = new System.Windows.Forms.RadioButton();
            this.rdAncee = new System.Windows.Forms.RadioButton();
            this.rdChrono = new System.Windows.Forms.RadioButton();
            this.btEtudient = new System.Windows.Forms.Button();
            this.btProfesseur = new System.Windows.Forms.Button();
            this.btTous = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prinom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age :";
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Location = new System.Drawing.Point(408, 190);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(41, 13);
            this.labelCM.TabIndex = 4;
            this.labelCM.Text = "Classe ";
            // 
            // rdEtudient
            // 
            this.rdEtudient.AutoSize = true;
            this.rdEtudient.Location = new System.Drawing.Point(433, 268);
            this.rdEtudient.Name = "rdEtudient";
            this.rdEtudient.Size = new System.Drawing.Size(64, 17);
            this.rdEtudient.TabIndex = 5;
            this.rdEtudient.TabStop = true;
            this.rdEtudient.Text = "Etudient";
            this.rdEtudient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdEtudient.UseVisualStyleBackColor = true;
            // 
            // rdProf
            // 
            this.rdProf.AutoSize = true;
            this.rdProf.Location = new System.Drawing.Point(540, 268);
            this.rdProf.Name = "rdProf";
            this.rdProf.Size = new System.Drawing.Size(70, 17);
            this.rdProf.TabIndex = 6;
            this.rdProf.TabStop = true;
            this.rdProf.Text = "Profeseur";
            this.rdProf.UseVisualStyleBackColor = true;
            this.rdProf.CheckedChanged += new System.EventHandler(this.rdProf_CheckedChanged);
            // 
            // btEnrg
            // 
            this.btEnrg.Location = new System.Drawing.Point(481, 322);
            this.btEnrg.Name = "btEnrg";
            this.btEnrg.Size = new System.Drawing.Size(75, 23);
            this.btEnrg.TabIndex = 7;
            this.btEnrg.Text = "Enregistrer";
            this.btEnrg.UseVisualStyleBackColor = true;
            this.btEnrg.Click += new System.EventHandler(this.btEnrg_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(499, 65);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(499, 103);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(499, 140);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(499, 183);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(100, 20);
            this.txtClasse.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Informations";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prenom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Classe/Matier";
            this.Column4.Name = "Column4";
            // 
            // rdAlpha
            // 
            this.rdAlpha.AutoSize = true;
            this.rdAlpha.Location = new System.Drawing.Point(17, 19);
            this.rdAlpha.Name = "rdAlpha";
            this.rdAlpha.Size = new System.Drawing.Size(87, 17);
            this.rdAlpha.TabIndex = 14;
            this.rdAlpha.TabStop = true;
            this.rdAlpha.Text = "Alphabatique";
            this.rdAlpha.UseVisualStyleBackColor = true;
            // 
            // rdAncee
            // 
            this.rdAncee.AutoSize = true;
            this.rdAncee.Location = new System.Drawing.Point(148, 19);
            this.rdAncee.Name = "rdAncee";
            this.rdAncee.Size = new System.Drawing.Size(73, 17);
            this.rdAncee.TabIndex = 15;
            this.rdAncee.TabStop = true;
            this.rdAncee.Text = "Anncietee";
            this.rdAncee.UseVisualStyleBackColor = true;
            // 
            // rdChrono
            // 
            this.rdChrono.AutoSize = true;
            this.rdChrono.Location = new System.Drawing.Point(276, 19);
            this.rdChrono.Name = "rdChrono";
            this.rdChrono.Size = new System.Drawing.Size(93, 17);
            this.rdChrono.TabIndex = 16;
            this.rdChrono.TabStop = true;
            this.rdChrono.Text = "Chronologique";
            this.rdChrono.UseVisualStyleBackColor = true;
            // 
            // btEtudient
            // 
            this.btEtudient.Location = new System.Drawing.Point(34, 307);
            this.btEtudient.Name = "btEtudient";
            this.btEtudient.Size = new System.Drawing.Size(75, 23);
            this.btEtudient.TabIndex = 17;
            this.btEtudient.Text = "Etudient";
            this.btEtudient.UseVisualStyleBackColor = true;
            // 
            // btProfesseur
            // 
            this.btProfesseur.Location = new System.Drawing.Point(154, 306);
            this.btProfesseur.Name = "btProfesseur";
            this.btProfesseur.Size = new System.Drawing.Size(75, 23);
            this.btProfesseur.TabIndex = 18;
            this.btProfesseur.Text = "Profeseur";
            this.btProfesseur.UseVisualStyleBackColor = true;
            // 
            // btTous
            // 
            this.btTous.Location = new System.Drawing.Point(290, 307);
            this.btTous.Name = "btTous";
            this.btTous.Size = new System.Drawing.Size(75, 23);
            this.btTous.TabIndex = 19;
            this.btTous.Text = "Tous";
            this.btTous.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdAlpha);
            this.panel1.Controls.Add(this.rdAncee);
            this.panel1.Controls.Add(this.rdChrono);
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 51);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btTous);
            this.Controls.Add(this.btProfesseur);
            this.Controls.Add(this.btEtudient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btEnrg);
            this.Controls.Add(this.rdProf);
            this.Controls.Add(this.rdEtudient);
            this.Controls.Add(this.labelCM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.RadioButton rdEtudient;
        private System.Windows.Forms.RadioButton rdProf;
        private System.Windows.Forms.Button btEnrg;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton rdAlpha;
        private System.Windows.Forms.RadioButton rdAncee;
        private System.Windows.Forms.RadioButton rdChrono;
        private System.Windows.Forms.Button btEtudient;
        private System.Windows.Forms.Button btProfesseur;
        private System.Windows.Forms.Button btTous;
        private System.Windows.Forms.Panel panel1;

    }
}

