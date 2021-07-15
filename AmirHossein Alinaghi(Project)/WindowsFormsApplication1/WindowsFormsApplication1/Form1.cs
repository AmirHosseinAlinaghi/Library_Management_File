using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            MiladiLbl.Text = System.DateTime.Now.Year.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Day.ToString();
            TimeLbl.Text = System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString();
            PersianCalendar p = new PersianCalendar();
            ShamsiLbl.Text = p.GetYear(System.DateTime.Now) + "/" + p.GetMonth(System.DateTime.Now) + "/" + p.GetDayOfMonth(System.DateTime.Now);
        }



        private void دستهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registergroup f = new registergroup();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void مدیریتدستههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managegroup f = new managegroup();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void ثبتکتابجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerbook f = new registerbook();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void جستجویکتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_book f = new manage_book();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void ثبتعضوجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registeruser f = new registeruser();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register_amanat f = new register_amanat();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void جستجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_amanat f = new search_amanat();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void مدیریتکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_user f = new manage_user();
            f.MdiParent = Form1.ActiveForm;
            f.Show();
        }

        private void ShamsiLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
