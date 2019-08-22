using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resim_Hafiza_Oyunu
{
    class Seviye
    {
        string _seviye;


        public string ZorlukSeviyesi
        {
            get
            {
                return _seviye;
            }
            set
            {
                //SatirSayisi satirSayisi = new SatirSayisi();
                //Kutu kutuBoyutu = new Kutu();

                //switch (value)
                //{
                //    case "Kolay":
                //        satirSayisi.RowNumber = 4;
                //        kutuBoyutu.KutuBoyutu = 50;
                //        break;
                //    case "Orta":
                //        satirSayisi.RowNumber = 6;
                //        kutuBoyutu.KutuBoyutu = 50;
                //        break;
                //    case "Zor":
                //        satirSayisi.RowNumber = 10;
                //        kutuBoyutu.KutuBoyutu = 50;
                //        break;
                //}

                _seviye = value;

            }
        }
    }
}
