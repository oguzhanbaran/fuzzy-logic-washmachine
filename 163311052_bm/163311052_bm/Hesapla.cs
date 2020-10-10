using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_bm
{
    class Hesapla
    {

        private double hassaslik, miktar, kirlilik;
        public List<string> hassaslikDeger = new List<string>();
        public List<string> miktarDeger = new List<string>();
        public List<string> kirlilikDeger= new List<string>();
        public Hesapla(double hassaslik,double miktar,double kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
            HassaslikHesapla();
            MiktarHesapla();
            KirlilikHesapla();
            
        }
        public void HassaslikHesapla()
        {
            if (hassaslik>=0 && hassaslik<=4)
            {
                hassaslikDeger.Add("Sağlam");
            }
            else if (hassaslik >= 4 && hassaslik <= 5.5)
            {
                hassaslikDeger.Add("Orta");
            }
            else if (hassaslik >= 5.5 && hassaslik <= 10)
            {
                hassaslikDeger.Add("Hassas");
            }
            if ((hassaslik >= 3 && hassaslik <= 4) || (hassaslik >= 5.5 && hassaslik <= 7))
            {
                if (!hassaslikDeger.Contains("Orta"))
                {
                    hassaslikDeger.Add("Orta");
                }
                
            }
           
        }
        public void MiktarHesapla()
        {
            if (miktar >= 0 && miktar<= 4)
            {
                miktarDeger.Add("Küçük");
            }
            else if (miktar >= 4 && miktar<= 5.5)
            {
                miktarDeger.Add("Orta");
            }
            else if (miktar>= 5.5 && miktar<= 10)
            {
                miktarDeger.Add("Büyük");
            }
            if ((miktar >= 3 && miktar<= 4) || (miktar>= 5.5 && miktar<= 7))
            {
                if (!miktarDeger.Contains("Orta"))
                {
                    miktarDeger.Add("Orta");
                }
                
            }

        }
        public void KirlilikHesapla()
        {
            if (kirlilik >= 0 && kirlilik<= 4.5)
            {
                kirlilikDeger.Add("Küçük");
            }
            else if (kirlilik >= 4.5 && kirlilik<= 5.5)
            {
                kirlilikDeger.Add("Orta");
            }
            else if (kirlilik>= 5.5 && kirlilik<= 10)
            {
                kirlilikDeger.Add("Büyük");
            }
            if ((kirlilik >= 3 && kirlilik<= 4.5) || (kirlilik>= 5.5 && kirlilik<= 7))
            {
                if (!kirlilikDeger.Contains("Orta"))
                {
                    kirlilikDeger.Add("Orta");
                }
                
            }
        }
 
    }
}
