namespace OyunMagazasi
{
    partial class frm_yapimciEkle
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
            this.lbl_yapimciadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_yapimciadi = new System.Windows.Forms.TextBox();
            this.tb_piyasadegeri = new System.Windows.Forms.TextBox();
            this.rtb_bilgi = new System.Windows.Forms.RichTextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_yapimciadi
            // 
            this.lbl_yapimciadi.AutoSize = true;
            this.lbl_yapimciadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yapimciadi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yapimciadi.Location = new System.Drawing.Point(86, 69);
            this.lbl_yapimciadi.Name = "lbl_yapimciadi";
            this.lbl_yapimciadi.Size = new System.Drawing.Size(97, 19);
            this.lbl_yapimciadi.TabIndex = 2;
            this.lbl_yapimciadi.Text = "Yapımcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Piyasa Değeri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yapımcı Hakkında Bilgi :";
            // 
            // tb_yapimciadi
            // 
            this.tb_yapimciadi.Location = new System.Drawing.Point(189, 68);
            this.tb_yapimciadi.Name = "tb_yapimciadi";
            this.tb_yapimciadi.Size = new System.Drawing.Size(195, 20);
            this.tb_yapimciadi.TabIndex = 3;
            // 
            // tb_piyasadegeri
            // 
            this.tb_piyasadegeri.Location = new System.Drawing.Point(189, 109);
            this.tb_piyasadegeri.Name = "tb_piyasadegeri";
            this.tb_piyasadegeri.Size = new System.Drawing.Size(195, 20);
            this.tb_piyasadegeri.TabIndex = 3;
            // 
            // rtb_bilgi
            // 
            this.rtb_bilgi.Location = new System.Drawing.Point(191, 157);
            this.rtb_bilgi.Name = "rtb_bilgi";
            this.rtb_bilgi.Size = new System.Drawing.Size(194, 107);
            this.rtb_bilgi.TabIndex = 4;
            this.rtb_bilgi.Text = "";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_ekle.Location = new System.Drawing.Point(191, 289);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(195, 55);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(390, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "mr/$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(199, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yapımcı Kayıt";
            // 
            // frm_yapimciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.rtb_bilgi);
            this.Controls.Add(this.tb_piyasadegeri);
            this.Controls.Add(this.tb_yapimciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_yapimciadi);
            this.Name = "frm_yapimciEkle";
            this.Text = "frm_yapimciEkle";
            this.Load += new System.EventHandler(this.frm_yapimciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yapimciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_yapimciadi;
        private System.Windows.Forms.TextBox tb_piyasadegeri;
        private System.Windows.Forms.RichTextBox rtb_bilgi;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}