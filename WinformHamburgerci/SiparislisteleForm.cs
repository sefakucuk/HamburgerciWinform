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
    public partial class SiparisListeleForm : Form
    {
        public SiparisListeleForm(List<Siparis> siparisler)
        {
            InitializeComponent();
            foreach (Siparis item in siparisler)
            {
                lst_Siparisler.Items.Add(item);
            }
            lbl_ToplamSiparisSayisi.Text = siparisler.Count.ToString();
            decimal ciro = 0, sosKazanci = 0, satilanUrunAdedi = 0;
            foreach (Siparis siparis in siparisler)
            {
                if (siparis.SosList.Count > 0)
                {
                    satilanUrunAdedi += siparis.SosList.Count;
                    foreach (Sos sos in siparis.SosList)
                    {
                        sosKazanci += sos.Fiyati;
                    }
                }
                ciro += siparis.Hesapla();
                satilanUrunAdedi += siparis.Adet;
            }

            lbl_Ciro.Text = ciro.ToString() + "₺";
            lbl_EkstraMalzemeGeliri.Text = sosKazanci.ToString() + "₺";
            lbl_SatilanUrunAdedi.Text = satilanUrunAdedi.ToString();
        }
    }
}
