namespace 智能平台总控端
{
    partial class Power
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Floor_Data = new System.Windows.Forms.DataGridView();
            this.Room_Data = new System.Windows.Forms.DataGridView();
            this.Device_Data = new System.Windows.Forms.DataGridView();
            this.Perform_Or_Sensor_Data = new System.Windows.Forms.DataGridView();
            this._Display = new System.Windows.Forms.CheckBox();
            this._Control = new System.Windows.Forms.CheckBox();
            this._Using = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Type = new System.Windows.Forms.ComboBox();
            this.Room_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Room_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Floor_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perform_Or_Sensor_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 100);
            this.panel3.TabIndex = 2;
            // 
            // Floor_Data
            // 
            this.Floor_Data.AllowUserToAddRows = false;
            this.Floor_Data.AllowUserToDeleteRows = false;
            this.Floor_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Floor_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Floor_Check,
            this.Floor_ID,
            this.FloorName,
            this.FloorInfo});
            this.Floor_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Floor_Data.Location = new System.Drawing.Point(3, 17);
            this.Floor_Data.Name = "Floor_Data";
            this.Floor_Data.RowTemplate.Height = 23;
            this.Floor_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Floor_Data.Size = new System.Drawing.Size(373, 174);
            this.Floor_Data.TabIndex = 0;
            this.Floor_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Floor_Data_CellClick);
            // 
            // Room_Data
            // 
            this.Room_Data.AllowUserToAddRows = false;
            this.Room_Data.AllowUserToDeleteRows = false;
            this.Room_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room_Check,
            this.Room_ID,
            this.RoomName,
            this.RoomInfo});
            this.Room_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Room_Data.Location = new System.Drawing.Point(3, 17);
            this.Room_Data.Name = "Room_Data";
            this.Room_Data.RowTemplate.Height = 23;
            this.Room_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Room_Data.Size = new System.Drawing.Size(373, 174);
            this.Room_Data.TabIndex = 0;
            this.Room_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_Data_CellClick);
            // 
            // Device_Data
            // 
            this.Device_Data.AllowUserToAddRows = false;
            this.Device_Data.AllowUserToDeleteRows = false;
            this.Device_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Device_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device_Check,
            this.Device_ID,
            this.DeviceName,
            this.DeviceInfo});
            this.Device_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Device_Data.Location = new System.Drawing.Point(3, 17);
            this.Device_Data.Name = "Device_Data";
            this.Device_Data.RowTemplate.Height = 23;
            this.Device_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Device_Data.Size = new System.Drawing.Size(373, 175);
            this.Device_Data.TabIndex = 0;
            this.Device_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Device_Data_CellClick);
            // 
            // Perform_Or_Sensor_Data
            // 
            this.Perform_Or_Sensor_Data.AllowUserToAddRows = false;
            this.Perform_Or_Sensor_Data.AllowUserToDeleteRows = false;
            this.Perform_Or_Sensor_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Perform_Or_Sensor_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Perform_Or_Sensor_Data.Location = new System.Drawing.Point(3, 17);
            this.Perform_Or_Sensor_Data.Name = "Perform_Or_Sensor_Data";
            this.Perform_Or_Sensor_Data.RowTemplate.Height = 23;
            this.Perform_Or_Sensor_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Perform_Or_Sensor_Data.Size = new System.Drawing.Size(373, 136);
            this.Perform_Or_Sensor_Data.TabIndex = 0;
            this.Perform_Or_Sensor_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Perform_Or_Sensor_Data_CellClick);
            // 
            // _Display
            // 
            this._Display.AutoSize = true;
            this._Display.Location = new System.Drawing.Point(76, 20);
            this._Display.Name = "_Display";
            this._Display.Size = new System.Drawing.Size(48, 16);
            this._Display.TabIndex = 0;
            this._Display.Text = "可见";
            this._Display.UseVisualStyleBackColor = true;
            // 
            // _Control
            // 
            this._Control.AutoSize = true;
            this._Control.Location = new System.Drawing.Point(22, 20);
            this._Control.Name = "_Control";
            this._Control.Size = new System.Drawing.Size(48, 16);
            this._Control.TabIndex = 1;
            this._Control.Text = "可控";
            this._Control.UseVisualStyleBackColor = true;
            // 
            // _Using
            // 
            this._Using.AutoSize = true;
            this._Using.Location = new System.Drawing.Point(130, 20);
            this._Using.Name = "_Using";
            this._Using.Size = new System.Drawing.Size(60, 16);
            this._Using.TabIndex = 2;
            this._Using.Text = "可使用";
            this._Using.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._Control);
            this.groupBox1.Controls.Add(this._Using);
            this.groupBox1.Controls.Add(this._Display);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Btn_Cancel);
            this.panel9.Controls.Add(this.Btn_Save);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 54);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(770, 46);
            this.panel9.TabIndex = 4;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(260, 8);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(60, 30);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(438, 8);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(60, 30);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 401);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this._Type);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(379, 39);
            this.panel8.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(388, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 195);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Device_Data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Floor_Data);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 194);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "楼层";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Room_Data);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(388, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 194);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "房间";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Perform_Or_Sensor_Data);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 156);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "执行器/传感器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型:";
            // 
            // _Type
            // 
            this._Type.FormattingEnabled = true;
            this._Type.Items.AddRange(new object[] {
            "执行器",
            "传感器"});
            this._Type.Location = new System.Drawing.Point(47, 8);
            this._Type.Name = "_Type";
            this._Type.Size = new System.Drawing.Size(152, 20);
            this._Type.TabIndex = 1;
            // 
            // Room_Check
            // 
            this.Room_Check.DataPropertyName = "Room_Check";
            this.Room_Check.HeaderText = "选定";
            this.Room_Check.Name = "Room_Check";
            this.Room_Check.ReadOnly = true;
            // 
            // Room_ID
            // 
            this.Room_ID.DataPropertyName = "RoomID";
            this.Room_ID.HeaderText = "RoomID";
            this.Room_ID.Name = "Room_ID";
            this.Room_ID.ReadOnly = true;
            this.Room_ID.Visible = false;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "房间名称";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // RoomInfo
            // 
            this.RoomInfo.DataPropertyName = "RoomInfo";
            this.RoomInfo.HeaderText = "房间简介";
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.ReadOnly = true;
            // 
            // Device_Check
            // 
            this.Device_Check.DataPropertyName = "Device_Check";
            this.Device_Check.HeaderText = "选定";
            this.Device_Check.Name = "Device_Check";
            this.Device_Check.ReadOnly = true;
            // 
            // Device_ID
            // 
            this.Device_ID.DataPropertyName = "DeviceID";
            this.Device_ID.HeaderText = "DeviceID";
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.ReadOnly = true;
            this.Device_ID.Visible = false;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "设备名称";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // DeviceInfo
            // 
            this.DeviceInfo.DataPropertyName = "DeviceInfo";
            this.DeviceInfo.HeaderText = "设备简介";
            this.DeviceInfo.Name = "DeviceInfo";
            this.DeviceInfo.ReadOnly = true;
            // 
            // Floor_Check
            // 
            this.Floor_Check.DataPropertyName = "Floor_Check";
            this.Floor_Check.HeaderText = "选定";
            this.Floor_Check.Name = "Floor_Check";
            // 
            // Floor_ID
            // 
            this.Floor_ID.DataPropertyName = "FloorID";
            this.Floor_ID.HeaderText = "FloorID";
            this.Floor_ID.Name = "Floor_ID";
            this.Floor_ID.Visible = false;
            // 
            // FloorName
            // 
            this.FloorName.DataPropertyName = "FloorName";
            this.FloorName.HeaderText = "楼层名称";
            this.FloorName.Name = "FloorName";
            this.FloorName.ReadOnly = true;
            // 
            // FloorInfo
            // 
            this.FloorInfo.DataPropertyName = "FloorInfo";
            this.FloorInfo.HeaderText = "楼层简介";
            this.FloorInfo.Name = "FloorInfo";
            this.FloorInfo.ReadOnly = true;
            // 
            // Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "Power";
            this.Text = "权限设置";
            this.Load += new System.EventHandler(this.Power_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Floor_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perform_Or_Sensor_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Device_Data;
        private System.Windows.Forms.DataGridView Floor_Data;
        private System.Windows.Forms.DataGridView Perform_Or_Sensor_Data;
        private System.Windows.Forms.DataGridView Room_Data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _Control;
        private System.Windows.Forms.CheckBox _Using;
        private System.Windows.Forms.CheckBox _Display;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox _Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Room_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Device_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Floor_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorInfo;
    }
}