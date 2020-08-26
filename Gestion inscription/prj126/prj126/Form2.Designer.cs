namespace prj126
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
            this.grdEtudient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFermer = new System.Windows.Forms.Button();
            this.rdTout = new System.Windows.Forms.RadioButton();
            this.rdTDI = new System.Windows.Forms.RadioButton();
            this.rdTRI = new System.Windows.Forms.RadioButton();
            this.btSup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEtudient)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEtudient
            // 
            this.grdEtudient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEtudient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grdEtudient.Location = new System.Drawing.Point(5, 12);
            this.grdEtudient.Name = "grdEtudient";
            this.grdEtudient.Size = new System.Drawing.Size(395, 150);
            this.grdEtudient.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ide";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bac";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sec";
            this.Column6.Name = "Column6";
            this.Column6.Width = 35;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Note";
            this.Column7.Name = "Column7";
            this.Column7.Width = 35;
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(303, 306);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(75, 23);
            this.btFermer.TabIndex = 16;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // rdTout
            // 
            this.rdTout.AutoSize = true;
            this.rdTout.Location = new System.Drawing.Point(417, 46);
            this.rdTout.Name = "rdTout";
            this.rdTout.Size = new System.Drawing.Size(47, 17);
            this.rdTout.TabIndex = 17;
            this.rdTout.TabStop = true;
            this.rdTout.Text = "Tout";
            this.rdTout.UseVisualStyleBackColor = true;
            this.rdTout.CheckedChanged += new System.EventHandler(this.rdTout_CheckedChanged);
            // 
            // rdTDI
            // 
            this.rdTDI.AutoSize = true;
            this.rdTDI.Location = new System.Drawing.Point(417, 70);
            this.rdTDI.Name = "rdTDI";
            this.rdTDI.Size = new System.Drawing.Size(43, 17);
            this.rdTDI.TabIndex = 18;
            this.rdTDI.TabStop = true;
            this.rdTDI.Text = "TDI";
            this.rdTDI.UseVisualStyleBackColor = true;
            this.rdTDI.CheckedChanged += new System.EventHandler(this.rdTDI_CheckedChanged);
            // 
            // rdTRI
            // 
            this.rdTRI.AutoSize = true;
            this.rdTRI.Location = new System.Drawing.Point(417, 94);
            this.rdTRI.Name = "rdTRI";
            this.rdTRI.Size = new System.Drawing.Size(43, 17);
            this.rdTRI.TabIndex = 19;
            this.rdTRI.TabStop = true;
            this.rdTRI.Text = "TRI";
            this.rdTRI.UseVisualStyleBackColor = true;
            this.rdTRI.CheckedChanged += new System.EventHandler(this.rdTRI_CheckedChanged);
            // 
            // btSup
            // 
            this.btSup.Location = new System.Drawing.Point(325, 177);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(75, 23);
            this.btSup.TabIndex = 20;
            this.btSup.Text = "Supprimer";
            this.btSup.UseVisualStyleBackColor = true;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.rdTRI);
            this.Controls.Add(this.rdTDI);
            this.Controls.Add(this.rdTout);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.grdEtudient);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEtudient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEtudient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.RadioButton rdTout;
        private System.Windows.Forms.RadioButton rdTDI;
        private System.Windows.Forms.RadioButton rdTRI;
        private System.Windows.Forms.Button btSup;
    }
}