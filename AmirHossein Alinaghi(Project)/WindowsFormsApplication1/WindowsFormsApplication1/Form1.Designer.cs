namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MiladiLbl = new System.Windows.Forms.Label();
            this.ShamsiLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتدستههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کتابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکتابجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجویکتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عضوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتعضوجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اماناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MiladiLbl);
            this.panel1.Controls.Add(this.ShamsiLbl);
            this.panel1.Controls.Add(this.TimeLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 42);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(407, 2);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(136, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاریخ شمسی :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 4);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(77, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "ساعت :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "تاریخ میلادی :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiladiLbl
            // 
            this.MiladiLbl.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MiladiLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MiladiLbl.Location = new System.Drawing.Point(139, 10);
            this.MiladiLbl.Name = "MiladiLbl";
            this.MiladiLbl.Size = new System.Drawing.Size(105, 23);
            this.MiladiLbl.TabIndex = 0;
            this.MiladiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShamsiLbl
            // 
            this.ShamsiLbl.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShamsiLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShamsiLbl.Location = new System.Drawing.Point(537, 11);
            this.ShamsiLbl.Name = "ShamsiLbl";
            this.ShamsiLbl.Size = new System.Drawing.Size(105, 23);
            this.ShamsiLbl.TabIndex = 0;
            this.ShamsiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShamsiLbl.Click += new System.EventHandler(this.ShamsiLbl_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimeLbl.Location = new System.Drawing.Point(315, 11);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(105, 23);
            this.TimeLbl.TabIndex = 0;
            this.TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتToolStripMenuItem,
            this.اماناتToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(624, 43);
            this.menuStrip1.TabIndex = 1;
            // 
            // ثبتToolStripMenuItem
            // 
            this.ثبتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دستهToolStripMenuItem,
            this.کتابToolStripMenuItem,
            this.عضوToolStripMenuItem});
            this.ثبتToolStripMenuItem.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ثبتToolStripMenuItem.Name = "ثبتToolStripMenuItem";
            this.ثبتToolStripMenuItem.Size = new System.Drawing.Size(57, 39);
            this.ثبتToolStripMenuItem.Text = "ثبت";
            // 
            // دستهToolStripMenuItem
            // 
            this.دستهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دستهجدیدToolStripMenuItem,
            this.مدیریتدستههاToolStripMenuItem});
            this.دستهToolStripMenuItem.Name = "دستهToolStripMenuItem";
            this.دستهToolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.دستهToolStripMenuItem.Text = "دسته";
            // 
            // دستهجدیدToolStripMenuItem
            // 
            this.دستهجدیدToolStripMenuItem.Name = "دستهجدیدToolStripMenuItem";
            this.دستهجدیدToolStripMenuItem.Size = new System.Drawing.Size(211, 40);
            this.دستهجدیدToolStripMenuItem.Text = "ثبت دسته جدید";
            this.دستهجدیدToolStripMenuItem.Click += new System.EventHandler(this.دستهجدیدToolStripMenuItem_Click);
            // 
            // مدیریتدستههاToolStripMenuItem
            // 
            this.مدیریتدستههاToolStripMenuItem.Name = "مدیریتدستههاToolStripMenuItem";
            this.مدیریتدستههاToolStripMenuItem.Size = new System.Drawing.Size(211, 40);
            this.مدیریتدستههاToolStripMenuItem.Text = "مدیریت دسته ها";
            this.مدیریتدستههاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتدستههاToolStripMenuItem_Click);
            // 
            // کتابToolStripMenuItem
            // 
            this.کتابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتکتابجدیدToolStripMenuItem,
            this.جستجویکتابهاToolStripMenuItem});
            this.کتابToolStripMenuItem.Name = "کتابToolStripMenuItem";
            this.کتابToolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.کتابToolStripMenuItem.Text = "کتاب";
            // 
            // ثبتکتابجدیدToolStripMenuItem
            // 
            this.ثبتکتابجدیدToolStripMenuItem.Name = "ثبتکتابجدیدToolStripMenuItem";
            this.ثبتکتابجدیدToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.ثبتکتابجدیدToolStripMenuItem.Text = "ثبت کتاب جدید";
            this.ثبتکتابجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتکتابجدیدToolStripMenuItem_Click);
            // 
            // جستجویکتابهاToolStripMenuItem
            // 
            this.جستجویکتابهاToolStripMenuItem.Name = "جستجویکتابهاToolStripMenuItem";
            this.جستجویکتابهاToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.جستجویکتابهاToolStripMenuItem.Text = "جست و جوی کتاب ها";
            this.جستجویکتابهاToolStripMenuItem.Click += new System.EventHandler(this.جستجویکتابهاToolStripMenuItem_Click);
            // 
            // عضوToolStripMenuItem
            // 
            this.عضوToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتعضوجدیدToolStripMenuItem,
            this.مدیریتکاربرانToolStripMenuItem});
            this.عضوToolStripMenuItem.Name = "عضوToolStripMenuItem";
            this.عضوToolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.عضوToolStripMenuItem.Text = "عضو";
            // 
            // ثبتعضوجدیدToolStripMenuItem
            // 
            this.ثبتعضوجدیدToolStripMenuItem.Name = "ثبتعضوجدیدToolStripMenuItem";
            this.ثبتعضوجدیدToolStripMenuItem.Size = new System.Drawing.Size(205, 40);
            this.ثبتعضوجدیدToolStripMenuItem.Text = "ثبت عضو جدید";
            this.ثبتعضوجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتعضوجدیدToolStripMenuItem_Click);
            // 
            // مدیریتکاربرانToolStripMenuItem
            // 
            this.مدیریتکاربرانToolStripMenuItem.Name = "مدیریتکاربرانToolStripMenuItem";
            this.مدیریتکاربرانToolStripMenuItem.Size = new System.Drawing.Size(205, 40);
            this.مدیریتکاربرانToolStripMenuItem.Text = "مدیریت کاربران";
            this.مدیریتکاربرانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکاربرانToolStripMenuItem_Click);
            // 
            // اماناتToolStripMenuItem
            // 
            this.اماناتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جدیدToolStripMenuItem,
            this.جستجوToolStripMenuItem});
            this.اماناتToolStripMenuItem.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.اماناتToolStripMenuItem.Name = "اماناتToolStripMenuItem";
            this.اماناتToolStripMenuItem.Size = new System.Drawing.Size(71, 39);
            this.اماناتToolStripMenuItem.Text = "امانات";
            // 
            // جدیدToolStripMenuItem
            // 
            this.جدیدToolStripMenuItem.Name = "جدیدToolStripMenuItem";
            this.جدیدToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.جدیدToolStripMenuItem.Text = "جدید";
            this.جدیدToolStripMenuItem.Click += new System.EventHandler(this.جدیدToolStripMenuItem_Click);
            // 
            // جستجوToolStripMenuItem
            // 
            this.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem";
            this.جستجوToolStripMenuItem.Size = new System.Drawing.Size(175, 40);
            this.جستجوToolStripMenuItem.Text = "جست و جو";
            this.جستجوToolStripMenuItem.Click += new System.EventHandler(this.جستجوToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(68, 39);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(624, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کتابخانه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ثبتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دستهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کتابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عضوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اماناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جستجوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MiladiLbl;
        private System.Windows.Forms.Label ShamsiLbl;
        private System.Windows.Forms.ToolStripMenuItem دستهجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتدستههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتکتابجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جستجویکتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتعضوجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکاربرانToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

