namespace Client.FormeKorisnik
{
    partial class FrmKreirajTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreirajTiket));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStavkeTiketa = new System.Windows.Forms.DataGridView();
            this.txtUplata = new System.Windows.Forms.TextBox();
            this.txtDatumUplate = new System.Windows.Forms.TextBox();
            this.txtPotencijalnaIsplata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKreirajTiket = new System.Windows.Forms.Button();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKvota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOsveži = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeTiketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uplata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum uplate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista stavki tiketa:";
            // 
            // dgvStavkeTiketa
            // 
            this.dgvStavkeTiketa.AllowUserToAddRows = false;
            this.dgvStavkeTiketa.AllowUserToDeleteRows = false;
            this.dgvStavkeTiketa.BackgroundColor = System.Drawing.Color.White;
            this.dgvStavkeTiketa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeTiketa.Location = new System.Drawing.Point(54, 184);
            this.dgvStavkeTiketa.Name = "dgvStavkeTiketa";
            this.dgvStavkeTiketa.ReadOnly = true;
            this.dgvStavkeTiketa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeTiketa.Size = new System.Drawing.Size(320, 140);
            this.dgvStavkeTiketa.TabIndex = 9;
            this.dgvStavkeTiketa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavkeTiketa_CellContentClick);
            // 
            // txtUplata
            // 
            this.txtUplata.Location = new System.Drawing.Point(171, 76);
            this.txtUplata.Name = "txtUplata";
            this.txtUplata.Size = new System.Drawing.Size(116, 23);
            this.txtUplata.TabIndex = 11;
            this.txtUplata.TextChanged += new System.EventHandler(this.txtUplata_TextChanged);
            this.txtUplata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUplata_KeyPress);
            // 
            // txtDatumUplate
            // 
            this.txtDatumUplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatumUplate.Enabled = false;
            this.txtDatumUplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumUplate.Location = new System.Drawing.Point(171, 117);
            this.txtDatumUplate.Name = "txtDatumUplate";
            this.txtDatumUplate.ReadOnly = true;
            this.txtDatumUplate.Size = new System.Drawing.Size(116, 23);
            this.txtDatumUplate.TabIndex = 12;
            // 
            // txtPotencijalnaIsplata
            // 
            this.txtPotencijalnaIsplata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPotencijalnaIsplata.Enabled = false;
            this.txtPotencijalnaIsplata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotencijalnaIsplata.Location = new System.Drawing.Point(171, 419);
            this.txtPotencijalnaIsplata.Name = "txtPotencijalnaIsplata";
            this.txtPotencijalnaIsplata.ReadOnly = true;
            this.txtPotencijalnaIsplata.Size = new System.Drawing.Size(116, 23);
            this.txtPotencijalnaIsplata.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Potencijalna isplata:";
            // 
            // btnKreirajTiket
            // 
            this.btnKreirajTiket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(69)))));
            this.btnKreirajTiket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKreirajTiket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnKreirajTiket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.btnKreirajTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajTiket.Location = new System.Drawing.Point(54, 466);
            this.btnKreirajTiket.Name = "btnKreirajTiket";
            this.btnKreirajTiket.Size = new System.Drawing.Size(320, 36);
            this.btnKreirajTiket.TabIndex = 15;
            this.btnKreirajTiket.Text = "Kreiraj tiket";
            this.btnKreirajTiket.UseVisualStyleBackColor = false;
            this.btnKreirajTiket.Click += new System.EventHandler(this.btnKreirajTiket_Click);
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.BackgroundColor = System.Drawing.Color.White;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Location = new System.Drawing.Point(392, 184);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.Size = new System.Drawing.Size(550, 258);
            this.dgvUtakmice.TabIndex = 17;
            this.dgvUtakmice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtakmice_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(388, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lista utakmica (Odaberite kvotu):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kreiraj svoj tiket:";
            // 
            // txtKvota
            // 
            this.txtKvota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKvota.Enabled = false;
            this.txtKvota.Location = new System.Drawing.Point(171, 378);
            this.txtKvota.Name = "txtKvota";
            this.txtKvota.ReadOnly = true;
            this.txtKvota.Size = new System.Drawing.Size(116, 23);
            this.txtKvota.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(77, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ukupna kvota:";
            // 
            // btnOsveži
            // 
            this.btnOsveži.BackColor = System.Drawing.Color.White;
            this.btnOsveži.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsveži.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnOsveži.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOsveži.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsveži.Image = ((System.Drawing.Image)(resources.GetObject("btnOsveži.Image")));
            this.btnOsveži.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsveži.Location = new System.Drawing.Point(868, 149);
            this.btnOsveži.Name = "btnOsveži";
            this.btnOsveži.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnOsveži.Size = new System.Drawing.Size(74, 28);
            this.btnOsveži.TabIndex = 23;
            this.btnOsveži.Text = "Osveži";
            this.btnOsveži.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsveži.UseVisualStyleBackColor = false;
            this.btnOsveži.Click += new System.EventHandler(this.btnOsveži_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.BackColor = System.Drawing.Color.White;
            this.btnObrisiStavku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiStavku.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisiStavku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiStavku.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiStavku.Image")));
            this.btnObrisiStavku.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiStavku.Location = new System.Drawing.Point(261, 330);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnObrisiStavku.Size = new System.Drawing.Size(113, 28);
            this.btnObrisiStavku.TabIndex = 19;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // FrmKreirajTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(972, 531);
            this.Controls.Add(this.btnOsveži);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKvota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.dgvUtakmice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKreirajTiket);
            this.Controls.Add(this.txtPotencijalnaIsplata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatumUplate);
            this.Controls.Add(this.txtUplata);
            this.Controls.Add(this.dgvStavkeTiketa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmKreirajTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket - Kreiranje tiketa";
            this.Load += new System.EventHandler(this.FrmKreirajTiket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeTiketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStavkeTiketa;
        private System.Windows.Forms.TextBox txtUplata;
        private System.Windows.Forms.TextBox txtDatumUplate;
        private System.Windows.Forms.TextBox txtPotencijalnaIsplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKreirajTiket;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKvota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOsveži;
    }
}