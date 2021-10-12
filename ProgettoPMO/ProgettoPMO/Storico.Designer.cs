
namespace ProgettoPMO
{
    partial class Storico
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.titolo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inizioprestito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.riconsegna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titolo,
            this.inizioprestito,
            this.riconsegna});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 348);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // titolo
            // 
            this.titolo.Text = "Titolo";
            this.titolo.Width = 200;
            // 
            // inizioprestito
            // 
            this.inizioprestito.Text = "Data Inizio Prestito";
            this.inizioprestito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inizioprestito.Width = 148;
            // 
            // riconsegna
            // 
            this.riconsegna.Text = "Riconsegnato il";
            this.riconsegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.riconsegna.Width = 148;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgettoPMO.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(348, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Storico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(824, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Storico";
            this.Text = "Storico";
            this.Load += new System.EventHandler(this.Storico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader titolo;
        private System.Windows.Forms.ColumnHeader inizioprestito;
        private System.Windows.Forms.ColumnHeader riconsegna;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}