namespace WinformHamburgerci
{
    partial class SiparisListeleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_SatilanUrunAdedi = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_EkstraMalzemeGeliri = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_ToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Ciro = new System.Windows.Forms.Label();
            this.lst_Siparisler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lst_Siparisler);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.MinimumSize = new System.Drawing.Size(457, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(811, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÜM SİPARİŞLER";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_SatilanUrunAdedi);
            this.groupBox5.Location = new System.Drawing.Point(444, 438);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 72);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satılan Ürün Adedi";
            // 
            // lbl_SatilanUrunAdedi
            // 
            this.lbl_SatilanUrunAdedi.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SatilanUrunAdedi.ForeColor = System.Drawing.Color.Red;
            this.lbl_SatilanUrunAdedi.Location = new System.Drawing.Point(157, 14);
            this.lbl_SatilanUrunAdedi.Name = "lbl_SatilanUrunAdedi";
            this.lbl_SatilanUrunAdedi.Size = new System.Drawing.Size(159, 55);
            this.lbl_SatilanUrunAdedi.TabIndex = 3;
            this.lbl_SatilanUrunAdedi.Text = "0,00";
            this.lbl_SatilanUrunAdedi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_EkstraMalzemeGeliri);
            this.groupBox4.Location = new System.Drawing.Point(444, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ekstra Malzeme Geliri";
            // 
            // lbl_EkstraMalzemeGeliri
            // 
            this.lbl_EkstraMalzemeGeliri.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EkstraMalzemeGeliri.ForeColor = System.Drawing.Color.Red;
            this.lbl_EkstraMalzemeGeliri.Location = new System.Drawing.Point(151, 12);
            this.lbl_EkstraMalzemeGeliri.Name = "lbl_EkstraMalzemeGeliri";
            this.lbl_EkstraMalzemeGeliri.Size = new System.Drawing.Size(171, 57);
            this.lbl_EkstraMalzemeGeliri.TabIndex = 2;
            this.lbl_EkstraMalzemeGeliri.Text = "0,00";
            this.lbl_EkstraMalzemeGeliri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_ToplamSiparisSayisi);
            this.groupBox3.Location = new System.Drawing.Point(444, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toplam Sipariş Sayısı";
            // 
            // lbl_ToplamSiparisSayisi
            // 
            this.lbl_ToplamSiparisSayisi.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamSiparisSayisi.ForeColor = System.Drawing.Color.Red;
            this.lbl_ToplamSiparisSayisi.Location = new System.Drawing.Point(139, 12);
            this.lbl_ToplamSiparisSayisi.Name = "lbl_ToplamSiparisSayisi";
            this.lbl_ToplamSiparisSayisi.Size = new System.Drawing.Size(177, 57);
            this.lbl_ToplamSiparisSayisi.TabIndex = 1;
            this.lbl_ToplamSiparisSayisi.Text = "0,00";
            this.lbl_ToplamSiparisSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Ciro);
            this.groupBox2.Location = new System.Drawing.Point(444, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ciro";
            // 
            // lbl_Ciro
            // 
            this.lbl_Ciro.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ciro.ForeColor = System.Drawing.Color.Red;
            this.lbl_Ciro.Location = new System.Drawing.Point(145, 11);
            this.lbl_Ciro.Name = "lbl_Ciro";
            this.lbl_Ciro.Size = new System.Drawing.Size(177, 58);
            this.lbl_Ciro.TabIndex = 0;
            this.lbl_Ciro.Text = "0,00";
            this.lbl_Ciro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lst_Siparisler
            // 
            this.lst_Siparisler.FormattingEnabled = true;
            this.lst_Siparisler.ItemHeight = 15;
            this.lst_Siparisler.Location = new System.Drawing.Point(12, 33);
            this.lst_Siparisler.Name = "lst_Siparisler";
            this.lst_Siparisler.Size = new System.Drawing.Size(426, 484);
            this.lst_Siparisler.TabIndex = 0;
            // 
            // SiparisListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 522);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SiparisListeleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sipariş Listele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_Siparisler;
        private System.Windows.Forms.Label lbl_Ciro;
        private System.Windows.Forms.Label lbl_SatilanUrunAdedi;
        private System.Windows.Forms.Label lbl_EkstraMalzemeGeliri;
        private System.Windows.Forms.Label lbl_ToplamSiparisSayisi;
    }
}