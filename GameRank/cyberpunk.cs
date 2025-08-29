using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameRank
{
    public partial class cyberpunk : Form
    {
        string dosyaYolu = Path.Combine(Application.StartupPath, "cyberpunk2077yorumlar.txt");
        List<int> oylar = new List<int>();

        public cyberpunk()
        {
            InitializeComponent();
        }

        private void cyberpunk_Load(object sender, EventArgs e)
        {
            // 1-10 arası puan seçeneklerini ekle
            for (int i = 1; i <= 10; i++)
                cyberpunk2077puanlama.Items.Add(i);
            cyberpunk2077puanlama.SelectedIndex = 0;

            // Daha önceki yorumları ve puanları yükle
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (var satir in satirlar)
                {
                    lstyorumlarcyberpunk2077.Items.Add(satir);

                    var match = Regex.Match(satir, @"Puan: (\d+)/10");
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int puan))
                        oylar.Add(puan);
                    cyberpunk2077aciklama.ReadOnly = true;
                }
            }

            // Ortalama puanı hesapla ve yaz
            lblortalamacyberpunk2077.Text = oylar.Count > 0
                ? $"Ortalama Puan: {oylar.Average():0.00}"
                : "Ortalama Puan: 0";
        }

        private void cyberpunk2077oyverme_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadicyberpunk2077.Text.Trim();
            string yorum = cyberpunk2077yorum.Text.Trim();

            // Puan kontrolü
            if (cyberpunk2077puanlama.SelectedItem == null ||
                !int.TryParse(cyberpunk2077puanlama.SelectedItem.ToString(), out int puan))
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

            // Puan eklenip ortalama güncelleniyor
            oylar.Add(puan);
            lblortalamacyberpunk2077.Text = $"Ortalama Puan: {oylar.Average():0.00}";

            MessageBox.Show("Oy gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Yeni yorum formatı
            string yeniYorum = $"👤 {kullanici} | \"{yorum}\" | ⭐ Puan: {puan}/10";

            lstyorumlarcyberpunk2077.Items.Add(yeniYorum);
            File.WriteAllLines(dosyaYolu, lstyorumlarcyberpunk2077.Items.Cast<string>());

            // Alanları temizle
            kullaniciadicyberpunk2077.Clear();
            cyberpunk2077yorum.Clear();
            cyberpunk2077puanlama.SelectedIndex = 0;
        }

        // Menü butonları
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
