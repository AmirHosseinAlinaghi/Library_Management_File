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
    public partial class register_amanat : Form
    {
        public register_amanat()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable dt = new DataTable();
        date_shamsi d_sh = new date_shamsi();
        string user_id = "";
        string book_id = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CodeTxt.Text.Trim() != "")
            {
                dt = db.get("select id,nam,family from member where id=" + CodeTxt.Text);
                if (dt.Rows.Count > 0)
                {
                    user_id = dt.Rows[0]["id"].ToString();
                    KarbarLbl.Text = dt.Rows[0]["nam"].ToString() + " " + dt.Rows[0]["family"].ToString();
                }
            }
        }

        private void register_amanat_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TahvilTxt.Text= d_sh.DateShamsi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_id != "" && book_id != "" && TahvilTxt.Text.Trim() != "" && BazgashtTxt.Text.Trim() != "")
            {
                db.run("insert into amanat (member_id,book_id,tahvil_date,s_date,bazgardani) values (" + user_id + "," + book_id + ",N'" + TahvilTxt.Text + "',N'" + BazgashtTxt.Text + "',0)");
                DeleteBtn.Visible = true;
                label1.Visible = true;
            }
            else
            {
                MessageBox.Show("اطلاعات را کامل وارد کنید");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            CodeTxt.ResetText();
            BookTxt.ResetText();
            TahvilTxt.ResetText();
            BazgashtTxt.ResetText();
        }

        private void KarbarLbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BookTxt_TextChanged(object sender, EventArgs e)
        {
            if (BookTxt.Text.Trim() != "")
            {
                dt = db.get("select id,title from book where id=" + BookTxt.Text);
                if (dt.Rows.Count > 0)
                {
                    book_id = dt.Rows[0]["id"].ToString();
                    BookLbl.Text = dt.Rows[0]["title"].ToString();
                }
            }
        }
    }
}
