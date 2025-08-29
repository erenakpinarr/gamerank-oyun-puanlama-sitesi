using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GameRank
{
    public partial class iletişim : Form
    {
        // Constructor - Form ilk oluşturulduğunda çağrılır
        public iletişim()
        {
            InitializeComponent(); // Tasarım bileşenlerini başlatır
        }

        // Menüden Oyunlar tıklandığında oyun formunu açar
        private void oyunlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oyunformu oyunFormu = new oyunformu();
            oyunFormu.Show();
        }

        // Menüden Hakkımızda tıklandığında hakkimizda formunu açar
        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkimizda hakkimizda = new hakkimizda();
            hakkimizda.Show();
        }

        // Menüden İletişim tıklandığında yeni iletişim formu açar (aynı formdan)
        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletişim iletişim = new iletişim();
            iletişim.Show();
        }

        // Ana Sayfa menüsüne tıklandığında mevcut iletişim formunu kapatır
        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Gönder butonuna basıldığında çağrılır
        private void btnsend_Click(object sender, EventArgs e)
        {
            // Formdaki alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basit e-posta doğrulaması: @ ve . içeriyor mu kontrolü
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mesaj içeriği oluşturuluyor
            string info = $"Tarih: {DateTime.Now}\nİsim: {txtName.Text}\nE-posta: {txtEmail.Text}\nMesaj: {txtMessage.Text}\n---\n";

            try
            {
                // Uygulama klasöründe "iletisimmesajlari.txt" dosyasının tam yolu
                string dosyaYolu = Path.Combine(Application.StartupPath, "iletisimmesajlari.txt");

                // Mesaj dosyaya UTF-8 kodlamasıyla ekleniyor
                File.AppendAllText(dosyaYolu, info, Encoding.UTF8);

                // Kullanıcıya mesajın başarıyla gönderildiğini bildir
                MessageBox.Show("Mesajınız gönderildi ve kaydedildi. Teşekkürler!\n\n" + info, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Dosya yazma hatası varsa kullanıcıya göster
                MessageBox.Show("Mesaj kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Gönderme işlemi sonrası form alanlarını temizle
            txtName.Clear();
            txtEmail.Clear();
            txtMessage.Clear();
        }

        // Form yüklenirken yapılacak işlemler (şimdilik boş)
        private void iletişim_Load(object sender, EventArgs e)
        {

        }
    }
}
