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
    public partial class Teamdetail2 : Form
    {
        public Teamdetail2()
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
            da = new SqlDataAdapter("Select * From Teamdetail", con);
            da.Fill(dt);

            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.ShowDialog();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")

            {

                cmd = new SqlCommand();


                con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
                cmd.CommandText = "insert into Teamdetail (Team_id,Name,Email,City) values " +
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
           

        }




        public void disp_data()
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "select * from Teamdetail";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void Teamdetail2_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "update  Teamdetail  set Name='" + textBox2.Text + "',Email='" + textBox3.Text + "',City='" + textBox4.Text +
                 "'where Team_id=" + textBox1.Text + "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();


            cmd.CommandText = "delete from Teamdetail where Team_id='" + textBox1.Text + "'";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


            MessageBox.Show("Record Remove sucessfully");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            GetList();
        }
    }





}
