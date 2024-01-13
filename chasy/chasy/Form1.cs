using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chasy
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
        }        

                private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();          
        }


        SoundPlayer sp = new SoundPlayer("D:\\1.wav");

        private void timer1_Tick(object sender, EventArgs e)
        {           
           int h = DateTime.Now.Hour;
           int m = DateTime.Now.Minute;
           int s = DateTime.Now.Second;

           string time = "";

           if (h < 10)
           {
               time += "0" + h;
           }
           else
           {
               time += h;
           }

           time += ":";

           if (m < 10)
           {
               time += "0" + m;
           }
           else
           {
               time += m;
           }

           time += ":";

           if (s < 10)
           {
               time += "0" + s;
           }
           else
           {
               time += s;
           }
           label2.Text = time;

           string data = "";

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (day < 10)
            {
                data += "0" + day;
            }
            else
            {
                data += day;
            }
            data += ".";
            if(month<10)
            {
                data += "0" + month;
            }
            else
            {
                data += month;
            }
            data += ".";
            data += year;
            label1.Text = data;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer f = new timer();//timer имя нового win form
            f.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sekundo f = new sekundo();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            budilnik f = new budilnik();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Издатель: Pavlentyi_22\nВерсия: 3\nИсточник: сайт\nОрганизация: Pavlentyi_production\nОписание: часы с секундомером , таймером и будильником", "Свойства");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            budilnik f = new budilnik();
            f.Show();
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
        int iFormX, iFormY, iMouseX, iMouseY;

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            будильник f = new будильник();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
            this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
            this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
