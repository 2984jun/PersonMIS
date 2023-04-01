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
using PersonMIS.DepartMange;
using System.Web;

namespace PersonMIS.PersonManage
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        private void AddPerson_Load(object sender, EventArgs e)
        {
            AddJobNameToCmbJobName();
            AddDepartNameToCmdDID();
            this.dtpLonginDate.Value=DateTime.Now;
        }

        public void AddJobNameToCmbJobName()
        {
            using(SqlConnection con = new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT JobName FROM tb_JobInfo",con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds,"Job");
                    this.cmbJobName.DisplayMember = "JobName";
                    this.cmbJobName.ValueMember = "JobName";
                    this.cmbJobName.DataSource = ds.Tables[0].DefaultView;
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

        public void AddDepartNameToCmdDID()
        {
            
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT Dname,DID FROM tb_DepartInfo", con);
                    DataSet ds= new DataSet();
                    adp.Fill(ds,"Depart");
                    this.cmbDID.DisplayMember = "Dname";
                    this.cmbDID.ValueMember = "DID";
                    this.cmbDID.DataSource = ds.Tables[0].DefaultView;
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
            if (this.txtPID.Text.Trim() == "" || this.txtPname.Text.Trim() == "" || this.cmbPsex.Text.Trim() == "" ||
                this.txtPplace.Text.ToString().Trim() == "" || this.txtPlevel.Text.ToString().Trim() == "" ||
                this.txtPbusi.Text.ToString().Trim() == "" || this.cmbDID.Text.ToString().Trim() == "" ||
                this.cmbJobName.Text.ToString().Trim() == "" || this.txtPspecial.Text.ToString().Trim() == "")
            {
                MessageBox.Show("请填写完整的员工信息！", "提示", 0);
            }
            else
            {
                DateTime dt1 = Convert.ToDateTime(this.dtpLonginDate.Value.ToShortDateString());

                using (SqlConnection con = new SqlConnection(strConn))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    };
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM tb_PersonInfo WHERE PID='"+this.txtPID.Text.Trim()+"'",con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("员工编号重复，请重新输入！","提示",0);
                        }
                        else
                        {
                            string sql, sql1, sql2;

                            sql1 = "INSERT INTO tb_PersonInfo(PID,Pname,Psex,Pspecial,Pplace,Plevel,DID,JobName,LoginDate";
                            sql2 = "VALUES('" + this.txtPID.Text.ToString().Trim() + "','" + this.txtPname.Text.ToString().Trim() + "','" +
                                this.cmbPsex.Text.ToString().Trim() + "','"+this.txtPspecial.Text.ToString().Trim()+"','" + this.txtPplace.Text.ToString().Trim() + "','" +
                                this.txtPlevel.Text.ToString().Trim() + "','" + this.cmbDID.SelectedValue.ToString().Trim() + "','" +
                                this.cmbJobName.Text.ToString().Trim() + "','" + dt1 + "'";

                            if(this.txtRemark.Text.Trim() != null)
                            {
                                sql1 = sql1 + ",Remark";
                                sql2 = sql2 + ",'" + this.txtRemark.Text.Trim() + "'";
                            }
                            if(this.txtPbusi.Text.Trim() != null)
                            {
                                sql1 = sql1 + ",Pbusi";
                                sql2=sql2+",'"+this.txtPbusi.Text.Trim()+"'";
                            }
                            sql = sql1 + ")" + sql2 + ")";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("员工信息添加成功","提示",0);
                        }

                    }
                    catch (Exception ex) 
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
