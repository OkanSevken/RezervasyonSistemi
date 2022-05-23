
namespace Rezervasyon.FormUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOtobusOtel = new System.Windows.Forms.Button();
            this.btnUcakOtel = new System.Windows.Forms.Button();
            this.btnOtobusCadır = new System.Windows.Forms.Button();
            this.btnUcakCadir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOtobusOtel);
            this.groupBox1.Controls.Add(this.btnUcakOtel);
            this.groupBox1.Controls.Add(this.btnOtobusCadır);
            this.groupBox1.Controls.Add(this.btnUcakCadir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(118, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(577, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Size Uygun Olan Rezervasyon Tipini Seçiniz";
            // 
            // btnOtobusOtel
            // 
            this.btnOtobusOtel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOtobusOtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtobusOtel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOtobusOtel.Location = new System.Drawing.Point(206, 255);
            this.btnOtobusOtel.Name = "btnOtobusOtel";
            this.btnOtobusOtel.Size = new System.Drawing.Size(162, 38);
            this.btnOtobusOtel.TabIndex = 23;
            this.btnOtobusOtel.Text = "Otobüs-Otel";
            this.btnOtobusOtel.UseVisualStyleBackColor = false;
            this.btnOtobusOtel.Click += new System.EventHandler(this.btnOtobusOtel_Click);
            // 
            // btnUcakOtel
            // 
            this.btnUcakOtel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUcakOtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcakOtel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUcakOtel.Location = new System.Drawing.Point(423, 162);
            this.btnUcakOtel.Name = "btnUcakOtel";
            this.btnUcakOtel.Size = new System.Drawing.Size(165, 38);
            this.btnUcakOtel.TabIndex = 22;
            this.btnUcakOtel.Text = "Uçak-Otel";
            this.btnUcakOtel.UseVisualStyleBackColor = false;
            this.btnUcakOtel.Click += new System.EventHandler(this.btnUcakOtel_Click);
            // 
            // btnOtobusCadır
            // 
            this.btnOtobusCadır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOtobusCadır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtobusCadır.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOtobusCadır.Location = new System.Drawing.Point(423, 255);
            this.btnOtobusCadır.Name = "btnOtobusCadır";
            this.btnOtobusCadır.Size = new System.Drawing.Size(165, 38);
            this.btnOtobusCadır.TabIndex = 21;
            this.btnOtobusCadır.Text = "Otobüs-Çadır";
            this.btnOtobusCadır.UseVisualStyleBackColor = false;
            this.btnOtobusCadır.Click += new System.EventHandler(this.btnOtobusCadır_Click);
            // 
            // btnUcakCadir
            // 
            this.btnUcakCadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUcakCadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcakCadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUcakCadir.Location = new System.Drawing.Point(206, 162);
            this.btnUcakCadir.Name = "btnUcakCadir";
            this.btnUcakCadir.Size = new System.Drawing.Size(162, 38);
            this.btnUcakCadir.TabIndex = 20;
            this.btnUcakCadir.Text = "Uçak-Çadır";
            this.btnUcakCadir.UseVisualStyleBackColor = false;
            this.btnUcakCadir.Click += new System.EventHandler(this.btnUcakCadir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(841, 575);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOtobusOtel;
        private System.Windows.Forms.Button btnUcakOtel;
        private System.Windows.Forms.Button btnOtobusCadır;
        private System.Windows.Forms.Button btnUcakCadir;
        private System.Windows.Forms.Label label5;
    }
}

