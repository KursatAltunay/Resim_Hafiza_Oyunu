using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Resim_Hafiza_Oyunu
{
    public  class Ana_Arkaplan
    {
        PictureBox kutu;
        Random rnd = new Random();
        Dictionary<int, int> Eslesme = new Dictionary<int, int>();
        List<int> cikanResimler = new List<int>();
        int resimIndisi = -1;
        int ilkTiklananResim = -1;
        int tiklanmaSayisi = 0;
        string dosyaYolu;
        PictureBox ilkTiklananKutu;
        Resim resimEkle;
        Timer _tmrBeklemeClass;

        public Ana_Arkaplan(Timer tmrBeklemeClass)
        {
            _tmrBeklemeClass = tmrBeklemeClass;
        }
        

        // Panel panel; //panel formda 70*70 eklendikten sonra burada ondan nesne alınarak butonlar eklenecek

        public void KutuYarat(int satirSayisi, int kutuBoyutu,ref Panel panel, int resimKlasorundekiSayiAdedi, Resim resim)
        {
            resimEkle = resim;
            int /*oluşacak*/toplamKutuSayisi = satirSayisi * satirSayisi;
            int sayac = 0;

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < satirSayisi; j++)
                {
                    kutu = new PictureBox();
                    kutu.Size = new Size(kutuBoyutu, kutuBoyutu);
                    kutu.Location = new Point(i * (kutuBoyutu+5), j * (kutuBoyutu+5));
                    kutu.SizeMode = PictureBoxSizeMode.StretchImage;
                    sayac++;
                    kutu.Tag = sayac;
                    kutu.BackColor = Color.Yellow;
                    panel.Controls.Add(kutu);


                    YaratilanKutuylaResimEslestir(sayac, toplamKutuSayisi, resimKlasorundekiSayiAdedi, ref Eslesme, ref cikanResimler);

                    //kutu.Click += new EventHandler (Kutuya_Tikla(kutu, Eslesme,(int)kutu.Tag,dosyaYolu,out tiklananResimIndexi));
                    kutu.Click += Tikla_Karsilastir_Kapat;
                }
            }
        }

        public void Tikla_Karsilastir_Kapat(object sender, EventArgs e)
        {
            PictureBox tiklananKutu = sender as PictureBox;
            int tiklananResimIndisi = Eslesme[(int)tiklananKutu.Tag];
            tiklananKutu.ImageLocation = dosyaYolu + tiklananResimIndisi.ToString();

            switch (tiklanmaSayisi)
            {
                case 0:
                    tiklanmaSayisi++;
                    ilkTiklananResim = tiklananResimIndisi;
                    ilkTiklananKutu = tiklananKutu; // hata verirse new atmak gerekebilir
                    resimEkle.DosyaTamAdi = tiklananResimIndisi.ToString();
                    tiklananKutu.ImageLocation = resimEkle.DosyaTamAdi;
                    break;

                case 1:
                    //_tmrBeklemeClass.Enabled = true;
                    if (ilkTiklananResim == tiklananResimIndisi)
                    {
                        resimEkle.DosyaTamAdi = tiklananResimIndisi.ToString();
                        tiklananKutu.ImageLocation = resimEkle.DosyaTamAdi;
                        //_tmrBeklemeClass.Start();
                        wait(1000);
                        ilkTiklananKutu.Visible = false;
                        Eslesme.Remove((int)ilkTiklananKutu.Tag);
                        tiklananKutu.Visible = false;
                        Eslesme.Remove((int)tiklananKutu.Tag);
                        OyunuBitir();
                    }

                    else
                    {
                        resimEkle.DosyaTamAdi = tiklananResimIndisi.ToString();
                        tiklananKutu.ImageLocation = resimEkle.DosyaTamAdi;
                        // _tmrBeklemeClass.Start();
                        wait(1000);
                        ilkTiklananKutu.ImageLocation = "";
                        tiklananKutu.ImageLocation = "";
                    }
                    tiklanmaSayisi = 0;
                    break;
            }
        }



        public void YaratilanKutuylaResimEslestir(int kutuSayisi, int kutuSayisiUstLimit, int ustLimit, ref Dictionary<int, int> ikiliListe, ref List<int> cekilenSayilar) //kutuSayisi=sayac, kutuSayisiUstLimit=satirSayisi^2, ustLimit=ResimKlasorundekiSayiAdedi
        {
            int resimIndisi;

            if (ikiliListe.Count < kutuSayisiUstLimit / 2)
            {
                BenzersizRastgeleSayiUret(ustLimit, ikiliListe, out resimIndisi);
                ikiliListe.Add(kutuSayisi, resimIndisi);
                cekilenSayilar.Add(resimIndisi);
            }
            else
            {
                int indexNo = rnd.Next(cikanResimler.Count);
                resimIndisi = cekilenSayilar[indexNo];
                ikiliListe.Add(kutuSayisi, resimIndisi);
                cekilenSayilar.Remove(resimIndisi);
            }

        }

        //Dictionary'de 1. indis Key, 2. indis Value. Key değeri uniq.

        public int BenzersizRastgeleSayiUret(int rastgeleSayiSiniri, Dictionary<int, int> ikiliListe, out int benzersizRastgeleSayi)
        {
            benzersizRastgeleSayi = rnd.Next(rastgeleSayiSiniri);

            if (ikiliListe.ContainsValue(benzersizRastgeleSayi) == true)
            {
                BenzersizRastgeleSayiUret(rastgeleSayiSiniri, ikiliListe, out benzersizRastgeleSayi);
            }

            return benzersizRastgeleSayi;

        }

        public void OyunuBitir ()
        {
            if (Eslesme.Count==0)
            {
                MessageBox.Show("Tebrikler. Tüm resimleri eşleştirdiniz");
            }
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
