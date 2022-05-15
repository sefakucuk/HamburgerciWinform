namespace WinformHamburgerci
{
    partial class UrunSecimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSecimForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flp_EkstraSecim = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_SiparisEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_MenuAdet = new System.Windows.Forms.NumericUpDown();
            this.gb_BoyutSec = new System.Windows.Forms.GroupBox();
            this.rbtn_Buyuk = new System.Windows.Forms.RadioButton();
            this.rbtn_Orta = new System.Windows.Forms.RadioButton();
            this.rbtn_Kucuk = new System.Windows.Forms.RadioButton();
            this.cmb_MenuSec = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lst_Secimler = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SiparisiTamamla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ToplamTutar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MenuAdet)).BeginInit();
            this.gb_BoyutSec.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.flp_EkstraSecim);
            this.panel1.Controls.Add(this.btn_SiparisEkle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nud_MenuAdet);
            this.panel1.Controls.Add(this.gb_BoyutSec);
            this.panel1.Controls.Add(this.cmb_MenuSec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 504);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "EKSTRA MALZEME SEÇİN";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "MENÜ SEÇİN";
            // 
            // flp_EkstraSecim
            // 
            this.flp_EkstraSecim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_EkstraSecim.Location = new System.Drawing.Point(9, 297);
            this.flp_EkstraSecim.Name = "flp_EkstraSecim";
            this.flp_EkstraSecim.Size = new System.Drawing.Size(285, 115);
            this.flp_EkstraSecim.TabIndex = 19;
            // 
            // btn_SiparisEkle
            // 
            this.btn_SiparisEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SiparisEkle.Location = new System.Drawing.Point(9, 455);
            this.btn_SiparisEkle.Name = "btn_SiparisEkle";
            this.btn_SiparisEkle.Size = new System.Drawing.Size(234, 47);
            this.btn_SiparisEkle.TabIndex = 18;
            this.btn_SiparisEkle.Text = "SİPARİŞ EKLE";
            this.btn_SiparisEkle.UseVisualStyleBackColor = false;
            this.btn_SiparisEkle.Click += new System.EventHandler(this.btn_SiparisEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adet :";
            // 
            // nud_MenuAdet
            // 
            this.nud_MenuAdet.Location = new System.Drawing.Point(120, 425);
            this.nud_MenuAdet.Name = "nud_MenuAdet";
            this.nud_MenuAdet.Size = new System.Drawing.Size(120, 24);
            this.nud_MenuAdet.TabIndex = 16;
            this.nud_MenuAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gb_BoyutSec
            // 
            this.gb_BoyutSec.Controls.Add(this.rbtn_Buyuk);
            this.gb_BoyutSec.Controls.Add(this.rbtn_Orta);
            this.gb_BoyutSec.Controls.Add(this.rbtn_Kucuk);
            this.gb_BoyutSec.Location = new System.Drawing.Point(12, 217);
            this.gb_BoyutSec.Name = "gb_BoyutSec";
            this.gb_BoyutSec.Size = new System.Drawing.Size(230, 52);
            this.gb_BoyutSec.TabIndex = 15;
            this.gb_BoyutSec.TabStop = false;
            this.gb_BoyutSec.Text = "Boyut Seçiniz";
            // 
            // rbtn_Buyuk
            // 
            this.rbtn_Buyuk.AutoSize = true;
            this.rbtn_Buyuk.Location = new System.Drawing.Point(161, 23);
            this.rbtn_Buyuk.Name = "rbtn_Buyuk";
            this.rbtn_Buyuk.Size = new System.Drawing.Size(64, 21);
            this.rbtn_Buyuk.TabIndex = 2;
            this.rbtn_Buyuk.TabStop = true;
            this.rbtn_Buyuk.Text = "Büyük";
            this.rbtn_Buyuk.UseVisualStyleBackColor = true;
            // 
            // rbtn_Orta
            // 
            this.rbtn_Orta.AutoSize = true;
            this.rbtn_Orta.Location = new System.Drawing.Point(81, 23);
            this.rbtn_Orta.Name = "rbtn_Orta";
            this.rbtn_Orta.Size = new System.Drawing.Size(52, 21);
            this.rbtn_Orta.TabIndex = 1;
            this.rbtn_Orta.TabStop = true;
            this.rbtn_Orta.Text = "Orta";
            this.rbtn_Orta.UseVisualStyleBackColor = true;
            // 
            // rbtn_Kucuk
            // 
            this.rbtn_Kucuk.AutoSize = true;
            this.rbtn_Kucuk.Location = new System.Drawing.Point(0, 23);
            this.rbtn_Kucuk.Name = "rbtn_Kucuk";
            this.rbtn_Kucuk.Size = new System.Drawing.Size(63, 21);
            this.rbtn_Kucuk.TabIndex = 0;
            this.rbtn_Kucuk.TabStop = true;
            this.rbtn_Kucuk.Text = "Küçük";
            this.rbtn_Kucuk.UseVisualStyleBackColor = true;
            // 
            // cmb_MenuSec
            // 
            this.cmb_MenuSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_MenuSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MenuSec.FormattingEnabled = true;
            this.cmb_MenuSec.Location = new System.Drawing.Point(11, 177);
            this.cmb_MenuSec.Name = "cmb_MenuSec";
            this.cmb_MenuSec.Size = new System.Drawing.Size(231, 23);
            this.cmb_MenuSec.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lst_Secimler);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 504);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // lst_Secimler
            // 
            this.lst_Secimler.FormattingEnabled = true;
            this.lst_Secimler.ItemHeight = 15;
            this.lst_Secimler.Location = new System.Drawing.Point(3, 3);
            this.lst_Secimler.Name = "lst_Secimler";
            this.lst_Secimler.Size = new System.Drawing.Size(508, 379);
            this.lst_Secimler.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(300, 385);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(511, 119);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SiparisiTamamla);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_ToplamTutar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 114);
            this.panel2.TabIndex = 20;
            // 
            // btn_SiparisiTamamla
            // 
            this.btn_SiparisiTamamla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SiparisiTamamla.Location = new System.Drawing.Point(303, 54);
            this.btn_SiparisiTamamla.Name = "btn_SiparisiTamamla";
            this.btn_SiparisiTamamla.Size = new System.Drawing.Size(205, 47);
            this.btn_SiparisiTamamla.TabIndex = 18;
            this.btn_SiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btn_SiparisiTamamla.UseVisualStyleBackColor = false;
            this.btn_SiparisiTamamla.Click += new System.EventHandler(this.btn_SiparisiTamamla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "TOPLAM TUTAR :";
            // 
            // lbl_ToplamTutar
            // 
            this.lbl_ToplamTutar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lbl_ToplamTutar.Location = new System.Drawing.Point(120, 18);
            this.lbl_ToplamTutar.Name = "lbl_ToplamTutar";
            this.lbl_ToplamTutar.Size = new System.Drawing.Size(177, 53);
            this.lbl_ToplamTutar.TabIndex = 17;
            this.lbl_ToplamTutar.Text = "0,00 ₺";
            this.lbl_ToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UrunSecimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(811, 504);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "UrunSecimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ürün Seçim";
            this.Load += new System.EventHandler(this.UrunSecimForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MenuAdet)).EndInit();
            this.gb_BoyutSec.ResumeLayout(false);
            this.gb_BoyutSec.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flp_EkstraSecim;
        private System.Windows.Forms.Button btn_SiparisEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_MenuAdet;
        private System.Windows.Forms.GroupBox gb_BoyutSec;
        private System.Windows.Forms.RadioButton rbtn_Buyuk;
        private System.Windows.Forms.RadioButton rbtn_Orta;
        private System.Windows.Forms.RadioButton rbtn_Kucuk;
        private System.Windows.Forms.ComboBox cmb_MenuSec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox lst_Secimler;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SiparisiTamamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ToplamTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

