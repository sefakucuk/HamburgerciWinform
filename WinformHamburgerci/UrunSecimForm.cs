using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformHamburgerci
{
    public partial class UrunSecimForm : Form
    {

        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        decimal toplamFiyat = 0;

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu() { Adi = "Whopper Menü", Fiyati = 69.99m },
            new Menu() { Adi = "Double Whopper Menü", Fiyati = 74.99m },
            new Menu() { Adi = "Etli Barbekü Brioche Menü", Fiyati = 59.99m },
            new Menu() { Adi = "Big King Menü", Fiyati = 64.99m },
            new Menu() { Adi = "Double Big King Menü", Fiyati = 79.99m },
            new Menu() { Adi = "BK Steak House Menü", Fiyati = 79.99m },
            new Menu() { Adi = "Texas Smokehouse Menü", Fiyati = 84.99m },
            new Menu() { Adi = "King Chicken Menü", Fiyati = 44.99m }
        };
        public static List<Sos> Soslar = new List<Sos>()
        {
            new Sos() { Adi = "Ketçap", Fiyati = 0 },
            new Sos() { Adi = "Mayonez", Fiyati = 0 },
            new Sos() { Adi = "Ranch", Fiyati = 2.5m },
            new Sos() { Adi = "BBQ", Fiyati = 2.5m },
            new Sos() { Adi = "Buffalo", Fiyati = 2.5m },
            new Sos() { Adi = "Hardal", Fiyati = 2.5m }
        };
        public UrunSecimForm()
        {
            InitializeComponent();
            rbtn_Kucuk.Checked = true;
        }

        private void UrunSecimForm_Load(object sender, System.EventArgs e)
        {
            foreach (Menu item in Menuler)
            {
                cmb_MenuSec.Items.Add(item);
            }
            cmb_MenuSec.SelectedIndex = 0;

            foreach (var item in Soslar)
            {
                flp_EkstraSecim.Controls.Add(new CheckBox() { Text = item.Adi });
            }
            if (lst_Secimler.Items.Count == 0)
            {
                btn_SiparisiTamamla.Enabled = false;
            }
        }

        private void btn_SiparisEkle_Click(object sender, System.EventArgs e)
        {
            btn_SiparisiTamamla.Enabled = true;
            toplamFiyat = 0;

            Siparis siparis = new Siparis();

            siparis.MenuList = (Menu)cmb_MenuSec.SelectedItem;

            if (rbtn_Buyuk.Checked)
            {
                siparis.BoyutList = Boyut.Buyuk;
            }
            else if (rbtn_Orta.Checked)
            {
                siparis.BoyutList = Boyut.Orta;
            }
            else if (rbtn_Kucuk.Checked)
            {
                siparis.BoyutList = Boyut.Kucuk;
            }

            foreach (CheckBox item in flp_EkstraSecim.Controls)
            {
                if (item.Checked)
                {
                    Sos sos = Soslar.Find(x => x.Adi == item.Text);
                    siparis.SosList.Add(sos);
                }
            }

            siparis.Adet = (int)nud_MenuAdet.Value;

            lst_Secimler.Items.Add(siparis);

            siparisler.Add(siparis);
            tumSiparisler.Add(siparis);

            Hesapla();
            Temizle();
        }

        private void Hesapla()
        {
            foreach (Siparis item in siparisler)
            {
                toplamFiyat += item.Tutar;
            }

            lbl_ToplamTutar.Text = toplamFiyat.ToString("00.##") + " ₺";
        }

        private void Temizle()
        {
            foreach (CheckBox item in flp_EkstraSecim.Controls)
            {
                item.Checked = false;
            }
            rbtn_Buyuk.Checked = false;
            rbtn_Kucuk.Checked = true;
            rbtn_Orta.Checked = false;
            cmb_MenuSec.SelectedIndex = 0;
        }

        private void btn_SiparisiTamamla_Click(object sender, System.EventArgs e)
        {
            Temizle();
            lst_Secimler.Items.Clear();
            lbl_ToplamTutar.Text = "0";
            btn_SiparisiTamamla.Enabled = false;
            toplamFiyat = 0;
            siparisler.Clear();
            MessageBox.Show("Siparişiniz Kaydedilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
