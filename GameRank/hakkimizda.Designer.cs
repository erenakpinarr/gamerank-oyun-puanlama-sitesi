namespace GameRank
{
    partial class hakkimizda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hakkimizda));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelbaslikhakkimizda1 = new System.Windows.Forms.Label();
            this.labelaciklama1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 1;
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
            // labelbaslikhakkimizda1
            // 
            this.labelbaslikhakkimizda1.AutoSize = true;
            this.labelbaslikhakkimizda1.BackColor = System.Drawing.Color.Transparent;
            this.labelbaslikhakkimizda1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaslikhakkimizda1.ForeColor = System.Drawing.Color.White;
            this.labelbaslikhakkimizda1.Location = new System.Drawing.Point(255, 33);
            this.labelbaslikhakkimizda1.Name = "labelbaslikhakkimizda1";
            this.labelbaslikhakkimizda1.Size = new System.Drawing.Size(255, 30);
            this.labelbaslikhakkimizda1.TabIndex = 32;
            this.labelbaslikhakkimizda1.Text = "GameRank - Hakkımızda\r\n";
            // 
            // labelaciklama1
            // 
            this.labelaciklama1.BackColor = System.Drawing.Color.Transparent;
            this.labelaciklama1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelaciklama1.ForeColor = System.Drawing.Color.White;
            this.labelaciklama1.Location = new System.Drawing.Point(9, 102);
            this.labelaciklama1.Name = "labelaciklama1";
            this.labelaciklama1.Size = new System.Drawing.Size(776, 460);
            this.labelaciklama1.TabIndex = 33;
            this.labelaciklama1.Text = resources.GetString("labelaciklama1.Text");
            // 
            // hakkimizda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(28)))));
            this.BackgroundImage = global::GameRank.Properties.Resources.outlast;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.labelaciklama1);
            this.Controls.Add(this.labelbaslikhakkimizda1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "hakkimizda";
            this.Text = "GameRank - Hakkımızda";
            this.Load += new System.EventHandler(this.hakkimizda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.Label labelbaslikhakkimizda1;
        private System.Windows.Forms.Label labelaciklama1;
    }
}