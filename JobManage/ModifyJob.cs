using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonMIS.JobManage
{
    public partial class ModifyJob : Form
    {

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        public string strJobID="";
        public string strJobName="";
        public string strJobRemark= "";

        public ModifyJob()
        {
            InitializeComponent();
        }

        private void ModifyJob_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.lblJobID.Text = this.strJobID;
            this.txtJobName.Text = this.strJobName;
            this.txtJobRemark.Text = this.strJobRemark;
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.txtJobName.Text.Trim()=="" || this.txtJobRemark.Text.Trim() == "")
            {
                MessageBox.Show("请输入完整信息！","提示",0);
            }
            else
            {
                using(SqlConnection con = new SqlConnection(strConn))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    };
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tb_JobInfo WHERE JobName='" + txtJobName.Text.Trim() + "'AND JobID<>" + this.strJobID, con);
                        if (cmd.ExecuteScalar() != null) 
                        {
                            MessageBox.Show("工种名称发生重复，请重新输入！","提示",0);
                        }
                        else
                        {
                            string sql = "UPDATE tb_JobInfo SET JobName='" + this.txtJobName.Text.Trim() + "',Remark='" + this.txtJobRemark.Text.Trim() + "'WHERE JobID=" + this.strJobID;
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("工种信息修改成功!","提示",0);

                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("错误："+ex.Message,"错误提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if(con.State== ConnectionState.Open)
                        {
                            con.Close();
                            con.Dispose();
                        }
                    }
                }
            }
        }
    }
}
