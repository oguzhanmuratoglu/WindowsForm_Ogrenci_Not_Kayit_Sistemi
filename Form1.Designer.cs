namespace Ogrenci_Not_Kayit_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            button1 = new System.Windows.Forms.Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btn_admingiris = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 24);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ NUMARASI";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new System.Drawing.Point(231, 128);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(125, 30);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(9, 191);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(347, 39);
            button1.TabIndex = 2;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(388, 423);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Giriş";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_admingiris);
            groupBox2.Location = new System.Drawing.Point(476, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(388, 423);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Admin Giriş";
            // 
            // btn_admingiris
            // 
            btn_admingiris.Location = new System.Drawing.Point(77, 159);
            btn_admingiris.Name = "btn_admingiris";
            btn_admingiris.Size = new System.Drawing.Size(248, 102);
            btn_admingiris.TabIndex = 2;
            btn_admingiris.Text = "GİRİŞ YAP";
            btn_admingiris.UseVisualStyleBackColor = true;
            btn_admingiris.Click += btn_admingiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(878, 447);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Öğrenci Not Kayıt Sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btn_admingiris;
        private System.Windows.Forms.Label label2;
    }
}
