namespace PersonMIS.PersonManage
{
    partial class BrowsePerson
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbDID = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.dgvPersonInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(466, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "开始查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(273, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改员工信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(450, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除员工信息";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(621, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbDID
            // 
            this.cmbDID.FormattingEnabled = true;
            this.cmbDID.Location = new System.Drawing.Point(203, 12);
            this.cmbDID.Name = "cmbDID";
            this.cmbDID.Size = new System.Drawing.Size(140, 20);
            this.cmbDID.TabIndex = 4;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(120, 16);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(77, 12);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "请选择部门：";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(12, 412);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(53, 12);
            this.lblHint.TabIndex = 6;
            this.lblHint.Text = "查询结果";
            // 
            // dgvPersonInfo
            // 
            this.dgvPersonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonInfo.Location = new System.Drawing.Point(12, 39);
            this.dgvPersonInfo.Name = "dgvPersonInfo";
            this.dgvPersonInfo.RowTemplate.Height = 23;
            this.dgvPersonInfo.Size = new System.Drawing.Size(1024, 356);
            this.dgvPersonInfo.TabIndex = 7;
            // 
            // BrowsePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.dgvPersonInfo);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.cmbDID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnQuery);
            this.Name = "BrowsePerson";
            this.Text = "                                                                                 " +
    "                       浏览员工信息";
            this.Load += new System.EventHandler(this.BrowsePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbDID;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView dgvPersonInfo;
    }
}