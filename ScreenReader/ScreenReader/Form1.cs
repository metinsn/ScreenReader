using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenReader
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        List<string> isimler = new List<string> { "Seçkin", "Ufuk", "Özgür", "Kaan", "Ege", "Temmuz", "Erdem", "Doğan", "Metin", "Alper" };
        Random rnd = new Random();
        int sayac = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Maximized;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, 10);
            string isim = isimler[index];
            Graphics g = CreateGraphics();

            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);


            int x = rnd.Next(10, this.Width - 100);
            int y = rnd.Next(10, this.Height - 100);


                g.DrawString(isim, new Font(FontFamily.GenericSansSerif, 20), new SolidBrush(Color.FromArgb(red, green, blue)), x, y);


            if (sayac == 100)
            {
                this.Invalidate();
            }
            sayac++;
        }


    }
}
