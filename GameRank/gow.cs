using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameRank
{
    public partial class gow : Form
    {
        string dosyaYolu = Path.Combine(Application.StartupPath, "gowyorumlar.txt");
        List<int> oylar = new List<int>();

        public gow()
        {
            InitializeComponent();
        }

        private void gow_Load(object sender, EventArgs e)
        {
            // Puanlama combobox'una 1-10 arası puanları ekle
            for (int i = 1; i <= 10; i++)
                gowpuanlama.Items.Add(i);

            gowpuanlama.SelectedIndex = 0;

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (var satir in satirlar)
                {
                    lstyorumlargow.Items.Add(satir);

                    // Satırdaki puanı Regex ile bul ve oylar listesine ekle
                    var match = Regex.Match(satir, @"Puan: (\d+)/10");
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int puan))
                        oylar.Add(puan);
                    gowaciklama.ReadOnly = true;
                }
            }

            // Ortalama puanı göster
            lblortalamagow.Text = oylar.Count > 0
                ? $"Ortalama Puan: {oylar.Average():0.00}"
                : "Ortalama Puan: 0";
        }

        private void gowoyverme_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadigow.Text.Trim();
            string yorum = gowyorum.Text.Trim();

            if (gowpuanlama.SelectedItem == null ||
                !int.TryParse(gowpuanlama.SelectedItem.ToString(), out int puan))
            {
                MessageBox.Show("Lütfen puan seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(kullanici))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz. Lütfen kullanıcı adınızı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(yorum))
            {
                MessageBox.Show("Yorum bölümü boş olamaz. Lütfen yorumunuzu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            oylar.Add(puan);
            lblortalamagow.Text = $"Ortalama Puan: {oylar.Average():0.00}";

            MessageBox.Show("Oy gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string yeniYorum = $"👤 {kullanici} | \"{yorum}\" | ⭐ Puan: {puan}/10";

            lstyorumlargow.Items.Add(yeniYorum);

            // Yorumları dosyaya kaydet
            File.WriteAllLines(dosyaYolu, lstyorumlargow.Items.Cast<string>());

            kullaniciadigow.Clear();
            gowyorum.Clear();
            gowpuanlama.SelectedIndex = 0;
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oyunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new oyunformu().Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new hakkimizda().Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new iletişim().Show();
        }
    }
}
