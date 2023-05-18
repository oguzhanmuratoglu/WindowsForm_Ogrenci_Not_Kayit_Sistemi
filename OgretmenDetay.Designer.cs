namespace Ogrenci_Not_Kayit_Sistemi
{
    partial class OgretmenDetay
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
            components = new System.ComponentModel.Container();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_kaydet = new System.Windows.Forms.Button();
            tbx_soyad = new System.Windows.Forms.TextBox();
            tbx_ad = new System.Windows.Forms.TextBox();
            Soyad = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            mtbx_numara = new System.Windows.Forms.MaskedTextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tbx_sinav1 = new System.Windows.Forms.TextBox();
            btn_güncelle = new System.Windows.Forms.Button();
            tbx_sinav3 = new System.Windows.Forms.TextBox();
            tbx_sinav2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            lbl_kalan = new System.Windows.Forms.Label();
            lbl_gecen = new System.Windows.Forms.Label();
            lbl_ortalama = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            studentsBindingSource = new System.Windows.Forms.BindingSource(components);
            studentsContextBindingSource = new System.Windows.Forms.BindingSource(components);
            studentsDalBindingSource = new System.Windows.Forms.BindingSource(components);
            initialCreateBindingSource = new System.Windows.Forms.BindingSource(components);
            studentsContextBindingSource1 = new System.Windows.Forms.BindingSource(components);
            studentsContextBindingSource2 = new System.Windows.Forms.BindingSource(components);
            studentsDalBindingSource1 = new System.Windows.Forms.BindingSource(components);
            btn_delete = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsContextBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsDalBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_kaydet);
            groupBox1.Controls.Add(tbx_soyad);
            groupBox1.Controls.Add(tbx_ad);
            groupBox1.Controls.Add(Soyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtbx_numara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(18, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(314, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new System.Drawing.Point(118, 150);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new System.Drawing.Size(163, 38);
            btn_kaydet.TabIndex = 0;
            btn_kaydet.Text = "Öğrenci Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // tbx_soyad
            // 
            tbx_soyad.Location = new System.Drawing.Point(118, 114);
            tbx_soyad.Name = "tbx_soyad";
            tbx_soyad.Size = new System.Drawing.Size(163, 30);
            tbx_soyad.TabIndex = 5;
            // 
            // tbx_ad
            // 
            tbx_ad.Location = new System.Drawing.Point(118, 75);
            tbx_ad.Name = "tbx_ad";
            tbx_ad.Size = new System.Drawing.Size(163, 30);
            tbx_ad.TabIndex = 0;
            // 
            // Soyad
            // 
            Soyad.AutoSize = true;
            Soyad.Location = new System.Drawing.Point(17, 117);
            Soyad.Name = "Soyad";
            Soyad.Size = new System.Drawing.Size(74, 24);
            Soyad.TabIndex = 4;
            Soyad.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 24);
            label2.TabIndex = 2;
            label2.Text = "Ad :";
            // 
            // mtbx_numara
            // 
            mtbx_numara.Location = new System.Drawing.Point(118, 30);
            mtbx_numara.Mask = "0000";
            mtbx_numara.Name = "mtbx_numara";
            mtbx_numara.Size = new System.Drawing.Size(163, 30);
            mtbx_numara.TabIndex = 1;
            mtbx_numara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 24);
            label1.TabIndex = 0;
            label1.Text = "Numara :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbx_sinav1);
            groupBox2.Controls.Add(btn_güncelle);
            groupBox2.Controls.Add(tbx_sinav3);
            groupBox2.Controls.Add(tbx_sinav2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new System.Drawing.Point(340, 14);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4);
            groupBox2.Size = new System.Drawing.Size(314, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // tbx_sinav1
            // 
            tbx_sinav1.Location = new System.Drawing.Point(118, 34);
            tbx_sinav1.Name = "tbx_sinav1";
            tbx_sinav1.Size = new System.Drawing.Size(163, 30);
            tbx_sinav1.TabIndex = 6;
            // 
            // btn_güncelle
            // 
            btn_güncelle.Location = new System.Drawing.Point(118, 150);
            btn_güncelle.Name = "btn_güncelle";
            btn_güncelle.Size = new System.Drawing.Size(163, 38);
            btn_güncelle.TabIndex = 0;
            btn_güncelle.Text = "Güncelle";
            btn_güncelle.UseVisualStyleBackColor = true;
            btn_güncelle.Click += btn_güncelle_Click;
            // 
            // tbx_sinav3
            // 
            tbx_sinav3.Location = new System.Drawing.Point(118, 114);
            tbx_sinav3.Name = "tbx_sinav3";
            tbx_sinav3.Size = new System.Drawing.Size(163, 30);
            tbx_sinav3.TabIndex = 5;
            // 
            // tbx_sinav2
            // 
            tbx_sinav2.Location = new System.Drawing.Point(118, 75);
            tbx_sinav2.Name = "tbx_sinav2";
            tbx_sinav2.Size = new System.Drawing.Size(163, 30);
            tbx_sinav2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "Sınav 3 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(19, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 24);
            label4.TabIndex = 2;
            label4.Text = "Sınav 2 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(19, 34);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 24);
            label5.TabIndex = 0;
            label5.Text = "Sınav 1 :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_kalan);
            groupBox3.Controls.Add(lbl_gecen);
            groupBox3.Controls.Add(lbl_ortalama);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new System.Drawing.Point(662, 16);
            groupBox3.Margin = new System.Windows.Forms.Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4);
            groupBox3.Size = new System.Drawing.Size(314, 157);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınıf Değerlendirmesi";
            // 
            // lbl_kalan
            // 
            lbl_kalan.AutoSize = true;
            lbl_kalan.Location = new System.Drawing.Point(148, 120);
            lbl_kalan.Name = "lbl_kalan";
            lbl_kalan.Size = new System.Drawing.Size(34, 24);
            lbl_kalan.TabIndex = 7;
            lbl_kalan.Text = "00";
            // 
            // lbl_gecen
            // 
            lbl_gecen.AutoSize = true;
            lbl_gecen.Location = new System.Drawing.Point(148, 80);
            lbl_gecen.Name = "lbl_gecen";
            lbl_gecen.Size = new System.Drawing.Size(34, 24);
            lbl_gecen.TabIndex = 6;
            lbl_gecen.Text = "00";
            // 
            // lbl_ortalama
            // 
            lbl_ortalama.AutoSize = true;
            lbl_ortalama.Location = new System.Drawing.Point(186, 35);
            lbl_ortalama.Name = "lbl_ortalama";
            lbl_ortalama.Size = new System.Drawing.Size(34, 24);
            lbl_ortalama.TabIndex = 5;
            lbl_ortalama.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 120);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(130, 24);
            label6.TabIndex = 4;
            label6.Text = "Kalan Sayısı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(13, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(134, 24);
            label7.TabIndex = 2;
            label7.Text = "Geçen Sayısı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 36);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(167, 24);
            label8.TabIndex = 0;
            label8.Text = "Sınıf Ortalaması :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new System.Drawing.Point(18, 229);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(959, 264);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(953, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // studentsBindingSource
            // 
            studentsBindingSource.DataSource = typeof(Entities.Students);
            // 
            // studentsContextBindingSource
            // 
            studentsContextBindingSource.DataSource = typeof(DataAccess.StudentsContext);
            // 
            // studentsDalBindingSource
            // 
            studentsDalBindingSource.DataSource = typeof(DataAccess.StudentsDal);
            // 
            // initialCreateBindingSource
            // 
            initialCreateBindingSource.DataSource = typeof(Migrations.initialCreate);
            // 
            // studentsContextBindingSource1
            // 
            studentsContextBindingSource1.DataSource = typeof(DataAccess.StudentsContext);
            // 
            // studentsContextBindingSource2
            // 
            studentsContextBindingSource2.DataSource = typeof(DataAccess.StudentsContext);
            // 
            // studentsDalBindingSource1
            // 
            studentsDalBindingSource1.DataSource = typeof(DataAccess.StudentsDal);
            // 
            // btn_delete
            // 
            btn_delete.Location = new System.Drawing.Point(661, 181);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(313, 42);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Seçili Öğrenciyi Sil";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // OgretmenDetay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(989, 505);
            Controls.Add(btn_delete);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "OgretmenDetay";
            Text = "OgretmenDetay";
            Load += OgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsDalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsContextBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsDalBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox tbx_soyad;
        private System.Windows.Forms.TextBox tbx_ad;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbx_numara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.TextBox tbx_sinav3;
        private System.Windows.Forms.TextBox tbx_sinav2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_kalan;
        private System.Windows.Forms.Label lbl_gecen;
        private System.Windows.Forms.Label lbl_ortalama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource studentsContextBindingSource;
        private System.Windows.Forms.BindingSource studentsDalBindingSource;
        private System.Windows.Forms.BindingSource initialCreateBindingSource;
        private System.Windows.Forms.BindingSource studentsContextBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentsContextBindingSource2;
        private System.Windows.Forms.BindingSource studentsDalBindingSource1;
        private System.Windows.Forms.TextBox tbx_sinav1;
        private System.Windows.Forms.Button btn_delete;
    }
}