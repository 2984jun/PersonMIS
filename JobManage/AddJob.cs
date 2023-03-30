using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonMIS.JobManage
{
    public partial class AddJob : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        public AddJob()
        {
            InitializeComponent();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {

        }

        private void btnJobOK_Click(object sender, EventArgs e)
        {
            

            if(txtJobName.Text.Trim()=="" || txtJobRematk.Text.Trim() == "")
            {
                MessageBox.Show("请输入工种名称和描述！","提示",0);
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tb_JobInfo WHERE JobName= '" + txtJobName.Text.Trim() + "'" ,con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("工种名称重复，请重新输入！","提示",0);
                        }
                        else
                        {
                            string sql = "INSERT INTO tb_JobInfo(JobName,Remark) VALUES('" + txtJobName.Text.Trim() + "','" + txtJobRematk.Text.Trim() + "')";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("添加工种信息成功！","提示",0);
                            txtJobName.Clear();
                            txtJobRematk.Clear();
                        }
                        
                    }catch (Exception ex)
                    {
                        MessageBox.Show("错误："+ex.Message,"错误提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if(con.State == ConnectionState.Open)
                        {
                            con.Close();
                            con.Dispose();
                        }
                    }
                }
            }
        }

        private void btnJobCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
