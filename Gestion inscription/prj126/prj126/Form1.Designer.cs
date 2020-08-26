namespace prj126
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtIde = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbBac = new System.Windows.Forms.ComboBox();
            this.cmbSec = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btFermer = new System.Windows.Forms.Button();
            this.grdEtudient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTDI = new System.Windows.Forms.Label();
            this.prgTDI = new System.Windows.Forms.ProgressBar();
            this.lblTRI = new System.Windows.Forms.Label();
            this.prgTRI = new System.Windows.Forms.ProgressBar();
            this.btOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEtudient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ide :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bac :";
            // 
            // txtIde
            // 
            this.txtIde.Location = new System.Drawing.Point(124, 42);
            this.txtIde.Name = "txtIde";
            this.txtIde.Size = new System.Drawing.Size(100, 20);
            this.txtIde.TabIndex = 4;
            this.txtIde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIde_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(124, 81);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(123, 20);
            this.txtNom.TabIndex = 5;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // cmbBac
            // 
            this.cmbBac.FormattingEnabled = true;
            this.cmbBac.Location = new System.Drawing.Point(124, 161);
            this.cmbBac.Name = "cmbBac";
            this.cmbBac.Size = new System.Drawing.Size(100, 21);
            this.cmbBac.TabIndex = 6;
            // 
            // cmbSec
            // 
            this.cmbSec.FormattingEnabled = true;
            this.cmbSec.Location = new System.Drawing.Point(124, 203);
            this.cmbSec.Name = "cmbSec";
            this.cmbSec.Size = new System.Drawing.Size(100, 21);
            this.cmbSec.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sec :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Note :";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(124, 248);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(58, 20);
            this.txtNote.TabIndex = 11;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(172, 289);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(105, 23);
            this.btAjouter.TabIndex = 12;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(172, 319);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(105, 23);
            this.btFermer.TabIndex = 13;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
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
            this.grdEtudient.Location = new System.Drawing.Point(285, 42);
            this.grdEtudient.Name = "grdEtudient";
            this.grdEtudient.Size = new System.Drawing.Size(395, 150);
            this.grdEtudient.TabIndex = 14;
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
            // lbTDI
            // 
            this.lbTDI.AutoSize = true;
            this.lbTDI.Location = new System.Drawing.Point(701, 81);
            this.lbTDI.Name = "lbTDI";
            this.lbTDI.Size = new System.Drawing.Size(31, 13);
            this.lbTDI.TabIndex = 15;
            this.lbTDI.Text = "TDI :";
            // 
            // prgTDI
            // 
            this.prgTDI.Location = new System.Drawing.Point(704, 97);
            this.prgTDI.Name = "prgTDI";
            this.prgTDI.Size = new System.Drawing.Size(100, 23);
            this.prgTDI.TabIndex = 16;
            // 
            // lblTRI
            // 
            this.lblTRI.AutoSize = true;
            this.lblTRI.Location = new System.Drawing.Point(701, 144);
            this.lblTRI.Name = "lblTRI";
            this.lblTRI.Size = new System.Drawing.Size(31, 13);
            this.lblTRI.TabIndex = 17;
            this.lblTRI.Text = "TRI :";
            // 
            // prgTRI
            // 
            this.prgTRI.Location = new System.Drawing.Point(704, 161);
            this.prgTRI.Name = "prgTRI";
            this.prgTRI.Size = new System.Drawing.Size(100, 23);
            this.prgTRI.TabIndex = 18;
            // 
            // btOperation
            // 
            this.btOperation.Location = new System.Drawing.Point(592, 211);
            this.btOperation.Name = "btOperation";
            this.btOperation.Size = new System.Drawing.Size(75, 23);
            this.btOperation.TabIndex = 19;
            this.btOperation.Text = "Operation";
            this.btOperation.UseVisualStyleBackColor = true;
            this.btOperation.Click += new System.EventHandler(this.btOperation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 354);
            this.Controls.Add(this.btOperation);
            this.Controls.Add(this.prgTRI);
            this.Controls.Add(this.lblTRI);
            this.Controls.Add(this.prgTDI);
            this.Controls.Add(this.lbTDI);
            this.Controls.Add(this.grdEtudient);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbSec);
            this.Controls.Add(this.cmbBac);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtIde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEtudient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIde;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbBac;
        private System.Windows.Forms.ComboBox cmbSec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.DataGridView grdEtudient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lbTDI;
        private System.Windows.Forms.ProgressBar prgTDI;
        private System.Windows.Forms.Label lblTRI;
        private System.Windows.Forms.ProgressBar prgTRI;
        private System.Windows.Forms.Button btOperation;
    }
}

