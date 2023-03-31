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

namespace PersonMIS.DepartMange
{
    public partial class ModifyDepart : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        public string strDID = "";
        public string strDname = "";
        public string strDleader = "";
        public string strRemark = "";

        public ModifyDepart()
        {
            InitializeComponent();
        }

        private void ModifyDepart_Load(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection())
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
                }catch (Exception ex)
                {
                    MessageBox.Show("错误："+ex.Message,"错误提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
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
            this.txtDName.Text = strDname;
            this.cmbPersonName.Text = this.strDleader;
            this.txtDRemak.Text = this.strRemark;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtDName.Text.Trim() == "")
            {
                MessageBox.Show("请输入完整信息！","提示",0);
            }
            else
            {
                using(SqlConnection con=new SqlConnection(strConn))
                {
                    if(con.State == ConnectionState.Closed) 
                    {
                        con.Open();
                    };
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tb_DepartInfo WHERE Dname='" + txtDName.Text.Trim() + "'AND DID<>" + this.strDID, con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("部门名称发生重复,请重新输入！","提示");
                        }
                        else
                        {
                            string sql = "UPDATE tb_DepartInfo SET Dname='" + txtDName.Text.Trim() + "',Dleader='" + this.cmbPersonName.Text.Trim() +
                                "',Remark='" + this.txtDRemak.Text.Trim() + "'WHERE DID=" + this.strDID;
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("部门信息修改成功！","提示",0);
                        }
                    }catch (Exception ex)
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
    }
}
