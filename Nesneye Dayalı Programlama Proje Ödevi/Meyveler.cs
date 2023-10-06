using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneye_Dayalı_Programlama_Proje_Ödevi
{
    class Meyveler : IMeyveler
    {
        string _meyveAdi;
        string _meyveTuru;
        double _verim;
        double _vitaminA;
        double _vitaminC;
        Image _image;
        public string MeyveAdi { get { return _meyveAdi; } set { } }
        public string MeyveTuru { get { return _meyveTuru; } set {  } }
        public double Verim { get { return _verim; } set {  } }
        public Image Image { get { return _image; } set { } }

        public Meyveler(string ad, string tur, double verim, double vitA, double vitC,Image image )
        {
            _meyveAdi = ad;
            _meyveTuru = tur;
            _verim = verim;
            _vitaminA = vitA;
            _vitaminC = vitC;
            _image = image;
        }

        public double SPGramaj()
        {
            return Gramaj._gramaj / 100 * _verim;
        }

        public double VitaminA()//iu
        {
            return Gramaj._gramaj / 100 * _vitaminA;
        }

        public double VitaminC()//mg
        {
            return Gramaj._gramaj / 100 * _vitaminC;
        }


     

        


    }
}
