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
    public partial class Form1 : Form
    {
        Ogreci_CRUD cRUD = new Ogreci_CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetListe();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetListe();
        }
        public void GetListe()
        {
            grid_Liste.Rows.Clear();           
            List<Ogrenci> ogrencis = cRUD.GetOgrenciListe();

            foreach (Ogrenci ogrenci in ogrencis)
            {
                grid_Liste.Rows.Add();
                grid_Liste.Rows[grid_Liste.RowCount - 1].Cells["ID"].Value = ogrenci.Id;
                grid_Liste.Rows[grid_Liste.RowCount - 1].Cells["Ad"].Value = ogrenci.Ad;
                grid_Liste.Rows[grid_Liste.RowCount - 1].Cells["Soyad"].Value = ogrenci.Soyad;
                grid_Liste.Rows[grid_Liste.RowCount - 1].Cells["Numara"].Value = ogrenci.Numara;
                grid_Liste.Rows[grid_Liste.RowCount - 1].Cells["DogumTarihi"].Value = ogrenci.DogumTarihi.ToString("dd/MM/yyyy");
            }

            //ikinci yöntem
           grid2.DataSource = cRUD.GetOgrenciListe2();

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frm_OgrenciEkle frm = new frm_OgrenciEkle();
            frm.ShowDialog();
            GetListe();

        }

        private void grid_Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 && e.ColumnIndex != 6)
                return;

            if (e.RowIndex == -1)
                return;

            int ID = Convert.ToInt32( grid_Liste.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 5) //Güncelleme
            {
                frm_OgrenciEkle frm = new frm_OgrenciEkle(ID);
                frm.ShowDialog();
                GetListe();
            }
            else
            {
                //Silme
                cRUD.OgrenciSil(ID);
                GetListe();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
