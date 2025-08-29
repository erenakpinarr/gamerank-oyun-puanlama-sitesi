using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameRank
{
    public partial class witcher3 : Form
    {
        string dosyaYolu = Path.Combine(Application.StartupPath, "witcher3yorumlar.txt");
        List<int> oylar = new List<int>();

        public witcher3()
        {
            InitializeComponent();
        }

        private void witcher3_Load(object sender, EventArgs e)
        {
            // 1'den 10'a kadar puanları combobox'a ekle
            for (int i = 1; i <= 10; i++)
                witcher3puanlama.Items.Add(i);

            witcher3puanlama.SelectedIndex = 0;

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (var satir in satirlar)
                {
                    lstyorumlarwitcher3.Items.Add(satir);

                    // Satırdaki puanı regex ile yakala
                    var match = Regex.Match(satir, @"Puan: (\d+)/10");
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int puan))
                    {
                        oylar.Add(puan);
                        
                    }
                }
            }

            // Ortalama puanı göster
            lblortalamawitcher3.Text = oylar.Count > 0
                ? $"Ortalama Puan: {oylar.Average():0.00}"
                : "Ortalama Puan: 0";
            witcher3aciklama.ReadOnly = true;
        }

        private void witcher3oyverme_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadiwitcher3.Text.Trim();
            string yorum = witcher3yorum.Text.Trim();

            if (witcher3puanlama.SelectedItem == null ||
                !int.TryParse(witcher3puanlama.SelectedItem.ToString(), out int puan))
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
            lblortalamawitcher3.Text = $"Ortalama Puan: {oylar.Average():0.00}";

            MessageBox.Show("Oy gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string yeniYorum = $"👤 {kullanici} | \"{yorum}\" | ⭐ Puan: {puan}/10";

            lstyorumlarwitcher3.Items.Add(yeniYorum);

            // Dosyaya tüm yorumları kaydet
            File.WriteAllLines(dosyaYolu, lstyorumlarwitcher3.Items.Cast<string>());

            kullaniciadiwitcher3.Clear();
            witcher3yorum.Clear();
            witcher3puanlama.SelectedIndex = 0;
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
