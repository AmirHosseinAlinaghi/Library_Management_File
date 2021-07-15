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
    public partial class registeruser : Form
    {
        public registeruser()
        {
            InitializeComponent();
        }
        database db = new database();
        private void button1_Click(object sender, EventArgs e)
        {
            if (NamTxt.Text.Trim() != "" && CodeTxt.Text.Trim() != "" && TellTxt.Text.Trim() != "" && FamilyTxt.Text.Trim() != "")
            {
                date_shamsi d_sh = new date_shamsi();
                db.run("insert into member(nam,family,codemeli,address,tell,date_o) values(N'" + NamTxt.Text + "',N'" + FamilyTxt.Text + "',N'" + CodeTxt.Text + "',N'" + AddressTxt.Text + "',N'" + TellTxt.Text + "',N'" + d_sh.DateShamsi() + "')");
                DeleteBtn.Visible = true;
                label7.Visible = true;
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }
        private void registergroup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NamTxt.Text.Trim() != "" && CodeTxt.Text.Trim() != "" && TellTxt.Text.Trim() != "" && FamilyTxt.Text.Trim() != "")
            {
                db.run("update [member] set nam=N'" + NamTxt.Text + "',codemeli=N'" + CodeTxt.Text + "',address=N'" + AddressTxt.Text + "',tell=N'" + TellTxt.Text + "',family=N'" + FamilyTxt.Text + "'where id=" + rabet.membercode);
                this.Close();
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }

        private void registeruser_Load(object sender, EventArgs e)
        {
            if (rabet.membercode != "")
            {
                //Tanzimat Virayesh
                button1.Visible = false;
                button2.Visible = true;
                DataTable dt = new DataTable();
                dt = db.get("select * from [member] where id =" + rabet.membercode);
                if (dt.Rows.Count > 0)
                {
                    NamTxt.Text = dt.Rows[0][1].ToString();
                    FamilyTxt.Text = dt.Rows[0][2].ToString();
                    CodeTxt.Text = dt.Rows[0][3].ToString();
                    TellTxt.Text = dt.Rows[0][4].ToString();
                    AddressTxt.Text = dt.Rows[0][5].ToString();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            NamTxt.ResetText();
            FamilyTxt.ResetText();
            CodeTxt.ResetText();
            AddressTxt.ResetText();
            TellTxt.ResetText();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
