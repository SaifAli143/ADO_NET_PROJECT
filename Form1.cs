using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_NET_PROJECT
{
   

        
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            String strconnection = ConfigurationManager.ConnectionStrings["Defaultconnection"].ConnectionString;
            con = new SqlConnection(strconnection);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from EMPLOYEE where ID=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));

                // open DB connection
                con.Open();
                // fire the query
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtname.Text = dr["NAME"].ToString();
                        txtsalary.Text = dr["SALARY"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("RECORD NOT FOUND");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into EMPLOYEE values(@name,@salary)";
                cmd = new SqlCommand(str, con);
                //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtsalary.Text));
                // open DB connection
                con.Open();
                // fire the query
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Inserted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "update EMPLOYEE set NAME=@name,SALARY=@salary where ID=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtsalary.Text));
                // open DB connection
                con.Open();
                // fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "delete from EMPLOYEE where ID=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                
                // open DB connection
                con.Open();
                // fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Deleted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from EMPLOYEE";
                cmd = new SqlCommand(str, con);
              //  cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));

                // open DB connection
                con.Open();
                // fire the query
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
