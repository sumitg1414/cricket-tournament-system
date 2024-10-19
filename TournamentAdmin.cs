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
    public partial class TournamentAdmin : Form
    {
        public TournamentAdmin()
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
            da = new SqlDataAdapter("Select * From Tournament", con);
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                cmd = new SqlCommand();

                con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
                cmd.CommandText = "insert into Tournament (Round_1,Round_2,Round_3) values " +
          "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();

                MessageBox.Show("Inserted sucessfully");


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";


                GetList();
            }
        }

        private void TournamentAdmin_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "select * from Tournament";
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
            cmd = new SqlCommand();


            cmd.CommandText = "delete from Tournament  where Round_1='" + textBox1.Text + "'";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


            MessageBox.Show("Record delete sucessfully");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            


            GetList();
        }
    }
}
