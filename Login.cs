using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRICKETNEW
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {












            Register R1 = new Register();
            R1.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Adminlogin A1 = new Adminlogin();
            A1.ShowDialog();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Contact C1 = new Contact();
            C1.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the Teamname");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter  the Password");

            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                      Integrated Security=true");
                    SqlCommand cmd = new SqlCommand("select * from  Teamreg where Team_Name = @Team_Name and Enter_Password =@Enter_Password", con);
                    cmd.Parameters.AddWithValue("@Team_Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Enter_Password", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        Home h1 = new Home();
                        h1.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(" TeamName or Password is Invalid");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.ShowDialog();
            this.Hide();
        }
    }
}
