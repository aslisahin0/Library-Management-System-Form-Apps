using KutuphaneSistem.db;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneSistem
{


    public partial class OgrenciIslem : Form
    {

        libraryDBEntities db = new libraryDBEntities();
        static int secilen_id =0 ;
        public OgrenciIslem()
        {
            InitializeComponent();
        }

        private void OgrenciIslem_Load(object sender, EventArgs e)
        {
            OgrenciDoldur();

            
            dataGridOgrenci.Columns["ogr_ad"].HeaderText = "Öğrenci Adı";
            dataGridOgrenci.Columns["ogr_soyad"].HeaderText = "Öğrenci Soyadı";
            dataGridOgrenci.Columns["ogr_no"].HeaderText = "Okul Numarası";

            dataGridOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOgrenci.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridOgrenci.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void OgrenciDoldur()
        {
            var ogrenciler = db.OGRENCI.ToList();

            dataGridOgrenci.DataSource = ogrenciler;

        }
        private void btnKitap_Click(object sender, EventArgs e)
        {
            KitapIslem formKitap = new KitapIslem();
            formKitap.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciIslem formOgrenci = new OgrenciIslem();
            formOgrenci.Show();
            this.Hide();
        }

        private void btnBilgiIslem_Click(object sender, EventArgs e)
        {
            BilgiIslem formBilgiIslem = new BilgiIslem();
            formBilgiIslem.Show();
            this.Hide();
        }

        private void btnYazar_Click(object sender, EventArgs e)
        {
            YazarIslem formYazarIslem = new YazarIslem();
            formYazarIslem.Show();
            this.Hide();

        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            TurIslem formTurIslem = new TurIslem();
            formTurIslem.Show();
            this.Hide();
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            OGRENCI temp = new OGRENCI();
            temp.ogr_ad = txtOgrAd.Text.Trim();
            temp.ogr_soyad = txtOgrSoyad.Text.Trim();
           // temp.ogr_no = Convert.ToInt32(txtOkulNo.Text.Trim());
          
            txtOgrSoyad.Text = txtOgrAd.Text = "";

            OgrenciDoldur();
            db.OGRENCI.Add(temp);
            db.SaveChanges();

        }

        private void btnOgrSilme_Click(object sender, EventArgs e)
        {
            if (secilen_id > 0)
            {
                OGRENCI temp = db.OGRENCI.Where(a => a.ogr_no == secilen_id).FirstOrDefault();
                txtOgrAd.Text = txtOgrSoyad.Text =  "";

                db.OGRENCI.Remove(temp); 
                db.SaveChanges();
                OgrenciDoldur();
            }
        }

        private void btnOgrGuncelleme_Click(object sender, EventArgs e)
        {
            OGRENCI temp = db.OGRENCI.Where(a => a.ogr_no == secilen_id).FirstOrDefault();
            temp.ogr_ad = txtOgrAd.Text.Trim();
            temp.ogr_soyad = txtOgrSoyad.Text.Trim();
           // temp.ogr_no = Convert.ToInt32(txtOkulNo.Text.Trim());
            txtOgrAd.Text = txtOgrSoyad.Text = "";

            OgrenciDoldur();
            db.SaveChanges();
        }
        private void dataGridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridOgrenci.Rows[e.RowIndex];
                txtOgrAd.Text = row.Cells["ogr_ad"].Value.ToString();
                txtOgrSoyad.Text = row.Cells["ogr_soyad"].Value.ToString();
                //txtOkulNo.Text = row.Cells["ogr_no"].Value.ToString();
            }
        }

     
        
    }

}

