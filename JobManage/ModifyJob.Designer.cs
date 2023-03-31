namespace PersonMIS.JobManage
{
    partial class ModifyJob
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
            this.lblJobID1 = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.txtJobRemark = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(85, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(328, 254);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 23);
            this.btnCannel.TabIndex = 1;
            this.btnCannel.Text = "取消";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // lblJobID1
            // 
            this.lblJobID1.AutoSize = true;
            this.lblJobID1.Location = new System.Drawing.Point(42, 81);
            this.lblJobID1.Name = "lblJobID1";
            this.lblJobID1.Size = new System.Drawing.Size(65, 12);
            this.lblJobID1.TabIndex = 2;
            this.lblJobID1.Text = "工种编号：";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(263, 81);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(65, 12);
            this.lblJobName.TabIndex = 3;
            this.lblJobName.Text = "工种名称：";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(42, 129);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(65, 12);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "工种描述：";
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(343, 78);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(100, 21);
            this.txtJobName.TabIndex = 6;
            // 
            // txtJobRemark
            // 
            this.txtJobRemark.Location = new System.Drawing.Point(134, 129);
            this.txtJobRemark.Multiline = true;
            this.txtJobRemark.Name = "txtJobRemark";
            this.txtJobRemark.Size = new System.Drawing.Size(309, 106);
            this.txtJobRemark.TabIndex = 7;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJobID.Location = new System.Drawing.Point(134, 81);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(55, 14);
            this.lblJobID.TabIndex = 8;
            this.lblJobID.Text = "lblJobID";
            // 
            // ModifyJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 349);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.txtJobRemark);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblJobID1);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnOK);
            this.Name = "ModifyJob";
            this.Text = "                                             修改工种种类";
            this.Load += new System.EventHandler(this.ModifyJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCannel;
        private System.Windows.Forms.Label lblJobID1;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.TextBox txtJobRemark;
        private System.Windows.Forms.Label lblJobID;
    }
}