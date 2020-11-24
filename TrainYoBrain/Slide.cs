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
    public partial class Slide : Form
    {
        Rectangle cropArea;
        Bitmap img = new Bitmap("1.png");
        int btnGridSize = 3;
        Button[,] btnGrid;
        Button[] linear_list;
        int empty_btn_ind;

        public Slide()
        {
            InitializeComponent();
        }

        public void Shuffle ()
        {
            Random random = new Random();
            int moves = random.Next(80, 100);
            int[] hood = { -3, 3, -1, 1 };
            for (int i = 0; i < moves; i++)
            {
                Button adj_btn;
                int n = random.Next(4);
                int adj_index = empty_btn_ind + hood[n];
                if (adj_index < 8 && adj_index >= 0)
                {
                    adj_btn = linear_list[adj_index];
                    empty_btn_ind += hood[n];
                    move(adj_btn);
                }
            }
        }

        public bool isSolved ()
        {
            bool solved = true;
            for (int i = 0; i < btnGridSize; i++)
            {
                for (int j = 0; j < btnGridSize; j++)
                {
                    if (btnGrid[i, j] != linear_list[i + j * 3])
                        solved = false;
                }
            }
            return solved;
        }

        public void move (Button temp)
        {
            Button btn = new Button();

            int x = (int)temp.Name[3] - 48;
            int y = (int)temp.Name[4] - 48;

            if (x > 0)
            {
                if (btnGrid[x - 1, y].Name == "emptybtn")
                {
                    btn.Location = btnGrid[x - 1, y].Location;
                    btnGrid[x - 1, y].Location = btnGrid[x, y].Location;
                    btnGrid[x, y].Location = btn.Location;
                    btn = btnGrid[x - 1, y];
                    btnGrid[x - 1, y] = btnGrid[x, y];
                    btnGrid[x - 1, y].Name = "btn" + (x - 1).ToString() + y.ToString();
                    btnGrid[x, y] = btn;
                    btnGrid[x, y].Name = "emptybtn";
                }
            }
            if (x + 1 < btnGridSize && btnGrid[x + 1, y].Name == "emptybtn")
            {
                btn.Location = btnGrid[x + 1, y].Location;
                btnGrid[x + 1, y].Location = btnGrid[x, y].Location;
                btnGrid[x, y].Location = btn.Location;
                btn = btnGrid[x + 1, y];
                btnGrid[x + 1, y] = btnGrid[x, y];
                btnGrid[x + 1, y].Name = "btn" + (x + 1).ToString() + y.ToString();
                btnGrid[x, y] = btn;
                btnGrid[x, y].Name = "emptybtn";
            }
            if (y > 0 && btnGrid[x, y - 1].Name == "emptybtn")
            {
                btn.Location = btnGrid[x, y - 1].Location;
                btnGrid[x, y - 1].Location = btnGrid[x, y].Location;
                btnGrid[x, y].Location = btn.Location;
                btn = btnGrid[x, y - 1];
                btnGrid[x, y - 1] = btnGrid[x, y];
                btnGrid[x, y - 1].Name = "btn" + x.ToString() + (y - 1).ToString();
                btnGrid[x, y] = btn;
                btnGrid[x, y].Name = "emptybtn";
            }
            if (y + 1 < btnGridSize && btnGrid[x, y + 1].Name == "emptybtn")
            {
                btn.Location = btnGrid[x, y + 1].Location;
                btnGrid[x, y + 1].Location = btnGrid[x, y].Location;
                btnGrid[x, y].Location = btn.Location;
                btn = btnGrid[x, y + 1];
                btnGrid[x, y + 1] = btnGrid[x, y];
                btnGrid[x, y + 1].Name = "btn" + x.ToString() + (y + 1).ToString();
                btnGrid[x, y] = btn;
                btnGrid[x, y].Name = "emptybtn";
            }
        }

        private void btnClick (object sender, EventArgs e)
        {
            move((Button)sender);
            isSolved();
        }

        private void Slide_Load(object sender, EventArgs e)
        {
            btnGrid = new Button[btnGridSize, btnGridSize];
            linear_list = new Button[btnGridSize * btnGridSize];
            ClientSize = new Size(615, 615);
            empty_btn_ind = btnGridSize * btnGridSize - 1;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        btnGrid[i, j] = new Button();
                        Controls.Add(btnGrid[i, j]);
                        btnGrid[i, j].Size = new Size(200, 200);
                        btnGrid[i, j].Location = new Point(205 * i, 205 * j);
                        btnGrid[i, j].Name = "emptybtn";
                        linear_list[i + j * 3] = btnGrid[i, j];
                    }
                    else
                    {
                        cropArea = new Rectangle(i * 200, j * 200, 200, 200);
                        Bitmap croppedImg = img.Clone(cropArea, img.PixelFormat);
                        btnGrid[i, j] = new Button();
                        Controls.Add(btnGrid[i, j]);
                        btnGrid[i, j].Size = new Size(200, 200);
                        btnGrid[i, j].Location = new Point(205 * i, 205 * j);
                        btnGrid[i, j].Image = croppedImg;
                        btnGrid[i, j].Name = "btn" + i.ToString() + j.ToString();
                        btnGrid[i, j].Click += new EventHandler(btnClick);
                        linear_list[i + j * 3] = btnGrid[i, j];
                    }
                }
            }
            Shuffle();
        }
    }
}
