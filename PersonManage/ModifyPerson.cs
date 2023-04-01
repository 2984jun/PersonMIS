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
    public partial class ModifyPerson : Form
    {
        public ModifyPerson()
        {
            InitializeComponent();
        }

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=db_Person;Integrated Security=True";

        public string strPID = "";
        public string strPname = "";
        public string strPsex = "";
        public string strJobName = "";
        public string strPlevel = "";
        public string strPbusi = "";
        public string strPplace = "";
        public string strRemark = "";
        public string strPspecial = "";
        public string strDID="";
        public string strLoginDate = "";

        private void ModifyPerson_Load(object sender, EventArgs e)
        {
            AddJobNameToCmbJobName();
            AddDepartToCmbCmbDID();

            this.txtPID.Enabled = false;
            this.txtPID.Text = this.strPID;
            this.txtPname.Text = this.strPname;
            this.cmbPsex.Text = this.strPsex;
            this.txtPlevel.Text = this.strPlevel;
            this.txtPbusi.Text = this.strPbusi;
            this.txtPplace.Text = this.strPplace;
            this.txtRemark.Text = this.strRemark;
            this.txtPspecial.Text = this.strPspecial;
            this.dtpLoginDate.Text = this.strLoginDate;
        }

        public void AddJobNameToCmbJobName()
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if(con.State==ConnectionState.Closed) 
                {
                    con.Open(); 
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT JobName FROM tb_JobInfo", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds,"Job");
                    this.cmbJobName.DisplayMember = "JobName";
                    this.cmbJobName.ValueMember = "JobName";
                    this.cmbJobName.DataSource = ds.Tables[0].DefaultView;
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

        public void AddDepartToCmbCmbDID()
        {
            using(SqlConnection con=new SqlConnection(strConn))
            {
                if( con.State==ConnectionState.Closed)
                {
                    con.Open(); 
                };
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT DID,Dname FROM tb_DepartInfo", con);
                    DataSet ds = new DataSet();
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
             using(SqlConnection con=new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open ();
                };
                try
                {
                    DateTime dt1 = Convert.ToDateTime(this.dtpLoginDate.Value.ToShortDateString());
                    string sql = "UPDATE tb_PersonInfo SET PID='" + this.txtPID.Text.ToString().Trim() + "',Pname='" + this.txtPname.Text.ToString().Trim() + "',Psex='" + this.cmbPsex.Text.ToString().Trim() +
                        "',Plevel='" + this.txtPlevel.Text.ToString().Trim() + "',Pbusi='" + this.txtPbusi.Text.ToString().Trim() + "',Pplace='" + this.txtPplace.Text.ToString().Trim() +
                        "',Pspecial='" + this.txtPspecial.Text.ToString().Trim() + "',JobName='" + this.cmbJobName.Text.ToString().Trim() + "',DID=" + this.cmbDID.SelectedValue.ToString().Trim() +
                        ",LoginDate='" + dt1 + "'";
                    if (this.txtRemark.Text.Trim() != "")
                    {
                        sql = sql + ",Remark='" + this.txtRemark.Text.ToString().Trim()+"'";
                    }
                    sql = sql + "WHERE PID='" + this.strPID + "'";
                    SqlCommand cmd = new SqlCommand(sql,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("员工信息修改成功！","提示",0);
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

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
