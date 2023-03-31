namespace PersonMIS.DepartMange
{
    partial class ModifyDepart
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDepartLeader = new System.Windows.Forms.Label();
            this.lblDepartRemark = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtDRemak = new System.Windows.Forms.TextBox();
            this.cmbPersonName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 316);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "修改";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDepartName
            // 
            this.lblDepartName.AutoSize = true;
            this.lblDepartName.Location = new System.Drawing.Point(34, 74);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(65, 12);
            this.lblDepartName.TabIndex = 2;
            this.lblDepartName.Text = "部门名称：";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblDepartLeader
            // 
            this.lblDepartLeader.AutoSize = true;
            this.lblDepartLeader.Location = new System.Drawing.Point(282, 74);
            this.lblDepartLeader.Name = "lblDepartLeader";
            this.lblDepartLeader.Size = new System.Drawing.Size(65, 12);
            this.lblDepartLeader.TabIndex = 3;
            this.lblDepartLeader.Text = "部门领导：";
            // 
            // lblDepartRemark
            // 
            this.lblDepartRemark.AutoSize = true;
            this.lblDepartRemark.Location = new System.Drawing.Point(34, 135);
            this.lblDepartRemark.Name = "lblDepartRemark";
            this.lblDepartRemark.Size = new System.Drawing.Size(41, 12);
            this.lblDepartRemark.TabIndex = 4;
            this.lblDepartRemark.Text = "描述：";
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(105, 71);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(160, 21);
            this.txtDName.TabIndex = 5;
            // 
            // txtDRemak
            // 
            this.txtDRemak.Location = new System.Drawing.Point(105, 135);
            this.txtDRemak.Multiline = true;
            this.txtDRemak.Name = "txtDRemak";
            this.txtDRemak.Size = new System.Drawing.Size(414, 159);
            this.txtDRemak.TabIndex = 6;
            // 
            // cmbPersonName
            // 
            this.cmbPersonName.FormattingEnabled = true;
            this.cmbPersonName.Location = new System.Drawing.Point(353, 71);
            this.cmbPersonName.Name = "cmbPersonName";
            this.cmbPersonName.Size = new System.Drawing.Size(166, 20);
            this.cmbPersonName.TabIndex = 7;
            // 
            // ModifyDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 390);
            this.Controls.Add(this.cmbPersonName);
            this.Controls.Add(this.txtDRemak);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.lblDepartRemark);
            this.Controls.Add(this.lblDepartLeader);
            this.Controls.Add(this.lblDepartName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Name = "ModifyDepart";
            this.Text = "ModifyDepart";
            this.Load += new System.EventHandler(this.ModifyDepart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDepartLeader;
        private System.Windows.Forms.Label lblDepartRemark;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtDRemak;
        private System.Windows.Forms.ComboBox cmbPersonName;
    }
}