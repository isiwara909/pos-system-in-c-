﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stockmanegment_system
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TE7B5C7;Initial Catalog=studentmanegment;Integrated Security=True");






        public void addtogrid()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from [teacher_info] ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex);
            }

            finally
            {
                con.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sname = textBox1.Text;
                string email = textBox2.Text;
                string grade = comboBox1.Text;
             

                string subject = comboBox2.Text;

                string sqlstring = "INSERT INTO [teacher_info] VALUES (  '" + sname + "',  '" + email + "', '" + grade + "','" + subject + "')";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid();
                con.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string sname = textBox1.Text;
                string email = textBox2.Text;
                string subject = comboBox1.Text;
               
                string grade = comboBox1.Text;

                string sqlstring = "UPDATE [studenet_info] SET teachername =  '" + sname + "', email = '" + email + "',subject = '" + subject + "',class = '"+grade+"', WEARE teacher_name = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlstring, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added Successfully", "SMD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addtogrid();
                con.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
    }
    

