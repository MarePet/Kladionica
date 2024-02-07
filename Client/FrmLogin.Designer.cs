namespace Client
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.rbKorisnik = new System.Windows.Forms.RadioButton();
            this.rbAdministrator = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(417, 135);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(171, 27);
            this.txtKorisnickoIme.TabIndex = 0;
            this.txtKorisnickoIme.Text = "marko";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka.Location = new System.Drawing.Point(417, 177);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(171, 27);
            this.txtLozinka.TabIndex = 1;
            this.txtLozinka.Text = "marko1";
            // 
            // rbKorisnik
            // 
            this.rbKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbKorisnik.AutoSize = true;
            this.rbKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.rbKorisnik.ForeColor = System.Drawing.Color.White;
            this.rbKorisnik.Location = new System.Drawing.Point(417, 226);
            this.rbKorisnik.Name = "rbKorisnik";
            this.rbKorisnik.Size = new System.Drawing.Size(82, 24);
            this.rbKorisnik.TabIndex = 2;
            this.rbKorisnik.TabStop = true;
            this.rbKorisnik.Text = "Korisnik";
            this.rbKorisnik.UseVisualStyleBackColor = false;
            // 
            // rbAdministrator
            // 
            this.rbAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAdministrator.AutoSize = true;
            this.rbAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.rbAdministrator.ForeColor = System.Drawing.Color.White;
            this.rbAdministrator.Location = new System.Drawing.Point(490, 226);
            this.rbAdministrator.Name = "rbAdministrator";
            this.rbAdministrator.Size = new System.Drawing.Size(121, 24);
            this.rbAdministrator.TabIndex = 3;
            this.rbAdministrator.TabStop = true;
            this.rbAdministrator.Text = "Administrator";
            this.rbAdministrator.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lozinka:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(414, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nemaš nalog? Napravi ga lako:";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijaviSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(69)))));
            this.btnPrijaviSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijaviSe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnPrijaviSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.Location = new System.Drawing.Point(417, 258);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(171, 36);
            this.btnPrijaviSe.TabIndex = 7;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrujSe.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrujSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrujSe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnRegistrujSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnRegistrujSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrujSe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrujSe.ForeColor = System.Drawing.Color.White;
            this.btnRegistrujSe.Location = new System.Drawing.Point(417, 347);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(171, 27);
            this.btnRegistrujSe.TabIndex = 8;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = false;
            this.btnRegistrujSe.Click += new System.EventHandler(this.btnRegistrujSe_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ti si:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrujSe);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAdministrator);
            this.Controls.Add(this.rbKorisnik);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket - Prijava na aplikaciju";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.RadioButton rbKorisnik;
        private System.Windows.Forms.RadioButton rbAdministrator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.Label label4;
    }
}