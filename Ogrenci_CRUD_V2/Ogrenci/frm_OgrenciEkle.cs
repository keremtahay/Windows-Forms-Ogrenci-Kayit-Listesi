using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogrenci.CRUD;

namespace Ogrenci
{
    public partial class frm_OgrenciEkle : Form
    {
        Ogreci_CRUD _CRUD = new Ogreci_CRUD();
        public frm_OgrenciEkle()
        {
            InitializeComponent();
        }

        private int ID;
        public frm_OgrenciEkle(int ID_)
        {
            ID = ID_;
            InitializeComponent();
        }

        private void frm_OgrenciEkle_Load(object sender, EventArgs e) //Formda herhangi bir yere tıklama
        {
            if (ID > 0)//Kayıt Güncelleme 
            {
                Ogrenci ogrenci = _CRUD.GetOgrenci(ID);
                if (ogrenci != null)
                {
                    txt_Ad.Text = ogrenci.Ad.ToString();
                    txt_Soyad.Text = ogrenci.Soyad.ToString();
                    txt_Numara.Text = ogrenci.Numara.ToString();
                    date_DTar.Value = ogrenci.DogumTarihi;
                }
            }
            else //Yeni Kayıt
            {

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Numara = Convert.ToInt32(txt_Numara.Text);
            ogrenci.Ad = txt_Ad.Text;
            ogrenci.Soyad = txt_Soyad.Text;
            ogrenci.Id = ID;
            ogrenci.DogumTarihi = date_DTar.Value;

            if (ID == 0)
                _CRUD.OgrenciEkle(ogrenci);
            else
                _CRUD.OgrenciGuncelle(ogrenci);


            this.Close();   //Formu Kapat
        }
    }
}
