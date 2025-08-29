using System;
using System.Windows.Forms;

namespace GameRank
{
    public partial class gamerankanasayfa : Form
    {
        public gamerankanasayfa()
        {
            InitializeComponent(); // Formun kontrollerini başlatır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void oyunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oyunlar formunu açar
            new oyunformu().Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hakkımızda formunu açar
            new hakkimizda().Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // İletişim formunu açar
            new iletişim().Show();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ana sayfaya özel işlem yok (boş bırakılmış)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Assassin’s Creed: Shadows oyun formunu açar
            new acshadows().Show();
        }

        private void pictureanamenüoyun2_Click(object sender, EventArgs e)
        {
            // Cyberpunk oyun formunu açar
            new cyberpunk().Show();
        }

        private void pictureanamenüoyun3_Click(object sender, EventArgs e)
        {
            // God of War oyun formunu açar
            new gow().Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Elden Ring oyun formunu açar
            new eldenring().Show();
        }

        private void pictureanamenüoyun5_Click(object sender, EventArgs e)
        {
            // Call of Duty 6 oyun formunu açar
            new cod6().Show();
        }
    }
}
