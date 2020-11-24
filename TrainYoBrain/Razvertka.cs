using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainYoBrain
{
    public partial class Razvertka : Form
    {
        public Razvertka()
        {
            InitializeComponent();
        }
        int[] a = new int[500];
        char[] b = { 'И', 'Г', 'Б', 'Д', 'Ф', 'Ф', 'Ж', 'Ж', 'В', 'М', 'Д', 'Б', 'Д', 'О', 'О',
        'А', 'Э', 'И', 'С', 'Я', 'А', 'Э', 'И', 'C', 'П', 'Д', 'Д', 'И', 'З', 'Ф'};
        int cnt = 0, right = 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            cnt++;
            if(textBox1.Text.Length == 0)
            {
                textBox1.Text = "[";
            }
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "[";
            }
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "[";
            }
            if (textBox4.Text.Length == 0)
            {
                textBox4.Text = "[";
            }
            if (textBox5.Text.Length == 0)
            {
                textBox5.Text = "[";
            }
            if (cnt == 1)
            {
                a[0] = Convert.ToChar(textBox1.Text);
                a[1] = Convert.ToChar(textBox2.Text);
                a[2] = Convert.ToChar(textBox3.Text);
                a[3] = Convert.ToChar(textBox4.Text);
                a[4] = Convert.ToChar(textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
            if (cnt == 2)
            {
                a[5] = Convert.ToChar(textBox1.Text);
                a[6] = Convert.ToChar(textBox2.Text);
                a[7] = Convert.ToChar(textBox3.Text);
                a[8] = Convert.ToChar(textBox4.Text);
                a[9] = Convert.ToChar(textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
            }
            if (cnt == 3)
            {
                a[10] = Convert.ToChar(textBox1.Text);
                a[11] = Convert.ToChar(textBox2.Text);
                a[12] = Convert.ToChar(textBox3.Text);
                a[13] = Convert.ToChar(textBox4.Text);
                a[14] = Convert.ToChar(textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
            }
            if(cnt == 4)
            {
                a[15] = Convert.ToChar(textBox1.Text);
                a[16] = Convert.ToChar(textBox2.Text);
                a[17] = Convert.ToChar(textBox3.Text);
                a[18] = Convert.ToChar(textBox4.Text);
                a[19] = Convert.ToChar(textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
            }
            if (cnt == 5)
            {
                a[20] = Convert.ToChar(textBox1.Text);
                a[21] = Convert.ToChar(textBox2.Text);
                a[22] = Convert.ToChar(textBox3.Text);
                a[23] = Convert.ToChar(textBox4.Text);
                a[24] = Convert.ToChar(textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
            }
            if (cnt == 6)
            {
                a[25] = Convert.ToChar(textBox1.Text);
                a[26] = Convert.ToChar(textBox2.Text);
                a[27] = Convert.ToChar(textBox3.Text);
                a[28] = Convert.ToChar(textBox4.Text);
                a[29] = Convert.ToChar(textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                for (int i = 0; i <= 29; i++)
                {
                    if (a[i] == b[i])
                    {
                        right++;
                    }
                    if(b[i] + 32 == a[i])
                    {
                        right++;
                    }
                }
                pictureBox15.Visible = false;
                label6.Text = "You've scored " + right + "/30";
                label6.Visible = true;
            }
        }
    }
}
