using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class database
    {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=library;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds;
            string message = "";

            public string run(string command)
            {
                cmd = new SqlCommand(command, con);

                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    message = "yes";
                    MessageBox.Show("انجام شد");
                    //Message = "no";
                    //MessageBox.Show("خطا");
                return message;

            }

            public DataTable get(string command)
            {
                dt = new DataTable();
                da = new SqlDataAdapter(command, con);
                try
                {
                    da.Fill(dt);
                }
                catch
                {
                    MessageBox.Show("خطا در نمایش اطلاعات");
                }
                return dt;
            }




            public DataSet getdataset(string command)
            {
               ds = new DataSet();
               SqlDataAdapter da2 = new SqlDataAdapter(command, con);
                try
                {
                    da2.Fill(ds, "c");
                }

                catch
                {
                    MessageBox.Show("خطا در نمایش اطلاعات");
                }
                return ds;
            }
        }
    }
