namespace Ogrenci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_KayitGuncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.grid2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grid_Liste
            // 
            this.grid_Liste.AllowUserToAddRows = false;
            this.grid_Liste.AllowUserToDeleteRows = false;
            this.grid_Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Liste.BackgroundColor = System.Drawing.Color.White;
            this.grid_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Soyad,
            this.Numara,
            this.DogumTarihi,
            this.btn_KayitGuncelle,
            this.btn_Sil});
            this.grid_Liste.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grid_Liste.Location = new System.Drawing.Point(9, 62);
            this.grid_Liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_Liste.Name = "grid_Liste";
            this.grid_Liste.ReadOnly = true;
            this.grid_Liste.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            this.grid_Liste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Liste.RowTemplate.Height = 28;
            this.grid_Liste.Size = new System.Drawing.Size(1176, 271);
            this.grid_Liste.TabIndex = 1;
            this.grid_Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Liste_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 8;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.Width = 150;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 8;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.Width = 150;
            // 
            // Numara
            // 
            this.Numara.HeaderText = "Numara";
            this.Numara.MinimumWidth = 8;
            this.Numara.Name = "Numara";
            this.Numara.ReadOnly = true;
            this.Numara.Width = 150;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.MinimumWidth = 8;
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            this.DogumTarihi.Width = 150;
            // 
            // btn_KayitGuncelle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.NullValue = "Güncelle";
            this.btn_KayitGuncelle.DefaultCellStyle = dataGridViewCellStyle1;
            this.btn_KayitGuncelle.HeaderText = "Güncelle";
            this.btn_KayitGuncelle.MinimumWidth = 8;
            this.btn_KayitGuncelle.Name = "btn_KayitGuncelle";
            this.btn_KayitGuncelle.ReadOnly = true;
            this.btn_KayitGuncelle.Text = "Güncelle";
            this.btn_KayitGuncelle.Width = 150;
            // 
            // btn_Sil
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "Sil";
            this.btn_Sil.DefaultCellStyle = dataGridViewCellStyle2;
            this.btn_Sil.HeaderText = "Sil";
            this.btn_Sil.MinimumWidth = 8;
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.ReadOnly = true;
            this.btn_Sil.Width = 150;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(244, 16);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(132, 42);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOgrenciEkle.Image = global::Ogrenci.Properties.Resources.add_user_8924229;
            this.btnOgrenciEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(1026, 10);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(133, 41);
            this.btnOgrenciEkle.TabIndex = 3;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Location = new System.Drawing.Point(9, 434);
            this.grid2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersWidth = 62;
            this.grid2.RowTemplate.Height = 28;
            this.grid2.Size = new System.Drawing.Size(932, 172);
            this.grid2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 617);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.grid_Liste);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Liste;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewButtonColumn btn_KayitGuncelle;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Sil;
        private System.Windows.Forms.DataGridView grid2;
    }
}

