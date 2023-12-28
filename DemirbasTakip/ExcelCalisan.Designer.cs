namespace DemirbasTakip
{
    partial class ExcelCalisan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aktar = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.cktAl = new System.Windows.Forms.Button();
            this.txt_excel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // aktar
            // 
            this.aktar.BackColor = System.Drawing.Color.GreenYellow;
            this.aktar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aktar.Location = new System.Drawing.Point(337, 221);
            this.aktar.Name = "aktar";
            this.aktar.Size = new System.Drawing.Size(92, 34);
            this.aktar.TabIndex = 1;
            this.aktar.Text = "İçe Aktar";
            this.aktar.UseVisualStyleBackColor = false;
            this.aktar.Click += new System.EventHandler(this.aktar_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.LightYellow;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.geri.Location = new System.Drawing.Point(35, 295);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(92, 45);
            this.geri.TabIndex = 2;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // cktAl
            // 
            this.cktAl.Location = new System.Drawing.Point(35, 233);
            this.cktAl.Name = "cktAl";
            this.cktAl.Size = new System.Drawing.Size(98, 40);
            this.cktAl.TabIndex = 3;
            this.cktAl.Text = "Çıktı Al";
            this.cktAl.UseVisualStyleBackColor = true;
            this.cktAl.Click += new System.EventHandler(this.cktAl_Click);
            // 
            // txt_excel
            // 
            this.txt_excel.Location = new System.Drawing.Point(435, 233);
            this.txt_excel.Name = "txt_excel";
            this.txt_excel.Size = new System.Drawing.Size(100, 22);
            this.txt_excel.TabIndex = 4;
            this.txt_excel.TextChanged += new System.EventHandler(this.txt_excel_TextChanged);
            // 
            // ExcelCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(628, 347);
            this.Controls.Add(this.txt_excel);
            this.Controls.Add(this.cktAl);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.aktar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcelCalisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelCalisan";
            this.Load += new System.EventHandler(this.ExcelCalisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button aktar;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button cktAl;
        private System.Windows.Forms.TextBox txt_excel;
    }
}