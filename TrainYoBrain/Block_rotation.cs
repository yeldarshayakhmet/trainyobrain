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
    public partial class Block_rotation : Form
    {
        bool testing = true, mistakes = false;
        List <PictureBox> array = new List<PictureBox>();
        List <int> wrong_answers = new List<int>();
        char[] user_answers;
        char[] answers = { 'C', 'E', 'D', 'A', 'E', 'B', 'B', 'C', 'E', 'B', 'D', 'A', 'E', 'A', 'B', 'C', 'B', 'D', 'E', 'C', 'E', 'C', 'D', 'B' };
        int ind, points, time;

        Control[] picsfinder = new Control[100];

        void next_pic ()
        {
            time = 42;

            if (user_answers[ind] == answers[ind])
                points++;
            else
                wrong_answers.Add(ind);

            array[ind].Visible = false;

            if (array.Count != ind + 1)
            {
                ind++;
                array[ind].Visible = true;
            }
            else
            {
                time_label.Visible = false;
                timer1.Stop();
                results.Text = "You've scored " + points + "/" + array.Count;

                if (points != array.Count)
                {
                    starter.Visible = true;
                    A.Visible = false;
                    B.Visible = false;
                    C.Visible = false;
                    D.Visible = false;
                    E.Visible = false;
                    starter.Text = "View Mistakes";
                    mistakes = true;
                    testing = false;
                    ind = 0;
                }
            }
        }


        

        public Block_rotation()
        {
            InitializeComponent();
        }

        private void Block_rotation_Load(object sender, EventArgs e)
        {
            array.Clear();
            wrong_answers.Clear();
            user_answers = new char[100];
            //ind = 0;
            //points = 0;
            time = 42;

            for (int i = 1; i < 25; i++)
            {
                picsfinder = Controls.Find("pictureBox" + i, true);
                PictureBox temp = (PictureBox)picsfinder[0];
                array.Add(temp);
                picsfinder = null;
                temp = null;
            }
        }

        private void starter_Click(object sender, EventArgs e)
        {
            if (testing && !mistakes)
            {
                timer1.Start();
                starter.Visible = false;
                pictureBox25.Visible = false;
                array[ind].Visible = true;
                A.Visible = true;
                B.Visible = true;
                C.Visible = true;
                D.Visible = true;
                E.Visible = true;
            }
            if (!testing && mistakes)
            {
                results.Visible = false;
                starter.Text = "NEXT";
                if (ind != 0)
                    array[wrong_answers[ind - 1]].Visible = false;

                show_answers.Text = "You answer: " + user_answers[wrong_answers[ind]];
                array[wrong_answers[ind]].Visible = true;

                if (ind != wrong_answers.Count - 1)
                    ind++;
                else
                    starter.Enabled = false;
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            user_answers[ind] = 'A';
            next_pic();
        }

        private void B_Click(object sender, EventArgs e)
        {
            user_answers[ind] = 'B';
            next_pic();
        }

        private void C_Click(object sender, EventArgs e)
        {
            user_answers[ind] = 'C';
            next_pic();
        }

        private void D_Click(object sender, EventArgs e)
        {
            user_answers[ind] = 'D';
            next_pic();
        }

        private void E_Click(object sender, EventArgs e)
        {
            user_answers[ind] = 'E';
            next_pic();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            time_label.Text = time.ToString();
            if (time == 0)
                next_pic();
        }
    }
}
