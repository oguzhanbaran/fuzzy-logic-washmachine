using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_bm
{
    class CikarimHesapla
    {
        double[] donusHiziHassasYamuk= { -5.8, -2.8, 0.5, 1.5 };
        double[] donusHiziHassasUcgen = { 0.5,2.75,5};
        double[] donusHiziOrtaUcgen= { 2.75,5,7.25};
        double[] donusHiziGucluUcgen = { 5,7.25,9.5};
        double[] donusHiziGucluYamuk= { 8.5,9.5,12.8,15.2};

        double[] sureKisaYamuk = {-46.5,-25.28,22.3,39.9};
        double[] sureKisaUcgen = {22.3,39.9,57.5};
        double[] sureOrtaUcgen = { 39.9,57.5,75.1};
        double[] sureUzunUcgen = { 57.5,75.1,92.7};
        double[] sureUzunYamuk = { 75,92.7,111.6,130};

        double[] deterjanMiktariAzYamuk = { 0,0,20,85};
        double[] deterjanMiktariAzUcgen = { 20,85,150};
        double[] deterjanMiktariOrtaUcgen = {85,150,215};
        double[] deterjanMiktariFazlaUcgen = { 150,215,280};
        double[] deterjanMiktariFazlaYamuk= {215,280,300,300};

        public double donusHiziAOrt, sureAOrt, deterjanAOrt;

        List<string> donusHiziTip, sureTip, deterjanMiktariTip;
        List<double> mamdaniDegerler;
        public CikarimHesapla(List<string> donusHiziTip, List<string> sureTip, List<string> deterjanMiktariTip,List<double> mamdaniDegerler)
        {
            this.mamdaniDegerler = mamdaniDegerler;
            this.donusHiziTip = donusHiziTip;
            this.sureTip = sureTip;
            this.deterjanMiktariTip = deterjanMiktariTip;
            DonusHiziTur();
            sureTur();
            deterjanMiktariTur();
        }

        void DonusHiziTur()
        {
            double agirlikliToplam = 0;
            double agirliklarToplami = 0;
            for (int i = 0; i <mamdaniDegerler.Count ; i++)
            {
                if (donusHiziTip[i] == "Hassas")
                {
                    agirlikliToplam += mamdaniDegerler[i] * donusHiziHassasYamuk[2];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (donusHiziTip[i] == "Normal Hassas")
                {
                    agirlikliToplam += mamdaniDegerler[i] * donusHiziHassasUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (donusHiziTip[i] == "Orta")
                {
                    agirlikliToplam += mamdaniDegerler[i] * donusHiziOrtaUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (donusHiziTip[i] == "Normal Güçlü")
                {
                    agirlikliToplam += mamdaniDegerler[i] * donusHiziGucluUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if(donusHiziTip[i] == "Güçlü")
                {
                    agirlikliToplam += mamdaniDegerler[i] * donusHiziGucluYamuk[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
            }
            donusHiziAOrt = agirlikliToplam / agirliklarToplami;
            

        }
        void sureTur()
        {
            double agirlikliToplam = 0;
            double agirliklarToplami = 0;
            for (int i = 0; i < mamdaniDegerler.Count; i++)
            {
                if (sureTip[i] == "Kısa")
                {
                    agirlikliToplam += mamdaniDegerler[i] * sureKisaYamuk[2];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (sureTip[i] == "Normal Kısa")
                {
                    agirlikliToplam += mamdaniDegerler[i] * sureKisaUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (sureTip[i] == "Orta")
                {
                    agirlikliToplam += mamdaniDegerler[i] *sureOrtaUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (sureTip[i] == "Normal Uzun")
                {
                    agirlikliToplam += mamdaniDegerler[i] * sureUzunUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if(sureTip[i] == "Uzun")
                {
                    agirlikliToplam += mamdaniDegerler[i] * sureUzunYamuk[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
            }
            sureAOrt = agirlikliToplam / agirliklarToplami;

        }
        void deterjanMiktariTur()
        {
            double agirlikliToplam = 0;
            double agirliklarToplami = 0;
            for (int i = 0; i < mamdaniDegerler.Count; i++)
            {
                if (deterjanMiktariTip[i] == "Çok Az")
                {
                    agirlikliToplam += mamdaniDegerler[i] * deterjanMiktariAzUcgen[2];
                    agirliklarToplami += mamdaniDegerler[i];

                }
                else if (deterjanMiktariTip[i] == "Az")
                {
                    agirlikliToplam += mamdaniDegerler[i] * deterjanMiktariAzUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (deterjanMiktariTip[i] == "Orta")
                {
                    agirlikliToplam += mamdaniDegerler[i] * deterjanMiktariOrtaUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if (deterjanMiktariTip[i] == "Fazla")
                {
                    agirlikliToplam += mamdaniDegerler[i] *deterjanMiktariFazlaUcgen[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
                else if(deterjanMiktariTip[i] == "Çok Fazla")
                {
                    agirlikliToplam += mamdaniDegerler[i] * deterjanMiktariFazlaYamuk[1];
                    agirliklarToplami += mamdaniDegerler[i];
                }
            }
            deterjanAOrt= agirlikliToplam / agirliklarToplami;

        }

    }
}
