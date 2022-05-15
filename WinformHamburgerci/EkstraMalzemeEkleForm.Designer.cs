namespace WinformHamburgerci
{
    partial class EkstraMalzemeEkleForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EMalzemeAd = new System.Windows.Forms.TextBox();
            this.nud_EMalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EMalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ekstra Malzeme Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ekstra Malzeme Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fiyatı :";
            // 
            // txt_EMalzemeAd
            // 
            this.txt_EMalzemeAd.Location = new System.Drawing.Point(171, 78);
            this.txt_EMalzemeAd.Name = "txt_EMalzemeAd";
            this.txt_EMalzemeAd.Size = new System.Drawing.Size(224, 24);
            this.txt_EMalzemeAd.TabIndex = 14;
            // 
            // nud_EMalzemeFiyat
            // 
            this.nud_EMalzemeFiyat.Location = new System.Drawing.Point(171, 135);
            this.nud_EMalzemeFiyat.Name = "nud_EMalzemeFiyat";
            this.nud_EMalzemeFiyat.Size = new System.Drawing.Size(224, 24);
            this.nud_EMalzemeFiyat.TabIndex = 15;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Kaydet.Location = new System.Drawing.Point(171, 184);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(224, 50);
            this.btn_Kaydet.TabIndex = 16;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // EkstraMalzemeEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(432, 260);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.nud_EMalzemeFiyat);
            this.Controls.Add(this.txt_EMalzemeAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EkstraMalzemeEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuEkleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_EMalzemeFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EMalzemeAd;
        private System.Windows.Forms.NumericUpDown nud_EMalzemeFiyat;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}