using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainYoBrain
{
    public partial class Proverbs : Form
    {
        int ind, num, points, index;
        bool memo, testtime, finish, end, mistakes;
        List <string> proverbs, proverbs_test, wrong_answers;
        List <int> number_list;
        static StreamReader str;
        string path;

        public Proverbs()
        {
            InitializeComponent();
        }

        private void Proverbs_2_Load(object sender, EventArgs e)
        {
            ind = 1;
            index = 0;
            points = 0;
            memo = true;
            testtime = false;
            finish = false;
            end = false;

            proverbs = new List <string>();
            proverbs_test = new List <string>();
            wrong_answers = new List <string>();
            number_list = new List <int>();

            Random random = new Random();
            num = random.Next(1, 12);

            for (int i = 0; i < 11; i++)
            {
                while (number_list.Contains(num))
                {
                    num = random.Next(1, 12);
                }
                number_list.Add(num);
                path = num.ToString() + ".txt";
                str = new StreamReader(path);
                proverbs.Add(str.ReadToEnd());
                path = num.ToString() + "test.txt";
                str = new StreamReader(path);
                proverbs_test.Add(str.ReadToEnd());
            }

            textBox1.Text = proverbs[0];
            number_list = new List <int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (memo)
            {
                if (ind == 11)
                {
                    memo = false;
                    testtime = true;
                    textBox1.Clear();
                    button1.Text = "START";
                    info_label.Text = "Memorization Finished";
                    info_label2.Text = "Let's test what you've learned";
                }
                else
                {
                    textBox1.Text = proverbs[ind];
                    ind++;
                }
            }

            else if (testtime)
            {
                ind = 0;
                if (index > 0 && textBox1.Text == proverbs[index - 1])
                {
                    points++;
                }
                else if (index > 0 && textBox1.Text != proverbs[index - 1])
                {
                    wrong_answers.Add(textBox1.Text);
                    number_list.Add(index - 1);
                }

                if (index == 11)
                {
                    finish = true;
                    testtime = false;
                    textBox1.Clear();
                    button1.Text = "Results";
                    info_label.Text = "You have finished!";
                    info_label2.Text = null;
                }
                else
                {
                    textBox1.Enabled = true;
                    button1.Text = "NEXT";
                    textBox1.Text = proverbs_test[index];
                    index++;
                }

            }

            else if (finish)
            {
                info_label.Text = "You've scored " + points + '/' + 11;
                if (points != 11)
                {
                    button1.Text = "View Mistakes";
                    mistakes = true;
                    finish = false;
                }
                else
                {
                    button1.Text = "EXIT";
                    end = true;
                    finish = false;
                }
            }

            else if (mistakes)
            {
                button1.Text = "NEXT";
                if (ind == number_list.Count)
                {
                    mistakes = false;
                    end = true;
                    button1.Text = "NEXT";
                }
                else
                {
                    textBox1.Text = proverbs[number_list[ind]];
                    textBox1.Text += "\r\n" + "\r\n" + "Your answer was: " + "\r\n" + "\r\n";
                    textBox1.Text += wrong_answers[ind];
                    ind++;
                }
            }

            else if (end)
                Close();
        }
    }
}