namespace PersonMIS.DepartMange
{
    partial class AddDepart
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.lblDepartRemark = new System.Windows.Forms.Label();
            this.lblDepartLeader = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.txtJobRemark = new System.Windows.Forms.TextBox();
            this.cmbPersonName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(97, 302);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(341, 302);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 23);
            this.btnCannel.TabIndex = 1;
            this.btnCannel.Text = "取消";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // lblDepartName
            // 
            this.lblDepartName.AutoSize = true;
            this.lblDepartName.Location = new System.Drawing.Point(46, 81);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(65, 12);
            this.lblDepartName.TabIndex = 2;
            this.lblDepartName.Text = "部门名称：";
            // 
            // lblDepartRemark
            // 
            this.lblDepartRemark.AutoSize = true;
            this.lblDepartRemark.Location = new System.Drawing.Point(46, 138);
            this.lblDepartRemark.Name = "lblDepartRemark";
            this.lblDepartRemark.Size = new System.Drawing.Size(41, 12);
            this.lblDepartRemark.TabIndex = 3;
            this.lblDepartRemark.Text = "备注：";
            // 
            // lblDepartLeader
            // 
            this.lblDepartLeader.AutoSize = true;
            this.lblDepartLeader.Location = new System.Drawing.Point(270, 81);
            this.lblDepartLeader.Name = "lblDepartLeader";
            this.lblDepartLeader.Size = new System.Drawing.Size(65, 12);
            this.lblDepartLeader.TabIndex = 4;
            this.lblDepartLeader.Text = "部门领导：";
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(117, 78);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(135, 21);
            this.txtDepName.TabIndex = 5;
            // 
            // txtJobRemark
            // 
            this.txtJobRemark.Location = new System.Drawing.Point(117, 135);
            this.txtJobRemark.Multiline = true;
            this.txtJobRemark.Name = "txtJobRemark";
            this.txtJobRemark.Size = new System.Drawing.Size(378, 143);
            this.txtJobRemark.TabIndex = 6;
            // 
            // cmbPersonName
            // 
            this.cmbPersonName.FormattingEnabled = true;
            this.cmbPersonName.Location = new System.Drawing.Point(341, 78);
            this.cmbPersonName.Name = "cmbPersonName";
            this.cmbPersonName.Size = new System.Drawing.Size(154, 20);
            this.cmbPersonName.TabIndex = 7;
            // 
            // AddDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 382);
            this.Controls.Add(this.cmbPersonName);
            this.Controls.Add(this.txtJobRemark);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.lblDepartLeader);
            this.Controls.Add(this.lblDepartRemark);
            this.Controls.Add(this.lblDepartName);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnOK);
            this.Name = "AddDepart";
            this.Text = "AddDepart";
            this.Load += new System.EventHandler(this.AddDepart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCannel;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.Label lblDepartRemark;
        private System.Windows.Forms.Label lblDepartLeader;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.TextBox txtJobRemark;
        private System.Windows.Forms.ComboBox cmbPersonName;
    }
}