using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRICKETNEW
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet db;

        void GetList()
        {
            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G;Initial catalog=CTMS;Integrated Security=true");
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * From Teamreg", con);
            da.Fill(dt);

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")

            {

                cmd = new SqlCommand();

                con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
                cmd.CommandText = "insert into Teamreg (Team_Name, Coach_Name,Contact_No,Enter_Password,Confirm_Password) values " +
          "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted sucessfully");


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                GetList();
            }
            else
            {
                MessageBox.Show("Please Enter Mandatory Details");
            }



















        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login L1 = new Login();
            L1.ShowDialog();
            this.Hide();

        }



        private void Register_Load(object sender, EventArgs e)
        {
           
        }
    }



}
