namespace PersonMIS.IncomeManage
{
    partial class ModifyIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPname = new System.Windows.Forms.ComboBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.dtpLoginDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(164, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改收入信息";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(32, 83);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(65, 12);
            this.lblPname.TabIndex = 1;
            this.lblPname.Text = "员工姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "收入：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "录入日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "月份：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // cmbPname
            // 
            this.cmbPname.FormattingEnabled = true;
            this.cmbPname.Location = new System.Drawing.Point(103, 80);
            this.cmbPname.Name = "cmbPname";
            this.cmbPname.Size = new System.Drawing.Size(121, 20);
            this.cmbPname.TabIndex = 6;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(103, 123);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(121, 21);
            this.txtIncome.TabIndex = 7;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(302, 123);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(112, 21);
            this.txtRemark.TabIndex = 8;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(302, 79);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(112, 21);
            this.txtMonth.TabIndex = 9;
            // 
            // dtpLoginDate
            // 
            this.dtpLoginDate.Location = new System.Drawing.Point(103, 170);
            this.dtpLoginDate.Name = "dtpLoginDate";
            this.dtpLoginDate.Size = new System.Drawing.Size(121, 21);
            this.dtpLoginDate.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(80, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(276, 214);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 23);
            this.btnCannel.TabIndex = 12;
            this.btnCannel.Text = "取消";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // ModifyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 269);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpLoginDate);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.cmbPname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.label1);
            this.Name = "ModifyIncome";
            this.Text = "                                     修改月收入信息";
            this.Load += new System.EventHandler(this.ModifyIncome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPname;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.DateTimePicker dtpLoginDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCannel;
    }
}