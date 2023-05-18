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
    public partial class OgrenciDetay : Form
    {
        public OgrenciDetay()
        {
            InitializeComponent();
        }
        StudentsDal _studentDal = new StudentsDal();
        public int number;
        private void OgrenciDetay_Load(object sender, EventArgs e)
        {
            var getByNumber = _studentDal.GetByNumber(number);
            lbl_ad.Text = getByNumber.Ad;
            lbl_soyad.Text = getByNumber.Soyad;
            lbl_numara.Text = getByNumber.Numara.ToString();
            lbl_sınav1.Text = getByNumber.Sinav1.ToString();
            lbl_sınav2.Text = getByNumber.Sinav2.ToString();
            lbl_sınav3.Text = getByNumber.Sinav3.ToString();
            lbl_ortalama.Text = getByNumber.Ortalama.ToString();
            lbl_durum.Text = getByNumber.Durum.ToString();
        }
    }
}
