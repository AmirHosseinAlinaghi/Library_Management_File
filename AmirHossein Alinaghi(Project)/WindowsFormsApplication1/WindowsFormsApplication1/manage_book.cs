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
    public partial class manage_book : Form
    {
        public manage_book()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            dt = db.get("select * from book");
            if (dt.Rows.Count > 0)
            {
                Book_Database.DataSource = dt;
                text_headers();
            }
        }
        private void text_headers()
        {
            this.Book_Database.DefaultCellStyle.Font = new Font("B Nazanin" , 11);
            Book_Database.Columns[2].HeaderText = "کد";
            Book_Database.Columns[2].Width = 100;
            Book_Database.Columns[3].HeaderText = "گروه";
            Book_Database.Columns[3].Width = 100;
            Book_Database.Columns[4].HeaderText = "عنوان";
            Book_Database.Columns[4].Width = 150;
            Book_Database.Columns[5].HeaderText = "نویسنده";
            Book_Database.Columns[5].Width = 100;
            Book_Database.Columns[6].HeaderText = "مترجم";
            Book_Database.Columns[6].Width = 100;
            Book_Database.Columns[7].HeaderText = "نسخه چاپ";
            Book_Database.Columns[7].Width = 100;
            Book_Database.Columns[8].HeaderText = "ناشر";
            Book_Database.Columns[8].Width = 150;
            Book_Database.Columns[9].HeaderText = "سال انتشار";
            Book_Database.Columns[9].Width = 100;
            Book_Database.Columns[10].HeaderText = "سرشناسه";
            Book_Database.Columns[10].Width = 150;
            Book_Database.Columns[11].HeaderText = "موضوع";
            Book_Database.Columns[11].Width = 150;
            Book_Database.Columns[12].HeaderText = "مشخصات ظاهری";
            Book_Database.Columns[12].Width = 100;
            Book_Database.Columns[13].HeaderText = "شابک";
            Book_Database.Columns[13].Width = 150;
            Book_Database.Columns[14].HeaderText = "وضعیت فهرست نویسی";
            Book_Database.Columns[14].Width = 100;
            Book_Database.Columns[15].HeaderText = "یادداشت";
            Book_Database.Columns[15].Width = 250;
            Book_Database.Columns[16].HeaderText = "رده بندی کنگره";
            Book_Database.Columns[16].Width = 150;
            Book_Database.Columns[17].HeaderText = "رده بندی دیویی";
            Book_Database.Columns[17].Width = 100;
            Book_Database.Columns[18].HeaderText = "شماره کتابشناسی(ملی)";
            Book_Database.Columns[18].Width = 100;
            Book_Database.Columns[19].HeaderText = "تیراژ";
            Book_Database.Columns[19].Width = 100;
            Book_Database.Columns[20].HeaderText = "دورنگار";
            Book_Database.Columns[20].Width = 150;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (WriterTxt.Text.Trim() != "")
            {
                dt = db.get("select * from book where author like N'" + WriterTxt.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    Book_Database.DataSource = dt;
                    text_headers();
                }
            }
            else
            {
                MessageBox.Show("نویسنده را وارد کنید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OnvanTxt.Text.Trim() != "")
            {
                dt = db.get("select * from book where title like N'" + OnvanTxt.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    Book_Database.DataSource = dt;
                    text_headers();
                }
            }
            else
            {
                MessageBox.Show("عنوان را وارد کنید");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (Book_Database.CurrentCell.Value.ToString().Trim() == "حذف")
                {
                    if (MessageBox.Show("آیا مطمئن هستید؟", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.run("delete from book where id="+ Book_Database.CurrentRow.Cells[2].Value.ToString());
                    }
                }
                else if (Book_Database.CurrentCell.Value.ToString().Trim() == "ویرایش")
                {
                    rabet.bookcode = Book_Database.CurrentRow.Cells[2].Value.ToString();
                    registerbook f = new registerbook();
                    f.ShowDialog();
                    f.Show();
                }
        }
    }
}
