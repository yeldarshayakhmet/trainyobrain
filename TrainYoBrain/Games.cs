using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TrainYoBrain
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void Slide_Click(object sender, EventArgs e)
        {
            Slide Slide = new Slide();
            Slide.Show();
        }

        private void HanoiTowers_Click(object sender, EventArgs e)
        {
            Process.Start(@"htowers\Hanoi Towers.exe");
        }

        private void Lightsout_Click(object sender, EventArgs e)
        {
            LightsOut LightsOut = new LightsOut();
            LightsOut.Show();
        }
    }
}
