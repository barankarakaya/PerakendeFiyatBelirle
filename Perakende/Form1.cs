using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perakende
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://elta-ada.com.tr/");
        }

        private void btn_iletisim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Baran Karakaya/ 0544 965 51 80", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_alis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_yuzde_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double yüzde = 0;
            double sayi1 = 0;
            double sonuc = 0;
            sayi1 = Convert.ToDouble(txt_alis.Text);
            yüzde = Convert.ToDouble(txt_yuzde.Text);
            sonuc = (sayi1 * yüzde / 100) + sayi1;
            lbl_sonuc.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
    }
}
