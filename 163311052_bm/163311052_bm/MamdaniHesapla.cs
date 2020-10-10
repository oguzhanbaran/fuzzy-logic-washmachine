using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_bm
{
    class MamdaniHesapla
    {
        double[] hasaslikSaglamYamuk = { -4, -1.5, 2, 4 };
        double[] hassaslikOrtaUcgen = { 3, 5, 7 };
        double[] hassaslikHassasYamuk = { 5.5, 8, 12.5, 14 };

        double[] miktarKucukYamuk = { -4, -1.5, 2, 4 };
        double[] miktarOrtaUcgen = { 3, 5, 7 };
        double[] miktarBuyukYamuk = { 5.5, 8, 12.5, 14 };

        double[] kirlilikKucukYamuk = { -4.5, -2.5, 2, 4.5 };
        double[] kirlilikOrtaUcgen = { 3, 5, 7 };
        double[] kirlilikBuyukYamuk = { 5.5, 8, 12.5, 15 };

        double HassaslikDegeri, MiktarDegeri, KirlilikDegeri;

        public string hassaslikTur, miktarTur, kirlilikTur;
        private double hassaslik, miktar, kirlilik;
        public List<string> hassaslikDeger = new List<string>();
        public List<string> miktarDeger = new List<string>();
        public List<string> kirlilikDeger = new List<string>();
        
       public MamdaniHesapla(string hassaslikTur,double hassaslik,string miktarTur,double miktar,string kirlilikTur,double kirlilik)
        {
            this.hassaslikTur = hassaslikTur;
            this.miktarTur = miktarTur;
            this.kirlilikTur = kirlilikTur;

            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
        }
        public double HassaslikMamdani(double gHDeger, string hassaslikTur)
        {
            if (hassaslikTur == "Ucgen")
            {
                if (gHDeger >= hassaslikOrtaUcgen[0] && gHDeger <= hassaslikOrtaUcgen[1])
                {
                    HassaslikDegeri = (gHDeger - hassaslikOrtaUcgen[0]) / (hassaslikOrtaUcgen[1] - hassaslikOrtaUcgen[0]);
                }
                else if (gHDeger >= hassaslikOrtaUcgen[1] && gHDeger <= hassaslikOrtaUcgen[2])
                {
                    HassaslikDegeri = (hassaslikOrtaUcgen[2] - gHDeger) / (hassaslikOrtaUcgen[2] - hassaslikOrtaUcgen[1]);
                }
                else
                    HassaslikDegeri = 0;
            }

            else if (hassaslikTur == "SaglamYamuk")
            {
                if (gHDeger >= hasaslikSaglamYamuk[0] && gHDeger <= hasaslikSaglamYamuk[1])
                {
                    HassaslikDegeri = (gHDeger - hasaslikSaglamYamuk[0]) / (hasaslikSaglamYamuk[1] - hasaslikSaglamYamuk[0]);
                }
                else if (gHDeger >= hasaslikSaglamYamuk[1] && gHDeger <= hasaslikSaglamYamuk[2])
                {
                    HassaslikDegeri = 1;
                }
                else if (gHDeger >= hasaslikSaglamYamuk[2] && gHDeger <= hasaslikSaglamYamuk[3])
                {
                    HassaslikDegeri = (hasaslikSaglamYamuk[3] - gHDeger) / (hasaslikSaglamYamuk[3] - hasaslikSaglamYamuk[2]);
                }
                else
                    HassaslikDegeri = 0;
            }

            else if (hassaslikTur == "HassasYamuk")
            {
                if (gHDeger >= hassaslikHassasYamuk[0] && gHDeger <= hassaslikHassasYamuk[1])
                {
                    HassaslikDegeri = (gHDeger - hassaslikHassasYamuk[0]) / (hassaslikHassasYamuk[1] - hassaslikHassasYamuk[0]);
                }
                else if (gHDeger >= hassaslikHassasYamuk[1] && gHDeger <= hassaslikHassasYamuk[2])
                {
                    HassaslikDegeri = 1;
                }
                else if (gHDeger >= hassaslikHassasYamuk[2] && gHDeger <= hassaslikHassasYamuk[3])
                {
                    HassaslikDegeri = (hasaslikSaglamYamuk[3] - gHDeger) / (hassaslikHassasYamuk[3] - hassaslikHassasYamuk[2]);
                }
                else
                    HassaslikDegeri = 0;
            }
            return HassaslikDegeri;
        }

        public double MiktarMamdani(double gMDeger, string miktarTur)
        {
            if (miktarTur == "Ucgen")
            {
                if (gMDeger >= miktarOrtaUcgen[0] && gMDeger <= miktarOrtaUcgen[1])
                {
                    MiktarDegeri = (gMDeger - miktarOrtaUcgen[0]) / (miktarOrtaUcgen[1] - miktarOrtaUcgen[0]);
                }
                else if (gMDeger >= miktarOrtaUcgen[1] && gMDeger <= miktarOrtaUcgen[2])
                {
                    MiktarDegeri = (miktarOrtaUcgen[2] - gMDeger) / (miktarOrtaUcgen[2] - miktarOrtaUcgen[1]);
                }
                else
                    MiktarDegeri = 0;
            }

            else if (miktarTur == "KucukYamuk")
            {
                if (gMDeger >= miktarKucukYamuk[0] && gMDeger <= miktarKucukYamuk[1])
                {
                    MiktarDegeri = (gMDeger - miktarKucukYamuk[0]) / (miktarKucukYamuk[1] - miktarKucukYamuk[0]);
                }
                else if (gMDeger >= miktarKucukYamuk[1] && gMDeger <= miktarKucukYamuk[2])
                {
                    MiktarDegeri = 1;
                }
                else if (gMDeger >= miktarKucukYamuk[2] && gMDeger <= miktarKucukYamuk[3])
                {
                    MiktarDegeri = (miktarKucukYamuk[3] - gMDeger) / (miktarKucukYamuk[3] - miktarKucukYamuk[2]);
                }
                else
                    MiktarDegeri = 0;
            }

            else if (miktarTur == "BuyukYamuk")
            {
                if (gMDeger >= miktarBuyukYamuk[0] && gMDeger <= miktarBuyukYamuk[1])
                {
                    MiktarDegeri = (gMDeger - miktarBuyukYamuk[0]) / (miktarBuyukYamuk[1] - miktarBuyukYamuk[0]);
                }
                else if (gMDeger >= miktarBuyukYamuk[1] && gMDeger <= miktarBuyukYamuk[2])
                {
                    MiktarDegeri = 1;
                }
                else if (gMDeger >= miktarBuyukYamuk[2] && gMDeger <= miktarBuyukYamuk[3])
                {
                    MiktarDegeri = (miktarKucukYamuk[3] - gMDeger) / (miktarBuyukYamuk[3] - miktarBuyukYamuk[2]);
                }
                else
                    MiktarDegeri = 0;
            }
            return MiktarDegeri;
        }

        public double KirlilikMamdani(double gKDeger, string kirlilikTur)
        {
            if (kirlilikTur == "Ucgen")
            {
                if (gKDeger >= kirlilikOrtaUcgen[0] && gKDeger <= kirlilikOrtaUcgen[1])
                {
                    KirlilikDegeri = (gKDeger - kirlilikOrtaUcgen[0]) / (kirlilikOrtaUcgen[1] - kirlilikOrtaUcgen[0]);
                }
                else if (gKDeger >= kirlilikOrtaUcgen[1] && gKDeger <= kirlilikOrtaUcgen[2])
                {
                    KirlilikDegeri = (kirlilikOrtaUcgen[2] - gKDeger) / (kirlilikOrtaUcgen[2] - kirlilikOrtaUcgen[1]);
                }
                else
                    KirlilikDegeri = 0;
            }

            else if (kirlilikTur == "KucukYamuk")
            {
                if (gKDeger >= kirlilikKucukYamuk[0] && gKDeger <= kirlilikKucukYamuk[1])
                {
                    KirlilikDegeri = (gKDeger - kirlilikKucukYamuk[0]) / (kirlilikKucukYamuk[1] - kirlilikKucukYamuk[0]);
                }
                else if (gKDeger >= kirlilikKucukYamuk[1] && gKDeger <= kirlilikKucukYamuk[2])
                {
                    KirlilikDegeri = 1;
                }
                else if (gKDeger >= kirlilikKucukYamuk[2] && gKDeger <= kirlilikKucukYamuk[3])
                {
                    KirlilikDegeri = (kirlilikKucukYamuk[3] - gKDeger) / (kirlilikKucukYamuk[3] - kirlilikKucukYamuk[2]);
                }
                else
                    KirlilikDegeri = 0;
            }

            else if (kirlilikTur == "BuyukYamuk")
            {
                if (gKDeger >= kirlilikBuyukYamuk[0] && gKDeger <= kirlilikBuyukYamuk[1])
                {
                    KirlilikDegeri = (gKDeger - kirlilikBuyukYamuk[0]) / (kirlilikBuyukYamuk[1] - kirlilikBuyukYamuk[0]);
                }
                else if (gKDeger >= kirlilikBuyukYamuk[1] && gKDeger <= kirlilikBuyukYamuk[2])
                {
                    KirlilikDegeri = 1;
                }
                else if (gKDeger >= kirlilikBuyukYamuk[2] && gKDeger <= kirlilikBuyukYamuk[3])
                {
                    KirlilikDegeri = (kirlilikKucukYamuk[3] - gKDeger) / (kirlilikBuyukYamuk[3] - kirlilikBuyukYamuk[2]);
                }
                else
                    KirlilikDegeri = 0;

            }
            return KirlilikDegeri;
        }

        List<double> mamdaniDegerleri = new List<double>();
        double minDeger;
        public double MamdaniHesap()
        {
            double hassaslikDegerim = HassaslikMamdani(hassaslik, hassaslikTur);
            double miktarDegerim = MiktarMamdani(miktar, miktarTur);
            double kirlilikDegerim = KirlilikMamdani(kirlilik, kirlilikTur);
            mamdaniDegerleri.Add(hassaslikDegerim);
            mamdaniDegerleri.Add(miktarDegerim);
            mamdaniDegerleri.Add(kirlilikDegerim);
            minDeger = mamdaniDegerleri.Min();
            mamdaniDegerleri.Clear();
            return minDeger;
        }
    }
}
