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
    public partial class managegroup : Form
    {
        public managegroup()
        {
            InitializeComponent();
        }
        database db = new database();
        private void showitems()
        {
            this.Group_Database.DefaultCellStyle.Font = new Font("B Nazanin", 11);
            Group_Database.DataSource = db.get("select * from [group]");

            Group_Database.Columns[0].HeaderText = "کد دسته";
            Group_Database.Columns[0].Width = 100;
            Group_Database.Columns[1].HeaderText = "شرح";
            Group_Database.Columns[1].Width = 300;
            Group_Database.Columns[2].HeaderText = "بخش";
            Group_Database.Columns[2].Width = 250;
        }
        private void managegroup_Load(object sender, EventArgs e)
        {
            showitems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟", "", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.run("delete from [group] where id =" + Group_Database.SelectedRows[0].Cells[0].Value.ToString());
                showitems();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           rabet.groupcode = Group_Database.SelectedRows[0].Cells[0].Value.ToString();
           registergroup f = new registergroup();
           f.ShowDialog();
           showitems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
