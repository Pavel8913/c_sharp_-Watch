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
    public partial class будильник : Form
    {

        Timer timer01 = new Timer();
        SoundPlayer sp = new SoundPlayer("C:\\1.wav");
        bool b = false;
        public будильник()
        {
            InitializeComponent();
            button1.Tag = false;
        }        
        
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
            label3.Text = Convert.ToString(h);
            label4.Text = Convert.ToString(m);
            label7.Text = Convert.ToString(s);




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(label3.Text== label8.Text&& label4.Text == label9.Text&& label7.Text == label10.Text)
            {                
                sp.Play();
                timer2.Stop();
                if (MessageBox.Show("Вставай!","Будильник!") == DialogResult.OK)
                {                    
                    sp.Stop();                    
                    return;
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            int x3 = Convert.ToInt32(textBox3.Text);
            if(textBox1.Text == "" || x > 23&& textBox2.Text == "" || x2 > 59&& textBox3.Text == "" || x3 > 59)
            {
                if (MessageBox.Show("Время не введено или введено не корректно!", "ошибка!") == DialogResult.OK)
                {
                    textBox1.Text = "0";
                    textBox2.Text = "0";
                    textBox3.Text = "0";
                }
                return;

            }
            if (textBox1.Text == "" || x > 23)
            {
                if(MessageBox.Show("Время не введено или введено не корректно!", "ошибка!")==DialogResult.OK)
                {
                    textBox1.Text = "0";
                    
                }                
            }
            if (textBox2.Text == "" || x2 > 59)
            {
                if (MessageBox.Show("Время не введено или введено не корректно!", "ошибка!") == DialogResult.OK)
                {
                    textBox2.Text = "0";
                    
                }                
            }
            if (textBox3.Text == "" || x3 > 59)
            {
                if (MessageBox.Show("Время не введено или введено не корректно!", "ошибка!") == DialogResult.OK)
                {
                    textBox3.Text = "0";
                    
                }                
            }
            if (textBox1.Text=="0")
            {
                label8.Text = textBox1.Text;
            }
            else
            {
                label8.Text = textBox1.Text;
            }
            if (textBox2.Text == "0")
            {
                label9.Text = textBox2.Text;
            }
            else
            {
                label9.Text = textBox2.Text;
            }
            if (textBox3.Text == "0")
            {
                label10.Text = textBox3.Text;
            }
            else
            {
                label10.Text = textBox3.Text;
            }
                       
            
            timer2.Start();                                    
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void будильник_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            timer2.Stop();

            textBox1.Text="0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            label8.Text = "00";
            label9.Text = "00";
            label10.Text = "00";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
        int iFormX, iFormY, iMouseX, iMouseY;

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;  
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void будильник_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void будильник_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
            this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
    }
}
