using System.Collections.Generic;

namespace WinformHamburgerci
{
    public class Siparis
    {
        public Siparis()
        {
            SosList = new List<Sos>();
        }
        public int Adet { get; set; }
        public decimal Tutar { get; set; }
        public Menu MenuList { get; set; }
        public Boyut BoyutList { get; set; }
        public List<Sos> SosList { get; set; }

        public override string ToString()
        {
            if (SosList.Count < 1)
            {
                return $"{Adet} adet {MenuList.Adi} {BoyutList} Boy,{string.Join(", ", SosList)} {Hesapla().ToString("00.##")} ₺";
            }
            else
            {
                return $"{Adet} adet {MenuList.Adi} {BoyutList} Boy, Soslar : {string.Join(", ", SosList)} {Hesapla().ToString("00.##")} ₺";
            }

        }
        public decimal Hesapla()
        {
            //orta boy seçili ise %10, büyük boy ise %25 fiyat eklemesi yapılacak
            Tutar = 0;
            foreach (Sos item in SosList)
            {
                Tutar += item.Fiyati;
            }
            if (BoyutList == Boyut.Kucuk)
            {
                Tutar += MenuList.Fiyati * Adet;
            }
            if (BoyutList == Boyut.Orta)
            {
                Tutar += (MenuList.Fiyati * 1.1m) * Adet;
            }
            if (BoyutList == Boyut.Buyuk)
            {
                Tutar += (MenuList.Fiyati * 1.25m) * Adet;
            }

            return Tutar;
        }
    }
}
