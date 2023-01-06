namespace OyunMagazasi
{
    partial class frm_yorumEkle
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
            this.btn_yorumekle = new System.Windows.Forms.Button();
            this.rtb_yorum = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_yorumekle
            // 
            this.btn_yorumekle.BackColor = System.Drawing.Color.Honeydew;
            this.btn_yorumekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yorumekle.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_yorumekle.Location = new System.Drawing.Point(13, 145);
            this.btn_yorumekle.Name = "btn_yorumekle";
            this.btn_yorumekle.Size = new System.Drawing.Size(73, 26);
            this.btn_yorumekle.TabIndex = 3;
            this.btn_yorumekle.Text = "Ekle";
            this.btn_yorumekle.UseVisualStyleBackColor = false;
            this.btn_yorumekle.Click += new System.EventHandler(this.btn_yorumekle_Click);
            // 
            // rtb_yorum
            // 
            this.rtb_yorum.Location = new System.Drawing.Point(12, 12);
            this.rtb_yorum.Name = "rtb_yorum";
            this.rtb_yorum.Size = new System.Drawing.Size(398, 112);
            this.rtb_yorum.TabIndex = 2;
            this.rtb_yorum.Text = "";
            // 
            // frm_yorumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 221);
            this.Controls.Add(this.btn_yorumekle);
            this.Controls.Add(this.rtb_yorum);
            this.Name = "frm_yorumEkle";
            this.Text = "frm_yorumEkle";
            this.Load += new System.EventHandler(this.frm_yorumEkle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yorumekle;
        private System.Windows.Forms.RichTextBox rtb_yorum;
    }
}