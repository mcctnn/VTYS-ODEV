namespace DemirbasTakip
{
    partial class AdminPanel
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
            this.dmrbas = new System.Windows.Forms.Button();
            this.clsnlar = new System.Windows.Forms.Button();
            this.deps = new System.Windows.Forms.Button();
            this.slndmr = new System.Windows.Forms.Button();
            this.slnclsn = new System.Windows.Forms.Button();
            this.cksyap = new System.Windows.Forms.Button();
            this.cktal = new System.Windows.Forms.Button();
            this.ydkle = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.klnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dmrbas
            // 
            this.dmrbas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dmrbas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dmrbas.Location = new System.Drawing.Point(12, 24);
            this.dmrbas.Name = "dmrbas";
            this.dmrbas.Size = new System.Drawing.Size(93, 34);
            this.dmrbas.TabIndex = 0;
            this.dmrbas.Text = "Demirbaşlar";
            this.dmrbas.UseVisualStyleBackColor = false;
            this.dmrbas.Click += new System.EventHandler(this.dmrbas_Click);
            // 
            // clsnlar
            // 
            this.clsnlar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clsnlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clsnlar.Location = new System.Drawing.Point(12, 70);
            this.clsnlar.Name = "clsnlar";
            this.clsnlar.Size = new System.Drawing.Size(94, 35);
            this.clsnlar.TabIndex = 1;
            this.clsnlar.Text = "Çalışanlar";
            this.clsnlar.UseVisualStyleBackColor = false;
            this.clsnlar.Click += new System.EventHandler(this.clsnlar_Click);
            // 
            // deps
            // 
            this.deps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deps.Location = new System.Drawing.Point(12, 111);
            this.deps.Name = "deps";
            this.deps.Size = new System.Drawing.Size(114, 58);
            this.deps.TabIndex = 2;
            this.deps.Text = "Departmanlar";
            this.deps.UseVisualStyleBackColor = false;
            this.deps.Click += new System.EventHandler(this.deps_Click);
            // 
            // slndmr
            // 
            this.slndmr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slndmr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slndmr.Location = new System.Drawing.Point(12, 185);
            this.slndmr.Name = "slndmr";
            this.slndmr.Size = new System.Drawing.Size(153, 60);
            this.slndmr.TabIndex = 3;
            this.slndmr.Text = "Silinen Demirbaşlar";
            this.slndmr.UseVisualStyleBackColor = false;
            this.slndmr.Click += new System.EventHandler(this.slndmr_Click);
            // 
            // slnclsn
            // 
            this.slnclsn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slnclsn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slnclsn.Location = new System.Drawing.Point(12, 260);
            this.slnclsn.Name = "slnclsn";
            this.slnclsn.Size = new System.Drawing.Size(124, 57);
            this.slnclsn.TabIndex = 4;
            this.slnclsn.Text = "Silinen Çalışanlar";
            this.slnclsn.UseVisualStyleBackColor = false;
            this.slnclsn.Click += new System.EventHandler(this.slnclsn_Click);
            // 
            // cksyap
            // 
            this.cksyap.BackColor = System.Drawing.Color.PapayaWhip;
            this.cksyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cksyap.Location = new System.Drawing.Point(636, 362);
            this.cksyap.Name = "cksyap";
            this.cksyap.Size = new System.Drawing.Size(124, 63);
            this.cksyap.TabIndex = 5;
            this.cksyap.Text = "Çıkış Yap";
            this.cksyap.UseVisualStyleBackColor = false;
            this.cksyap.Click += new System.EventHandler(this.cksyap_Click);
            // 
            // cktal
            // 
            this.cktal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cktal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cktal.Location = new System.Drawing.Point(667, 111);
            this.cktal.Name = "cktal";
            this.cktal.Size = new System.Drawing.Size(93, 35);
            this.cktal.TabIndex = 6;
            this.cktal.Text = "Çıktı Al";
            this.cktal.UseVisualStyleBackColor = false;
            this.cktal.Click += new System.EventHandler(this.cktal_Click);
            // 
            // ydkle
            // 
            this.ydkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ydkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ydkle.Location = new System.Drawing.Point(667, 45);
            this.ydkle.Name = "ydkle";
            this.ydkle.Size = new System.Drawing.Size(86, 37);
            this.ydkle.TabIndex = 7;
            this.ydkle.Text = "Yedekle";
            this.ydkle.UseVisualStyleBackColor = false;
            this.ydkle.Click += new System.EventHandler(this.ydkle_Click);
            // 
            // klnEkle
            // 
            this.klnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.klnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.klnEkle.Location = new System.Drawing.Point(191, 362);
            this.klnEkle.Name = "klnEkle";
            this.klnEkle.Size = new System.Drawing.Size(161, 56);
            this.klnEkle.TabIndex = 8;
            this.klnEkle.Text = "Kullanıcı Ekle";
            this.klnEkle.UseVisualStyleBackColor = false;
            this.klnEkle.Click += new System.EventHandler(this.klnEkle_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.klnEkle);
            this.Controls.Add(this.ydkle);
            this.Controls.Add(this.cktal);
            this.Controls.Add(this.cksyap);
            this.Controls.Add(this.slnclsn);
            this.Controls.Add(this.slndmr);
            this.Controls.Add(this.deps);
            this.Controls.Add(this.clsnlar);
            this.Controls.Add(this.dmrbas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dmrbas;
        private System.Windows.Forms.Button clsnlar;
        private System.Windows.Forms.Button deps;
        private System.Windows.Forms.Button slndmr;
        private System.Windows.Forms.Button slnclsn;
        private System.Windows.Forms.Button cksyap;
        private System.Windows.Forms.Button cktal;
        private System.Windows.Forms.Button ydkle;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button klnEkle;
    }
}

