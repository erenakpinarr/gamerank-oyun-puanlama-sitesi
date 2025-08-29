using System;
using System.Windows.Forms;

namespace GameRank
{
    public partial class oyunformu : Form
    {
        // Constructor - Form ilk oluşturulduğunda çağrılır
        public oyunformu()
        {
            InitializeComponent(); // Form elemanlarını başlatır
        }

        // Ana Sayfa menüsüne tıklandığında formu kapatır
        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Oyunlar menüsüne tıklandığında aynı formdan yeni bir örnek açar
        private void oyunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oyunformu oyunFormu = new oyunformu();
            oyunFormu.Show();
        }

        // Hakkımızda menüsüne tıklandığında hakkimizda formunu açar
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

        // Aşağıdaki buton click olayları ilgili oyun formlarını açar
        private void buttonacshadows_Click(object sender, EventArgs e)
        {
            acshadows acshadows = new acshadows();
            acshadows.Show();
        }

        private void buttoncod6_Click(object sender, EventArgs e)
        {
            cod6 cod6 = new cod6();
            cod6.Show();
        }

        private void buttongow_Click(object sender, EventArgs e)
        {
            gow gow = new gow();
            gow.Show();
        }

        private void buttoncyberpunk_Click(object sender, EventArgs e)
        {
            cyberpunk cyberpunk = new cyberpunk();
            cyberpunk.Show();
        }

        private void buttoneldenring_Click(object sender, EventArgs e)
        {
            eldenring eldenring = new eldenring();
            eldenring.Show();
        }

        private void buttonwitcher3_Click(object sender, EventArgs e)
        {
            witcher3 witcher3 = new witcher3();
            witcher3.Show();
        }

       
        private void oyunformu_Load(object sender, EventArgs e)
        {
            richTextBoxeldenring.ReadOnly = true;
            richTextBoxacshadows.ReadOnly = true;
            richTextBoxcops6.ReadOnly = true;
            richTextBoxgow.ReadOnly = true;
            richTextBoxcyberpunk.ReadOnly = true;
            richTextBoxwitcher3.ReadOnly = true;
        }
    }
}
