using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneye_Dayalı_Programlama_Proje_Ödevi
{
    interface IMeyveler
    {
        System.Drawing.Image Image { get; set; }
        string MeyveAdi { get; set; }
        string MeyveTuru { get; set; }
        double Verim { get; set; }
        double VitaminA();
        double VitaminC();
        double SPGramaj();

    }
    
}
