using KutuphaneSistem.db;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneSistem
{
    public partial class YazarIslem : Form
    {
        libraryDBEntities db = new libraryDBEntities();
        static int secilen_id = 0;
        public YazarIslem()
        {
            InitializeComponent();
        }


        private void YazarIslem_Load(object sender, EventArgs e)
        {
            YazarDoldur();
            this.dataGridYazar.Columns["yazar_no"].Visible = false;
            
            dataGridYazar.Columns["yazar_ad"].HeaderText = "Yazar Adı";
            dataGridYazar.Columns["yazar_soyad"].HeaderText = "Yazar Soyadı";

            dataGridYazar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridYazar.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridYazar.DefaultCellStyle.SelectionForeColor = Color.White;
        }


        private void YazarDoldur()
        {
            var yazarlar = db.YAZAR.ToList();
            dataGridYazar.DataSource = yazarlar;

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

        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            YAZAR temp = new YAZAR();
            temp.yazar_ad = txtYazarAd.Text.Trim();
            temp.yazar_soyad = txtYazarSoyad.Text.Trim();
            txtYazarAd.Text = txtYazarSoyad.Text = " ";

            db.YAZAR.Add(temp);
            db.SaveChanges();
            YazarDoldur();
        }

        private void btnYazarSilme_Click(object sender, EventArgs e)
        {
            if (secilen_id > 0)
            {
                YAZAR temp = db.YAZAR.Where(a => a.yazar_no == secilen_id).FirstOrDefault();
                db.YAZAR.Remove(temp);
                txtYazarAd.Text = txtYazarSoyad.Text = "";
                db.SaveChanges();
                YazarDoldur();
            }
        }

        private void btnYazarGuncelleme_Click(object sender, EventArgs e)
        {
            YAZAR temp = db.YAZAR.Where(a => a.yazar_no == secilen_id).FirstOrDefault();
            temp.yazar_ad = txtYazarAd.Text.Trim();
            temp.yazar_soyad = txtYazarSoyad.Text.Trim();

            txtYazarAd.Text = txtYazarSoyad.Text = "";
            db.SaveChanges();
            YazarDoldur();
        }

        private void dataGridYazar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridYazar.Rows[e.RowIndex];
                txtYazarAd.Text = row.Cells["yazar_ad"].Value.ToString();
                txtYazarSoyad.Text = row.Cells["yazar_soyad"].Value.ToString();
                secilen_id = Convert.ToInt32(row.Cells["yazar_no"].Value.ToString().Trim());
            }

           

        }

        private void dataGridYazar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridYazar.Rows[e.RowIndex];
                    txtYazarAd.Text = row.Cells["yazar_ad"].Value.ToString();
                    txtYazarSoyad.Text = row.Cells["yazar_soyad"].Value.ToString();
                    secilen_id = Convert.ToInt32(row.Cells["yazar_no"].Value.ToString().Trim());
                }


            

        }
    }
}
