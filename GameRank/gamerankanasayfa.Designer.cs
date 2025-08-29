namespace GameRank
{
    partial class gamerankanasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamerankanasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelbaslikanasayfa = new System.Windows.Forms.Label();
            this.labelaciklama = new System.Windows.Forms.Label();
            this.pictureanamenüoyun1 = new System.Windows.Forms.PictureBox();
            this.pictureanamenüoyun2 = new System.Windows.Forms.PictureBox();
            this.pictureanamenüoyun3 = new System.Windows.Forms.PictureBox();
            this.pictureanamenüoyun4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.oyunlarToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // oyunlarToolStripMenuItem
            // 
            this.oyunlarToolStripMenuItem.Name = "oyunlarToolStripMenuItem";
            this.oyunlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oyunlarToolStripMenuItem.Text = "Oyunlar";
            this.oyunlarToolStripMenuItem.Click += new System.EventHandler(this.oyunlarToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // labelbaslikanasayfa
            // 
            this.labelbaslikanasayfa.AutoSize = true;
            this.labelbaslikanasayfa.BackColor = System.Drawing.Color.Transparent;
            this.labelbaslikanasayfa.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaslikanasayfa.ForeColor = System.Drawing.Color.White;
            this.labelbaslikanasayfa.Location = new System.Drawing.Point(285, 35);
            this.labelbaslikanasayfa.Name = "labelbaslikanasayfa";
            this.labelbaslikanasayfa.Size = new System.Drawing.Size(646, 37);
            this.labelbaslikanasayfa.TabIndex = 12;
            this.labelbaslikanasayfa.Text = "GameRank - Oyun Tutkunlarının Buluşma Noktası";
            // 
            // labelaciklama
            // 
            this.labelaciklama.AutoSize = true;
            this.labelaciklama.BackColor = System.Drawing.Color.Transparent;
            this.labelaciklama.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelaciklama.ForeColor = System.Drawing.Color.White;
            this.labelaciklama.Location = new System.Drawing.Point(1, 361);
            this.labelaciklama.Name = "labelaciklama";
            this.labelaciklama.Size = new System.Drawing.Size(1215, 390);
            this.labelaciklama.TabIndex = 13;
            this.labelaciklama.Text = resources.GetString("labelaciklama.Text");
           
            // 
            // pictureanamenüoyun1
            // 
            this.pictureanamenüoyun1.BackColor = System.Drawing.Color.Transparent;
            this.pictureanamenüoyun1.BackgroundImage = global::GameRank.Properties.Resources.assassinscreedshadows;
            this.pictureanamenüoyun1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureanamenüoyun1.Location = new System.Drawing.Point(0, 112);
            this.pictureanamenüoyun1.Name = "pictureanamenüoyun1";
            this.pictureanamenüoyun1.Size = new System.Drawing.Size(300, 163);
            this.pictureanamenüoyun1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureanamenüoyun1.TabIndex = 14;
            this.pictureanamenüoyun1.TabStop = false;
            this.pictureanamenüoyun1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureanamenüoyun2
            // 
            this.pictureanamenüoyun2.BackColor = System.Drawing.Color.Transparent;
            this.pictureanamenüoyun2.BackgroundImage = global::GameRank.Properties.Resources.cyberpunk2077;
            this.pictureanamenüoyun2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureanamenüoyun2.Location = new System.Drawing.Point(306, 112);
            this.pictureanamenüoyun2.Name = "pictureanamenüoyun2";
            this.pictureanamenüoyun2.Size = new System.Drawing.Size(300, 163);
            this.pictureanamenüoyun2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureanamenüoyun2.TabIndex = 15;
            this.pictureanamenüoyun2.TabStop = false;
            this.pictureanamenüoyun2.Click += new System.EventHandler(this.pictureanamenüoyun2_Click);
            // 
            // pictureanamenüoyun3
            // 
            this.pictureanamenüoyun3.BackColor = System.Drawing.Color.Transparent;
            this.pictureanamenüoyun3.BackgroundImage = global::GameRank.Properties.Resources.EGS_GodofWar_SantaMonicaStudio_S1_2560x1440_5d74d9b240bba8f2c40920dcde7c5c67_2560x1440_5d74d9b240bba8f2c40920dcde7c5c67;
            this.pictureanamenüoyun3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureanamenüoyun3.Location = new System.Drawing.Point(612, 112);
            this.pictureanamenüoyun3.Name = "pictureanamenüoyun3";
            this.pictureanamenüoyun3.Size = new System.Drawing.Size(300, 163);
            this.pictureanamenüoyun3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureanamenüoyun3.TabIndex = 16;
            this.pictureanamenüoyun3.TabStop = false;
            this.pictureanamenüoyun3.Click += new System.EventHandler(this.pictureanamenüoyun3_Click);
            // 
            // pictureanamenüoyun4
            // 
            this.pictureanamenüoyun4.BackColor = System.Drawing.Color.Transparent;
            this.pictureanamenüoyun4.BackgroundImage = global::GameRank.Properties.Resources.eldenring;
            this.pictureanamenüoyun4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureanamenüoyun4.Location = new System.Drawing.Point(916, 112);
            this.pictureanamenüoyun4.Name = "pictureanamenüoyun4";
            this.pictureanamenüoyun4.Size = new System.Drawing.Size(300, 163);
            this.pictureanamenüoyun4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureanamenüoyun4.TabIndex = 17;
            this.pictureanamenüoyun4.TabStop = false;
            this.pictureanamenüoyun4.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // gamerankanasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(28)))));
            this.BackgroundImage = global::GameRank.Properties.Resources.outlast;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 760);
            this.Controls.Add(this.pictureanamenüoyun4);
            this.Controls.Add(this.pictureanamenüoyun3);
            this.Controls.Add(this.pictureanamenüoyun2);
            this.Controls.Add(this.pictureanamenüoyun1);
            this.Controls.Add(this.labelaciklama);
            this.Controls.Add(this.labelbaslikanasayfa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gamerankanasayfa";
            this.Text = "GameRank - AnaSayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureanamenüoyun4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.Label labelbaslikanasayfa;
        private System.Windows.Forms.Label labelaciklama;
        private System.Windows.Forms.PictureBox pictureanamenüoyun1;
        private System.Windows.Forms.PictureBox pictureanamenüoyun2;
        private System.Windows.Forms.PictureBox pictureanamenüoyun3;
        private System.Windows.Forms.PictureBox pictureanamenüoyun4;
    }
}

