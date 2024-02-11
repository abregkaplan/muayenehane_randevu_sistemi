namespace SISWin
{
    partial class FormSekreterBilgisi
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
            txtKimlikNo = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEPosta = new TextBox();
            txtTelefon = new TextBox();
            txtGsmNo = new TextBox();
            btnKaydet = new Button();
            lblAyrac = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(293, 34);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(141, 23);
            txtKimlikNo.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(293, 79);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(141, 23);
            txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(293, 122);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(141, 23);
            txtSoyad.TabIndex = 9;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(293, 164);
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(141, 23);
            txtEPosta.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(293, 209);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(141, 23);
            txtTelefon.TabIndex = 11;
            // 
            // txtGsmNo
            // 
            txtGsmNo.Location = new Point(293, 242);
            txtGsmNo.Name = "txtGsmNo";
            txtGsmNo.Size = new Size(141, 23);
            txtGsmNo.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(318, 291);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(209, 277);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(260, 2);
            lblAyrac.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 37);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 82);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 125);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(209, 167);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "E-Posta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 212);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefon No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 245);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 6;
            label6.Text = "GSM No:";
            // 
            // FormSekreterBilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 360);
            Controls.Add(lblAyrac);
            Controls.Add(btnKaydet);
            Controls.Add(txtGsmNo);
            Controls.Add(txtTelefon);
            Controls.Add(txtEPosta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtKimlikNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSekreterBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sekreter Kayıt ve Güncelleme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtKimlikNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEPosta;
        private TextBox txtTelefon;
        private TextBox txtGsmNo;
        private Button btnKaydet;
        private Label lblAyrac;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}