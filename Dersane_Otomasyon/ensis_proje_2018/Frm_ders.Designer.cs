namespace ensis_proje_2018
{
    partial class Frm_ders
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
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_derskod_arama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.cbox_dersgunu = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_dersssati = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_sube = new System.Windows.Forms.ComboBox();
            this.txt_ders_kodu = new System.Windows.Forms.TextBox();
            this.txt_ders_adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_excell = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Azure;
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(332, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 33);
            this.button5.TabIndex = 17;
            this.button5.Text = "ANASAYFA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_derskod_arama);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 140);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Koduna Göre Arama";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(85, 86);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(185, 28);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Arama";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ders Kodu:";
            // 
            // txt_derskod_arama
            // 
            this.txt_derskod_arama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_derskod_arama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_derskod_arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_derskod_arama.Location = new System.Drawing.Point(85, 39);
            this.txt_derskod_arama.Name = "txt_derskod_arama";
            this.txt_derskod_arama.Size = new System.Drawing.Size(185, 20);
            this.txt_derskod_arama.TabIndex = 8;
            this.txt_derskod_arama.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.cbox_dersgunu);
            this.groupBox1.Controls.Add(this.maskedTextBox_dersssati);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbox_sube);
            this.groupBox1.Controls.Add(this.txt_ders_kodu);
            this.groupBox1.Controls.Add(this.txt_ders_adi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 254);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Bilgileri";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(87, 259);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 14;
            // 
            // cbox_dersgunu
            // 
            this.cbox_dersgunu.FormattingEnabled = true;
            this.cbox_dersgunu.Items.AddRange(new object[] {
            "PAZARTESİ",
            "SALI",
            "ÇARŞAMBA",
            "PERŞEMBE",
            "CUMA",
            "CUMARTESİ",
            "PAZAR",
            "Hafta İçi Her Gün",
            "Hafta Sonu"});
            this.cbox_dersgunu.Location = new System.Drawing.Point(98, 122);
            this.cbox_dersgunu.Name = "cbox_dersgunu";
            this.cbox_dersgunu.Size = new System.Drawing.Size(200, 21);
            this.cbox_dersgunu.TabIndex = 13;
            // 
            // maskedTextBox_dersssati
            // 
            this.maskedTextBox_dersssati.Location = new System.Drawing.Point(98, 164);
            this.maskedTextBox_dersssati.Mask = "00:00--00:00";
            this.maskedTextBox_dersssati.Name = "maskedTextBox_dersssati";
            this.maskedTextBox_dersssati.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox_dersssati.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ders Saati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ders Günü:";
            // 
            // cbox_sube
            // 
            this.cbox_sube.FormattingEnabled = true;
            this.cbox_sube.Location = new System.Drawing.Point(98, 206);
            this.cbox_sube.Name = "cbox_sube";
            this.cbox_sube.Size = new System.Drawing.Size(200, 21);
            this.cbox_sube.TabIndex = 5;
            // 
            // txt_ders_kodu
            // 
            this.txt_ders_kodu.Location = new System.Drawing.Point(98, 79);
            this.txt_ders_kodu.Name = "txt_ders_kodu";
            this.txt_ders_kodu.Size = new System.Drawing.Size(200, 20);
            this.txt_ders_kodu.TabIndex = 4;
            this.txt_ders_kodu.TextChanged += new System.EventHandler(this.txt_ders_kodu_TextChanged);
            // 
            // txt_ders_adi
            // 
            this.txt_ders_adi.Location = new System.Drawing.Point(98, 39);
            this.txt_ders_adi.Name = "txt_ders_adi";
            this.txt_ders_adi.Size = new System.Drawing.Size(200, 20);
            this.txt_ders_adi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınıf Şube:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Azure;
            this.btn_update.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(510, 158);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(156, 30);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(510, 194);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(156, 32);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Azure;
            this.btn_add.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(332, 158);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 30);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "EKLE";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 181);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Azure;
            this.btn_reset.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(332, 194);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(172, 33);
            this.btn_reset.TabIndex = 35;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_excell
            // 
            this.btn_excell.BackColor = System.Drawing.Color.Azure;
            this.btn_excell.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excell.Location = new System.Drawing.Point(510, 232);
            this.btn_excell.Name = "btn_excell";
            this.btn_excell.Size = new System.Drawing.Size(156, 33);
            this.btn_excell.TabIndex = 37;
            this.btn_excell.Text = "Bilgileri Excel \'e Aktar";
            this.btn_excell.UseVisualStyleBackColor = false;
            this.btn_excell.Click += new System.EventHandler(this.btn_excell_Click);
            // 
            // Frm_ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.btn_excell);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_ders";
            this.Text = "Ders İşlemleri";
            this.Load += new System.EventHandler(this.Frm_ders_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_derskod_arama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ders_kodu;
        private System.Windows.Forms.TextBox txt_ders_adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbox_sube;
        private System.Windows.Forms.ComboBox cbox_dersgunu;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dersssati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btn_excell;
    }
}