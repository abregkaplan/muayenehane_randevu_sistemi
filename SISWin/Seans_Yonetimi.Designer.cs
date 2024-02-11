namespace SISWin
{
    partial class Seans_Yonetimi
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
            listBox1 = new ListBox();
            lnkSeansEkle = new LinkLabel();
            lnkSeansIptalEt = new LinkLabel();
            cbbUzmanlar = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 325);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Uzman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Seanslar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "lstSeanslar" });
            listBox1.Location = new Point(277, 93);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(471, 244);
            listBox1.TabIndex = 3;
            // 
            // lnkSeansEkle
            // 
            lnkSeansEkle.AutoSize = true;
            lnkSeansEkle.Location = new Point(662, 75);
            lnkSeansEkle.Name = "lnkSeansEkle";
            lnkSeansEkle.Size = new Size(86, 15);
            lnkSeansEkle.TabIndex = 4;
            lnkSeansEkle.TabStop = true;
            lnkSeansEkle.Text = "Yeni Seans Ekle";
            // 
            // lnkSeansIptalEt
            // 
            lnkSeansIptalEt.AutoSize = true;
            lnkSeansIptalEt.Location = new Point(639, 340);
            lnkSeansIptalEt.Name = "lnkSeansIptalEt";
            lnkSeansIptalEt.Size = new Size(109, 15);
            lnkSeansIptalEt.TabIndex = 5;
            lnkSeansIptalEt.TabStop = true;
            lnkSeansIptalEt.Text = "Seçili Seansı İptal Et";
            // 
            // cbbUzmanlar
            // 
            cbbUzmanlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUzmanlar.FormattingEnabled = true;
            cbbUzmanlar.Location = new Point(344, 25);
            cbbUzmanlar.Name = "cbbUzmanlar";
            cbbUzmanlar.Size = new Size(218, 23);
            cbbUzmanlar.TabIndex = 6;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(286, 60);
            label3.Name = "label3";
            label3.Size = new Size(450, 2);
            label3.TabIndex = 7;
            // 
            // Seans_Yonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 381);
            Controls.Add(label3);
            Controls.Add(cbbUzmanlar);
            Controls.Add(lnkSeansIptalEt);
            Controls.Add(lnkSeansEkle);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Seans_Yonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seans Yönetimi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private LinkLabel lnkSeansEkle;
        private LinkLabel lnkSeansIptalEt;
        private ComboBox cbbUzmanlar;
        private Label label3;
    }
}