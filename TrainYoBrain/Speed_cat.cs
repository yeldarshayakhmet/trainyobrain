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
    public partial class Speed_cat : Form
    {
        public Speed_cat()
        {
            InitializeComponent();
        }

        private void speed_game_button_Click(object sender, EventArgs e)
        {
            speed_game speed_game = new speed_game();
            speed_game.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution();
            solution.Show();
            Hide();
        }
    }
}
