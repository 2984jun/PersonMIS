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

namespace PersonMIS.DepartMange
{
    public partial class BrowseDepart : Form
    {
        public BrowseDepart()
        {
            InitializeComponent();
        }

        public static string strConn = " Data Source=DESKTOP-SK9ALMG;Initial Catalog = db_Person; Integrated Security = True";

        private void BrowseDepart_Load(object sender, EventArgs e)
        {
            showinf();
        }

        private void showinf()
        {
            using(SqlConnection con = new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    string sql = "SELECT DID AS 编号,Dname AS 部门名称,Dleader AS 部门领导,Remark AS 描述 FROM tb_DepartInfo ORDER BY DID";
                    SqlDataAdapter adp = new SqlDataAdapter(sql,con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds,"Depart");
                    this.dgvDepartInfo.DataSource = ds.Tables[0].DefaultView;

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
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.dgvDepartInfo.CurrentCell != null)
            {
                ModifyDepart frmModifyDepart= new ModifyDepart();
                frmModifyDepart.strDID = this.dgvDepartInfo[0, this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyDepart.strDleader = this.dgvDepartInfo[1, this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyDepart.strRemark = this.dgvDepartInfo[2, this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyDepart.StartPosition = FormStartPosition.CenterParent;
                if(frmModifyDepart.DialogResult== DialogResult.OK )
                {
                    showinf();
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    if (this.dgvDepartInfo.CurrentCell != null)
                    {
                        string sql = "SELECT Dname FROM tb_DepartInfo WHERE DID =" + this.dgvDepartInfo[0, this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim() +
                            "AND DID NOT IN(SELECT DISTINCT tb_PersonInfo INNER JOIN tb_DepartInfo ON tb_PersonInfo.DID=tb_DepartInfo.DID)";
                        SqlCommand cmd = new SqlCommand(sql,con);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (!dr.Read())
                        {
                            MessageBox.Show("删除部门'" + this.dgvDepartInfo[0,this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"失败，请先删除与此工种相关的员工！");
                            dr.Close();
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELECT FROM tb_DepartInfo WHERE DID=" + this.dgvDepartInfo[0, this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim() +
                                "AND DID NOT IN(SELECT DISTINCT DID FROM tb_PersonInfo)";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除部门" + this.dgvDepartInfo[0,this.dgvDepartInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"'成功","提示");
                        }

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
