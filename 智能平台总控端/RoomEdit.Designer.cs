namespace 智能平台总控端
{
    partial class RoomEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomEdit));
            this.Floorcmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OKbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cancelbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Floorcmb
            // 
            this.Floorcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floorcmb.FormattingEnabled = true;
            this.Floorcmb.Location = new System.Drawing.Point(200, 142);
            this.Floorcmb.Name = "Floorcmb";
            this.Floorcmb.Size = new System.Drawing.Size(206, 26);
            this.Floorcmb.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "房间楼层：";
            // 
            // Nametext
            // 
            this.Nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametext.Location = new System.Drawing.Point(200, 112);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(206, 26);
            this.Nametext.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "房间名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 40;
            this.label1.Text = "填写房间信息";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("Cancelbtn.Image")));
            this.Cancelbtn.Location = new System.Drawing.Point(303, 223);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(80, 74);
            this.Cancelbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cancelbtn.TabIndex = 46;
            this.Cancelbtn.TabStop = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(303, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // OKbtn
            // 
            this.OKbtn.Image = ((System.Drawing.Image)(resources.GetObject("OKbtn.Image")));
            this.OKbtn.Location = new System.Drawing.Point(82, 223);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(80, 74);
            this.OKbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OKbtn.TabIndex = 44;
            this.OKbtn.TabStop = false;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // RoomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.Floorcmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoomEdit";
            this.Text = "RoomEdit";
            this.Load += new System.EventHandler(this.RoomEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cancelbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Floorcmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Cancelbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox OKbtn;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}