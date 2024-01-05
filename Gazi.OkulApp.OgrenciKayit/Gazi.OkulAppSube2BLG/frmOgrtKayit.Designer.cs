namespace Gazi.OkulAppSube2BLG
{
    partial class frmOgrtKayit
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
            this.gbOgrtBilgi = new System.Windows.Forms.GroupBox();
            this.tbOgrtTcNo = new System.Windows.Forms.TextBox();
            this.tbOgrtSoyad = new System.Windows.Forms.TextBox();
            this.tbOgrtAd = new System.Windows.Forms.TextBox();
            this.lblOgrtTcNo = new System.Windows.Forms.Label();
            this.lblOgrtSoyad = new System.Windows.Forms.Label();
            this.lblOgrtAd = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.gbOgrtBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOgrtBilgi
            // 
            this.gbOgrtBilgi.Controls.Add(this.tbOgrtTcNo);
            this.gbOgrtBilgi.Controls.Add(this.tbOgrtSoyad);
            this.gbOgrtBilgi.Controls.Add(this.tbOgrtAd);
            this.gbOgrtBilgi.Controls.Add(this.lblOgrtTcNo);
            this.gbOgrtBilgi.Controls.Add(this.lblOgrtSoyad);
            this.gbOgrtBilgi.Controls.Add(this.lblOgrtAd);
            this.gbOgrtBilgi.Location = new System.Drawing.Point(16, 15);
            this.gbOgrtBilgi.Name = "gbOgrtBilgi";
            this.gbOgrtBilgi.Size = new System.Drawing.Size(280, 178);
            this.gbOgrtBilgi.TabIndex = 0;
            this.gbOgrtBilgi.TabStop = false;
            this.gbOgrtBilgi.Text = "Öğretmen Bilgileri";
            // 
            // tbOgrtTcNo
            // 
            this.tbOgrtTcNo.Location = new System.Drawing.Point(145, 126);
            this.tbOgrtTcNo.Name = "tbOgrtTcNo";
            this.tbOgrtTcNo.Size = new System.Drawing.Size(100, 22);
            this.tbOgrtTcNo.TabIndex = 5;
            // 
            // tbOgrtSoyad
            // 
            this.tbOgrtSoyad.Location = new System.Drawing.Point(145, 77);
            this.tbOgrtSoyad.Name = "tbOgrtSoyad";
            this.tbOgrtSoyad.Size = new System.Drawing.Size(100, 22);
            this.tbOgrtSoyad.TabIndex = 4;
            // 
            // tbOgrtAd
            // 
            this.tbOgrtAd.Location = new System.Drawing.Point(145, 37);
            this.tbOgrtAd.Name = "tbOgrtAd";
            this.tbOgrtAd.Size = new System.Drawing.Size(100, 22);
            this.tbOgrtAd.TabIndex = 3;
            // 
            // lblOgrtTcNo
            // 
            this.lblOgrtTcNo.AutoSize = true;
            this.lblOgrtTcNo.Location = new System.Drawing.Point(36, 132);
            this.lblOgrtTcNo.Name = "lblOgrtTcNo";
            this.lblOgrtTcNo.Size = new System.Drawing.Size(41, 16);
            this.lblOgrtTcNo.TabIndex = 2;
            this.lblOgrtTcNo.Text = "TcNo";
            // 
            // lblOgrtSoyad
            // 
            this.lblOgrtSoyad.AutoSize = true;
            this.lblOgrtSoyad.Location = new System.Drawing.Point(36, 80);
            this.lblOgrtSoyad.Name = "lblOgrtSoyad";
            this.lblOgrtSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblOgrtSoyad.TabIndex = 1;
            this.lblOgrtSoyad.Text = "Soyad";
            // 
            // lblOgrtAd
            // 
            this.lblOgrtAd.AutoSize = true;
            this.lblOgrtAd.Location = new System.Drawing.Point(42, 40);
            this.lblOgrtAd.Name = "lblOgrtAd";
            this.lblOgrtAd.Size = new System.Drawing.Size(24, 16);
            this.lblOgrtAd.TabIndex = 0;
            this.lblOgrtAd.Text = "Ad";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnKaydet.Location = new System.Drawing.Point(305, 16);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 30);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSil.Location = new System.Drawing.Point(304, 124);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 30);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGuncelle.Location = new System.Drawing.Point(305, 89);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 30);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTemizle.Location = new System.Drawing.Point(304, 160);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 30);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBul.Location = new System.Drawing.Point(304, 53);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(96, 30);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // frmOgrtKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 205);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbOgrtBilgi);
            this.Name = "frmOgrtKayit";
            this.Text = "Öğretmen Kayıt İşlemleri";
            this.gbOgrtBilgi.ResumeLayout(false);
            this.gbOgrtBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrtBilgi;
        public System.Windows.Forms.TextBox tbOgrtTcNo;
        public System.Windows.Forms.TextBox tbOgrtSoyad;
        public System.Windows.Forms.TextBox tbOgrtAd;
        private System.Windows.Forms.Label lblOgrtTcNo;
        private System.Windows.Forms.Label lblOgrtSoyad;
        private System.Windows.Forms.Label lblOgrtAd;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBul;
    }
}