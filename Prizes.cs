using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRICKETNEW
{
    public partial class Prizes : Form
    {
        public Prizes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Home h1 = new Home();
            h1.ShowDialog();
            this.Hide();
        }
    }
}
