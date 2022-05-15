using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformHamburgerci
{
    public partial class EkstraMalzemeEkleForm : Form
    {
        public EkstraMalzemeEkleForm()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_EMalzemeAd.Text.Length > 0)
            {
                Sos yeniSos = new Sos();
                yeniSos.Adi = txt_EMalzemeAd.Text;
                yeniSos.Fiyati = nud_EMalzemeFiyat.Value;
                UrunSecimForm.Soslar.Add(yeniSos);
                MessageBox.Show("Ekstra Malzeme Kaydedildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ekstra Malzeme adı boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
