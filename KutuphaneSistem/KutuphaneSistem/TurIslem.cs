using KutuphaneSistem.db;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneSistem
{

    public partial class TurIslem : Form
    {
        libraryDBEntities db = new libraryDBEntities();
        static int secilen_id = 0;

        public TurIslem()
        {
            InitializeComponent();
        }

        private void TurIslem_Load(object sender, EventArgs e)
        {
            TurDoldur();

            this.dataGridTur.Columns["tur_no"].Visible = false;
            
            dataGridTur.Columns["tur_ad"].HeaderText = "Tür Adı";

            dataGridTur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTur.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridTur.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void TurDoldur()
        {
            var turler = db.TUR.ToList();

            dataGridTur.DataSource = turler;

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



        private void btnTurKaydet_Click(object sender, EventArgs e)
        {
           TUR temp = new TUR();
                temp.tur_ad = txtTurAd.Text.Trim();
                txtTurAd.Text = " ";


                db.TUR.Add(temp);
                db.SaveChanges();
                TurDoldur();

            
        }

        private void btnTurSilme_Click(object sender, EventArgs e)
        {
            if (secilen_id > 0)
            {
                TUR temp = db.TUR.Where(a => a.tur_no == secilen_id).FirstOrDefault();
                db.TUR.Remove(temp);
                txtTurAd.Text = "";
                db.SaveChanges();
                TurDoldur();
            }
        }

        private void btnTurGuncelleme_Click(object sender, EventArgs e)
        {
            TUR temp = db.TUR.Where(a => a.tur_no == secilen_id).FirstOrDefault();
            temp.tur_ad = txtTurAd.Text.Trim();
            txtTurAd.Text = "";
            db.SaveChanges();
            TurDoldur();


          



        }

        private void dataGridTur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridTur.Rows[e.RowIndex];
                txtTurAd.Text = row.Cells["tur_ad"].Value.ToString();
                secilen_id = Convert.ToInt32(row.Cells["tur_no"].Value.ToString().Trim());
            }

            
        }
    } 
    
    }

    

