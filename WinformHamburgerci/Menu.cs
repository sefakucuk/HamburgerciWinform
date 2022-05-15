using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformHamburgerci
{
    public class Menu
    {
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }

        public override string ToString()
        {
            return $"{Adi} {Fiyati} ₺";
        }
    }
}
