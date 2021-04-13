namespace Chess
{
    partial class joc
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
            this.Joaca = new System.Windows.Forms.Button();
            this.Sfarsit = new System.Windows.Forms.Button();
            this.tabel = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewImageColumn();
            this.b = new System.Windows.Forms.DataGridViewImageColumn();
            this.c = new System.Windows.Forms.DataGridViewImageColumn();
            this.d = new System.Windows.Forms.DataGridViewImageColumn();
            this.e = new System.Windows.Forms.DataGridViewImageColumn();
            this.f = new System.Windows.Forms.DataGridViewImageColumn();
            this.g = new System.Windows.Forms.DataGridViewImageColumn();
            this.h = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // Joaca
            // 
            this.Joaca.BackColor = System.Drawing.Color.Aqua;
            this.Joaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Joaca.Location = new System.Drawing.Point(1168, 129);
            this.Joaca.Name = "Joaca";
            this.Joaca.Size = new System.Drawing.Size(182, 71);
            this.Joaca.TabIndex = 0;
            this.Joaca.Text = "Joaca\r\n";
            this.Joaca.UseVisualStyleBackColor = false;
            this.Joaca.Click += new System.EventHandler(this.Joaca_Click);
            // 
            // Sfarsit
            // 
            this.Sfarsit.BackColor = System.Drawing.Color.Aqua;
            this.Sfarsit.Location = new System.Drawing.Point(1168, 335);
            this.Sfarsit.Name = "Sfarsit";
            this.Sfarsit.Size = new System.Drawing.Size(174, 77);
            this.Sfarsit.TabIndex = 2;
            this.Sfarsit.Text = "Sfarsit";
            this.Sfarsit.UseVisualStyleBackColor = false;
            this.Sfarsit.Click += new System.EventHandler(this.Sfarsit_Click);
            // 
            // tabel
            // 
            this.tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c,
            this.d,
            this.e,
            this.f,
            this.g,
            this.h});
            this.tabel.Location = new System.Drawing.Point(34, 49);
            this.tabel.Name = "tabel";
            this.tabel.RowTemplate.Height = 24;
            this.tabel.Size = new System.Drawing.Size(1117, 648);
            this.tabel.TabIndex = 3;
            this.tabel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_CellClick);
            this.tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_CellContentClick);
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            // 
            // c
            // 
            this.c.HeaderText = "c";
            this.c.Name = "c";
            // 
            // d
            // 
            this.d.HeaderText = "d";
            this.d.Name = "d";
            // 
            // e
            // 
            this.e.HeaderText = "e";
            this.e.Name = "e";
            // 
            // f
            // 
            this.f.HeaderText = "f";
            this.f.Name = "f";
            // 
            // g
            // 
            this.g.HeaderText = "g";
            this.g.Name = "g";
            // 
            // h
            // 
            this.h.HeaderText = "h";
            this.h.Name = "h";
            // 
            // joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1362, 643);
            this.Controls.Add(this.tabel);
            this.Controls.Add(this.Sfarsit);
            this.Controls.Add(this.Joaca);
            this.DoubleBuffered = true;
            this.Name = "joc";
            this.Text = "joc";
            this.Load += new System.EventHandler(this.joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Joaca;
        private System.Windows.Forms.Button Sfarsit;
        private System.Windows.Forms.DataGridView tabel;
        private System.Windows.Forms.DataGridViewImageColumn a;
        private System.Windows.Forms.DataGridViewImageColumn b;
        private System.Windows.Forms.DataGridViewImageColumn c;
        private System.Windows.Forms.DataGridViewImageColumn d;
        private System.Windows.Forms.DataGridViewImageColumn e;
        private System.Windows.Forms.DataGridViewImageColumn f;
        private System.Windows.Forms.DataGridViewImageColumn g;
        private System.Windows.Forms.DataGridViewImageColumn h;
    }
}