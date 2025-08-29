using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameRank
{
    public partial class cod6 : Form
    {
        // Yorumların saklandığı dosya yolu
        string dosyaYolu = Path.Combine(Application.StartupPath, "cod6yorumlar.txt");

        // Puanları tutacak liste
        List<int> oylar = new List<int>();

        public cod6()
        {
            InitializeComponent();
        }

        private void cod6_Load(object sender, EventArgs e)
        {
            // 1-10 arası puanları comboBox'a ekle
            for (int i = 1; i <= 10; i++)
                cod6puanlama.Items.Add(i);
            cod6puanlama.SelectedIndex = 0;

            // Daha önce kayıtlı yorumları ve puanları yükle
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                foreach (var satir in satirlar)
                {
                    lstyorumlargow.Items.Add(satir);

                    // "⭐ Puan: x/10" formatındaki puanı çek
                    var match = Regex.Match(satir, @"Puan: (\d+)/10");
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int puan))
                        oylar.Add(puan);
                    cod6aciklama.ReadOnly = true;
                }
            }

            // Ortalama puanı göster
            lblortalamacod6.Text = oylar.Count > 0
                ? $"Ortalama Puan: {oylar.Average():0.00}"
                : "Ortalama Puan: 0";
        }

        private void cod6oyverme_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadicod6.Text.Trim();
            string yorum = cod6yorum.Text.Trim();

            // Puan kontrolü
            if (cod6puanlama.SelectedItem == null ||
                !int.TryParse(cod6puanlama.SelectedItem.ToString(), out int puan))
            {
                MessageBox.Show("Lütfen puan seçin.");
                return;
            }

            // Kullanıcı adı kontrolü
            if (string.IsNullOrWhiteSpace(kullanici))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yorum kontrolü
            if (string.IsNullOrWhiteSpace(yorum))
            {
                MessageBox.Show("Yorum boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Puanı listeye ekle, ortalamayı güncelle
            oylar.Add(puan);
            lblortalamacod6.Text = $"Ortalama Puan: {oylar.Average():0.00}";

            // Yeni yorum formatı
            string yeniYorum = $"👤 {kullanici} | \"{yorum}\" | ⭐ Puan: {puan}/10";

            // Listeye ekle ve dosyaya yaz
            lstyorumlargow.Items.Add(yeniYorum);
            File.WriteAllLines(dosyaYolu, lstyorumlargow.Items.Cast<string>());

            MessageBox.Show("Oy gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Alanları temizle
            kullaniciadicod6.Clear();
            cod6yorum.Clear();
            cod6puanlama.SelectedIndex = 0;
        }

        // Menü işlemleri
        private void anaSayfaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat
        }

        private void oyunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new oyunformu().Show(); // Oyun formunu aç
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new hakkimizda().Show(); // Hakkımızda formunu aç
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new iletişim().Show(); // İletişim formunu aç
        }
    }
}
