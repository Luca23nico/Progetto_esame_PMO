
namespace ProgettoPMO
{
    partial class AreaPersonale
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_storico = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Titolo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataprestito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datarestituzione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_storico);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 455);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(182, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 67);
            this.label1.TabIndex = 15;
            this.label1.Text = "Libri Attualmente in Prestito";
            // 
            // btn_storico
            // 
            this.btn_storico.Location = new System.Drawing.Point(389, 334);
            this.btn_storico.Name = "btn_storico";
            this.btn_storico.Size = new System.Drawing.Size(159, 41);
            this.btn_storico.TabIndex = 12;
            this.btn_storico.Text = "Storico prestiti";
            this.btn_storico.UseVisualStyleBackColor = true;
            this.btn_storico.Click += new System.EventHandler(this.btn_storico_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titolo,
            this.dataprestito,
            this.datarestituzione});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(852, 250);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Titolo
            // 
            this.Titolo.Text = "Titolo";
            this.Titolo.Width = 274;
            // 
            // dataprestito
            // 
            this.dataprestito.Text = "Data inizio Prestito";
            this.dataprestito.Width = 226;
            // 
            // datarestituzione
            // 
            this.datarestituzione.Text = "Data fine prestito";
            this.datarestituzione.Width = 236;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgettoPMO.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(419, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AreaPersonale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(935, 479);
            this.Controls.Add(this.panel2);
            this.Name = "AreaPersonale";
            this.Text = "AreaPersonale";
            this.Load += new System.EventHandler(this.AreaPersonale_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_storico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Titolo;
        private System.Windows.Forms.ColumnHeader dataprestito;
        private System.Windows.Forms.ColumnHeader datarestituzione;
    }
}