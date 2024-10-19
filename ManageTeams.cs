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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRICKETNEW
{
    public partial class ManageTeams : Form
    {
        public ManageTeams()
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
        private void button5_Click(object sender, EventArgs e)
        {
            Admin A2 = new Admin();
            A2.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "update Teamreg set Coach_Name='" + textBox2.Text + "',Contact_No='" + textBox3.Text + "',Enter_Password='" + textBox4.Text + "',Confirm_Password='" + textBox5.Text +
                 "'where Team_Name =" + textBox1.Text + "";
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
            textBox5.Text = "";



            GetList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ManageTeams_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        public void disp_data()
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "select * from Teamreg";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")

            {

                cmd = new SqlCommand();

                con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
                cmd.CommandText = "insert into Teamreg (Team_Name,Coach_Name,Contact_No,Enter_Password,Confirm_Password) values " +
          "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
                textBox5.Text = "";

                GetList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();


            cmd.CommandText = "delete from Teamreg  where Team_Name='" + textBox1.Text + "'";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


            MessageBox.Show("Record delete sucessfully");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            


            GetList();
        }
    }
}
