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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void Logic_cat_launcher_Click(object sender, EventArgs e)
        {
            Logic_cat logic_cat = new Logic_cat();
            logic_cat.Show();
        }

        private void Memory_cat_launcher_Click(object sender, EventArgs e)
        {
            Memory memory_cat = new Memory();
            memory_cat.Show();
        }

        private void Speed_cat_launcher_Click(object sender, EventArgs e)
        {
            Speed_cat speed_cat = new Speed_cat();
            speed_cat.Show();
        }

        private void games_Click(object sender, EventArgs e)
        {
            Games gms = new Games();
            gms.Show();
        }
    }
}
