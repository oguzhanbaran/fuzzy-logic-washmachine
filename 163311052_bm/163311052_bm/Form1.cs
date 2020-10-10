using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _163311052_bm
{
    public partial class b_mantık : Form
    {
        public b_mantık()
        {
            InitializeComponent();
        }
        double hassaslik,kirlilik,miktar;
        public void ListviewDoldur()
        {
            kuralList.Items.Clear();
            int sayac = 1;
            for (int i = 0; i < 27; i++)
            {
                ListViewItem satir = new ListViewItem((sayac).ToString());
                for (int j = 0; j < 6; j++)
                    satir.SubItems.Add(KuralSec.KuralTablosu[i, j].ToString());

                kuralList.Items.Add(satir);
                sayac++;
            }
        }
        private void B_mantık_Load(object sender, EventArgs e)
        {
           
            kuralList.Columns.Add("No", 50, HorizontalAlignment.Center);
            kuralList.Columns.Add("Hassaslık", 80, HorizontalAlignment.Center);
            kuralList.Columns.Add("Miktar", 75, HorizontalAlignment.Center);
            kuralList.Columns.Add("Kirlilik", 72, HorizontalAlignment.Center);
            kuralList.Columns.Add("DönüşHızı", 105, HorizontalAlignment.Center);
            kuralList.Columns.Add("Süre", 80, HorizontalAlignment.Center);
            kuralList.Columns.Add("Deterjan", 65, HorizontalAlignment.Center);
            kuralList.View = View.Details;
            ListviewDoldur();
            
        }
        List<string> hassaslikDeger, miktarDeger, kirlilikDeger;
        private void BtnCalistir_Click(object sender, EventArgs e)
        {
            ListViewTemizle();
            mamdaniDegerleri.Items.Clear();
            lblHassaslikGoster.Text = "";
            lblKirlilikGoster.Text = "";
            lblMiktarGoster.Text = "";
            hassaslik = (double) numericHassaslik.Value;
            kirlilik= (double)numericKirlilik.Value;
            miktar = (double)numericMiktar.Value;
            Hesapla yeniHesap = new Hesapla(hassaslik,miktar, kirlilik);
            hassaslikDeger = yeniHesap.hassaslikDeger;
            miktarDeger = yeniHesap.miktarDeger;
            kirlilikDeger = yeniHesap.kirlilikDeger;
            for (int i = 0; i < yeniHesap.hassaslikDeger.Count; i++)
            {
                lblHassaslikGoster.Text += " "+yeniHesap.hassaslikDeger[i];
            }
            for (int i = 0; i < yeniHesap.kirlilikDeger.Count; i++)
            {
                lblKirlilikGoster.Text += " " +yeniHesap.kirlilikDeger[i];
            }
            for (int i = 0; i < yeniHesap.miktarDeger.Count; i++)
            {
                lblMiktarGoster.Text +=" "+ yeniHesap.miktarDeger[i];
            }
            KuralSecim();
            OrtalamaHesapla();
        }
        public void ListViewTemizle()
        {
           
                        for (int n = 0; n < 27; n++)
                        {
                            kuralList.Items[n].BackColor = Color.White;
                            kuralList.Items[n].ForeColor = Color.Black;
                        }
        }
        private void NumericValueChanged(object sender,EventArgs e)
        {
            hassaslikTrc.Value =(int) (numericHassaslik.Value*10) ;
            kirlilikTrc.Value = (int)(numericKirlilik.Value*10);
            miktarTrc.Value = (int)(numericMiktar.Value*10);
        }
        
        List<string> donusHiziTip, sureTip, deterjanTip;
        List<double> mamdaniDeger;
        public void KuralSecim()
        {
            donusHiziTip = new List<string>();
            sureTip = new List<string>();
            deterjanTip = new List<string>();
            mamdaniDeger = new List<double>();
            string[,] kuralListe = KuralSec.KuralTablosu;
            for (int k = 0; k < hassaslikDeger.Count; k++)
            {
                for (int l = 0; l < miktarDeger.Count; l++)
                {
                    for (int m = 0; m < kirlilikDeger.Count; m++)
                    {
                        for (int n = 0; n < 27; n++)
                        {
                            if (kuralListe[n, 0] == hassaslikDeger[k] && kuralListe[n, 1] == miktarDeger[l] && kuralListe[n, 2] == kirlilikDeger[m])
                            {
                                donusHiziTip.Add(kuralListe[n, 3]);
                                sureTip.Add(kuralListe[n, 4]);
                                deterjanTip.Add(kuralListe[n, 5]);
                                GirisTip yeniTur = new GirisTip(hassaslikDeger[k],miktarDeger[l],kirlilikDeger[m]);
                                MamdaniHesapla yeniDeger = new MamdaniHesapla(yeniTur.hassaslikTur, hassaslik, yeniTur.miktarTur, miktar, yeniTur.kirlilikTur, kirlilik);
                                double donenDeger = yeniDeger.MamdaniHesap();
                                mamdaniDeger.Add(donenDeger);
                                mamdaniDegerleri.Items.Add(n+1+".  "+donenDeger);
                                kuralList.Items[n].BackColor = Color.Blue;
                                kuralList.Items[n].ForeColor = Color.White;
                                n++;
                            }
                        }
                    }
                }
            }
        }
        public void OrtalamaHesapla()
        {
            CikarimHesapla yeniCikarim = new CikarimHesapla(donusHiziTip, sureTip, deterjanTip, mamdaniDeger);
            donusHiziLbl.Text = "Dönüş Hızı Ağırlıklı Ortalaması:" + yeniCikarim.donusHiziAOrt.ToString();
            sureLbl.Text = "Süre Ağırlıklı Ortalaması:" + yeniCikarim.sureAOrt.ToString();
            deterjanLbl.Text = "Deterjan Miktarı Ağırlıklı Ortalaması:" + yeniCikarim.deterjanAOrt.ToString();
        }
    }
}
