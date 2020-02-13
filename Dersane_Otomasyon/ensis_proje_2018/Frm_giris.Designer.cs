namespace ensis_proje_2018
{
    partial class Frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_giris));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_kullanici_ad = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.AcceptsReturn = true;
            this.txt_ad.BackColor = System.Drawing.Color.White;
            this.txt_ad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ad.Location = new System.Drawing.Point(188, 95);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(177, 27);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ad_KeyDown);
            this.txt_ad.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.True);
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.Location = new System.Drawing.Point(45, 145);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(54, 19);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "ŞİFRE:";
            this.lbl_sifre.Click += new System.EventHandler(this.lbl_sifre_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifre.Location = new System.Drawing.Point(188, 141);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(177, 27);
            this.txt_sifre.TabIndex = 1;
            // 
            // lbl_kullanici_ad
            // 
            this.lbl_kullanici_ad.AutoSize = true;
            this.lbl_kullanici_ad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullanici_ad.Location = new System.Drawing.Point(45, 103);
            this.lbl_kullanici_ad.Name = "lbl_kullanici_ad";
            this.lbl_kullanici_ad.Size = new System.Drawing.Size(127, 19);
            this.lbl_kullanici_ad.TabIndex = 0;
            this.lbl_kullanici_ad.Text = "KULLANICI ADI:";
            this.lbl_kullanici_ad.Click += new System.EventHandler(this.lbl_kullanici_ad_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Silver;
            this.btn_giris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_giris.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giris.Location = new System.Drawing.Point(188, 187);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(177, 35);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_giris;
            this.ClientSize = new System.Drawing.Size(488, 389);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_kullanici_ad);
            this.Controls.Add(this.txt_ad);
            this.Name = "Frm_giris";
            this.Text = "GİRİŞ SAYFASI";
            this.Load += new System.EventHandler(this.Frm_giris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_giris_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.True);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_kullanici_ad;
        private System.Windows.Forms.Button btn_giris;

    }
}

