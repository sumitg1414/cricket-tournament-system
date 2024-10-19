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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show(" Please Enter Username ");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show(" Please Enter Password ");
                }
                else if (textBox1.Text == "SUMIT" && textBox2.Text == "admin")
                {
                    Admin A2 = new Admin();
                    A2.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Username & Password");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            L1.ShowDialog();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
