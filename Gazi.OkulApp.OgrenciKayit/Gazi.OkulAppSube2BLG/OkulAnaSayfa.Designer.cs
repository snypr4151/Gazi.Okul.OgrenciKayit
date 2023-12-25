namespace Gazi.OkulAppSube2BLG
{
    partial class OkulAnaSayfa
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
            this.lblOgretmenEkle = new System.Windows.Forms.Label();
            this.lblOgrenciEkle = new System.Windows.Forms.Label();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOgretmenEkle);
            this.groupBox1.Controls.Add(this.lblOgrenciEkle);
            this.groupBox1.Controls.Add(this.btnOgretmenEkle);
            this.groupBox1.Controls.Add(this.btnOgrenciEkle);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gazi";
            // 
            // lblOgretmenEkle
            // 
            this.lblOgretmenEkle.AutoSize = true;
            this.lblOgretmenEkle.Location = new System.Drawing.Point(6, 53);
            this.lblOgretmenEkle.Name = "lblOgretmenEkle";
            this.lblOgretmenEkle.Size = new System.Drawing.Size(66, 16);
            this.lblOgretmenEkle.TabIndex = 3;
            this.lblOgretmenEkle.Text = "Öğretmen";
            // 
            // lblOgrenciEkle
            // 
            this.lblOgrenciEkle.AutoSize = true;
            this.lblOgrenciEkle.Location = new System.Drawing.Point(6, 20);
            this.lblOgrenciEkle.Name = "lblOgrenciEkle";
            this.lblOgrenciEkle.Size = new System.Drawing.Size(54, 16);
            this.lblOgrenciEkle.TabIndex = 2;
            this.lblOgrenciEkle.Text = "Öğrenci";
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOgretmenEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgretmenEkle.Location = new System.Drawing.Point(78, 48);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(56, 26);
            this.btnOgretmenEkle.TabIndex = 1;
            this.btnOgretmenEkle.Text = "Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = false;
            this.btnOgretmenEkle.Click += new System.EventHandler(this.btnOgretmenEkle_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(78, 16);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(56, 24);
            this.btnOgrenciEkle.TabIndex = 0;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // OkulAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(156, 106);
            this.Controls.Add(this.groupBox1);
            this.Name = "OkulAnaSayfa";
            this.Text = "OkulAnaSayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOgretmenEkle;
        private System.Windows.Forms.Label lblOgrenciEkle;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.Button btnOgrenciEkle;
    }
}