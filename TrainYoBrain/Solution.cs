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
    public partial class Solution : Form
    {
        int[] ans;
        public Solution()
        {
            InitializeComponent();
        }
        int cnt = 0;
        private void check()
        {

            ans = speed_game.wrong;

        }
        private void Solution_Load(object sender, EventArgs e)
        {
            ans = new int[500];
            if (ans[0] == 1)
            {
                pictureBox19.Visible = true;
            }
            else
            {
                pictureBox18.Visible = true;
            }
            pictureBox3.Visible = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            check();
            if (cnt > 0)
            {
                cnt--;
            }
            label1.Text = Convert.ToString(cnt + 1);
            if (ans[cnt] == 1)
            {
                pictureBox19.Visible = true;
                pictureBox18.Visible = false;
            }
            if (ans[cnt] == 0)
            {
                pictureBox18.Visible = true;
                pictureBox19.Visible = false;
            }
            if (cnt == 0)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
            if (cnt == 1)
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
            if (cnt == 2)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            if (cnt == 3)
            {
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
            }
            if (cnt == 4)
            {
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            if (cnt == 5)
            {
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
            }
            if (cnt == 6)
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
            }
            if (cnt == 7)
            {
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
            }
            if (cnt == 8)
            {
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
            }
            if (cnt == 9)
            {
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
            }
            if (cnt == 10)
            {
                pictureBox13.Visible = true;
                pictureBox14.Visible = false;
            }
            if (cnt == 11)
            {
                pictureBox14.Visible = true;
                pictureBox15.Visible = false;
            }
            if (cnt == 12)
            {
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
            }
            if (cnt == 13)
            {
                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            check();
            if (cnt < 14)
            {
                cnt++;
            }
            label1.Text = Convert.ToString(cnt + 1);
            if (ans[cnt] == 1)
            {
                pictureBox19.Visible = true;
                pictureBox18.Visible = false;
            }
            if (ans[cnt] == 0)
            {
                pictureBox18.Visible = true;
                pictureBox19.Visible = false;
            }
            if (cnt == 1)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
            }
            if (cnt == 2)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
            }
            if (cnt == 3)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
            }
            if (cnt == 4)
            {
                pictureBox7.Visible = true;
                pictureBox6.Visible = false;
            }
            if (cnt == 5)
            {
                pictureBox8.Visible = true;
                pictureBox7.Visible = false;
            }
            if (cnt == 6)
            {
                pictureBox9.Visible = true;
                pictureBox8.Visible = false;
            }
            if (cnt == 7)
            {
                pictureBox10.Visible = true;
                pictureBox9.Visible = false;
            }
            if (cnt == 8)
            {
                pictureBox11.Visible = true;
                pictureBox10.Visible = false;
            }
            if (cnt == 9)
            {
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
            }
            if (cnt == 10)
            {
                pictureBox13.Visible = true;
                pictureBox12.Visible = false;
            }
            if (cnt == 11)
            {
                pictureBox14.Visible = true;
                pictureBox13.Visible = false;
            }
            if (cnt == 12)
            {
                pictureBox15.Visible = true;
                pictureBox14.Visible = false;
            }
            if (cnt == 13)
            {
                pictureBox16.Visible = true;
                pictureBox15.Visible = false;
            }
            if (cnt == 14)
            {
                pictureBox17.Visible = true;
                pictureBox16.Visible = false;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
