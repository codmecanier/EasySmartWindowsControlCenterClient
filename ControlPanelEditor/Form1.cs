using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPanelEditor
{
    public partial class Form1 : Form
    {
        Control movectrl;
        Point po;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (po.X + po.Y != 0)
            {
                Point now = Control.MousePosition;
                int movex = now.X - po.X;
                int movey = now.Y - po.Y;
                Point p = new Point(movex, movey);
                movectrl.Location = p;
            }
            else
            {
                po = new Point(Control.MousePosition.X - movectrl.Location.X, Control.MousePosition.Y - movectrl.Location.Y);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            movectrl = sender as Control;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            po = new Point(0, 0);
        }
    }
}
