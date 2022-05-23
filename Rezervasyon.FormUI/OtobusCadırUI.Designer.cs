
namespace Rezervasyon.FormUI
{
    partial class OtobusCadırUI
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
            this.dgwGoruntule = new System.Windows.Forms.DataGridView();
            this.gbxRezervayonEkle = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRezervasyonİptal = new System.Windows.Forms.Button();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.txtNereye = new System.Windows.Forms.TextBox();
            this.txtBiletSayisi = new System.Windows.Forms.TextBox();
            this.txtNereden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBilet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGoruntule)).BeginInit();
            this.gbxRezervayonEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwGoruntule
            // 
            this.dgwGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGoruntule.Location = new System.Drawing.Point(4, 378);
            this.dgwGoruntule.Name = "dgwGoruntule";
            this.dgwGoruntule.RowHeadersWidth = 51;
            this.dgwGoruntule.RowTemplate.Height = 24;
            this.dgwGoruntule.Size = new System.Drawing.Size(801, 260);
            this.dgwGoruntule.TabIndex = 4;
            // 
            // gbxRezervayonEkle
            // 
            this.gbxRezervayonEkle.Controls.Add(this.txtFiyat);
            this.gbxRezervayonEkle.Controls.Add(this.label5);
            this.gbxRezervayonEkle.Controls.Add(this.btnRezervasyonİptal);
            this.gbxRezervayonEkle.Controls.Add(this.dateCikis);
            this.gbxRezervayonEkle.Controls.Add(this.dateGiris);
            this.gbxRezervayonEkle.Controls.Add(this.btnRezervasyon);
            this.gbxRezervayonEkle.Controls.Add(this.txtNereye);
            this.gbxRezervayonEkle.Controls.Add(this.txtBiletSayisi);
            this.gbxRezervayonEkle.Controls.Add(this.txtNereden);
            this.gbxRezervayonEkle.Controls.Add(this.label1);
            this.gbxRezervayonEkle.Controls.Add(this.label2);
            this.gbxRezervayonEkle.Controls.Add(this.label3);
            this.gbxRezervayonEkle.Controls.Add(this.lblBilet);
            this.gbxRezervayonEkle.Controls.Add(this.label4);
            this.gbxRezervayonEkle.Controls.Add(this.txtEmail);
            this.gbxRezervayonEkle.Controls.Add(this.txtSoyad);
            this.gbxRezervayonEkle.Controls.Add(this.txtAd);
            this.gbxRezervayonEkle.Controls.Add(this.lblEmail);
            this.gbxRezervayonEkle.Controls.Add(this.lblSoyad);
            this.gbxRezervayonEkle.Controls.Add(this.lblAd);
            this.gbxRezervayonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRezervayonEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxRezervayonEkle.Location = new System.Drawing.Point(4, 12);
            this.gbxRezervayonEkle.Name = "gbxRezervayonEkle";
            this.gbxRezervayonEkle.Size = new System.Drawing.Size(793, 360);
            this.gbxRezervayonEkle.TabIndex = 3;
            this.gbxRezervayonEkle.TabStop = false;
            this.gbxRezervayonEkle.Text = "Otobüs-Çadır";
            this.gbxRezervayonEkle.Enter += new System.EventHandler(this.gbxRezervayonEkle_Enter);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(150, 241);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(191, 30);
            this.txtFiyat.TabIndex = 38;
            this.txtFiyat.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Fiyat:";
            // 
            // btnRezervasyonİptal
            // 
            this.btnRezervasyonİptal.BackColor = System.Drawing.Color.Red;
            this.btnRezervasyonİptal.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonİptal.Location = new System.Drawing.Point(542, 301);
            this.btnRezervasyonİptal.Name = "btnRezervasyonİptal";
            this.btnRezervasyonİptal.Size = new System.Drawing.Size(208, 53);
            this.btnRezervasyonİptal.TabIndex = 36;
            this.btnRezervasyonİptal.Text = "Rezervasyon İptal";
            this.btnRezervasyonİptal.UseVisualStyleBackColor = false;
            this.btnRezervasyonİptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateCikis
            // 
            this.dateCikis.Location = new System.Drawing.Point(542, 189);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(200, 30);
            this.dateCikis.TabIndex = 35;
            // 
            // dateGiris
            // 
            this.dateGiris.Location = new System.Drawing.Point(150, 189);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(191, 30);
            this.dateGiris.TabIndex = 34;
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRezervasyon.Location = new System.Drawing.Point(150, 301);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(191, 53);
            this.btnRezervasyon.TabIndex = 10;
            this.btnRezervasyon.Text = "Rezervasyon Yap";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // txtNereye
            // 
            this.txtNereye.Location = new System.Drawing.Point(542, 143);
            this.txtNereye.Name = "txtNereye";
            this.txtNereye.Size = new System.Drawing.Size(200, 30);
            this.txtNereye.TabIndex = 33;
            // 
            // txtBiletSayisi
            // 
            this.txtBiletSayisi.Enabled = false;
            this.txtBiletSayisi.Location = new System.Drawing.Point(542, 95);
            this.txtBiletSayisi.Name = "txtBiletSayisi";
            this.txtBiletSayisi.Size = new System.Drawing.Size(200, 30);
            this.txtBiletSayisi.TabIndex = 26;
            this.txtBiletSayisi.Text = "1";
            // 
            // txtNereden
            // 
            this.txtNereden.Location = new System.Drawing.Point(150, 140);
            this.txtNereden.Name = "txtNereden";
            this.txtNereden.Size = new System.Drawing.Size(191, 30);
            this.txtNereden.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(453, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Çıkış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Giriş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(433, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nereye:";
            // 
            // lblBilet
            // 
            this.lblBilet.AutoSize = true;
            this.lblBilet.Location = new System.Drawing.Point(401, 98);
            this.lblBilet.Name = "lblBilet";
            this.lblBilet.Size = new System.Drawing.Size(113, 25);
            this.lblBilet.TabIndex = 23;
            this.lblBilet.Text = "Bilet Sayisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nereden:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 30);
            this.txtEmail.TabIndex = 27;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(542, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 30);
            this.txtSoyad.TabIndex = 25;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(150, 49);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(191, 30);
            this.txtAd.TabIndex = 24;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(46, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 25);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(435, 49);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblSoyad.TabIndex = 21;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(77, 52);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 25);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Ad:";
            // 
            // OtobusCadırUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(804, 642);
            this.Controls.Add(this.dgwGoruntule);
            this.Controls.Add(this.gbxRezervayonEkle);
            this.Name = "OtobusCadırUI";
            this.Text = "OtobusCadır";
            this.Load += new System.EventHandler(this.OtobusCadır_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGoruntule)).EndInit();
            this.gbxRezervayonEkle.ResumeLayout(false);
            this.gbxRezervayonEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGoruntule;
        private System.Windows.Forms.GroupBox gbxRezervayonEkle;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.TextBox txtNereye;
        private System.Windows.Forms.TextBox txtBiletSayisi;
        private System.Windows.Forms.TextBox txtNereden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBilet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnRezervasyonİptal;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
    }
}