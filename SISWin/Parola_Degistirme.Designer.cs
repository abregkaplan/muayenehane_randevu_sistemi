namespace SISWin
{
    partial class Parola_Degistirme
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
            txtEski = new TextBox();
            txtYeni = new TextBox();
            txtYeni2 = new TextBox();
            btnDegistir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(226, 50);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Eski Parola:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(224, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Yeni Parola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(185, 134);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 3;
            label3.Text = "Yeni Parola(Tekrar):";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(185, 185);
            label4.Name = "label4";
            label4.Size = new Size(290, 2);
            label4.TabIndex = 4;
            // 
            // txtEski
            // 
            txtEski.Location = new Point(305, 50);
            txtEski.Name = "txtEski";
            txtEski.PasswordChar = '*';
            txtEski.Size = new Size(136, 23);
            txtEski.TabIndex = 5;
            // 
            // txtYeni
            // 
            txtYeni.Location = new Point(305, 96);
            txtYeni.Name = "txtYeni";
            txtYeni.PasswordChar = '*';
            txtYeni.Size = new Size(136, 23);
            txtYeni.TabIndex = 6;
            // 
            // txtYeni2
            // 
            txtYeni2.Location = new Point(305, 134);
            txtYeni2.Name = "txtYeni2";
            txtYeni2.PasswordChar = '*';
            txtYeni2.Size = new Size(136, 23);
            txtYeni2.TabIndex = 7;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(353, 202);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(88, 31);
            btnDegistir.TabIndex = 8;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            // 
            // Parola_Degistirme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 287);
            Controls.Add(btnDegistir);
            Controls.Add(txtYeni2);
            Controls.Add(txtYeni);
            Controls.Add(txtEski);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Parola_Degistirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parola Degistirme";
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
        private TextBox txtEski;
        private TextBox txtYeni;
        private TextBox txtYeni2;
        private Button btnDegistir;
    }
}