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
    public partial class registerbook : Form
    {
        public registerbook()
        {
            InitializeComponent();
        }
        database db = new database();
        private void button1_Click(object sender, EventArgs e)
        {
            if (WriterTxt.Text.Trim() != "" && NasherTxt.Text.Trim() != "" && OnvanTxt.Text.Trim() != "" && EntesharTxt.Text.Trim() != "" && ChapTxt.Text.Trim() != "" && SarshenasehTxt.Text.Trim() != "" && mozoeTxt.Text.Trim() != "" && ZaheriTxt.Text.Trim() != "" && ShabakTxt.Text.Trim() != "" && FehrestTxt.Text.Trim() != "" && KetabShenasiTxt.Text.Trim() != "" && TirazhTxt.Text.Trim() != "" && DornegarTxt.Text.Trim() != "")
            {
                db.run("insert into book(group_id,author,nasher,title,enteshar,noskheh,motarjem,sarshenaseh,mozoe,zaheri,shabak,fehrest,yaddasht,kongereh,divoii,ketabshenasi,tirazh,dornegar) values(" + GroupCombo.SelectedValue + ",N'" + WriterTxt.Text + "',N'" + NasherTxt.Text + "',N'" + OnvanTxt.Text + "',N'" + EntesharTxt.Text + "',N'" + ChapTxt.Text + "',N'" + TarjomehTxt.Text + "',N'" + SarshenasehTxt.Text + "',N'" + mozoeTxt.Text + "',N'" + ZaheriTxt.Text + "',N'" + ShabakTxt.Text  + "',N'" + FehrestTxt.Text + "',N'" + YaddashtTxt.Text + "',N'" + KongerehTxt.Text + "',N'" + DivoiiTxt.Text + "',N'" + KetabShenasiTxt.Text + "',N'" + TirazhTxt.Text + "',N'" + DornegarTxt.Text + "')");
                DeleteBtn.Visible = true;
                label6.Visible = true;
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }
        string bookcode = "";
        private void registergroup_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = db.getdataset("select id,sharh from [group]");
            GroupCombo.DataBindings.Clear();
            GroupCombo.DataSource = null;
            GroupCombo.Items.Clear();
            GroupCombo.DataBindings.Add(new Binding("datasource", ds, "c"));
            GroupCombo.DisplayMember = "sharh";
            GroupCombo.ValueMember = "id"; 


            if (rabet.bookcode != "")
            {
                //Tanzimat Virayesh
                bookcode = rabet.bookcode;
                rabet.bookcode = "";
                button1.Visible = false;
                button2.Visible = true;
               
             DataTable dt = new DataTable();
             dt = db.get("select * from book where id =" + bookcode);
             if (dt.Rows.Count > 0)
             {
                 OnvanTxt.Text = dt.Rows[0][2].ToString();
                 WriterTxt.Text = dt.Rows[0][3].ToString();
                 TarjomehTxt.Text = dt.Rows[0][4].ToString();
                 ChapTxt.Text = dt.Rows[0][5].ToString();
                 NasherTxt.Text = dt.Rows[0][6].ToString();
                 EntesharTxt.Text = dt.Rows[0][7].ToString();
                 SarshenasehTxt.Text = dt.Rows[0][8].ToString();
                 mozoeTxt.Text = dt.Rows[0][9].ToString();
                 ZaheriTxt.Text = dt.Rows[0][10].ToString();
                 ShabakTxt.Text = dt.Rows[0][11].ToString();
                 FehrestTxt.Text = dt.Rows[0][12].ToString();
                 YaddashtTxt.Text = dt.Rows[0][13].ToString();
                 KongerehTxt.Text = dt.Rows[0][14].ToString();
                 DivoiiTxt.Text = dt.Rows[0][15].ToString();
                 KetabShenasiTxt.Text = dt.Rows[0][16].ToString();
                 TirazhTxt.Text = dt.Rows[0][17].ToString();
                 DornegarTxt.Text = dt.Rows[0][18].ToString();
              }                  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WriterTxt.Text.Trim() != "" && NasherTxt.Text.Trim() != "" && OnvanTxt.Text.Trim() != "" && EntesharTxt.Text.Trim() != "" && ChapTxt.Text.Trim() != "" && SarshenasehTxt.Text.Trim() != "" && mozoeTxt.Text.Trim() != "" && ZaheriTxt.Text.Trim() != "" && ShabakTxt.Text.Trim() != "" && FehrestTxt.Text.Trim() != "" && KetabShenasiTxt.Text.Trim() != "" && TirazhTxt.Text.Trim() != "" && DornegarTxt.Text.Trim() != "")
            {
                db.run("update book set group_id=" + GroupCombo.SelectedValue + ",author=N'" + WriterTxt.Text + "',nasher=N'" + NasherTxt.Text + "',title=N'" + OnvanTxt.Text + "',enteshar=N'" + EntesharTxt.Text + "',motarjem=N'" + TarjomehTxt.Text + "',noskheh=N'" + ChapTxt.Text + "',sarshenaseh=N'" + SarshenasehTxt.Text + "',mozoe=N'" + mozoeTxt.Text + "',zaheri=N'" + ZaheriTxt.Text + "',shabak=N'" + ShabakTxt.Text + "',fehrest=N'" + FehrestTxt.Text + "',yaddasht=N'" + YaddashtTxt.Text + "',kongereh=N'" + KongerehTxt.Text + "',divoii=N'" + DivoiiTxt.Text + "',ketabshenasi=N'" + KetabShenasiTxt.Text + "',tirazh=N'" + TirazhTxt.Text + "',dornegar=N'" + DornegarTxt.Text + "'where id=" + bookcode);
                this.Close();
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            WriterTxt.ResetText();
            NasherTxt.ResetText();
            OnvanTxt.ResetText();
            EntesharTxt.ResetText();
            ChapTxt.ResetText();
            TarjomehTxt.ResetText();
            SarshenasehTxt.ResetText();
            mozoeTxt.ResetText();
            ZaheriTxt.ResetText();
            ShabakTxt.ResetText();
            FehrestTxt.ResetText();
            YaddashtTxt.ResetText();
            KongerehTxt.ResetText();
            DivoiiTxt.ResetText();
            KetabShenasiTxt.ResetText();
            TirazhTxt.ResetText();
            DornegarTxt.ResetText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
