using System;
using System.Windows.Forms;

namespace GameRank
{
    public partial class hakkimizda : Form
    {
        // Constructor - Form ilk açıldığında bileşenleri başlatır
        public hakkimizda()
        {
            InitializeComponent();
        }

        // Oyunlar menüsüne tıklandığında oyun formunu açar
        private void oyunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oyunformu oyunFormu = new oyunformu();
            oyunFormu.Show();
        }

        // Hakkımızda menüsüne tıklanınca yeni hakkimizda formu açar (aynı formdan)
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkimizda hakkimizda = new hakkimizda();
            hakkimizda.Show();
        }

        // İletişim menüsüne tıklandığında iletişim formunu açar
        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletişim iletişim = new iletişim();
            iletişim.Show();
        }

        // Ana Sayfa menüsüne tıklandığında bu formu kapatır
        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form açılırken yapılacak işlemler (şu an boş)
        private void hakkimizda_Load(object sender, EventArgs e)
        {

        }
    }
}
