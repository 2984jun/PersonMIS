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

namespace PersonMIS.IncomeManage
{
    public partial class BrowseIncome : Form
    {
        public BrowseIncome()
        {
            InitializeComponent();
        }

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        private void BrowseIncome_Load(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT PID,Pname FROM tb_PersonInfo", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds,"Perosn");
                    this.cmbPname.DisplayMember = "Pname";
                    this.cmbPname.ValueMember = "PID";
                    this.cmbPname.DataSource = ds.Tables[0].DefaultView;
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            showinf();
        }

        private void showinf()
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    string sql = "SELECT  tb_Income.PID AS 员工编号,tb_Income.Imonth AS 月份,tb_Income.Income AS 月收入,tb_Income.Remark AS 备注,tb_Income.LoginDate AS 登录日期," +
                        "tb_PersonInfo.Pname AS 员工姓名,tb_Income.IID AS 自动编号 FROM tb_Income INNER JOIN tb_PersonInfo ON tb_Income.PID=tb_PersonInfo.PID WHERE tb_PersonInfo.Pname='" +
                        this.cmbPname.Text.ToString() + "'ORDER BY IID";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Income");
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        this.dgvIncomeInfo.DataSource = ds.Tables[0].DefaultView;
                        this.lblHint.Text = "共有" + ds.Tables[0].Rows.Count + "条查询结果";
                    }
                    else
                    {
                        this.lblHint.Text = "没有您所查找的收入信息";
                        this.dgvIncomeInfo.DataSource = null;
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvIncomeInfo.CurrentCell != null)
            {
                ModifyIncome frmmodifyIncome=new ModifyIncome();
                frmmodifyIncome.strImonth = this.dgvIncomeInfo[1,this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmmodifyIncome.strIncome = this.dgvIncomeInfo[2, this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmmodifyIncome.strRemark = this.dgvIncomeInfo[3, this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmmodifyIncome.strLoginDate = this.dgvIncomeInfo[4, this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmmodifyIncome.strPID = this.dgvIncomeInfo[5, this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmmodifyIncome.strIID = this.dgvIncomeInfo[6, this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim();
                frmmodifyIncome.ShowDialog();
                if(frmmodifyIncome.DialogResult == DialogResult.OK)
                {
                    showinf();
                }
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if(con.State == ConnectionState.Closed) 
                {
                    con.Open();
                };
                try
                {
                    if(this.dgvIncomeInfo.CurrentCell != null)
                    {
                        string sql = "DELETE FROM tb_Income WHERE IID='" + this.dgvIncomeInfo[6, this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim() + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除员工'" + this.dgvIncomeInfo[5,this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim()+
                            "'的'" + this.dgvIncomeInfo[1,this.dgvIncomeInfo.CurrentCell.RowIndex].Value.ToString().Trim()+"的收入成功","提示");
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
