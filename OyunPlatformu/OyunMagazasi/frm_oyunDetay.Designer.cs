namespace OyunMagazasi
{
    partial class frm_oyunDetay
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
            this.lbl_oyunlarim_secilen = new System.Windows.Forms.Label();
            this.lbl_oyunlarim_oyunadi = new System.Windows.Forms.Label();
            this.dgv_yorumlar = new System.Windows.Forms.DataGridView();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_yapimcibilgi = new System.Windows.Forms.RichTextBox();
            this.lbl_yapimciadi = new System.Windows.Forms.Label();
            this.lbl_piyasadegeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yorumlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_oyunlarim_secilen
            // 
            this.lbl_oyunlarim_secilen.AutoSize = true;
            this.lbl_oyunlarim_secilen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oyunlarim_secilen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oyunlarim_secilen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_oyunlarim_secilen.Location = new System.Drawing.Point(120, 17);
            this.lbl_oyunlarim_secilen.Name = "lbl_oyunlarim_secilen";
            this.lbl_oyunlarim_secilen.Size = new System.Drawing.Size(0, 22);
            this.lbl_oyunlarim_secilen.TabIndex = 7;
            // 
            // lbl_oyunlarim_oyunadi
            // 
            this.lbl_oyunlarim_oyunadi.AutoSize = true;
            this.lbl_oyunlarim_oyunadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oyunlarim_oyunadi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oyunlarim_oyunadi.Location = new System.Drawing.Point(8, 17);
            this.lbl_oyunlarim_oyunadi.Name = "lbl_oyunlarim_oyunadi";
            this.lbl_oyunlarim_oyunadi.Size = new System.Drawing.Size(106, 19);
            this.lbl_oyunlarim_oyunadi.TabIndex = 6;
            this.lbl_oyunlarim_oyunadi.Text = "Seçilen Oyun : ";
            // 
            // dgv_yorumlar
            // 
            this.dgv_yorumlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yorumlar.Location = new System.Drawing.Point(12, 43);
            this.dgv_yorumlar.Name = "dgv_yorumlar";
            this.dgv_yorumlar.Size = new System.Drawing.Size(240, 318);
            this.dgv_yorumlar.TabIndex = 5;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kategori.Location = new System.Drawing.Point(269, 51);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(68, 16);
            this.lbl_kategori.TabIndex = 8;
            this.lbl_kategori.Text = "Kategori :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_yapimcibilgi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_piyasadegeri);
            this.groupBox1.Controls.Add(this.lbl_yapimciadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(495, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 273);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapımcı Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapımcı Adı    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Piyasa Değeri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bilgi";
            // 
            // rtb_yapimcibilgi
            // 
            this.rtb_yapimcibilgi.Enabled = false;
            this.rtb_yapimcibilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_yapimcibilgi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rtb_yapimcibilgi.Location = new System.Drawing.Point(17, 123);
            this.rtb_yapimcibilgi.Name = "rtb_yapimcibilgi";
            this.rtb_yapimcibilgi.Size = new System.Drawing.Size(255, 123);
            this.rtb_yapimcibilgi.TabIndex = 1;
            this.rtb_yapimcibilgi.Text = "";
            // 
            // lbl_yapimciadi
            // 
            this.lbl_yapimciadi.AutoSize = true;
            this.lbl_yapimciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yapimciadi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_yapimciadi.Location = new System.Drawing.Point(123, 40);
            this.lbl_yapimciadi.Name = "lbl_yapimciadi";
            this.lbl_yapimciadi.Size = new System.Drawing.Size(0, 16);
            this.lbl_yapimciadi.TabIndex = 0;
            // 
            // lbl_piyasadegeri
            // 
            this.lbl_piyasadegeri.AutoSize = true;
            this.lbl_piyasadegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_piyasadegeri.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_piyasadegeri.Location = new System.Drawing.Point(123, 71);
            this.lbl_piyasadegeri.Name = "lbl_piyasadegeri";
            this.lbl_piyasadegeri.Size = new System.Drawing.Size(0, 16);
            this.lbl_piyasadegeri.TabIndex = 0;
            // 
            // frm_oyunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_oyunlarim_secilen);
            this.Controls.Add(this.lbl_oyunlarim_oyunadi);
            this.Controls.Add(this.dgv_yorumlar);
            this.Name = "frm_oyunDetay";
            this.Text = "frm_oyunDetay";
            this.Load += new System.EventHandler(this.frm_oyunDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yorumlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_oyunlarim_secilen;
        private System.Windows.Forms.Label lbl_oyunlarim_oyunadi;
        private System.Windows.Forms.DataGridView dgv_yorumlar;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_yapimcibilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_piyasadegeri;
        private System.Windows.Forms.Label lbl_yapimciadi;
        private System.Windows.Forms.Label label1;
    }
}