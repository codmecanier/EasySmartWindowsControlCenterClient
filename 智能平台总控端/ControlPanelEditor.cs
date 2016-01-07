using AGaugeApp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class ControlPanelEditor : Form
    {
        public int DeviceID;
        private List<PickBox> selected = new List<PickBox>();
        private List<PickBox> controls = new List<PickBox>();
        string path = "";
       // PickBox pb = new PickBox();
        public ControlPanelEditor()
        {
            InitializeComponent();
        }

        private void ControlPanelEditor_Load(object sender, EventArgs e)
        {
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickBox pb = new PickBox();
            switch ((string)listBox1.SelectedItem)
            {
                case "标签":
                    {
                        Label lb = new Label();
                        lb.Text = "文字";
                        lb.AutoSize = true;
                        lb.Name = "文字";
                        lb.Click += Control_Click;
                        lb.MouseUp += Control_MouseUp;
                        lb.MouseDown += Control_MouseDown;
                        lb.MouseMove += Control_MouseMove;
                        pb.WireControl(lb);
                        panel4.Controls.Add(lb);
                        controls.Add(pb);
                        break;
                    }
                case "仪表控件":
                    {
                        AGauge ag = new AGauge();
                        ag.Width = 200;
                        ag.Height = 200;
                        ag.Click += Control_Click;
                        ag.MouseUp += Control_MouseUp;
                        ag.MouseDown += Control_MouseDown;
                        ag.MouseMove += Control_MouseMove;
                        pb.WireControl(ag);
                        panel4.Controls.Add(ag);
                        controls.Add(pb);
                        break;
                    }
                case "图片":
                    {
                        PictureBox ag = new PictureBox();
                        ag.BackColor = Color.Gray;
                        ag.Width = 128;
                        ag.Height = 128;
                        ag.SizeMode = PictureBoxSizeMode.StretchImage;
                        ag.Click += Control_Click;
                        ag.MouseUp += Control_MouseUp;
                        ag.MouseDown += Control_MouseDown;
                        ag.MouseMove += Control_MouseMove;
                        pb.WireControl(ag);
                        panel4.Controls.Add(ag);
                        controls.Add(pb);
                        break;
                    }
            }
            if (pb.Control != null)
            {
                selected.Add(pb);
            }
        }
        private void Control_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = sender;
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control )
            {
                foreach(PickBox c in controls)
                {
                    if(c.Control==sender)
                    {
                            c.SelectControl(sender, e);
                            selected.Add(c);

                    }
                }
            }
            else
            {
                foreach (PickBox p in selected)
                {
                    p.Remove();
                }
                selected.Clear();

                foreach (PickBox c in controls)
                {
                    if(c.Control==sender)
                    {

                            c.SelectControl(sender, e);
                            selected.Add(c);

                    }
                }
            }
        }

        private void Control_MouseDown(object sender,MouseEventArgs e)
        {
            foreach (PickBox p in selected)
            {
                p.ctl_MouseDown(sender, e);
            }
        }
        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (PickBox p in selected)
            {
                p.ctl_MouseUp(sender, e);
            }
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (PickBox p in selected)
            {
                p.ctl_MouseMove(sender, e);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ObjectXML.WriteXML(panel4);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            foreach(PickBox p in selected)
            {
                p.Remove();
            }
            selected.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            foreach (PickBox c in selected)
            {
                panel4.Controls.Remove(c.Control);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("未编译的文档不能保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (path.Length == 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML文档|*.xml";
                sfd.FilterIndex = 0;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("要保存文件吗？\n要保存文件请点击是\n要放弃文件请点击否，您所做的更改全部丢失\n要返回设计器请点击取消"))
            {
                case DialogResult.Cancel:
                    {
                        return;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Yes:
                    {
                        if (richTextBox1.Text.Length == 0)
                        {
                            MessageBox.Show("未编译的文档不能保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (path.Length == 0)
                            {
                                SaveFileDialog sfd = new SaveFileDialog();
                                sfd.Filter = "XML文档|*.xml";
                                sfd.FilterIndex = 0;
                                if (sfd.ShowDialog() == DialogResult.OK)
                                {
                                    path = sfd.FileName;
                                    StreamWriter sw = new StreamWriter(path);
                                    sw.WriteLine(richTextBox1.Text);
                                    sw.Flush();
                                    sw.Close();
                                }
                            }
                            else
                            {
                                StreamWriter sw = new StreamWriter(path);
                                sw.WriteLine(richTextBox1.Text);
                                sw.Flush();
                                sw.Close();
                            }
                        }
                        break;
                    }
            }
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "XML文档|*.xml";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string str = sr.ReadToEnd();
                sr.Close();
                //try
                //{
                //    panel4.Controls.Clear();
                    ObjectXML.ReadXML(panel4,str);
                //}
                //catch
                //{
                //    MessageBox.Show("XML文件损坏", "文件损坏", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void ControlPanelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(MessageBox.Show("要保存文件吗？\n要保存文件请点击是\n要放弃文件请点击否，您所做的更改全部丢失\n要返回设计器请点击取消"))
            {
                case DialogResult.Cancel:
                    {
                        e.Cancel = true;
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Yes:
                    {
                        if (richTextBox1.Text.Length == 0)
                        {
                            MessageBox.Show("未编译的文档不能保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (path.Length == 0)
                        {
                            SaveFileDialog sfd = new SaveFileDialog();
                            sfd.Filter = "XML文档|*.xml";
                            sfd.FilterIndex = 0;
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                path = sfd.FileName;
                                StreamWriter sw = new StreamWriter(path);
                                sw.WriteLine(richTextBox1.Text);
                                sw.Flush();
                                sw.Close();
                            }
                        }
                        else
                        {
                            StreamWriter sw = new StreamWriter(path);
                            sw.WriteLine(richTextBox1.Text);
                            sw.Flush();
                            sw.Close();
                        }
                        break;
                    }
            }
        }
    }
}
