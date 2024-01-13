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
    public partial class budilnik : Form
    {

        Timer timer = new Timer();

    
       
        private string Hour = "";
        private string Minutes = "";
        private string Seconds = "";
        private string HourNow = "";
        private string MinutesNow = "";
        private string SecondsNow = "";
        public budilnik()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите значение в поле.", "Ошибка!");
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите значение в поле.", "Ошибка!");
                    textBox2.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите значение в поле.", "Ошибка!");
                    textBox2.Focus();
                    return;
                }
                if (!(Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 23))
                {
                    MessageBox.Show("Некорректно указаны часы.", "Ошибка!");
                    textBox1.Focus();
                    return;
                }
                if (!(Convert.ToInt32(textBox2.Text) >= 0 && Convert.ToInt32(textBox2.Text) <= 59))
                {
                    MessageBox.Show("Некорректно указаны минуты.", "Ошибка!");
                    textBox2.Focus();
                    return;
                }
                if (!(Convert.ToInt32(textBox3.Text) >= 0 && Convert.ToInt32(textBox3.Text) <= 59))
                {
                    MessageBox.Show("Некорректно указаны секунды.", "Ошибка!");
                    textBox3.Focus();
                    return;
                }
                timer1.Start();



        }

        private void budilnik_Load(object sender, EventArgs e)
        {


            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();

            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();


            Hour = DateTime.Now.Hour.ToString();
            Minutes = DateTime.Now.Minute.ToString();
            Seconds = DateTime.Now.Second.ToString();
            if(Hour.Length==1)
            {
                Hour = "0" + Hour;
            }
            if(Minutes.Length==1)
            {
                Minutes = "0" + Minutes;
            }
            if(Seconds.Length==1)
            {
                Seconds = "0" + Seconds;
            }
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==1)
            {
                textBox1.Text = "0" + textBox1.Text;

            }
            if (textBox1.Text == "")
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.KeyChar = Convert.ToChar(Keys.None);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.KeyChar = Convert.ToChar(Keys.None);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.KeyChar = Convert.ToChar(Keys.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (HourNow.Length == 1)
            {
                HourNow = "0" + HourNow;

            }
            if (MinutesNow.Length == 1)
            {
                MinutesNow = "0" + MinutesNow;

            }
            if (SecondsNow.Length == 1)
            {
                SecondsNow = "0" + SecondsNow;

            }
            SoundPlayer sp = new SoundPlayer("C:\\1.wav");
            Hour = textBox1.Text;
            Minutes = textBox2.Text;
            Seconds = textBox3.Text;
            if (Hour==HourNow&&Minutes==MinutesNow&&Seconds==SecondsNow)
            {
                timer1.Stop();
                sp.Play();
                if (MessageBox.Show("Вставай!","Будильник") == DialogResult.OK)
                {
                    sp.Stop();
                }
            }

          
            }
       

        private void timer2_Tick(object sender, EventArgs e)
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
            label4.Text = time;

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
