using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameRank
{
    public partial class acshadows : Form
    {
        // Yorumların ve puanların saklandığı dosya yolu
        string dosyaYolu = Path.Combine(Application.StartupPath, "acshadowsyorumlar.txt");

        // Puanları tutan liste
        List<int> oylar = new List<int>();

        public acshadows()
        {
            InitializeComponent();
        }

        private void acshadows_Load(object sender, EventArgs e)
        {
            // Puanlama kutusuna 1-10 arası değerleri ekler
            for (int i = 1; i <= 10; i++)
                acshadowspuanlama.Items.Add(i);

            acshadowspuanlama.SelectedIndex = 0;

            // Önceki yorumları yükle
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (var satir in satirlar)
                {
                    lstyorumlaracshadows.Items.Add(satir);

                    // Satırdan puan bilgisini çekip listeye ekle
                    var match = Regex.Match(satir, @"Puan: (\d+)/10");
                    if (match.Success && int.TryParse(match.Groups[1].Value, out int puan))
                        oylar.Add(puan);
                }
            }

            // Ortalama puanı hesapla ve göster
            lblortalamaacshadows.Text = oylar.Count > 0
                ? $"Ortalama Puan: {oylar.Average():0.00}"
                : "Ortalama Puan: 0";
            acshadowsaciklama.ReadOnly = true;
        }

        private void acshadowsoyverme_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadiacshadows.Text.Trim();
            string yorum = acshadowsyorum.Text.Trim();

            // Puan kontrolü
            if (acshadowspuanlama.SelectedItem == null ||
                !int.TryParse(acshadowspuanlama.SelectedItem.ToString(), out int puan))
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
            lblortalamaacshadows.Text = $"Ortalama Puan: {oylar.Average():0.00}";

            // Yeni yorum satırı oluştur
            string yeniYorum = $"👤 {kullanici} | \"{yorum}\" | ⭐ Puan: {puan}/10";

            // Listeye ekle ve dosyaya kaydet
            lstyorumlaracshadows.Items.Add(yeniYorum);
            File.WriteAllLines(dosyaYolu, lstyorumlaracshadows.Items.Cast<string>());

            MessageBox.Show("Oy gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Girişleri temizle
            kullaniciadiacshadows.Clear();
            acshadowsyorum.Clear();
            acshadowspuanlama.SelectedIndex = 0;
        }

        // Menü butonları
        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
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
