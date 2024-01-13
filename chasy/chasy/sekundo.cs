using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chasy
{
    public partial class sekundo : Form
    {
        public sekundo()
        {
            InitializeComponent();
        }
        int mil, cek, min;


        int has2, minuti2, sekun2;
        private void button5_Click(object sender, EventArgs e)
        {


            has2 = Convert.ToInt32(label9.Text);
            minuti2 = Convert.ToInt32(label11.Text);
            sekun2 = Convert.ToInt32(label13.Text);



            timer1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // при нажатии пользователем на кнопку "Сброс" таймер останавливается, а текст в label'ах "сбрасывается" до нуля.
            label9.Text = "0";
            label11.Text = "0";
            label13.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sekundo_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        int iFormX, iFormY, iMouseX, iMouseY;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void sekundo_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(has2);
            label11.Text = Convert.ToString(minuti2);
            label13.Text = Convert.ToString(sekun2);
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mil += 1;
            if (mil == 10)
            {
                mil = 0;
                cek += 1;
            }
            if (cek == 60)
            {
                cek = 0;
                min += 1;
            }

            label9.Text = Convert.ToString(min); //выводим таймер на экран, чтобы пользователь наглядно видел, сколько время осталось.
            label11.Text = Convert.ToString(cek);
            label13.Text = Convert.ToString(mil);
        }
    }
}
