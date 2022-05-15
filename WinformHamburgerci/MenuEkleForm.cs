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
    public partial class MenuEkleForm : Form
    {
        public MenuEkleForm()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_MenuAd.Text.Length > 0)
            {
                Menu yeniMenu = new Menu();
                yeniMenu.Adi = txt_MenuAd.Text;
                yeniMenu.Fiyati = nud_MenuFiyat.Value;
                UrunSecimForm.Menuler.Add(yeniMenu);
                MessageBox.Show("Menü Kaydedildi!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Menü adı boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
