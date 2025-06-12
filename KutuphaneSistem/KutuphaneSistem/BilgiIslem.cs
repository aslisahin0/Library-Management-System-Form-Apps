using KutuphaneSistem.db;
using System;
using System.Windows.Forms;

namespace KutuphaneSistem
{
    public partial class BilgiIslem : Form
    {
        libraryDBEntities db = new libraryDBEntities();
        public BilgiIslem()
        {
            InitializeComponent();
        }

        private void BilgiIslem_Load(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
