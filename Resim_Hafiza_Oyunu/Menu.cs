using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim_Hafiza_Oyunu
{
    public partial class Menu : Form
    {
        //Resim secilenResimKlasoru;
        public string menuSeviye;
        
        public Menu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //secilenResimKlasoru = new Resim();
            //secilenResimKlasoru.DosyaYolu = cbx_resim_klasoru.Text;
            menuSeviye = cbx_seviye.Text;
            Oyun_Tahtasi instance = new Oyun_Tahtasi(menuSeviye, cbx_resim_klasoru.Text);
            this.Hide();
            instance.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cbx_seviye.SelectedIndex = 0;
            cbx_resim_klasoru.SelectedIndex = 0;
        }
    }
}
