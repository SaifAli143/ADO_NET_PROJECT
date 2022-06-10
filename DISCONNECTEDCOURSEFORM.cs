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
using System.Data;

namespace ADO_NET_PROJECT
{
    public partial class DISCONNECTEDCOURSEFORM : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;

        public DISCONNECTEDCOURSEFORM()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["Defaultconnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

        private DataSet GetCOURSEData()
        {
            da = new SqlDataAdapter("select * from COURSE", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "COURSE");
            return ds;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetCOURSEData();
                DataRow row = ds.Tables["COURSE"].NewRow();
                row["NAME"] = txtCOURSE_NAME.Text;
                row["FEES"] = txtCOURSE_FEES.Text;
                ds.Tables["COURSE"].Rows.Add(row);
                int result = da.Update(ds.Tables["COURSE"]);
                if (result == 1)
                {
                    MessageBox.Show("Record Inserted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetCOURSEData();
                DataRow row = ds.Tables["COURSE"].Rows.Find(txtCOURSE_ID.Text);
                if (row != null)
                {
                    row["NAME"] = txtCOURSE_NAME.Text;
                    row["FEES"] = txtCOURSE_FEES.Text;
                    int result = da.Update(ds.Tables["COURSE"]);
                    if (result == 1)
                    {
                        MessageBox.Show("RECORD UPDATED");
                    }

                }
                else
                {
                    MessageBox.Show("ID DOES NOT EXISTS TO UPDATE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetCOURSEData();
                DataRow row = ds.Tables["COURSE"].Rows.Find(txtCOURSE_ID.Text);
                if (row != null)
                {
                    row.Delete();

                    // row["NAME"] = txtname.Text;
                    //row["SALARY"] = txtsalary.Text;
                    int result = da.Update(ds.Tables["COURSE"]);
                    if (result == 1)
                    {
                        MessageBox.Show("RECORD DELETED");
                    }





                }
                else
                {
                    MessageBox.Show("ID DOES NOT EXISTS TO DELETED");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetCOURSEData();
                DataRow row = ds.Tables["COURSE"].Rows.Find(txtCOURSE_ID.Text);
                if (row != null)
                {
                    txtCOURSE_NAME.Text = row["NAME"].ToString();
                    txtCOURSE_FEES.Text = row["FEES"].ToString();


                }
                else
                {
                    MessageBox.Show("ID DOES NOT EXISTS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ds = GetCOURSEData();
            dataGridView1.DataSource = ds.Tables["COURSE"];
        }
    }
}
