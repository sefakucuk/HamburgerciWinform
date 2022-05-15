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
    public partial class MyMDIForm : Form
    {
        private List<Siparis> _siparisler;
        public MyMDIForm()
        {
            InitializeComponent();
            _siparisler = UrunSecimForm.tumSiparisler;

        }

        private void LoadForm(Form childForm)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            this.Width = childForm.Width + 20;
            this.Height = childForm.Height + 67;
            childForm.MdiParent = this;
            this.ActivateMdiChild(childForm);
            childForm.Show();
        }

        private void btn_SiparisOlustur_Click(object sender, EventArgs e)
        {
            LoadForm(new UrunSecimForm());
        }

        private void btn_SiparisListele_Click(object sender, EventArgs e)
        {
            LoadForm(new SiparisListeleForm(_siparisler));
        }

        private void btn_MenuEkle_Click(object sender, EventArgs e)
        {
            LoadForm(new MenuEkleForm());
        }

        private void btn_EkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            LoadForm(new EkstraMalzemeEkleForm());
        }
    }
}
