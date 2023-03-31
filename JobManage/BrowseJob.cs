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

namespace PersonMIS.JobManage
{
    public partial class BrowseJob : Form
    {

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        public BrowseJob()
        {
            InitializeComponent();
        }

        private void BrowseJob_Load(object sender, EventArgs e)
        {
            showinf();
        }

        private void showinf() 
        {
            using(SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    string sql = "SELECT JobID AS 编号,JobName AS 工种名称,Remark AS 描述 FROM tb_JobInfo ORDER BY JobID";
                    SqlDataAdapter adp = new SqlDataAdapter(sql,con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds,"Job");
                    this.dgvJobInfo.DataSource = ds.Tables[0].DefaultView;
                }catch (Exception ex)
                {
                    MessageBox.Show("错误："+ex.Message,"提示错误",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvJobInfo.CurrentCell != null)
            {
                ModifyJob frmModifyJob=new ModifyJob();
                frmModifyJob.strJobID = this.dgvJobInfo[0,this.dgvJobInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyJob.strJobName = this.dgvJobInfo[1,this.dgvJobInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyJob.strJobRemark = this.dgvJobInfo[2,this.dgvJobInfo.CurrentCell.RowIndex ].Value.ToString().Trim();

                frmModifyJob.StartPosition = FormStartPosition.Manual;
                frmModifyJob.ShowDialog();
                if(frmModifyJob.DialogResult == DialogResult.OK)
                {
                    showinf();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con =new SqlConnection(strConn))
            {
                if(con.State== ConnectionState.Closed)
                {
                    con.Close();
                };

                try
                {
                    if (this.dgvJobInfo.CurrentCell != null)
                    {
                        string sql = "SELECT JobName FROM tb_JobInfo WHERE JobID=" + this.dgvJobInfo[0, this.dgvJobInfo.CurrentCell.RowIndex].Value.ToString().Trim() +
                            "AND JobID NOT IN(SELECT DISTINCT tb_JobInfo.JobID FORM" + "tb_PersonInfo INNER JOIN tb_JobInfo ON tb_PersonInfo.JobName=tb_JobInfo.JobName)";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        if (!dr.Read()) 
                        {
                            MessageBox.Show("删除工种'" + this.dgvJobInfo[0,this.dgvJobInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"'失败，请先删除与此工种相关的员工！","提示");
                            dr.Close();
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM tb_JobInfo WHERE JobInfo=" + this.dgvJobInfo[0, this.dgvJobInfo.CurrentCell.RowIndex].Value.ToString().Trim() +
                                "AND JobName NOT IN(SELECT DISTINCT JobName FROM tb_PersonInfo)";

                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除工种'" + this.dgvJobInfo[0,this.dgvJobInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"'成功","提示");
                            


                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("错误："+ex.Message,"错误提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                finally
                {
                    if(con.State==ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            showinf();
            
        }
    }
}
