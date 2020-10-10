using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_bm
{
    class GirisTip
    {
        string hassaslikDeger, miktarDeger, kirlilikDeger;
        public string hassaslikTur, miktarTur, kirlilikTur;

        public GirisTip(string hassaslikDeger,string miktarDeger,string kirlilikDeger)
        {
            this.hassaslikDeger = hassaslikDeger;
            this.miktarDeger = miktarDeger;
            this.kirlilikDeger = kirlilikDeger;
            HassaslikTur();
            MiktarTur();
            KirlilikTur();
        }
        public void HassaslikTur()
        {
            if (hassaslikDeger == "Sağlam")
            {
                hassaslikTur = "SaglamYamuk";
            }
            else if (hassaslikDeger == "Orta")
            {
                hassaslikTur = "Ucgen";
            }
            else
            {
                hassaslikTur = "HassasYamuk";
            }
        }
        public void MiktarTur()
        {
            if (miktarDeger == "Küçük")
            {
                miktarTur = "KucukYamuk";
            }
            else if (miktarDeger == "Orta")
            {
                miktarTur = "Ucgen";
            }
            else
            {
                miktarTur = "BuyukYamuk";
            }

        }
        public void KirlilikTur()
        {
            if (kirlilikDeger == "Küçük")
            {
                kirlilikTur = "KucukYamuk";
            }
            else if (kirlilikDeger== "Orta")
            {
                kirlilikTur = "Ucgen";
            }
            else
            {
                kirlilikTur = "BuyukYamuk";
            }
        }
    }
}
