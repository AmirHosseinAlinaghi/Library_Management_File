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
    public partial class search_amanat : Form
    {
        public search_amanat()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            dt = db.get("select a.id,m.nam,m.family,b.title,a.tahvil_date,a.s_date,a.bazgardani from amanat a,member m,book b where a.member_id=m.id and a.book_id=b.id ");
            if (dt.Rows.Count > 0)
            {
                Amanat_Database.DataSource = dt;
                text_headers();
            }
        }
        private void text_headers()
        {
            this.Amanat_Database.DefaultCellStyle.Font = new Font("B Nazanin", 11);
            Amanat_Database.Columns[2].HeaderText = "کد";
            Amanat_Database.Columns[2].Width = 100;
            Amanat_Database.Columns[3].HeaderText = "نام عضو";
            Amanat_Database.Columns[3].Width = 100;
            Amanat_Database.Columns[4].HeaderText = "نام خانوادگی عضو";
            Amanat_Database.Columns[4].Width = 100;
            Amanat_Database.Columns[5].HeaderText = "کتاب";
            Amanat_Database.Columns[5].Width = 150;
            Amanat_Database.Columns[6].HeaderText = "تاریخ تحویل";
            Amanat_Database.Columns[6].Width = 100;
            Amanat_Database.Columns[7].HeaderText = "تاریخ بازگردانی";
            Amanat_Database.Columns[7].Width = 150;
            Amanat_Database.Columns[8].HeaderText = "بازگردانی";
            Amanat_Database.Columns[8].Width = 100;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (CodeTxt.Text.Trim() != "")
            {
                dt = db.get("select a.id,m.nam,m.family,b.title,a.tahvil_date,a.s_date,a.bazgardani from amanat a,member m,book b where a.member_id=m.id and a.book_id=b.id and a.member_id=" + CodeTxt.Text);
                if (dt.Rows.Count > 0)
                {
                    Amanat_Database.DataSource = dt;
                    text_headers();
                }
            }
            else
            {
                MessageBox.Show("کد کاربر را وارد کنید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt = db.get("select a.id,m.nam,m.family,b.title,a.tahvil_date,a.s_date,a.bazgardani from amanat a,member m,book b where a.member_id=m.id and a.book_id=b.id and a.bazgardani=0");
            if (dt.Rows.Count > 0)
            {
                Amanat_Database.DataSource = dt;
                text_headers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (Amanat_Database.CurrentCell.Value.ToString().Trim() == "حذف")
                {
                    if (MessageBox.Show("آیا مطمئن هستید؟", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.run("delete from amanat where id=" + Amanat_Database.CurrentRow.Cells[2].Value.ToString());
                    }
 
                }
                else if (Amanat_Database.CurrentCell.Value.ToString().Trim() == "بازگردانی")
                {
                    db.run("update amanat set bazgardani=1  where id=" + Amanat_Database.CurrentRow.Cells[2].Value.ToString());
                }
        }

        private void manage_book_Load(object sender, EventArgs e)
        {

        }
    }
}
