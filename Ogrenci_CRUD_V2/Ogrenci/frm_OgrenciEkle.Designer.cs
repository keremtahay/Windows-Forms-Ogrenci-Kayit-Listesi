namespace Ogrenci
{
    partial class frm_OgrenciEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Numara = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_DTar = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(106, 26);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(509, 26);
            this.txt_Ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(106, 58);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(509, 26);
            this.txt_Soyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numara:";
            // 
            // txt_Numara
            // 
            this.txt_Numara.Location = new System.Drawing.Point(106, 90);
            this.txt_Numara.Name = "txt_Numara";
            this.txt_Numara.Size = new System.Drawing.Size(509, 26);
            this.txt_Numara.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(355, 362);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(260, 54);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "D.Tarihi:";
            // 
            // date_DTar
            // 
            this.date_DTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_DTar.Location = new System.Drawing.Point(106, 124);
            this.date_DTar.Name = "date_DTar";
            this.date_DTar.Size = new System.Drawing.Size(249, 26);
            this.date_DTar.TabIndex = 6;
            // 
            // frm_OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.date_DTar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txt_Numara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label1);
            this.Name = "frm_OgrenciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekle";
            this.Load += new System.EventHandler(this.frm_OgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Numara;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_DTar;
    }
}