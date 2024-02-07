namespace Client.FormeAdministrator
{
    partial class FrmIzmeniUtakmice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzmeniUtakmice));
            this.label5 = new System.Windows.Forms.Label();
            this.cbUtakmice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRezultat = new System.Windows.Forms.ComboBox();
            this.btnIzmeniRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Izaberite utakmicu:";
            // 
            // cbUtakmice
            // 
            this.cbUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUtakmice.FormattingEnabled = true;
            this.cbUtakmice.Location = new System.Drawing.Point(166, 47);
            this.cbUtakmice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUtakmice.Name = "cbUtakmice";
            this.cbUtakmice.Size = new System.Drawing.Size(192, 23);
            this.cbUtakmice.TabIndex = 33;
            this.cbUtakmice.Text = "Izaberi utakmicu...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rezultat utakmice:";
            // 
            // cbRezultat
            // 
            this.cbRezultat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRezultat.FormattingEnabled = true;
            this.cbRezultat.Location = new System.Drawing.Point(166, 107);
            this.cbRezultat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRezultat.Name = "cbRezultat";
            this.cbRezultat.Size = new System.Drawing.Size(192, 23);
            this.cbRezultat.TabIndex = 36;
            this.cbRezultat.Text = "Izaberi rezultat...";
            // 
            // btnIzmeniRezultat
            // 
            this.btnIzmeniRezultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(69)))));
            this.btnIzmeniRezultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmeniRezultat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnIzmeniRezultat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnIzmeniRezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniRezultat.Location = new System.Drawing.Point(46, 182);
            this.btnIzmeniRezultat.Name = "btnIzmeniRezultat";
            this.btnIzmeniRezultat.Size = new System.Drawing.Size(312, 33);
            this.btnIzmeniRezultat.TabIndex = 37;
            this.btnIzmeniRezultat.Text = "Postavi rezultat utakmice";
            this.btnIzmeniRezultat.UseVisualStyleBackColor = false;
            this.btnIzmeniRezultat.Click += new System.EventHandler(this.btnIzmeniRezultat_Click);
            // 
            // FrmIzmeniUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(421, 281);
            this.Controls.Add(this.btnIzmeniRezultat);
            this.Controls.Add(this.cbRezultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbUtakmice);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmIzmeniUtakmice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket - Dodaj rezultat utakmice";
            this.Load += new System.EventHandler(this.FrmIzmeniUtakmice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUtakmice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRezultat;
        private System.Windows.Forms.Button btnIzmeniRezultat;
    }
}