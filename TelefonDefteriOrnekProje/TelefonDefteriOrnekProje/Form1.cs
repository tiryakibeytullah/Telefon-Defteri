using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonDefteriOrnekProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.VerileriYükle();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayıt frm = new frmYeniKayıt();
            DialogResult sonuc= frm.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                Kisi yeniKisi = frm.YeniKisi;

                DataTable dt = this.dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr[0] = yeniKisi.Id;
                dr[1] = yeniKisi.Ad;
                dr[2] = yeniKisi.Soyad;
                dr[3] = yeniKisi.TelefonNo;

                dt.Rows.Add(dr);
            }
            this.KayitSayisiHesaplama();
            this.lblSonIslemBilgi.Text = "Yeni Kayıt Eklendi";

        }      

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.CurrentRow != null) // DataGridWiev üzerinde seçili bir satır var ise;
            {
                frmDuzenle frm = new frmDuzenle();
                frm.GuncellenecekKisi = new Kisi();
                frm.GuncellenecekKisi.Ad = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.GuncellenecekKisi.Soyad = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.GuncellenecekKisi.TelefonNo = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                DialogResult sonuc = frm.ShowDialog();

                if(sonuc == DialogResult.OK)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;//Seçili olan satır yakalanır.
                    DataRow dr = drv.Row;
                    //Daha sonrasında güncellenir.
                    dr[1] = frm.GuncellenecekKisi.Ad;
                    dr[2] = frm.GuncellenecekKisi.Soyad;
                    dr[3] = frm.GuncellenecekKisi.TelefonNo;
                }
            }
            this.lblSonIslemBilgi.Text = "Kayıt Düzenlendi İşlemi Yapıldı";
        }

        private void btnKayitSilme_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz ?", "Kayıt Silme İşlemi",
                MessageBoxButtons.YesNoCancel);

                if (sonuc == DialogResult.Yes)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;//Seçili olan satır yakalanır.
                    DataRow dr = drv.Row;

                    dr.Delete();
                }
            }
            this.KayitSayisiHesaplama();
            this.lblSonIslemBilgi.Text = "Kayıt Silme İşlemi Yapıldı";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ds.WriteXml(Application.StartupPath + "\\" + "data.xml",XmlWriteMode.WriteSchema);
            this.lblSonIslemBilgi.Text = "Veriler Kayıt Edildi";
        }
     
        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            this.lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuYenileme_Click(object sender, EventArgs e)
        {
            this.VerileriYükle();
            this.lblSonIslemBilgi.Text = "Veriler Yenilendi";
        }

        private void menuCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuProgramBilgi_Click(object sender, EventArgs e)
        {
            frmHakkinda frm = new frmHakkinda();
            frm.ShowDialog();
        }
        private void VerileriYükle()
        {
            ds.Tables.Clear();
            ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);

            if (ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            this.KayitSayisiHesaplama();
            this.lblSonIslemBilgi.Text = "Veriler Yüklendi";
        }

        private void KayitSayisiHesaplama()
        {
            this.lblKayitSayisi.Text = "Kayıt Sayısı : " + this.dataGridView1.RowCount.ToString();
        }

        
    }
}
