using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resim_Hafiza_Oyunu
{
    public class Resim
    {
        private string _dosyaYolu;
        private string _dosyaTamAdi;
        private string _dosyaAdi;
        private int _klasordekiResimSayisi;
        //C:\Users\MusTapHa\source\repos\Denemeler\Resim_Hafıza_Oyunu\Resim_Hafiza_Oyunu\Resimler
        //C:\Users\MusTapHa\source\repos\Denemeler\Resim_Hafıza_Oyunu\Resim_Hafiza_Oyunu\Resimler\Emoji Nature
        public Resim(string secilenDosyaAdi)
        {
            _dosyaAdi = secilenDosyaAdi;

            switch (_dosyaAdi) //Nature Objects Places Smiley Symbols
            {
                case "Nature":
                    _dosyaYolu = @"Emoji Nature\Emoji Natur-";
                    break;
                case "Objects":
                    _dosyaYolu = @"Emoji Objects\Emoji Objects-.";
                    break;
                case "Places":
                    _dosyaYolu = @"Emoji Places\Emoji Orte-.";
                    break;
                case "Smiley":
                    _dosyaYolu = @"Emoji Smiley\Emoji Smiley-.";
                    break;
                case "Symbols":
                    _dosyaYolu = @"Emoji Symbols\Emoji Symbols-.";
                    break;
            }

            _dosyaYolu = @"C:\Users\MusTapHa\source\repos\Denemeler\Resim_Hafıza_Oyunu\Resim_Hafiza_Oyunu\Resimler\" + _dosyaYolu;


            switch (_dosyaAdi)
            {
                case "Nature":
                    _klasordekiResimSayisi = 116;
                    break;
                case "Objects":
                    _klasordekiResimSayisi = 230;
                    break;
                case "Places":
                    _klasordekiResimSayisi = 101;
                    break;
                case "Smiley":
                    _klasordekiResimSayisi = 189;
                    break;
                case "Symbols":
                    _klasordekiResimSayisi = 209;
                    break;

            }
        }


        public string DosyaYolu //Programın dizinine atılan resimlerin dosya yolu, resimlerin sonundaki numaralara kadar adres olarak alındı.
        {
            get { return _dosyaYolu; }

        }


        public int KlasordekiResimSayisi //klasörlerdeki resim sayıları rastgele sayı çekmek için alındı
        {
            get { return _klasordekiResimSayisi; }
        }

        public string DosyaTamAdi { get { return _dosyaTamAdi; } set { _dosyaTamAdi = _dosyaYolu + value + ".png"; } }
    }
}
