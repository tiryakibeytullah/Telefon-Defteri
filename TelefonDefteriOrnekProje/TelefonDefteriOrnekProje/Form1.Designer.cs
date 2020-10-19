namespace TelefonDefteriOrnekProje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKayitDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKayitSilme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuYenileme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProgramBilgi = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblKayitSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSonIslemBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.btnKayitDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnKayitSilme = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuIslem,
            this.menuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKaydet,
            this.toolStripMenuItem5,
            this.menuCıkıs});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuCıkıs
            // 
            this.menuCıkıs.Name = "menuCıkıs";
            this.menuCıkıs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuCıkıs.Size = new System.Drawing.Size(182, 22);
            this.menuCıkıs.Text = "Çıkış";
            this.menuCıkıs.Click += new System.EventHandler(this.menuCıkıs_Click);
            // 
            // menuDuzen
            // 
            this.menuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKes,
            this.menuKopyala,
            this.toolStripMenuItem2,
            this.menuYapistir});
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(52, 20);
            this.menuDuzen.Text = "Düzen";
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(158, 22);
            this.menuKes.Text = "Kes";
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopyala.Size = new System.Drawing.Size(158, 22);
            this.menuKopyala.Text = "Kopyala";
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(158, 22);
            this.menuYapistir.Text = "Yapıştır";
            // 
            // menuIslem
            // 
            this.menuIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeniKayit,
            this.menuKayitDuzenle,
            this.toolStripMenuItem1,
            this.menuKayitSilme,
            this.toolStripMenuItem3,
            this.menuYenileme});
            this.menuIslem.Name = "menuIslem";
            this.menuIslem.Size = new System.Drawing.Size(47, 20);
            this.menuIslem.Text = "İşlem";
            // 
            // menuYeniKayit
            // 
            this.menuYeniKayit.Name = "menuYeniKayit";
            this.menuYeniKayit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuYeniKayit.Size = new System.Drawing.Size(187, 22);
            this.menuYeniKayit.Text = "Yeni Kayıt";
            this.menuYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // menuKayitDuzenle
            // 
            this.menuKayitDuzenle.Name = "menuKayitDuzenle";
            this.menuKayitDuzenle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuKayitDuzenle.Size = new System.Drawing.Size(187, 22);
            this.menuKayitDuzenle.Text = "Kayıt Düzenle";
            this.menuKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
            // 
            // menuKayitSilme
            // 
            this.menuKayitSilme.Name = "menuKayitSilme";
            this.menuKayitSilme.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKayitSilme.Size = new System.Drawing.Size(187, 22);
            this.menuKayitSilme.Text = "Kayıt Silme";
            this.menuKayitSilme.Click += new System.EventHandler(this.btnKayitSilme_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
            // 
            // menuYenileme
            // 
            this.menuYenileme.Name = "menuYenileme";
            this.menuYenileme.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuYenileme.Size = new System.Drawing.Size(187, 22);
            this.menuYenileme.Text = "Yenile";
            this.menuYenileme.Click += new System.EventHandler(this.menuYenileme_Click);
            // 
            // menuHakkinda
            // 
            this.menuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYardim,
            this.toolStripMenuItem4,
            this.menuProgramBilgi});
            this.menuHakkinda.Name = "menuHakkinda";
            this.menuHakkinda.Size = new System.Drawing.Size(69, 20);
            this.menuHakkinda.Text = "Hakkında";
            // 
            // menuYardim
            // 
            this.menuYardim.Name = "menuYardim";
            this.menuYardim.Size = new System.Drawing.Size(146, 22);
            this.menuYardim.Text = "Yardım";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 6);
            // 
            // menuProgramBilgi
            // 
            this.menuProgramBilgi.Name = "menuProgramBilgi";
            this.menuProgramBilgi.Size = new System.Drawing.Size(152, 22);
            this.menuProgramBilgi.Text = "Program Bilgi";
            this.menuProgramBilgi.Click += new System.EventHandler(this.menuProgramBilgi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.lblKayitSayisi,
            this.lblSonIslemBilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblKayitSayisi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(69, 19);
            this.lblKayitSayisi.Text = "Kayıt Sayısı";
            // 
            // lblSonIslemBilgi
            // 
            this.lblSonIslemBilgi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSonIslemBilgi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSonIslemBilgi.Name = "lblSonIslemBilgi";
            this.lblSonIslemBilgi.Size = new System.Drawing.Size(62, 19);
            this.lblSonIslemBilgi.Text = "Son Islem";
            // 
            // lblSaat
            // 
            this.lblSaat.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSaat.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSaat.ForeColor = System.Drawing.Color.Blue;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 19);
            this.lblSaat.Text = "Saat";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKayit,
            this.btnKayitDuzenle,
            this.btnKayitSilme,
            this.toolStripSeparator1,
            this.btnKaydet,
            this.toolStripSeparator,
            this.btnKes,
            this.btnKopyala,
            this.btnYapistir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 308);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(182, 22);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(179, 6);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniKayit.Image = global::TelefonDefteriOrnekProje.Properties.Resources.icon_yeni16;
            this.btnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(23, 22);
            this.btnYeniKayit.Text = "&New";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayitDuzenle.Image = global::TelefonDefteriOrnekProje.Properties.Resources.icon_duzenle16;
            this.btnKayitDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(23, 22);
            this.btnKayitDuzenle.Text = "&Open";
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // btnKayitSilme
            // 
            this.btnKayitSilme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayitSilme.Image = global::TelefonDefteriOrnekProje.Properties.Resources.icon_sil16;
            this.btnKayitSilme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitSilme.Name = "btnKayitSilme";
            this.btnKayitSilme.Size = new System.Drawing.Size(23, 22);
            this.btnKayitSilme.Text = "&Delete";
            this.btnKayitSilme.Click += new System.EventHandler(this.btnKayitSilme_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(23, 22);
            this.btnKaydet.Text = "&Save";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(23, 22);
            this.btnKes.Text = "C&ut";
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(23, 22);
            this.btnKopyala.Text = "&Copy";
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = ((System.Drawing.Image)(resources.GetObject("btnYapistir.Image")));
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(23, 22);
            this.btnYapistir.Text = "&Paste";
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ornek Telefon Rehberi Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuCıkıs;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripMenuItem menuIslem;
        private System.Windows.Forms.ToolStripMenuItem menuYeniKayit;
        private System.Windows.Forms.ToolStripMenuItem menuKayitDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuKayitSilme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuYenileme;
        private System.Windows.Forms.ToolStripMenuItem menuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem menuYardim;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuProgramBilgi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblKayitSayisi;
        private System.Windows.Forms.ToolStripStatusLabel lblSonIslemBilgi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeniKayit;
        private System.Windows.Forms.ToolStripButton btnKayitDuzenle;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnKayitSilme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Timer tmrSaat;
    }
}

