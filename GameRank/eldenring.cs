using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameRank
{
    public partial class eldenring : Form
    {
        string dosyaYolu = Path.Combine(Application.StartupPath, "eldenringyorumlar.txt");
        List<int> oylar = new List<int>();

        public eldenring()
        {
            InitializeComponent();
        }

        private void eldenring_Load(object sender, EventArgs e)
        {
            // Puanlama combobox'una 1-10 arası puanları ekle
            for (int i = 1; i <= 10; i++)
                eldenringpuanlama.Items.Add(i);

            eldenringpuanlama.SelectedIndex = 0;

            // Yorumlar dosyadan okunup listeye ekleniyor
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (var satir in satirlar)
                {
                    lstyorumlareldenring.Items.Add(satir);

                    // Satırdaki puanı Regex ile bul ve listeye ekle
                    var match = Regex.Match(satir, @"Puan: (\d+)/10");
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int puan))
                        oylar.Add(puan);
                    eldenringaciklama.ReadOnly = true;
                }
            }

            // Ortalama puanı göster
            lblortalamaeldenring.Text = oylar.Count > 0
                ? $"Ortalama Puan: {oylar.Average():0.00}"
                : "Ortalama Puan: 0";
        }

        private void eldenringoyverme_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadieldenring.Text.Trim();
            string yorum = eldenringyorum.Text.Trim();

            if (eldenringpuanlama.SelectedItem == null ||
                !int.TryParse(eldenringpuanlama.SelectedItem.ToString(), out int puan))
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

            // Yeni puanı listeye ekle ve ortalamayı güncelle
            oylar.Add(puan);
            lblortalamaeldenring.Text = $"Ortalama Puan: {oylar.Average():0.00}";

            MessageBox.Show("Oy gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string yeniYorum = $"👤 {kullanici} | \"{yorum}\" | ⭐ Puan: {puan}/10";

            lstyorumlareldenring.Items.Add(yeniYorum);

            // Yorumları dosyaya kaydet
            File.WriteAllLines(dosyaYolu, lstyorumlareldenring.Items.Cast<string>());

            // Alanları temizle
            kullaniciadieldenring.Clear();
            eldenringyorum.Clear();
            eldenringpuanlama.SelectedIndex = 0;
        }

        // Menü item eventleri
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
