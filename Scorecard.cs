﻿using System;
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
    public partial class Scorecard : Form
    {
        public Scorecard()
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
            da = new SqlDataAdapter("Select * From Scorecard1", con);
            da.Fill(dt);

            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {


            Admin A2 = new Admin();
            A2.ShowDialog();
            this.Hide();
        }

        private void Scorecard_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "select * from Scorecard1";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")

            {

                cmd = new SqlCommand();


                con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
                cmd.CommandText = "insert into Scorecard1 (Sr_no,Team1_Name,Team2_Name,T1_Score,T2_Score,Win_Team) values " +
          "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "' ,'" + textBox6.Text + "')";
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();

                MessageBox.Show("Record Submit sucessfully");


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";




                GetList();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();

            con = new SqlConnection(@"Data Source =DESKTOP-PRCIU0G ; Initial Catalog=CTMS;
                  Integrated Security=true");
            cmd.CommandText = "update  Scorecard1  set Team1_Name='" + textBox2.Text + "',Team2_Name='" + textBox3.Text + "',T1_Score='" + textBox4.Text + "',T2_Score='" + textBox5.Text + "',Win_Team='" + textBox6.Text +
                 "'where Sr_no =" + textBox1.Text + "";
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
            textBox6.Text = "";


            GetList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();


            cmd.CommandText = "delete from Scorecard1  where Sr_no='" + textBox1.Text + "'";
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


            MessageBox.Show("Record Delete sucessfully");


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


            GetList();
        }
    }
}
