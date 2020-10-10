using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_bm
{
    class CikisTip
    {
        string donusHizi, sure, deterjanMiktari;
        string donusHiziTip, sureTip, deterjanMiktariTip;
        public CikisTip(string donusHizi,string sure,string deterjanMiktari)
        {
            this.donusHizi = donusHizi;
            this.sure = sure;
            this.deterjanMiktari = deterjanMiktari;
            DonusHiziTip();
            SureTip();
            DeterjanMiktariTip();
        }
        public void DonusHiziTip()
        {
            if (donusHizi=="Hassas")
            {
                donusHiziTip = "HassasYamuk";
            }
            else if (donusHizi=="Normal Hassas")
            {
                donusHiziTip = "HassasUcgen";
            }
            else if (donusHizi=="Orta")
            {
                donusHiziTip = "OrtaUcgen";
            }
            else if (donusHizi=="Normal Güçlü")
            {
                donusHiziTip = "GucluUcgen";
            }
            else
            {
                donusHiziTip = "GucluYamuk";
            }
        }
        public void SureTip()
        {
            if (sure == "Kısa")
            {
                sureTip= "KısaYamuk";
            }
            else if (sure == "Normal Kısa")
            {
                sureTip= "KısaUcgen";
            }
            else if (sure == "Orta")
            {
                sureTip= "OrtaUcgen";
            }
            else if (sure == "Normal Uzun")
            {
                sureTip = "UzunUcgen";
            }
            else
            {
                sureTip = "UzunYamuk";
            }
        }
        public void DeterjanMiktariTip()
        {
            if (deterjanMiktari == "Çok Az")
            {
                deterjanMiktariTip = "AzYamuk";
            }
            else if (deterjanMiktari== "Az")
            {
                deterjanMiktariTip= "AzUcgen";
            }
            else if (deterjanMiktari== "Orta")
            {
                deterjanMiktariTip= "OrtaUcgen";
            }
            else if (deterjanMiktari== "Fazla")
            {
                deterjanMiktariTip= "FazlaUcgen";
            }
            else
            {
                deterjanMiktariTip= "FazlaYamuk";
            }
        }
       
    }
}
