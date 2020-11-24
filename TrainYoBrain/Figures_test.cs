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
    public partial class Figures_test : Form
    {
        char[] answers = {'A', 'C', 'E', 'B', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'E', 'D', 'E', 'B', 'E', 'B', 'E', 'A', 'A'};
        char[] wrong_ans;
        List <Image> tests;
        RadioButton[] first_row = new RadioButton[5];
        RadioButton[] second_row = new RadioButton[5];
        RadioButton[] third_row = new RadioButton[5];
        RadioButton[] fourth_row = new RadioButton[5];
        RadioButton[] used;
        int picnum, picnum_real, points;
        bool finish;
        public static bool closed;

        public void load()
        {
            
        }

        public Figures_test()
        {
            InitializeComponent();
        }

        private void Figures_Load(object sender, EventArgs e)
        {
            finish = false;
            wrong_ans = new char[20];
            used = new RadioButton[20];
            tests = new List <Image>();
            picnum = 4; picnum_real = 4;
            points = 0;
            first_row[0] = A1; first_row[1] = B1; first_row[2] = C1; first_row[3] = D1; first_row[4] = E1;
            second_row[0] = A2; second_row[1] = B2; second_row[2] = C2; second_row[3] = D2; second_row[4] = E2;
            third_row[0] = A3; third_row[1] = B3; third_row[2] = C3; third_row[3] = D3; third_row[4] = E3;
            fourth_row[0] = A4; fourth_row[1] = B4; fourth_row[2] = C4; fourth_row[3] = D4; fourth_row[4] = E4;

            FormClosed += new FormClosedEventHandler(form_closed);

            for (int i = 1; i <= 20; i++)
            {
                string name = "testmem" + i.ToString();
                object obj = Properties.Resources.ResourceManager.GetObject(name);
                tests.Add((Image)obj);
            }
        }

        private void form_closed (object sender, EventArgs e)
        {
            closed = true;
        }

        private void prev_Click(object sender, EventArgs e)
        {
            next.Text = ">";
            next.Size = new Size(30, 24);
            next.Location = new Point(526, 259);
            if (finish)
                finish = false;
            if (picnum != 4)
            {
                picnum -= 4;
                pictureBox1.Image = tests[picnum - 4];
                pictureBox2.Image = tests[picnum - 3];
                pictureBox3.Image = tests[picnum - 2];
                pictureBox4.Image = tests[picnum - 1];
                for (int i = picnum - 4; i < picnum; i++)
                {
                    if (used[i] != null)
                        used[i].Checked = true;
                }
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (first_row[i].Checked)
                {
                    used[picnum - 4] = first_row[i];
                    if (first_row[i].Name[0] == answers[picnum - 4] && picnum == picnum_real)
                        points++;
                    else
                        wrong_ans[picnum - 4] = first_row[i].Name[0];

                    first_row[i].Checked = false;
                }

                if (second_row[i].Checked)
                {
                    used[picnum - 3] = second_row[i];
                    if (second_row[i].Name[0] == answers[picnum - 3] && picnum == picnum_real)
                        points++;
                    else
                        wrong_ans[picnum - 3] = second_row[i].Name[0];

                    second_row[i].Checked = false;
                }

                if (third_row[i].Checked)
                {
                    used[picnum - 2] = third_row[i];
                    if (third_row[i].Name[0] == answers[picnum - 2] && picnum == picnum_real)
                        points++;
                    else
                        wrong_ans[picnum - 2] = third_row[i].Name[0];

                    third_row[i].Checked = false;
                }

                if (fourth_row[i].Checked)
                {
                    used[picnum - 1] = fourth_row[i];
                    if (fourth_row[i].Name[0] == answers[picnum - 1] && picnum == picnum_real)
                        points++;
                    else
                        wrong_ans[picnum - 1] = fourth_row[i].Name[0];
                    fourth_row[i].Checked = false;
                }
            }

            if (finish)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                next.Visible = false;
                prev.Visible = false;
                finish = false;
                result.Text = "You've scored " + points + "/20";
            }

            if (picnum != 20)
            {
                if (picnum == picnum_real)
                {
                    picnum_real += 4;
                }

                for (int i = picnum; i < picnum + 4; i++)
                {
                    if (used[i] != null)
                    {
                        used[i].Checked = true;
                    }
                }

                picnum += 4;
                pictureBox1.Image = tests[picnum - 4];
                pictureBox2.Image = tests[picnum - 3];
                pictureBox3.Image = tests[picnum - 2];
                pictureBox4.Image = tests[picnum - 1];

            }
            if (picnum == 20)
            {
                next.Size = new Size(60, 34);
                next.Location = new Point(490, 259);
                next.Text = "FINISH";
                finish = true;
            }
        }
    }
}
