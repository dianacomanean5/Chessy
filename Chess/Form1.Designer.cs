namespace Chess
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
            this.Istoric = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Istoric
            // 
            this.Istoric.BackColor = System.Drawing.Color.Turquoise;
            this.Istoric.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Istoric.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Istoric.Location = new System.Drawing.Point(448, 397);
            this.Istoric.Name = "Istoric";
            this.Istoric.Size = new System.Drawing.Size(228, 102);
            this.Istoric.TabIndex = 0;
            this.Istoric.Text = "Istoric/Reguli";
            this.Istoric.UseVisualStyleBackColor = false;
            this.Istoric.Click += new System.EventHandler(this.Istoric_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Turquoise;
            this.Start.Font = new System.Drawing.Font("Segoe MDL2 Assets", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(404, 275);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(322, 76);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chess.Properties.Resources.Picture11;
            this.pictureBox1.Location = new System.Drawing.Point(35, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.Chess1;
            this.ClientSize = new System.Drawing.Size(1208, 758);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Istoric);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Chess Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Istoric;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

