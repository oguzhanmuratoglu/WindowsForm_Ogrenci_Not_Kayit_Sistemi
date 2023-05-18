using Ogrenci_Not_Kayit_Sistemi.DataAccess;
using Ogrenci_Not_Kayit_Sistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Not_Kayit_Sistemi
{
    public partial class OgretmenDetay : Form
    {
        public OgretmenDetay()
        {
            InitializeComponent();
        }
        StudentsDal _studentsDal = new StudentsDal();
        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var all = _studentsDal.GetAll();
            dataGridView1.DataSource = all;
            decimal ort = 0;
            int gecen = 0;
            int kalan = 0;
            int sayac = 0;
            foreach (var student in all)
            {
                if (student.Sinav1 != null || student.Sinav2 != null || student.Sinav3 != null)
                {
                    ort += (decimal.Parse(student.Sinav1.ToString()) + decimal.Parse(student.Sinav2.ToString()) + decimal.Parse(student.Sinav3.ToString())) / 3;
                    sayac++;
                    if (student.Ortalama >= 50)
                    {
                        gecen++;
                    }
                    else
                    {
                        kalan++;
                    }
                }
                
            }
            lbl_ortalama.Text = Math.Round((ort / sayac),2).ToString();
            lbl_gecen.Text = gecen.ToString();
            lbl_kalan.Text = kalan.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            _studentsDal.Add(new Students
            {
                Ad = tbx_ad.Text,
                Soyad = tbx_soyad.Text,
                Numara = int.Parse(mtbx_numara.Text)
            });
            LoadData();
            MessageBox.Show("Öğrenci Başarıyla Eklendi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilen = dataGridView1.SelectedCells[0].RowIndex;
            var sinav1 = dataGridView1.Rows[secilen].Cells[4].Value;
            var sinav2 = dataGridView1.Rows[secilen].Cells[5].Value;
            var sinav3 = dataGridView1.Rows[secilen].Cells[6].Value;
            if (sinav1 == null && sinav2 == null && sinav3 == null)
            {
                return;
            }
            tbx_sinav1.Text = sinav1.ToString();
            tbx_sinav2.Text = sinav2.ToString();
            tbx_sinav3.Text = sinav3.ToString();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            decimal s1 = decimal.Parse(tbx_sinav1.Text);
            decimal s2 = decimal.Parse(tbx_sinav2.Text);
            decimal s3 = decimal.Parse(tbx_sinav3.Text);
            decimal ortalama = (s1 + s2 + s3) / 3;

            _studentsDal.Update(new Students
            {
                Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Numara = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()),
                Ad = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                Soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                Sinav1 = int.Parse(tbx_sinav1.Text),
                Sinav2 = int.Parse(tbx_sinav2.Text),
                Sinav3 = int.Parse(tbx_sinav3.Text),
                Ortalama = ortalama,
                Durum = ortalama >= 50 ? true : false,
            });
            LoadData();
            MessageBox.Show("Öğrencinin Sınavları Başarıyla Değiştirildi!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _studentsDal.Delete(studentId);
            LoadData();
            MessageBox.Show("Öğrenci Başarıyla Silindi!");
        }
    }
}
