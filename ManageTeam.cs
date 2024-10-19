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
    public partial class ManageTeam : Form
    {
        public ManageTeam()
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
            da = new SqlDataAdapter("Select * From manage_team", con);
            da.Fill(dt);

            con.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")

            {

                cmd = new SqlCommand();


                con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
                cmd.CommandText = "insert into manage_team (P_id,P_Name,C_VC,Skill) values " +
          "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();

                MessageBox.Show("Inserted sucessfully");


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";


                GetList();
            }
            else
            {
                MessageBox.Show("Please Enter Mandatory Details");
            }
        }

        private void ManageTeam_Load(object sender, EventArgs e)
        {
            disp_data();
        }


        public void disp_data()
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "select * from manage_team";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "update  manage_team  set P_Name='" + textBox2.Text + "',Skill='" + textBox3.Text + "',C_VC='" + textBox4.Text +
                 "'where P_id=" + textBox1.Text + "";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


            MessageBox.Show("Record Updated  sucessfully");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            GetList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();


            cmd.CommandText = "delete from manage_team  where P_id='" + textBox1.Text + "'";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


            MessageBox.Show("Record Clear sucessfully");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            GetList();
        }
    }
}




