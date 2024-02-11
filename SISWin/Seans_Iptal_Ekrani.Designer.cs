namespace SISWin
{
    partial class Seans_Iptal_Ekrani
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
            lblSeans = new Label();
            label5 = new Label();
            lblUzman = new Label();
            textBox1 = new TextBox();
            btnIptal = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Uzman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Seans:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 114);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "İptal Nedeni:";
            // 
            // lblSeans
            // 
            lblSeans.BorderStyle = BorderStyle.FixedSingle;
            lblSeans.Location = new Point(278, 60);
            lblSeans.Name = "lblSeans";
            lblSeans.Size = new Size(247, 23);
            lblSeans.TabIndex = 4;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(226, 95);
            label5.Name = "label5";
            label5.Size = new Size(300, 2);
            label5.TabIndex = 5;
            // 
            // lblUzman
            // 
            lblUzman.BorderStyle = BorderStyle.FixedSingle;
            lblUzman.Location = new Point(279, 23);
            lblUzman.Name = "lblUzman";
            lblUzman.Size = new Size(247, 23);
            lblUzman.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 114);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 107);
            textBox1.TabIndex = 7;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(450, 227);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İptal Et";
            btnIptal.UseVisualStyleBackColor = true;
            // 
            // Seans_Iptal_Ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 278);
            Controls.Add(btnIptal);
            Controls.Add(textBox1);
            Controls.Add(lblUzman);
            Controls.Add(label5);
            Controls.Add(lblSeans);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Seans_Iptal_Ekrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seans İptal Et";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSeans;
        private Label label5;
        private Label lblUzman;
        private TextBox textBox1;
        private Button btnIptal;
    }
}