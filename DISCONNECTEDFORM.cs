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
    public partial class DISCONNECTEDFORM : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;

        public DISCONNECTEDFORM()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["Defaultconnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

        private DataSet GetEMPLOYEEData()
        {
            da = new SqlDataAdapter("select * from EMPLOYEE", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();              
            da.Fill(ds, "EMPLOYEE");
            return ds;

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEMPLOYEEData();
                DataRow row = ds.Tables["EMPLOYEE"].NewRow();
                row["NAME"] = txtname.Text;
                row["SALARY"] = txtsalary.Text;
                ds.Tables["EMPLOYEE"].Rows.Add(row);
                int result = da.Update(ds.Tables["EMPLOYEE"]);
                if(result==1)
                {
                    MessageBox.Show("Record Inserted");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEMPLOYEEData();
                DataRow row = ds.Tables["EMPLOYEE"].Rows.Find(txtid.Text);
                if(row != null)
                {
                    row["NAME"] = txtname.Text;
                    row["SALARY"] = txtsalary.Text;
                    int result = da.Update(ds.Tables["EMPLOYEE"]);
                    if(result == 1)
                    {
                        MessageBox.Show("RECORD UPDATED");
                    }

                }
                else
                {
                    MessageBox.Show("ID DOES NOT EXISTS TO UPDATE");
                }
                      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEMPLOYEEData();
                DataRow row = ds.Tables["EMPLOYEE"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    row.Delete();

                   // row["NAME"] = txtname.Text;
                    //row["SALARY"] = txtsalary.Text;
                    int result = da.Update(ds.Tables["EMPLOYEE"]);
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
                ds = GetEMPLOYEEData();
                DataRow row = ds.Tables["EMPLOYEE"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    txtname.Text = row["NAME"].ToString();
                    txtsalary.Text = row["SALARY"].ToString();

                        
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
            ds = GetEMPLOYEEData();
            dataGridView1.DataSource = ds.Tables["EMPLOYEE"];
        }
    }
}
