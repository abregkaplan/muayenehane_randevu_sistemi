namespace SISWin
{
    partial class HastaBilgisi
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtKimlikNo = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEPosta = new TextBox();
            txtTelefon = new TextBox();
            txtGsmNo = new TextBox();
            txtAdres = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            ccbCinsiyet = new ComboBox();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(259, 70);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(259, 108);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 145);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 4;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 180);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Cinsiyeti:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 214);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "EPosta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 251);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 7;
            label7.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(259, 287);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 8;
            label8.Text = "GSM No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 319);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 9;
            label9.Text = "Adres:";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(10, 387);
            label10.Name = "label10";
            label10.Size = new Size(587, 2);
            label10.TabIndex = 10;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(343, 30);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(131, 23);
            txtKimlikNo.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(343, 67);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(131, 23);
            txtAd.TabIndex = 12;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(342, 105);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(132, 23);
            txtSoyad.TabIndex = 13;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(342, 211);
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(132, 23);
            txtEPosta.TabIndex = 14;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(342, 248);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(132, 23);
            txtTelefon.TabIndex = 15;
            // 
            // txtGsmNo
            // 
            txtGsmNo.Location = new Point(342, 284);
            txtGsmNo.Name = "txtGsmNo";
            txtGsmNo.Size = new Size(132, 23);
            txtGsmNo.TabIndex = 16;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(342, 316);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(255, 68);
            txtAdres.TabIndex = 17;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(343, 145);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(131, 23);
            dtpDogumTarihi.TabIndex = 18;
            // 
            // ccbCinsiyet
            // 
            ccbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            ccbCinsiyet.FormattingEnabled = true;
            ccbCinsiyet.Items.AddRange(new object[] { "E", "K" });
            ccbCinsiyet.Location = new Point(342, 180);
            ccbCinsiyet.Name = "ccbCinsiyet";
            ccbCinsiyet.Size = new Size(48, 23);
            ccbCinsiyet.TabIndex = 19;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(522, 392);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // HastaBilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 446);
            Controls.Add(btnKaydet);
            Controls.Add(ccbCinsiyet);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtAdres);
            Controls.Add(txtGsmNo);
            Controls.Add(txtTelefon);
            Controls.Add(txtEPosta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtKimlikNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "HastaBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaBilgisi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtKimlikNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEPosta;
        private TextBox txtTelefon;
        private TextBox txtGsmNo;
        private TextBox txtAdres;
        private DateTimePicker dtpDogumTarihi;
        private ComboBox ccbCinsiyet;
        private Button btnKaydet;
    }
}