namespace SISWin
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnGir = new Button();
            txtKullanici = new TextBox();
            txtParola = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 71);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı:";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 109);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Parola:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FubRsR2XsAI0zqO;
            pictureBox1.Location = new Point(30, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnGir
            // 
            btnGir.Location = new Point(265, 159);
            btnGir.Name = "btnGir";
            btnGir.Size = new Size(82, 23);
            btnGir.TabIndex = 3;
            btnGir.Text = "Gir";
            btnGir.UseVisualStyleBackColor = true;
            // 
            // txtKullanici
            // 
            txtKullanici.ForeColor = SystemColors.WindowText;
            txtKullanici.Location = new Point(209, 68);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(148, 23);
            txtKullanici.TabIndex = 4;
            txtKullanici.Text = "abc\r\n";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(209, 109);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(148, 23);
            txtParola.TabIndex = 5;
            txtParola.Text = "111";
            txtParola.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 275);
            Controls.Add(txtParola);
            Controls.Add(txtKullanici);
            Controls.Add(btnGir);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnGir;
        private TextBox txtKullanici;
        private TextBox txtParola;
    }
}
