namespace DemirbasTakip
{
    partial class AnaSayfa
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
            this.dmr = new System.Windows.Forms.Button();
            this.dep = new System.Windows.Forms.Button();
            this.cks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dmr
            // 
            this.dmr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dmr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dmr.Location = new System.Drawing.Point(55, 51);
            this.dmr.Name = "dmr";
            this.dmr.Size = new System.Drawing.Size(127, 49);
            this.dmr.TabIndex = 0;
            this.dmr.Text = "Demirbaşlar";
            this.dmr.UseVisualStyleBackColor = false;
            this.dmr.Click += new System.EventHandler(this.dmr_Click);
            // 
            // dep
            // 
            this.dep.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dep.Location = new System.Drawing.Point(55, 130);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(127, 50);
            this.dep.TabIndex = 1;
            this.dep.Text = "Departmanlar";
            this.dep.UseVisualStyleBackColor = false;
            this.dep.Click += new System.EventHandler(this.dep_Click);
            // 
            // cks
            // 
            this.cks.BackColor = System.Drawing.Color.Beige;
            this.cks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cks.Location = new System.Drawing.Point(209, 258);
            this.cks.Name = "cks";
            this.cks.Size = new System.Drawing.Size(127, 54);
            this.cks.TabIndex = 2;
            this.cks.Text = "Çıkış Yap";
            this.cks.UseVisualStyleBackColor = false;
            this.cks.Click += new System.EventHandler(this.cks_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 324);
            this.Controls.Add(this.cks);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.dmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dmr;
        private System.Windows.Forms.Button dep;
        private System.Windows.Forms.Button cks;
    }
}