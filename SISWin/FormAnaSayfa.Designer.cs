namespace SISWin
{
    partial class FormAnaSayfa
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
            menuStrip1 = new MenuStrip();
            mniMenu = new ToolStripMenuItem();
            parolaDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            parolaSıfırlaToolStripMenuItem = new ToolStripMenuItem();
            uzmanKaydetToolStripMenuItem = new ToolStripMenuItem();
            sekreterKaydetToolStripMenuItem = new ToolStripMenuItem();
            çalışanAraToolStripMenuItem = new ToolStripMenuItem();
            randevuYönetToolStripMenuItem = new ToolStripMenuItem();
            seansYönetToolStripMenuItem = new ToolStripMenuItem();
            seansYönetToolStripMenuItem1 = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsiKullanici = new ToolStripStatusLabel();
            tsiTarih = new ToolStripStatusLabel();
            tsiSaat = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mniMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(587, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mniMenu
            // 
            mniMenu.DropDownItems.AddRange(new ToolStripItem[] { parolaDeğiştirToolStripMenuItem, parolaSıfırlaToolStripMenuItem, uzmanKaydetToolStripMenuItem, sekreterKaydetToolStripMenuItem, çalışanAraToolStripMenuItem, randevuYönetToolStripMenuItem, seansYönetToolStripMenuItem, seansYönetToolStripMenuItem1, çıkışToolStripMenuItem });
            mniMenu.Name = "mniMenu";
            mniMenu.Size = new Size(50, 20);
            mniMenu.Text = "&Menü";
            // 
            // parolaDeğiştirToolStripMenuItem
            // 
            parolaDeğiştirToolStripMenuItem.Name = "parolaDeğiştirToolStripMenuItem";
            parolaDeğiştirToolStripMenuItem.Size = new Size(180, 22);
            parolaDeğiştirToolStripMenuItem.Text = "Parola &Değiştir";
            // 
            // parolaSıfırlaToolStripMenuItem
            // 
            parolaSıfırlaToolStripMenuItem.Name = "parolaSıfırlaToolStripMenuItem";
            parolaSıfırlaToolStripMenuItem.Size = new Size(180, 22);
            parolaSıfırlaToolStripMenuItem.Text = "Parola Sıfırla";
            // 
            // uzmanKaydetToolStripMenuItem
            // 
            uzmanKaydetToolStripMenuItem.Name = "uzmanKaydetToolStripMenuItem";
            uzmanKaydetToolStripMenuItem.Size = new Size(180, 22);
            uzmanKaydetToolStripMenuItem.Text = "Uzman Kaydet";
            // 
            // sekreterKaydetToolStripMenuItem
            // 
            sekreterKaydetToolStripMenuItem.Name = "sekreterKaydetToolStripMenuItem";
            sekreterKaydetToolStripMenuItem.Size = new Size(180, 22);
            sekreterKaydetToolStripMenuItem.Text = "Sekreter Kaydet";
            // 
            // çalışanAraToolStripMenuItem
            // 
            çalışanAraToolStripMenuItem.Name = "çalışanAraToolStripMenuItem";
            çalışanAraToolStripMenuItem.Size = new Size(180, 22);
            çalışanAraToolStripMenuItem.Text = "Çalışan Ara";
            // 
            // randevuYönetToolStripMenuItem
            // 
            randevuYönetToolStripMenuItem.Name = "randevuYönetToolStripMenuItem";
            randevuYönetToolStripMenuItem.Size = new Size(180, 22);
            randevuYönetToolStripMenuItem.Text = "Randevu Yönet";
            // 
            // seansYönetToolStripMenuItem
            // 
            seansYönetToolStripMenuItem.Name = "seansYönetToolStripMenuItem";
            seansYönetToolStripMenuItem.Size = new Size(180, 22);
            seansYönetToolStripMenuItem.Text = "Seans Yönet";
            // 
            // seansYönetToolStripMenuItem1
            // 
            seansYönetToolStripMenuItem1.Name = "seansYönetToolStripMenuItem1";
            seansYönetToolStripMenuItem1.Size = new Size(180, 22);
            seansYönetToolStripMenuItem1.Text = "Seans Yönet";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(180, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsiKullanici, tsiTarih, tsiSaat });
            statusStrip1.Location = new Point(0, 537);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(587, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsiKullanici
            // 
            tsiKullanici.Name = "tsiKullanici";
            tsiKullanici.Size = new Size(269, 17);
            tsiKullanici.Spring = true;
            tsiKullanici.Text = "Abreg Kaplan (Sistem Yöneticisi)";
            // 
            // tsiTarih
            // 
            tsiTarih.Name = "tsiTarih";
            tsiTarih.Size = new Size(269, 17);
            tsiTarih.Spring = true;
            tsiTarih.Text = "23 Ocak 2024, Salı";
            // 
            // tsiSaat
            // 
            tsiSaat.Name = "tsiSaat";
            tsiSaat.Size = new Size(34, 17);
            tsiSaat.Text = "17:55";
            // 
            // FormAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FwcaCKFXsAIVEly;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(587, 559);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAnaSayfa";
            Load += FormAnaSayfa_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mniMenu;
        private ToolStripMenuItem parolaDeğiştirToolStripMenuItem;
        private ToolStripMenuItem parolaSıfırlaToolStripMenuItem;
        private ToolStripMenuItem uzmanKaydetToolStripMenuItem;
        private ToolStripMenuItem sekreterKaydetToolStripMenuItem;
        private ToolStripMenuItem çalışanAraToolStripMenuItem;
        private ToolStripMenuItem randevuYönetToolStripMenuItem;
        private ToolStripMenuItem seansYönetToolStripMenuItem;
        private ToolStripMenuItem seansYönetToolStripMenuItem1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsiKullanici;
        private ToolStripStatusLabel tsiTarih;
        private ToolStripStatusLabel tsiSaat;
    }
}