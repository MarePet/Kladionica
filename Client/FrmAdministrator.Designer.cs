namespace Client
{
    partial class FrmAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiketiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUlogovaniAdministrator = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.utakmiceToolStripMenuItem,
            this.tiketiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.korisniciToolStripMenuItem.Text = "Vidi korisnike";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // utakmiceToolStripMenuItem
            // 
            this.utakmiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.utakmiceToolStripMenuItem.Name = "utakmiceToolStripMenuItem";
            this.utakmiceToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.utakmiceToolStripMenuItem.Text = "Unesi utakmice";
            this.utakmiceToolStripMenuItem.Click += new System.EventHandler(this.utakmiceToolStripMenuItem_Click);
            // 
            // tiketiToolStripMenuItem
            // 
            this.tiketiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tiketiToolStripMenuItem.Name = "tiketiToolStripMenuItem";
            this.tiketiToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.tiketiToolStripMenuItem.Text = "Upravljaj utakmicama";
            this.tiketiToolStripMenuItem.Click += new System.EventHandler(this.tiketiToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblUlogovaniAdministrator
            // 
            this.lblUlogovaniAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUlogovaniAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.lblUlogovaniAdministrator.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlogovaniAdministrator.ForeColor = System.Drawing.Color.White;
            this.lblUlogovaniAdministrator.Location = new System.Drawing.Point(184, 168);
            this.lblUlogovaniAdministrator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUlogovaniAdministrator.Name = "lblUlogovaniAdministrator";
            this.lblUlogovaniAdministrator.Size = new System.Drawing.Size(95, 25);
            this.lblUlogovaniAdministrator.TabIndex = 26;
            this.lblUlogovaniAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Client.Properties.Resources.photo___frmAdmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUlogovaniAdministrator);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket - [Administrator]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utakmiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiketiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUlogovaniAdministrator;
    }
}