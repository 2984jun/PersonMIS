namespace PersonMIS.JobManage
{
    partial class AddJob
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
            this.btnJobOK = new System.Windows.Forms.Button();
            this.btnJobCannel = new System.Windows.Forms.Button();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.txtJobRematk = new System.Windows.Forms.TextBox();
            this.lblJobInfoName = new System.Windows.Forms.Label();
            this.lblJobInfoRemark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJobOK
            // 
            this.btnJobOK.Location = new System.Drawing.Point(86, 247);
            this.btnJobOK.Name = "btnJobOK";
            this.btnJobOK.Size = new System.Drawing.Size(75, 23);
            this.btnJobOK.TabIndex = 0;
            this.btnJobOK.Text = "确定";
            this.btnJobOK.UseVisualStyleBackColor = true;
            this.btnJobOK.Click += new System.EventHandler(this.btnJobOK_Click);
            // 
            // btnJobCannel
            // 
            this.btnJobCannel.Location = new System.Drawing.Point(260, 247);
            this.btnJobCannel.Name = "btnJobCannel";
            this.btnJobCannel.Size = new System.Drawing.Size(75, 23);
            this.btnJobCannel.TabIndex = 1;
            this.btnJobCannel.Text = "取消";
            this.btnJobCannel.UseVisualStyleBackColor = true;
            this.btnJobCannel.Click += new System.EventHandler(this.btnJobCannel_Click);
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(112, 62);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(253, 21);
            this.txtJobName.TabIndex = 2;
            // 
            // txtJobRematk
            // 
            this.txtJobRematk.Location = new System.Drawing.Point(112, 122);
            this.txtJobRematk.Multiline = true;
            this.txtJobRematk.Name = "txtJobRematk";
            this.txtJobRematk.Size = new System.Drawing.Size(253, 109);
            this.txtJobRematk.TabIndex = 3;
            // 
            // lblJobInfoName
            // 
            this.lblJobInfoName.AutoSize = true;
            this.lblJobInfoName.Location = new System.Drawing.Point(41, 71);
            this.lblJobInfoName.Name = "lblJobInfoName";
            this.lblJobInfoName.Size = new System.Drawing.Size(65, 12);
            this.lblJobInfoName.TabIndex = 4;
            this.lblJobInfoName.Text = "工种名称：";
            // 
            // lblJobInfoRemark
            // 
            this.lblJobInfoRemark.AutoSize = true;
            this.lblJobInfoRemark.Location = new System.Drawing.Point(41, 125);
            this.lblJobInfoRemark.Name = "lblJobInfoRemark";
            this.lblJobInfoRemark.Size = new System.Drawing.Size(65, 12);
            this.lblJobInfoRemark.TabIndex = 5;
            this.lblJobInfoRemark.Text = "工种描述：";
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 332);
            this.Controls.Add(this.lblJobInfoRemark);
            this.Controls.Add(this.lblJobInfoName);
            this.Controls.Add(this.txtJobRematk);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.btnJobCannel);
            this.Controls.Add(this.btnJobOK);
            this.Name = "AddJob";
            this.Text = "                                 添加工种信息";
            this.Load += new System.EventHandler(this.AddJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJobOK;
        private System.Windows.Forms.Button btnJobCannel;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.TextBox txtJobRematk;
        private System.Windows.Forms.Label lblJobInfoName;
        private System.Windows.Forms.Label lblJobInfoRemark;
    }
}