using System;
using System.Windows.Forms;
using System.Drawing;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Resim_Hafiza_Oyunu
{
    public partial class Oyun_Tahtasi : Form
    {
        Ana_Arkaplan arkaplan;
        Resim resim;
        SatirSayisi satirSayisi;
        string menuSev, klasorAd;
        Kutu kutuSayisi;
       
        public Oyun_Tahtasi(string menuSeviye,string klasorAdi)
        {
            InitializeComponent();
            menuSev = menuSeviye;
            klasorAd = klasorAdi;
        }

        private void tmrBekleme_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            tmrBekleme.Stop();
        }

        private void Oyun_Tahtasi_Load(object sender, EventArgs e)
        {
            arkaplan = new Ana_Arkaplan(tmrBekleme);
            resim = new Resim(klasorAd);
            kutuSayisi = new Kutu(menuSev);
            satirSayisi = new SatirSayisi(menuSev);
            
            this.WindowState = FormWindowState.Maximized;
            pnl_oyun_paneli.BackColor = Color.Red;
            pnl_oyun_paneli.Size = new Size(700, 700);
    


            arkaplan.KutuYarat(Convert.ToInt32(satirSayisi.RowNumber) , Convert.ToInt32(kutuSayisi.KutuBoyutu),ref pnl_oyun_paneli, resim.KlasordekiResimSayisi, resim);

        }
    }
}
