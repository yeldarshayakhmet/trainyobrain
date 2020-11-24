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
    public partial class speed_game : Form
    {
        public speed_game()
        {
            InitializeComponent();
        }
        int[] a = new int[500];
        int[] b = { 2, 3, 1, 1, 3, 4, 1, 2, 2, 3, 3, 1, 2, 3, 4 };
        public static int[] wrong = new int[500];
        int i = 0;
        int num = 0;
        int picc = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    private void next()
        {
            if (picc == 14)
            {
                for (int i = 0; i <= picc; i++)
                {
                    if (a[i] == b[i])
                    {
                        wrong[i] = 1;
                        num++;
                    }
                    else
                    {
                        wrong[i] = 0;
                    }
                }
                label2.Visible = true;
                label2.Text = Convert.ToString(num + " / " + 15 + " points");
                button1.Visible = true;
                timer1.Enabled = false;
                label1.Visible = false;
                pictureBox29.Visible = false;
                pictureBox28.Visible = false;
                pictureBox30.Visible = false;
            }
            else if (picc == 0)
            {
                pictureBox33.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                i = 0;
            }
            else if (picc == 1)
            {
                pictureBox33.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox3.Visible = false;
                pictureBox6.Visible = true;
                i = 0;
            }
            else if (picc == 2)
            {
                pictureBox31.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = true;
                pictureBox6.Visible = false;
                pictureBox8.Visible = true;
                i = 0;
            }
            else if (picc == 3)
            {
                pictureBox31.Visible = true;
                pictureBox7.Visible = false;
                pictureBox9.Visible = true;
                pictureBox8.Visible = false;
                pictureBox10.Visible = true;
                i = 0;
            }
            else if (picc == 4)
            {
                pictureBox31.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = true;
                pictureBox10.Visible = false;
                pictureBox12.Visible = true;
                i = 0;
            }
            else if (picc == 5)
            {
                pictureBox11.Visible = false;
                pictureBox13.Visible = true;
                pictureBox12.Visible = false;
                pictureBox14.Visible = true;
                i = 0;
            }
            else if (picc == 6)
            {
                pictureBox13.Visible = false;
                pictureBox15.Visible = true;
                pictureBox14.Visible = false;
                pictureBox16.Visible = true;
                i = 0;
            }
            else if (picc == 7)
            {
                pictureBox15.Visible = false;
                pictureBox17.Visible = true;
                pictureBox16.Visible = false;
                pictureBox18.Visible = true;
                i = 0;
            }
            else if (picc == 8)
            {
                pictureBox17.Visible = false;
                pictureBox19.Visible = true;
                pictureBox18.Visible = false;
                pictureBox20.Visible = true;
                i = 0;
            }
            else if (picc == 9)
            {
                pictureBox34.Visible = true;
                pictureBox19.Visible = false;
                pictureBox21.Visible = true;
                pictureBox20.Visible = false;
                pictureBox22.Visible = true;
                i = 0;
            }
            else if (picc == 10)
            {
                pictureBox34.Visible = false;
                pictureBox21.Visible = false;
                pictureBox23.Visible = true;
                pictureBox22.Visible = false;
                pictureBox24.Visible = true;
                i = 0;
            }
            else if (picc == 11)
            {
                pictureBox23.Visible = false;
                pictureBox25.Visible = true;
                pictureBox24.Visible = false;
                pictureBox26.Visible = true;
                i = 0;
            }
            else if (picc == 12)
            {
                pictureBox32.Visible = true;
                pictureBox25.Visible = false;
                pictureBox27.Visible = true;
                pictureBox26.Visible = false;
                pictureBox28.Visible = true;
                i = 0;
            }
            else if (picc == 13)
            {
                pictureBox32.Visible = false;
                pictureBox27.Visible = false;
                pictureBox29.Visible = true;
                pictureBox28.Visible = false;
                pictureBox30.Visible = true;
                i = 0;
            }
            picc++;
            if (picc <= 13)
            {
                label3.Text = Convert.ToString(b[picc]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = Convert.ToString(i);
            if (i == 15)
            {
                label1.Text = Convert.ToString(0);
                a[picc] = 0;
                next();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a[picc] = 3;
            next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a[picc] = 4;
            next();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }


        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            a[picc] = 1;
            next();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            a[picc] = 2;
            next();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution();
            solution.Show();
            Hide();
        }
    }
}
