namespace SISWin
{
    partial class FormCalisanAra
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            IstCalisanlar = new ListBox();
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(28, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 47);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 176);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Çalışanlar";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(231, 161);
            label4.Name = "label4";
            label4.Size = new Size(280, 2);
            label4.TabIndex = 4;
            label4.Text = "Çalışanlar";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(309, 44);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(114, 23);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(309, 87);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(114, 23);
            txtSoyad.TabIndex = 6;
            // 
            // IstCalisanlar
            // 
            IstCalisanlar.FormattingEnabled = true;
            IstCalisanlar.ItemHeight = 15;
            IstCalisanlar.Location = new Point(233, 192);
            IstCalisanlar.Name = "IstCalisanlar";
            IstCalisanlar.ScrollAlwaysVisible = true;
            IstCalisanlar.Size = new Size(273, 154);
            IstCalisanlar.TabIndex = 7;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(338, 129);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 8;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // FormCalisanAra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 362);
            Controls.Add(btnAra);
            Controls.Add(IstCalisanlar);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCalisanAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalışan Ara";
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
        private TextBox txtAd;
        private TextBox txtSoyad;
        private ListBox IstCalisanlar;
        private Button btnAra;
    }
}