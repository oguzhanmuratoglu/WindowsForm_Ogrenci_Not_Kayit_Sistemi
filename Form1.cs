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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentsDal _studentDal = new StudentsDal();
        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDetay ogn = new OgrenciDetay();
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Öğrenci Numarası Boş Bırakılamaz");
                return;
            }
            ogn.number = int.Parse(maskedTextBox1.Text);

            if (_studentDal.IsContainsNumber(ogn.number))
            {
                var getByNumber = _studentDal.GetByNumber(ogn.number);
                ogn.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Bir Öğrenci Numarası Yazdınız Lütfen Tekrar Deneyiniz");
            }


        }

        private void btn_admingiris_Click(object sender, EventArgs e)
        {
            OgretmenDetay ogret = new OgretmenDetay();
            ogret.Show();
        }
    }
}
