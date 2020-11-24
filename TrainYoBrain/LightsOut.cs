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
    public partial class LightsOut : Form
    {
        Button[,] btnGrid;
        Button[] linear_list;
        Color on = Color.Yellow;
        Color off = Color.DarkRed;
        Color[,] init_set;
        int btnGridSize = 5, formX = 520, formY= 565;

        public LightsOut()
        {
            InitializeComponent();
        }

        public void toggle (Button btn)
        {
            if (btn.BackColor == on)
                btn.BackColor = off;
            else if (btn.BackColor == off)
                btn.BackColor = on;
        }

        private void shuffler (object sender, EventArgs e)
        {
            Shuffle();
            Save();
        }

        private void restarter (object sender, EventArgs e)
        {
            for (int i = 0; i < btnGridSize; i++)
            {
                for (int j = 0; j < btnGridSize; j++)
                {
                    //if (init_set != null && btnGrid != null)
                    btnGrid[i, j].BackColor = init_set[i, j];
                }
            }
        }

        public void move (Button temp)
        {
            toggle(temp);
            int x = (int)temp.Name[3] - 48;
            int y = (int)temp.Name[4] - 48;
            if (x > 0)
            {
                toggle(btnGrid[x - 1, y]);
            }
            if (x + 1 < btnGridSize)
                toggle(btnGrid[x + 1, y]);
            if (y > 0)
                toggle(btnGrid[x, y - 1]);
            if (y + 1 < btnGridSize)
                toggle(btnGrid[x, y + 1]);
        }

        public bool isSolved ()
        {
            bool solved = true;
            for (int i = 0; i < btnGridSize; i++)
            {
                for (int j = 0; j < btnGridSize; j++)
                {
                    if (btnGrid[i, j].BackColor == on)
                    {
                        solved = false;
                        break;
                    }
                }
            }
            return solved;
        }

        private void btnClick (object sender, EventArgs e)
        {
            move((Button)sender);
            if (isSolved())
            {
                gratz.Visible = true;
                gratz.Location = new Point(formX / 2 - gratz.Size.Width / 2, formY / 2 - gratz.Size.Height / 2);
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int moves = random.Next(80, 100);
            int[] hood = { -btnGridSize, btnGridSize, -1, 1 };
            for (int i = 0; i < moves; i++)
            {
                int n = random.Next(btnGridSize * btnGridSize);
                move(linear_list[n]);
            }
        }

        public void Save()
        {
            for (int a = 0; a < btnGridSize; a++)
            {
                for (int b = 0; b < btnGridSize; b++)
                {
                    //if (init_set != null && btnGrid != null)
                    init_set[a, b] = btnGrid[a, b].BackColor;
                }
            }
        }

        private void LightsOut_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(formX, formY);

            btnGrid = new Button[btnGridSize, btnGridSize];
            linear_list = new Button[btnGridSize * btnGridSize];
            init_set = new Color[btnGridSize, btnGridSize];

            Button shuffle_btn = new Button();
            Controls.Add(shuffle_btn);
            shuffle_btn.Size = new Size(250, 35);
            shuffle_btn.Location = new Point(0, formY - 40);
            shuffle_btn.Text = "Shuffle";
            shuffle_btn.Click += new EventHandler(shuffler);

            Button restart_btn = new Button();
            Controls.Add(restart_btn);
            restart_btn.Size = new Size(250, 35);
            restart_btn.Location = new Point(formX - 255, formY - 40);
            restart_btn.Text = "Restart";
            restart_btn.Click += new EventHandler(restarter);


            for (int i = 0; i < btnGridSize; i++)
            {
                for (int j = 0; j < btnGridSize; j++)
                {
                    btnGrid[i, j] = new Button();
                    Controls.Add(btnGrid[i, j]);
                    btnGrid[i, j].Location = new Point(105 * i, 105 * j);
                    btnGrid[i, j].Size = new Size(100, 100);
                    btnGrid[i, j].BackColor = off;
                    btnGrid[i, j].Name = "btn" + i.ToString() + j.ToString();
                    btnGrid[i, j].Click += new EventHandler(btnClick);
                    linear_list[i + j * 5] = btnGrid[i, j];
                    init_set[i, j] = btnGrid[i, j].BackColor;

                }
            }
            Shuffle();
            Save();
        }
    }
}