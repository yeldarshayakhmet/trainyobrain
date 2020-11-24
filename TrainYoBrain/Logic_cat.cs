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
    public partial class Logic_cat : Form
    {
        public Logic_cat()
        {
            InitializeComponent();
        }

        private void Logic_cat_Load(object sender, EventArgs e)
        {

        }

        private void razvertka_Click(object sender, EventArgs e)
        {
            Razvertka razv = new Razvertka();
            razv.Show();
            Close();
        }

        private void rotation_Click(object sender, EventArgs e)
        {
            Block_rotation block_rotation = new Block_rotation();
            block_rotation.Show();
            Close();
        }
    }
}
