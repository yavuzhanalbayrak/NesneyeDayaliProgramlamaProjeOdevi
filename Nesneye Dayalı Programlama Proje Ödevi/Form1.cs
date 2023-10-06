        /****************************************************************************
        **					     SAKARYA ÜNİVERSİTESİ
        **			   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
        **				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
        **				    NESNEYE DAYALI PROGRAMLAMA DERSİ
        **					     2020-2021 BAHAR DÖNEMİ
        **	
        **				    ÖDEV NUMARASI..........: Proje Ödevi
        **				    ÖĞRENCİ ADI............: Yavuzhan ALBAYRAK
        **				    ÖĞRENCİ NUMARASI.......: G201210008
        **                  DERSİN ALINDIĞI GRUP...: B Grubu
        ****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayalı_Programlama_Proje_Ödevi
{
   
    public partial class Form1 : Form
    {
        
        Meyveler portakal = new Meyveler("Portakal", "Sıvı", 54, 225, 45, Image.FromFile("portakal.jpg"));//Meyvelerin değerleri girildi.
        Meyveler mandalina = new Meyveler("Mandalina", "Sıvı", 32, 681, 26, Image.FromFile("mandalina.jpg"));
        Meyveler greyfurt = new Meyveler("Greyfurt", "Sıvı", 69, 3, 44, Image.FromFile("greyfurt.jpg"));
        Meyveler elma = new Meyveler("Elma", "Katı", 82, 54, 5, Image.FromFile("elma.jpg"));
        Meyveler armut = new Meyveler("Armut", "Katı", 93, 25, 5, Image.FromFile("armut.jpg"));
        Meyveler cilek = new Meyveler("Çilek", "Katı", 89, 12, 60, Image.FromFile("cilek.jpg"));
        int time = 60;
        string[] meyvelerarray = { "Portakal", "Mandalina", "Greyfurt", "Elma", "Armut", "Çilek" };//Rastgele resim çağırmak için oluşturulmuş bir dizi.
        
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnYeniMeyve.Enabled = false;//Program başlatılmadığı sürece butonlar aktif olmaz.
            btnKati.Enabled = false;
            btnNarenciye.Enabled = false;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblMeyveadi_Click(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            lblMeyveadi.Text = meyvelerarray[random.Next(0, 6)];//Program başladığında rastgele meyve çağırılır.
            
            ResimKontrol();//Meyveye uygun resim çağırılır.
            
            Gramaj._gramaj = random.Next(70, 120);//Rastgele bir meyve gramajı atanır.
            time = 60;//Zaman sıfırlanır.
            timer.Start();//Zamanlayıcı başlatılır.
            btnYeniMeyve.Enabled = true;//Butonlar yeniden aktif olur.
            btnKati.Enabled = true;
            btnNarenciye.Enabled = true;
            btnBasla.Enabled = false;//Program bitene kadar başlat butonu kapalı kalır.
            listName.Items.Clear();//Program yeniden başlatıldığında tüm işlemler silinir.
            listGramaj.Items.Clear();
            listVA.Items.Clear();
            listVC.Items.Clear();
            listPS.Items.Clear();
            lblGramaj.Text = "";
            lblVA.Text = "";
            lblVC.Text = "";
            lblPS.Text = "";
            lblTA.Text = "";
            lblTC.Text = "";
            lblTPS.Text = "";
        }
        
        private void timer1_Tick(object sender, EventArgs e)//Süre tutucu.
        {


            if ( time >= 0) //Zamanlayıcı 60.snden başlayıp 0 olana kadar devam eder.
            {
                
                timer.Interval = 1000;//Komut 1000ms'de 1 döner.
                int sayac = time--;//Her saniye zaman 1 azalır.
                lblSure.Text = sayac.ToString();//Kalan süre yazdırılır.
            }
            else//Zamanlayıcı 0 olduğunda program durur.
            {
                btnYeniMeyve.Enabled = false;//Program durduğunda tüm işlemler etkisiz hale gelir.
                btnKati.Enabled = false;
                btnNarenciye.Enabled = false;
                btnBasla.Enabled = true;//Program bittiğinde başlat butonu aktif olur.
                timer.Stop();//Zamanlayıcı durur.
            }
        }

        private void btnNarenciye_Click(object sender, EventArgs e)
        {

            if (lblMeyveadi.Text == portakal.MeyveAdi) 
            {
                lblGramaj.Text = Gramaj._gramaj.ToString();//Labellara çıkan sonuçlar girildi.
                lblVA.Text = portakal.VitaminA().ToString();
                lblVC.Text = portakal.VitaminC().ToString();
                lblPS.Text = portakal.SPGramaj().ToString();
                listName.Items.Add(portakal.MeyveAdi);//Listelere işlemler kalıcı olarak eklendi.
                listGramaj.Items.Add(Gramaj._gramaj);
                listVA.Items.Add(portakal.VitaminA());
                listVC.Items.Add(portakal.VitaminC());
                listPS.Items.Add(portakal.SPGramaj());
                Gramaj._tplmPS += portakal.SPGramaj();
                Gramaj._tplmVA += portakal.VitaminA();
                Gramaj._tplmVC += portakal.VitaminC();
                ToplamYazdir();//Toplam değerleri yazan fonksiyon.
            }
            else if (lblMeyveadi.Text == mandalina.MeyveAdi)
            {
                lblGramaj.Text = Gramaj._gramaj.ToString();//Labellara çıkan sonuçlar girildi.
                lblVA.Text = mandalina.VitaminA().ToString();
                lblVC.Text = mandalina.VitaminC().ToString();
                lblPS.Text = mandalina.SPGramaj().ToString();
                listName.Items.Add(mandalina.MeyveAdi);//Listelere işlemler kalıcı olarak eklendi.
                listGramaj.Items.Add(Gramaj._gramaj);
                listVA.Items.Add(mandalina.VitaminA());
                listVC.Items.Add(mandalina.VitaminC());
                listPS.Items.Add(mandalina.SPGramaj());
                Gramaj._tplmPS += mandalina.SPGramaj();
                Gramaj._tplmVA += mandalina.VitaminA();
                Gramaj._tplmVC += mandalina.VitaminC();
                ToplamYazdir();//Toplam değerleri yazan fonksiyon.
            }
            else if (lblMeyveadi.Text == greyfurt.MeyveAdi)
            {
                lblGramaj.Text = Gramaj._gramaj.ToString();//Labellara çıkan sonuçlar girildi.
                lblVA.Text = greyfurt.VitaminA().ToString();
                lblVC.Text = greyfurt.VitaminC().ToString();
                lblPS.Text = greyfurt.SPGramaj().ToString();
                listName.Items.Add(greyfurt.MeyveAdi);//Listelere işlemler kalıcı olarak eklendi.
                listGramaj.Items.Add(Gramaj._gramaj);
                listVA.Items.Add(greyfurt.VitaminA());
                listVC.Items.Add(greyfurt.VitaminC());
                listPS.Items.Add(greyfurt.SPGramaj());
                Gramaj._tplmPS += greyfurt.SPGramaj();
                Gramaj._tplmVA += greyfurt.VitaminA();
                Gramaj._tplmVC += greyfurt.VitaminC();
                ToplamYazdir();//Toplam değerleri yazan fonksiyon.
            }




            btnNarenciye.Enabled = false;//Yeni meyve gelene kadar buton kullanılmaz hale gelir.
        }

        private void btnKati_Click(object sender, EventArgs e)
        {
            if (lblMeyveadi.Text == elma.MeyveAdi)
            {
                lblGramaj.Text = Gramaj._gramaj.ToString();//Labellara çıkan sonuçlar girildi.
                lblVA.Text = elma.VitaminA().ToString();
                lblVC.Text = elma.VitaminC().ToString();
                lblPS.Text = elma.SPGramaj().ToString();
                listName.Items.Add(elma.MeyveAdi);//Listelere işlemler kalıcı olarak eklendi.
                listGramaj.Items.Add(Gramaj._gramaj);
                listVA.Items.Add(elma.VitaminA());
                listVC.Items.Add(elma.VitaminC());
                listPS.Items.Add(elma.SPGramaj());
                Gramaj._tplmPS += elma.SPGramaj();
                Gramaj._tplmVA += elma.VitaminA();
                Gramaj._tplmVC += elma.VitaminC();
                ToplamYazdir();//Toplam değerleri yazan fonksiyon.

            }
            else if (lblMeyveadi.Text == armut.MeyveAdi)
            {
                lblGramaj.Text = Gramaj._gramaj.ToString();//Labellara çıkan sonuçlar girildi.
                lblVA.Text = armut.VitaminA().ToString();
                lblVC.Text = armut.VitaminC().ToString();
                lblPS.Text = armut.SPGramaj().ToString();
                listName.Items.Add(armut.MeyveAdi);//Listelere işlemler kalıcı olarak eklendi.
                listGramaj.Items.Add(Gramaj._gramaj);
                listVA.Items.Add(armut.VitaminA());
                listVC.Items.Add(armut.VitaminC());
                listPS.Items.Add(armut.SPGramaj());
                Gramaj._tplmPS += armut.SPGramaj();
                Gramaj._tplmVA += armut.VitaminA();
                Gramaj._tplmVC += armut.VitaminC();
                ToplamYazdir();//Toplam değerleri yazan fonksiyon.
            }
            else if (lblMeyveadi.Text == cilek.MeyveAdi)
            {
                lblGramaj.Text = Gramaj._gramaj.ToString();//Labellara çıkan sonuçlar girildi.
                lblVA.Text = cilek.VitaminA().ToString();
                lblVC.Text = cilek.VitaminC().ToString();
                lblPS.Text = cilek.SPGramaj().ToString();
                listName.Items.Add(cilek.MeyveAdi);//Listelere işlemler kalıcı olarak eklendi.
                listGramaj.Items.Add(Gramaj._gramaj);
                listVA.Items.Add(cilek.VitaminA());
                listVC.Items.Add(cilek.VitaminC());
                listPS.Items.Add(cilek.SPGramaj());
                Gramaj._tplmPS += cilek.SPGramaj();
                Gramaj._tplmVA += cilek.VitaminA();
                Gramaj._tplmVC += cilek.VitaminC();
                ToplamYazdir();//Toplam değerleri yazan fonksiyon.


            }




            btnKati.Enabled = false;//Yeni meyve gelene kadar buton kullanılmaz hale gelir.
        }



        private void btnYeniMeyve_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            lblMeyveadi.Text = meyvelerarray[random.Next(0, 6)];//Yeni rastgele meyve çağırılır.
            Gramaj._gramaj = random.Next(70, 120);//Rastgele gramaj oluşturulur.
            lblGramaj.Text = "";//Eski bilgiler silinir.
            lblVA.Text = "";
            lblVC.Text = "";
            lblPS.Text = "";

            ResimKontrol();//Meyveye uygun resim çağırılır.

            btnKati.Enabled = true;//Sıkacaklar yeniden aktif olur.
            btnNarenciye.Enabled = true;
        }
        public void ResimKontrol()
        {
            if (lblMeyveadi.Text == portakal.MeyveAdi)//if koşulu ile doğru meyvenin resminin getirilmesi kontrol ediliyor.
            {
                resim.Image = portakal.Image;
            }
            if (lblMeyveadi.Text == mandalina.MeyveAdi)
            {
                resim.Image = mandalina.Image;
            }
            if (lblMeyveadi.Text == greyfurt.MeyveAdi)
            {
                resim.Image = greyfurt.Image;
            }
            if (lblMeyveadi.Text == elma.MeyveAdi)
            {
                resim.Image = elma.Image;
            }
            if (lblMeyveadi.Text == armut.MeyveAdi)
            {
                resim.Image = armut.Image;
            }
            if (lblMeyveadi.Text == cilek.MeyveAdi)
            {
                resim.Image = cilek.Image;
            }
        }
        public void ToplamYazdir()//Toplam değerleri yazmaya yarayan fonksiyon.
        {
            lblTA.Text = Gramaj._tplmVA.ToString();
            lblTC.Text = Gramaj._tplmVC.ToString();
            lblTPS.Text = Gramaj._tplmPS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//Programı kapatır.
        }
    }


    

   
    
}
