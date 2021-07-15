using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class registergroup : Form
    {
        public registergroup()
        {
            InitializeComponent();
        }
        database db = new database();
        private void button1_Click(object sender, EventArgs e)
        {
            if (SharhTxt.Text.Trim() != "" && BakhshTxt.Text.Trim() != "")
            { 
                db.run("insert into [group](sharh,bakhsh) values(N'" + SharhTxt.Text + "',N'" + BakhshTxt.Text + "')");
                DeleteBtn.Visible = true;
                label3.Visible = true;
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }

        private void registergroup_Load(object sender, EventArgs e)
        {
            if (rabet.groupcode != "")
            {
                //Tanzimat Virayesh
                button1.Visible = false;
                button2.Visible = true;
                DataTable dt = new DataTable();
             dt = db.get("select * from [group] where id ="+rabet.groupcode);
             if (dt.Rows.Count > 0)
             {
                 SharhTxt.Text = dt.Rows[0][1].ToString();
                 BakhshTxt.Text = dt.Rows[0][2].ToString();  
             }      
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SharhTxt.Text.Trim() != "" && BakhshTxt.Text.Trim() != "")
            {

                db.run("update [group] set sharh= N'" + SharhTxt.Text + "',bakhsh= N'" + BakhshTxt.Text + "'where id="+ rabet.groupcode);
                this.Close();
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SharhTxt.ResetText();
            BakhshTxt.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
