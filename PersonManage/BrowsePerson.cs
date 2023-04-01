using PersonMIS.DepartMange;
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
using System.Windows.Forms.VisualStyles;

namespace PersonMIS.PersonManage
{
    public partial class BrowsePerson : Form
    {
        public BrowsePerson()
        {
            InitializeComponent();
        }

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        private void BrowsePerson_Load(object sender, EventArgs e)
        {
            AddDepartNameToCmbDID();
        }

        public void AddDepartNameToCmbDID()
        {
            using(SqlConnection con = new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed) 
                {
                    con.Open();
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT DID,Dname FROM tb_DepartInfo", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Depart");
                    this.cmbDID.DisplayMember = "Dname";
                    this.cmbDID.ValueMember = "DID";
                    this.cmbDID.DataSource = ds.Tables[0].DefaultView;
                }catch (Exception ex)
                {
                    MessageBox.Show("错误:"+ex.Message,"错误提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            showinf();
        }

        public void showinf()
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if( con.State==ConnectionState.Closed )
                {
                    con.Open();
                };
                try
                {
                    string sql = "SELECT tb_PersonInfo.PID AS 员工编号,tb_PersonInfo.Pname AS 员工姓名,tb_PersonInfo.Psex AS 性别,tb_PersonInfo.JobName AS 工种名称,tb_PersonInfo.Pplace AS 员工籍贯," +
                        "tb_PersonInfo.Plevel AS 学历,tb_PersonInfo.Pspecial AS 专业,tb_PersonInfo.Pbusi AS 职称,tb_DepartInfo.Dname AS 部门名称,tb_PersonInfo.LoginDate AS 登录日期," +
                        "tb_PersonInfo.Remark AS 备注 FROM tb_PersonInfo INNER JOIN tb_DepartInfo ON tb_PersonInfo.DID=tb_DepartInfo.DID WHERE tb_DepartInfo.Dname='" + this.cmbDID.Text.ToString() + "'ORDER BY PID";
                    SqlDataAdapter adp = new SqlDataAdapter(sql,con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds,"person");
                    if (ds.Tables[0].Rows.Count !=0)
                    {
                        this.dgvPersonInfo.DataSource = ds.Tables[0].DefaultView;
                        this.lblHint.Text = "共有" + ds.Tables[0].Rows.Count + "条查询结果";
                    }
                    else
                    {
                        this.lblHint.Text = "没有您所查找的员工信息";
                        this.dgvPersonInfo.DataSource = null;
                    }
                        
                }catch (Exception ex)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonInfo.CurrentCell != null)
            {
                ModifyPerson frmModifyPerson= new ModifyPerson();
                frmModifyPerson.strPID = this.dgvPersonInfo[0,this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strPname = this.dgvPersonInfo[1, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strPsex = this.dgvPersonInfo[2, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strJobName = this.dgvPersonInfo[3, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strPplace = this.dgvPersonInfo[4, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strPlevel = this.dgvPersonInfo[5, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strPspecial = this.dgvPersonInfo[6, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strPbusi = this.dgvPersonInfo[7, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strDID = this.dgvPersonInfo[8, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strLoginDate = this.dgvPersonInfo[9, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmModifyPerson.strRemark = this.dgvPersonInfo[10, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim();

                frmModifyPerson.StartPosition = FormStartPosition.CenterParent;
                frmModifyPerson.ShowDialog();
                if(frmModifyPerson.DialogResult == DialogResult.OK)
                {
                    showinf();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    if (this.dgvPersonInfo.CurrentCell != null)
                    {
                        string sql = "SELECT * FROM tb_Income WHERE PID='" + this.dgvPersonInfo[0, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim() + "'";
                        SqlCommand cmd = new SqlCommand(sql,con);
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr;
                        dr= cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("删除员工'" + this.dgvPersonInfo[0,this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"'失败，请先删除该员工的收入信息！","提示");
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM tb_PersonInfo WHERE PID='" + this.dgvPersonInfo[0, this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim() + "'";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除员工'" + this.dgvPersonInfo[0,this.dgvPersonInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"'成功","提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("没有指定的员工信息","提示");
                    }
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
            showinf();
        }
    }
}
