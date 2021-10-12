
namespace ProgettoPMO
{
    partial class Lista
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
            this.label_nomeutente = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Titolo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textbox_ricerca = new System.Windows.Forms.TextBox();
            this.btn_ricerca = new System.Windows.Forms.Button();
            this.btn_areapersonale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nomeutente
            // 
            this.label_nomeutente.AutoSize = true;
            this.label_nomeutente.Location = new System.Drawing.Point(38, 186);
            this.label_nomeutente.Name = "label_nomeutente";
            this.label_nomeutente.Size = new System.Drawing.Size(0, 17);
            this.label_nomeutente.TabIndex = 2;
            this.label_nomeutente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titolo,
            this.Autore,
            this.Genere});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(148, 206);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 272);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Titolo
            // 
            this.Titolo.Text = "Titolo";
            this.Titolo.Width = 263;
            // 
            // Autore
            // 
            this.Autore.Text = "Autore";
            this.Autore.Width = 204;
            // 
            // Genere
            // 
            this.Genere.Text = "Genere";
            this.Genere.Width = 769;
            // 
            // textbox_ricerca
            // 
            this.textbox_ricerca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_ricerca.Location = new System.Drawing.Point(432, 494);
            this.textbox_ricerca.Multiline = true;
            this.textbox_ricerca.Name = "textbox_ricerca";
            this.textbox_ricerca.Size = new System.Drawing.Size(480, 26);
            this.textbox_ricerca.TabIndex = 4;
            this.textbox_ricerca.TextChanged += new System.EventHandler(this.textbox_ricerca_TextChanged);
            // 
            // btn_ricerca
            // 
            this.btn_ricerca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ricerca.Location = new System.Drawing.Point(208, 484);
            this.btn_ricerca.Name = "btn_ricerca";
            this.btn_ricerca.Size = new System.Drawing.Size(192, 42);
            this.btn_ricerca.TabIndex = 5;
            this.btn_ricerca.Text = "Ricerca";
            this.btn_ricerca.UseVisualStyleBackColor = true;
            this.btn_ricerca.Click += new System.EventHandler(this.btn_ricerca_Click);
            // 
            // btn_areapersonale
            // 
            this.btn_areapersonale.Location = new System.Drawing.Point(232, 33);
            this.btn_areapersonale.Name = "btn_areapersonale";
            this.btn_areapersonale.Size = new System.Drawing.Size(103, 46);
            this.btn_areapersonale.TabIndex = 7;
            this.btn_areapersonale.Text = "Area Personale";
            this.btn_areapersonale.UseVisualStyleBackColor = true;
            this.btn_areapersonale.Click += new System.EventHandler(this.btn_areapersonale_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dati profilo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Scelti Per Te";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista dei Libri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_areapersonale);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 120);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProgettoPMO.Properties.Resources.logout1;
            this.pictureBox2.Location = new System.Drawing.Point(860, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1113, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ricerca);
            this.Controls.Add(this.textbox_ricerca);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nomeutente);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nomeutente;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textbox_ricerca;
        private System.Windows.Forms.Button btn_ricerca;
        private System.Windows.Forms.ColumnHeader Titolo;
        private System.Windows.Forms.ColumnHeader Autore;
        private System.Windows.Forms.Button btn_areapersonale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Genere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}