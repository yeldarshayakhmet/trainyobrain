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
    public partial class Memory : Form
    {
        bool check = true;
        public Memory()
        {
            InitializeComponent();
        }

        private void Memory_Load(object sender, EventArgs e)
        {

        }

        private void proverbs_button_Click(object sender, EventArgs e)
        {
            Proverbs proverbs = new Proverbs();
            proverbs.Show();
            Close();
        }

        private void Figures_Click(object sender, EventArgs e)
        {
            if (check || Figures_test.closed)
            {
                Figures Figures_form = new Figures();
                Figures_form.Show();
                check = false;
                Figures_test.closed = false;
            }
        }
    }
}
