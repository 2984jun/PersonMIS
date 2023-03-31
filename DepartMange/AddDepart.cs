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
using System.Data.Odbc;

namespace PersonMIS.DepartMange
{
    public partial class AddDepart : Form
    {
        public AddDepart()
        {
            InitializeComponent();
        }

        public static string strConn="Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        private void AddDepart_Load(object sender, EventArgs e)
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
                    adp.Fill(ds,"Person");
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
            if (this.txtDepName.Text.Trim() == "")
            {
                MessageBox.Show("请输入完整信息！","提示",0);
            }
            else
            {
                using(SqlConnection con= new SqlConnection(strConn))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    };
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tb_DepartInfo WHERE DName='"+this.txtDepName.Text.Trim()+"'",con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("部门名称重复,请重新输入！","提示",0);
                        }
                        else
                        {
                            string sql = "INSERT INTO tb_DepartInfo(DName,Dleader,Remark)VALUES('" + this.txtDepName.Text.Trim() + "','" + this.cmbPersonName.Text.Trim() + "','" + this.txtJobRemark.Text.Trim() + "')";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("添加部门信息成功！","提示",0);
                            this.txtDepName.Clear();
                            this.txtJobRemark.Clear();
                            
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
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
