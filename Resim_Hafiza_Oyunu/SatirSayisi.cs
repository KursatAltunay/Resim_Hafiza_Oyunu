using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resim_Hafiza_Oyunu
{
    class SatirSayisi
    {
        int _satirSayisi;
        public int RowNumber { get { return _satirSayisi; } set { } }

        public SatirSayisi(string seviye)
        {

            switch (seviye)
            {
                case "Kolay":
                    _satirSayisi = 4;

                    break;
                case "Orta":
                    _satirSayisi = 6;

                    break;
                case "Zor":
                    _satirSayisi = 10;

                    break;
            }
        }
    }
}
