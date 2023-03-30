using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonMIS.JobManage;
using PersonMIS.DepartMange;
using PersonMIS.IncomeManage;
using PersonMIS.PersonManage;


namespace PersonMIS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void 添加工种ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuAddJob_Click(object sender, EventArgs e)
        {
            AddJob frmAddJob=new AddJob();
            frmAddJob.Owner = this;
            frmAddJob.StartPosition= FormStartPosition.CenterParent;
            frmAddJob.ShowDialog();
        }

        private void menuAddDepart_Click(object sender, EventArgs e)
        {
            AddDepart frmAddDepart = new AddDepart();
            frmAddDepart.Owner = this;
            frmAddDepart.StartPosition = FormStartPosition.CenterParent;
            frmAddDepart.ShowDialog();
        }

        private void menuAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson frmAddPerson = new AddPerson();
            frmAddPerson.Owner = this;
            frmAddPerson.StartPosition = FormStartPosition.CenterParent;
            frmAddPerson.ShowDialog();
        }

        private void menuAddIncome_Click(object sender, EventArgs e)
        {
            AddIncome frmAddIncome = new AddIncome();
            frmAddIncome.Owner = this;
            frmAddIncome.StartPosition = FormStartPosition.CenterParent;
            frmAddIncome.ShowDialog();
        }

        private void menuBrowseJob_Click(object sender, EventArgs e)
        {
            BrowseJob frmBrowseJob = new BrowseJob();
            frmBrowseJob.Owner = this;
            frmBrowseJob.StartPosition = FormStartPosition.CenterParent;
            frmBrowseJob.ShowDialog();
        }
       
        private void menuBrowDepart_Click(object sender, EventArgs e)
        {
            BrowseDepart frmBrowseDepart = new BrowseDepart();
            frmBrowseDepart.Owner = this;
            frmBrowseDepart.StartPosition = FormStartPosition.CenterParent;
            frmBrowseDepart.ShowDialog();
        }

        private void menuBrowsePerson_Click(object sender, EventArgs e)
        {
            BrowsePerson frmBrowsePerson = new BrowsePerson();
            frmBrowsePerson.Owner = this;
            frmBrowsePerson.StartPosition = FormStartPosition.CenterParent;
            frmBrowsePerson.ShowDialog();
        }

        private void menuBrowseIncome_Click(object sender, EventArgs e)
        {
            BrowseIncome frmBrowseIncome = new BrowseIncome();
            frmBrowseIncome.Owner = this;
            frmBrowseIncome.StartPosition = FormStartPosition.CenterParent;
            frmBrowseIncome.ShowDialog();
        }

        private void menuExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            About frmAbout=new About();
            frmAbout.Owner = this;
            frmAbout.StartPosition = FormStartPosition.CenterParent;
            frmAbout.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ttsTime.Text = "时间为：" + DateTime.Now.ToString();
        }
    }
}
