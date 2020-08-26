namespace projetpharmcie2
{
    partial class Form3
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
            this.dtgclients = new System.Windows.Forms.DataGridView();
            this.refferance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgclients)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgclients
            // 
            this.dtgclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgclients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refferance,
            this.Prix,
            this.Qte,
            this.Ordo,
            this.Genre,
            this.Type});
            this.dtgclients.Location = new System.Drawing.Point(12, 29);
            this.dtgclients.Name = "dtgclients";
            this.dtgclients.Size = new System.Drawing.Size(643, 150);
            this.dtgclients.TabIndex = 0;
            this.dtgclients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgclients_CellContentClick);
            // 
            // refferance
            // 
            this.refferance.HeaderText = "refferance";
            this.refferance.Name = "refferance";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Qte
            // 
            this.Qte.HeaderText = "Qte";
            this.Qte.Name = "Qte";
            // 
            // Ordo
            // 
            this.Ordo.HeaderText = "Ordo";
            this.Ordo.Name = "Ordo";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour au menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetpharmcie2.Properties.Resources.modèle_sans_couture_de_pharmacie_en_vert_47122268;
            this.ClientSize = new System.Drawing.Size(799, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgclients);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgclients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgclients;
        private System.Windows.Forms.DataGridViewTextBoxColumn refferance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button button1;
    }
}