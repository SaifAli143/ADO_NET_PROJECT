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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["Defaultconnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into COURSE values(@id,@name,@fees)";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCOURSE_ID.Text));
                cmd.Parameters.AddWithValue("@name", txtCOURSE_NAME.Text);
                cmd.Parameters.AddWithValue("@fees", Convert.ToDouble(txtCOURSE_FEES.Text));
                // open DB connection
                con.Open();
                // fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
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
                string str = "update COURSE set NAME=@name,FEES=@fees where ID=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCOURSE_ID.Text));
                cmd.Parameters.AddWithValue("@name", txtCOURSE_NAME.Text);
                cmd.Parameters.AddWithValue("@fees", Convert.ToDouble(txtCOURSE_FEES.Text));
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
                string str = "delete from COURSE where ID=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCOURSE_ID.Text));

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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from COURSE where ID=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCOURSE_ID.Text));

                // open DB connection
                con.Open();
                // fire the query
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtCOURSE_NAME.Text = dr["NAME"].ToString();
                        txtCOURSE_FEES.Text = dr["FEES"].ToString();
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

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from COURSE";
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
