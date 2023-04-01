using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonMIS.IncomeManage
{
    public partial class ModifyIncome : Form
    {
        public ModifyIncome()
        {
            InitializeComponent();
        }

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        public string strIID = "";
        public string strImonth="";
        public string strPID = "";
        public string strIncome = "";
        public string strRemark = "";
        public string strLoginDate = "";

        private void ModifyIncome_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.txtIncome.Text = this.strIncome;
            this.txtMonth.Text = this.strImonth;
            this.txtRemark.Text = this.strRemark;
            //this.cmbPname.Text = this.strPID;

            AddPersonNameToCmbPName();
            this.cmbPname.Text = this.strPID;

        }

        private void AddPersonNameToCmbPName()
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT Pname,PID FROM tb_PersonInfo", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Person");
                    this.cmbPname.DisplayMember = "Pname";
                    this.cmbPname.ValueMember = "PID";
                    this.cmbPname.DataSource = ds.Tables[0].DefaultView;
                    this.dtpLoginDate.Text=this.strLoginDate;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           using(SqlConnection con = new SqlConnection(strConn))
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    DateTime dt1= DateTime.Now;
                    string sql = "UPDATE tb_Income SET Imonth='" + this.txtMonth.Text.ToString().Trim() + "',Income='" + this.txtIncome.Text.Trim() + "',Remark='" + this.txtRemark.Text.Trim() +
                        "',PID='" + this.cmbPname.SelectedValue.ToString() + "',LoginDate='" + dt1 + "' WHERE IID='" + strIID + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("员工收入修改成功！","提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
            }
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
