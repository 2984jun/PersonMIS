namespace PersonMIS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加工种ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrowseJob = new System.Windows.Forms.ToolStripMenuItem();
            this.部门设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrowDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrowsePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.收入管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrowseIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加工种ToolStripMenuItem,
            this.部门设置ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.收入管理ToolStripMenuItem,
            this.menuAbout,
            this.menuExitSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加工种ToolStripMenuItem
            // 
            this.添加工种ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddJob,
            this.menuBrowseJob});
            this.添加工种ToolStripMenuItem.Name = "添加工种ToolStripMenuItem";
            this.添加工种ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加工种ToolStripMenuItem.Text = "工种设置";
            this.添加工种ToolStripMenuItem.Click += new System.EventHandler(this.添加工种ToolStripMenuItem_Click);
            // 
            // menuAddJob
            // 
            this.menuAddJob.Name = "menuAddJob";
            this.menuAddJob.Size = new System.Drawing.Size(180, 22);
            this.menuAddJob.Text = "添加工种";
            this.menuAddJob.Click += new System.EventHandler(this.menuAddJob_Click);
            // 
            // menuBrowseJob
            // 
            this.menuBrowseJob.Name = "menuBrowseJob";
            this.menuBrowseJob.Size = new System.Drawing.Size(180, 22);
            this.menuBrowseJob.Text = "浏览工种";
            this.menuBrowseJob.Click += new System.EventHandler(this.menuBrowseJob_Click);
            // 
            // 部门设置ToolStripMenuItem
            // 
            this.部门设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddDepart,
            this.menuBrowDepart});
            this.部门设置ToolStripMenuItem.Name = "部门设置ToolStripMenuItem";
            this.部门设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.部门设置ToolStripMenuItem.Text = "部门设置";
            // 
            // menuAddDepart
            // 
            this.menuAddDepart.Name = "menuAddDepart";
            this.menuAddDepart.Size = new System.Drawing.Size(180, 22);
            this.menuAddDepart.Text = "添加部门";
            this.menuAddDepart.Click += new System.EventHandler(this.menuAddDepart_Click);
            // 
            // menuBrowDepart
            // 
            this.menuBrowDepart.Name = "menuBrowDepart";
            this.menuBrowDepart.Size = new System.Drawing.Size(180, 22);
            this.menuBrowDepart.Text = "浏览部门";
            this.menuBrowDepart.Click += new System.EventHandler(this.menuBrowDepart_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddPerson,
            this.menuBrowsePerson});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // menuAddPerson
            // 
            this.menuAddPerson.Name = "menuAddPerson";
            this.menuAddPerson.Size = new System.Drawing.Size(180, 22);
            this.menuAddPerson.Text = "添加员工";
            this.menuAddPerson.Click += new System.EventHandler(this.menuAddPerson_Click);
            // 
            // menuBrowsePerson
            // 
            this.menuBrowsePerson.Name = "menuBrowsePerson";
            this.menuBrowsePerson.Size = new System.Drawing.Size(180, 22);
            this.menuBrowsePerson.Text = "浏览员工";
            this.menuBrowsePerson.Click += new System.EventHandler(this.menuBrowsePerson_Click);
            // 
            // 收入管理ToolStripMenuItem
            // 
            this.收入管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddIncome,
            this.menuBrowseIncome});
            this.收入管理ToolStripMenuItem.Name = "收入管理ToolStripMenuItem";
            this.收入管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.收入管理ToolStripMenuItem.Text = "收入管理";
            // 
            // menuAddIncome
            // 
            this.menuAddIncome.Name = "menuAddIncome";
            this.menuAddIncome.Size = new System.Drawing.Size(180, 22);
            this.menuAddIncome.Text = "添加收入";
            this.menuAddIncome.Click += new System.EventHandler(this.menuAddIncome_Click);
            // 
            // menuBrowseIncome
            // 
            this.menuBrowseIncome.Name = "menuBrowseIncome";
            this.menuBrowseIncome.Size = new System.Drawing.Size(180, 22);
            this.menuBrowseIncome.Text = "浏览收入";
            this.menuBrowseIncome.Click += new System.EventHandler(this.menuBrowseIncome_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(68, 21);
            this.menuAbout.Text = "关于系统";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuExitSystem
            // 
            this.menuExitSystem.Name = "menuExitSystem";
            this.menuExitSystem.Size = new System.Drawing.Size(68, 21);
            this.menuExitSystem.Text = "退出系统";
            this.menuExitSystem.Click += new System.EventHandler(this.menuExitSystem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttsTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1278, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ttsTime
            // 
            this.ttsTime.Name = "ttsTime";
            this.ttsTime.Size = new System.Drawing.Size(131, 17);
            this.ttsTime.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1278, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加工种ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddJob;
        private System.Windows.Forms.ToolStripMenuItem menuBrowseJob;
        private System.Windows.Forms.ToolStripMenuItem 部门设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddDepart;
        private System.Windows.Forms.ToolStripMenuItem menuBrowDepart;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddPerson;
        private System.Windows.Forms.ToolStripMenuItem menuBrowsePerson;
        private System.Windows.Forms.ToolStripMenuItem 收入管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddIncome;
        private System.Windows.Forms.ToolStripMenuItem menuBrowseIncome;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExitSystem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel ttsTime;
    }
}