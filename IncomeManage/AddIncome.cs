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
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
        }

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";


        private void AddIncome_Load(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT PID,Pname FROM tb_PersonInfo", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Person");
                    this.cmbPersonName.DisplayMember = "Pname";
                    this.cmbPersonName.ValueMember = "PID";
                    this.cmbPersonName.DataSource = ds.Tables[0].DefaultView;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.txtIncome.Text.Trim()=="" || this.txtMonth.Text.Trim()=="" ||this.cmbPersonName.Text.Trim()=="")
            {
                MessageBox.Show("请输入完整的信息！","提示",0);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(strConn))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    };
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Income WHERE PID='" + this.cmbPersonName.SelectedValue.ToString() + "'AND" + " Imonth='" + this.txtMonth.Text.Trim() + "'", con);
                        if (cmd.ExecuteScalar() != null) 
                        {
                            MessageBox.Show("收入信息重复，请重新输入！","提示",0);
                        }
                        else
                        {   
                            DateTime dt1= DateTime.Now;
                            string sql, sql1, sql2;
                            sql1 = "INSERT INTO tb_Income(Imonth,Income,PID,Remark,LoginDate";
                            sql2 = "VALUES('" + this.txtMonth.Text.ToString().Trim() + "','" + this.txtIncome.Text.ToString().Trim() + "','" + this.cmbPersonName.SelectedValue.ToString().Trim() +
                                "','" + this.txtRemark.Text.Trim() + "','" + dt1 + "'";
                            sql = sql1+")" + sql2+")";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("收入信息添加成功!","提示",0);
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
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
