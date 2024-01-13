using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace chasy
{
    public partial class timer : Form
    {


        Timer myTimer = new Timer();
        public timer()
        {
            InitializeComponent();



            myTimer.Interval = 1000;
            myTimer.Enabled = true;



           
        }

        int h, m, s; //часы, минуты, секунды


        int has, minuti, sekun;
        private void button2_Click(object sender, EventArgs e)
        {
            has = Convert.ToInt32(textBox1.Text);
            minuti = Convert.ToInt32(textBox2.Text);
            sekun = Convert.ToInt32(textBox3.Text);



            if (textBox1.Text == "0" && textBox2.Text == "0" && textBox3.Text == "0")
            {

            }
            else
            {
                timer1.Stop(); // при нажатии пользователем на кнопку "Стоп" таймер останавливается

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox2.Text == "0" && textBox3.Text == "0")
            {

            }
            else
            {
                timer1.Stop(); // при нажатии пользователем на кнопку "Сброс" таймер останавливается, а текст в label'ах "сбрасывается" до нуля.
                label1.Text = "0";
                label3.Text = "0";
                label5.Text = "0";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool metka = false;
            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);
            if (h != 0 || m != 0 || s != 0)
            {
                metka = true;
            }
            if (metka == true)
            {
                timer1.Start();

            }
            else
            {
                MessageBox.Show("Введите значение!");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0" + textBox1.Text;

            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                textBox2.Text = "0" + textBox2.Text;

            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                textBox3.Text = "0" + textBox3.Text;

            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
        }

        private void timer_Load(object sender, EventArgs e)
        {

        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        int iFormX, iFormY, iMouseX, iMouseY;

        private void timer_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void timer_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(has);
            textBox2.Text = Convert.ToString(minuti);
            textBox3.Text = Convert.ToString(sekun);
            timer1.Start();

        }

        SoundPlayer sp = new SoundPlayer("C:\\1.wav");
        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1) 
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1) 
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0) 
            {
                timer1.Stop();
                sp.Play();
                if (MessageBox.Show("Время истекло!") == DialogResult.OK)
                {
                    sp.Stop();
                }         
            }
            label1.Text = Convert.ToString(h); 
            label3.Text = Convert.ToString(m);
            label5.Text = Convert.ToString(s);
        }
    }
}
