namespace Client
{
    partial class FrmKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKorisnik));
            this.btnIzmeniNalog = new System.Windows.Forms.Button();
            this.lblUlogovaniKorisnik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kreirajTiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajSvojeTiketeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKomponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmeniNalog
            // 
            this.btnIzmeniNalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniNalog.BackColor = System.Drawing.Color.White;
            this.btnIzmeniNalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmeniNalog.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzmeniNalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzmeniNalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniNalog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzmeniNalog.Location = new System.Drawing.Point(176, 188);
            this.btnIzmeniNalog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIzmeniNalog.Name = "btnIzmeniNalog";
            this.btnIzmeniNalog.Size = new System.Drawing.Size(149, 37);
            this.btnIzmeniNalog.TabIndex = 0;
            this.btnIzmeniNalog.Text = "Podešavanja naloga";
            this.btnIzmeniNalog.UseVisualStyleBackColor = false;
            this.btnIzmeniNalog.Click += new System.EventHandler(this.btnIzmeniNalog_Click);
            // 
            // lblUlogovaniKorisnik
            // 
            this.lblUlogovaniKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.lblUlogovaniKorisnik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlogovaniKorisnik.ForeColor = System.Drawing.Color.White;
            this.lblUlogovaniKorisnik.Location = new System.Drawing.Point(128, 159);
            this.lblUlogovaniKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUlogovaniKorisnik.Name = "lblUlogovaniKorisnik";
            this.lblUlogovaniKorisnik.Size = new System.Drawing.Size(250, 21);
            this.lblUlogovaniKorisnik.TabIndex = 2;
            this.lblUlogovaniKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajTiketToolStripMenuItem,
            this.pogledajSvojeTiketeToolStripMenuItem,
            this.dodajKomponenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kreirajTiketToolStripMenuItem
            // 
            this.kreirajTiketToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kreirajTiketToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kreirajTiketToolStripMenuItem.Name = "kreirajTiketToolStripMenuItem";
            this.kreirajTiketToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.kreirajTiketToolStripMenuItem.Text = "Kreiraj tiket";
            this.kreirajTiketToolStripMenuItem.Click += new System.EventHandler(this.kreirajTiketToolStripMenuItem_Click);
            // 
            // pogledajSvojeTiketeToolStripMenuItem
            // 
            this.pogledajSvojeTiketeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pogledajSvojeTiketeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pogledajSvojeTiketeToolStripMenuItem.Name = "pogledajSvojeTiketeToolStripMenuItem";
            this.pogledajSvojeTiketeToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.pogledajSvojeTiketeToolStripMenuItem.Text = "Pogledaj svoje tikete";
            this.pogledajSvojeTiketeToolStripMenuItem.Click += new System.EventHandler(this.pogledajSvojeTiketeToolStripMenuItem_Click);
            // 
            // dodajKomponenteToolStripMenuItem
            // 
            this.dodajKomponenteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dodajKomponenteToolStripMenuItem.Name = "dodajKomponenteToolStripMenuItem";
            this.dodajKomponenteToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.dodajKomponenteToolStripMenuItem.Text = "Dodaj komponente";
            this.dodajKomponenteToolStripMenuItem.Click += new System.EventHandler(this.dodajKomponenteToolStripMenuItem_Click);
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.BackgroundImage = global::Client.Properties.Resources.photo___frmAdmin;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.lblUlogovaniKorisnik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzmeniNalog);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket - [Korisnik]";
            this.Load += new System.EventHandler(this.FrmKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeniNalog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUlogovaniKorisnik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kreirajTiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pogledajSvojeTiketeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKomponenteToolStripMenuItem;
    }
}