namespace SISWin
{
    partial class Yeni_Seans_Kayit_Ekrani
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
            dtpTarih = new DateTimePicker();
            dtpBaslangicSaati = new DateTimePicker();
            dtpBitisSaati = new DateTimePicker();
            btnKaydet = new Button();
            lblUzman1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 41);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Uzman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 85);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 122);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "Başlangıç Saati:";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(241, 197);
            label4.Name = "label4";
            label4.Size = new Size(290, 2);
            label4.TabIndex = 4;
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(332, 79);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(98, 23);
            dtpTarih.TabIndex = 7;
            // 
            // dtpBaslangicSaati
            // 
            dtpBaslangicSaati.CustomFormat = "HH:mm";
            dtpBaslangicSaati.Format = DateTimePickerFormat.Custom;
            dtpBaslangicSaati.Location = new Point(332, 117);
            dtpBaslangicSaati.Name = "dtpBaslangicSaati";
            dtpBaslangicSaati.Size = new Size(65, 23);
            dtpBaslangicSaati.TabIndex = 8;
            // 
            // dtpBitisSaati
            // 
            dtpBitisSaati.CustomFormat = "HH:mm";
            dtpBitisSaati.Format = DateTimePickerFormat.Custom;
            dtpBitisSaati.Location = new Point(332, 154);
            dtpBitisSaati.Name = "dtpBitisSaati";
            dtpBitisSaati.Size = new Size(65, 23);
            dtpBitisSaati.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(445, 216);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lblUzman1
            // 
            lblUzman1.BorderStyle = BorderStyle.FixedSingle;
            lblUzman1.Location = new Point(332, 40);
            lblUzman1.Name = "lblUzman1";
            lblUzman1.Size = new Size(200, 23);
            lblUzman1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 160);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Bitiş Saati:";
            // 
            // Yeni_Seans_Kayit_Ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 293);
            Controls.Add(label5);
            Controls.Add(lblUzman1);
            Controls.Add(btnKaydet);
            Controls.Add(dtpBitisSaati);
            Controls.Add(dtpBaslangicSaati);
            Controls.Add(dtpTarih);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Yeni_Seans_Kayit_Ekrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Seans Kayıt";
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
        private DateTimePicker dtpTarih;
        private DateTimePicker dtpBaslangicSaati;
        private DateTimePicker dtpBitisSaati;
        private Button btnKaydet;
        private Label lblUzman1;
        private Label label5;
    }
}