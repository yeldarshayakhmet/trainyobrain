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
    public partial class Figures : Form
    {
        int sec = 8, min = 0;
        public Figures()
        {
            InitializeComponent();
        }

        private void Figures_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            time.Text = min.ToString() + " : " +  sec.ToString();

            if (min == 0 && sec == 0)
            {
                pictureBox1.Visible = false; pictureBox6.Visible = false; pictureBox11.Visible = false; pictureBox16.Visible = false;
                pictureBox2.Visible = false; pictureBox7.Visible = false; pictureBox12.Visible = false; pictureBox17.Visible = false;
                pictureBox3.Visible = false; pictureBox8.Visible = false; pictureBox13.Visible = false; pictureBox18.Visible = false;
                pictureBox4.Visible = false; pictureBox9.Visible = false; pictureBox14.Visible = false; pictureBox19.Visible = false;
                pictureBox5.Visible = false; pictureBox10.Visible = false; pictureBox15.Visible = false; pictureBox20.Visible = false;
                label1.Visible = true; label2.Visible = true; time.Visible = false;
                button1.Visible = true;
                timer1.Enabled = false;

                sec = 30;
                min = 0;
                timer2.Start();
                Games distarction = new Games();
                distarction.Show();
            }

            if (sec == 0)
            {
                min--;
                sec = 60;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figures_test figures_test = new Figures_test();
            figures_test.Show();
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec--;
            button1.Text = min.ToString() + " : " +  sec.ToString();
            if (min == 0 && sec == 0)
            {
                button1.Text = "START";
                button1.Enabled = true;
                timer2.Enabled = false;
            }
            else if (sec == 0)
            {
                min--;
                sec = 60;
            }
        }

    }
}
