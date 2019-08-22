using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resim_Hafiza_Oyunu
{
    class Kutu
    {
        int _kutuBoyutu;
        public int KutuBoyutu { get { return _kutuBoyutu; } set { } }

        public Kutu(string seviye)
        {
            switch (seviye)
            {
                case "Kolay":

                    _kutuBoyutu = 100;
                    break;
                case "Orta":

                    _kutuBoyutu = 40;
                    break;
                case "Zor":

                    _kutuBoyutu = 30;
                    break;
            }

        }
    }
}
