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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class ControlPanelEditor : Form
    {
        public int DeviceID;
        private List<PickBox> selected = new List<PickBox>();
        private List<PickBox> controls = new List<PickBox>();
        ControlSertialzer controllist = new ControlSertialzer();
        object Clicked;
        string path = "";
       // PickBox pb = new PickBox();
        public ControlPanelEditor()
        {
            InitializeComponent();
        }

        private void ControlPanelEditor_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = panel4.Height;
            numericUpDown2.Value = panel4.Width;
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)listBox1.SelectedItem)
            {
                case "标签":
                    {
                        Label lb = new Label();
                        lb.Text = "文字";
                        lb.AutoSize = true;
                        lb.Name = "文字";
                        panel4.Controls.Add(lb);
                        break;
                    }
                case "仪表控件":
                    {
                        AGauge ag = new AGauge();
                        ag.Width = 200;
                        ag.Height = 200;
                        panel4.Controls.Add(ag);
                        int i = panel4.Controls.Count;
                        break;
                    }
                case "图片":
                    {
                        PictureBox ag = new PictureBox();
                        ag.BackColor = Color.Transparent;
                        ag.BorderStyle = BorderStyle.FixedSingle;
                        ag.Image = Properties.Resources.Error;
                        ag.Width = 128;
                        ag.Height = 128;
                        ag.SizeMode = PictureBoxSizeMode.StretchImage;
                        panel4.Controls.Add(ag);
                        break;
                    }
                case "数字编辑器":
                    {
                        NumericUpDown ag = new NumericUpDown();

                        panel4.Controls.Add(ag);
                        break;
                    }
            }
 //           LoadAllControls();
            pictureBox3_Click(sender, e);

        }
        private void LoadAllControls()
        {

            foreach(Control ag in panel4.Controls)
            {
                PickBox pb = new PickBox();
                ag.Click += Control_Click;
                ag.MouseUp += Control_MouseUp;
                ag.MouseDown += Control_MouseDown;
                ag.MouseMove += Control_MouseMove;
                bool contains = false;
                foreach (PickBox b in controls)
                {
                    if (b.Control == ag)
                    {
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                {
                    pb.WireControl(ag);
                    controls.Add(pb);
                }
            }

        }
        private void Control_Click(object sender, EventArgs e)
        {
            if(Clicked == sender)
            {
                return;
            }
            propertyGrid1.SelectedObject = sender;
            Clicked = sender;
            int i = panel4.Controls.Count;
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
            Thread.Sleep(50);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int i = panel4.Controls.Count;
            controllist.LoadControlls(panel4.Controls);
            panel4.Controls.Clear();
            controllist.GetControls(panel4);
            LoadAllControls();
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
            
            if (path.Length == 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML文档|*.xml";
                sfd.FilterIndex = 0;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    FileObject fo = new FileObject();
                    fo.Storge(controllist, path);
                }
            }
            else
            {
                FileObject fo = new FileObject();
                fo.Storge(controllist, path);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); ;
            ofd.Filter = "XML文档|*.xml";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileObject fo = new FileObject();
                controllist=fo.GetObj(ofd.FileName) as ControlSertialzer;
                panel4.Controls.Clear();
                controllist.GetControls(panel4);
                LoadAllControls();
                panel4.Size = controllist.panelsize;
                panel4.BackgroundImage = controllist.background;
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
                        break;
                    }
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_MouseHover(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Leave(object sender, EventArgs e)
        {
            
        }

        private void propertyGrid1_PropertyTabChanged(object s, PropertyTabChangedEventArgs e)
        {
            MessageBox.Show("change");
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel4.Height = (int)numericUpDown1.Value;
            controllist.panelsize = panel4.Size;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            panel4.Width = (int)numericUpDown2.Value;
            controllist.panelsize = panel4.Size;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.jpg;*.bmp;*.gif;*.png";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image imf = Image.FromFile(ofd.FileName);
                panel4.BackgroundImage = imf;
                panel4.BackgroundImageLayout = ImageLayout.Stretch;
                controllist.background = panel4.BackgroundImage;
            }
        }
    }
}
