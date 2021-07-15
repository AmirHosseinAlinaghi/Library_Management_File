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
    public partial class manage_user : Form
    {
        public manage_user()
        {
            InitializeComponent();
        }
        database db = new database();
        private void showitems()
        {
            this.User_Database.DefaultCellStyle.Font = new Font("B Nazanin", 11);
            User_Database.DataSource = db.get("select * from [member]");

            User_Database.Columns[0].HeaderText = "کد کاربر";
            User_Database.Columns[0].Width = 100;
            User_Database.Columns[1].HeaderText = "نام";
            User_Database.Columns[1].Width = 300;
            User_Database.Columns[2].HeaderText = "نام خانوادگی";
            User_Database.Columns[2].Width = 300;
            User_Database.Columns[3].HeaderText = "کد ملی";
            User_Database.Columns[3].Width = 250;
            User_Database.Columns[4].HeaderText = "شماره همراه";
            User_Database.Columns[4].Width = 250;
            User_Database.Columns[5].HeaderText = "آدرس کاربر";
            User_Database.Columns[5].Width = 350;
            User_Database.Columns[6].HeaderText = "تاریخ عضویت";
            User_Database.Columns[6].Width = 250;
        }
        private void manage_user_Load(object sender, EventArgs e)
        {
            showitems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.run("delete from [member] where id =" + User_Database.SelectedRows[0].Cells[0].Value.ToString());
                showitems();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rabet.membercode = User_Database.SelectedRows[0].Cells[0].Value.ToString();
            registeruser f = new registeruser();
            f.ShowDialog();
            showitems();
        }
    }
}
