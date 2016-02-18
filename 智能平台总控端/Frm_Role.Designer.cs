namespace 智能平台总控端
{
    partial class Frm_Role
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Role_Data = new System.Windows.Forms.DataGridView();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Role_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Delete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(3, 3);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "新增";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(84, 3);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "修改";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(165, 3);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Role_Data
            // 
            this.Role_Data.AllowUserToAddRows = false;
            this.Role_Data.AllowUserToDeleteRows = false;
            this.Role_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Role_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleName,
            this.RoleID,
            this.RoleRemark});
            this.Role_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Role_Data.Location = new System.Drawing.Point(0, 31);
            this.Role_Data.Name = "Role_Data";
            this.Role_Data.ReadOnly = true;
            this.Role_Data.RowTemplate.Height = 23;
            this.Role_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Role_Data.Size = new System.Drawing.Size(700, 481);
            this.Role_Data.TabIndex = 1;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "RoleID";
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Visible = false;
            // 
            // RoleRemark
            // 
            this.RoleRemark.DataPropertyName = "RoleRemark";
            this.RoleRemark.HeaderText = "角色备注";
            this.RoleRemark.Name = "RoleRemark";
            this.RoleRemark.ReadOnly = true;
            // 
            // Frm_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 512);
            this.Controls.Add(this.Role_Data);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Frm_Role";
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.Frm_Role_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Role_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView Role_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleRemark;
    }
}