
using AGaugeApp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using 智能平台总控端.MyControls;

namespace 智能平台总控端
{
    [Serializable]
    public class ControlSertialzer
    {
        ArrayList clist = new ArrayList();
        public Size panelsize;
        public Image background;

        public object GetSerialControl(Control c)
        {
            if (c is Label)
            {
                MyLabel ml = new MyLabel();
                ml.Control = c as Label;
                if (c.Text.Length != 0)
                {
                    return ml;
                }
            }
            if (c is PictureBox)
            {
                MyPictureBox mpb = new MyPictureBox();
                mpb.Control = c as PictureBox;
                if (mpb.Control.Image != null)
                {
                    return mpb;
                }
            }
            if (c is NumericUpDown)
            {
                MyNumericUpDown mnu = new MyNumericUpDown();
                mnu.Control = c as NumericUpDown;
                return mnu;
            }
            if (c is AGauge)
            {
                MyAGauge mag = new MyAGauge();
                mag.Control = c as AGauge;
                return mag;
            }
            return null;
        }
        public void LoadControlls(Control.ControlCollection cs)
        {
            clist.Clear();
            foreach (Control c in cs)
            {
                clist.Add(GetSerialControl(c));
            }

        }
        public void GetControls(Panel pl)
        {
            foreach (var c in clist)
            {
                if (c is MyLabel)
                {
                    Label lb = (c as MyLabel).Control;
                    pl.Controls.Add(lb);
                }
                if (c is MyPictureBox)
                {
                    PictureBox pb = (c as MyPictureBox).Control;
                    pl.Controls.Add(pb);
                }
                if (c is MyNumericUpDown)
                {
                    NumericUpDown nud = (c as MyNumericUpDown).Control;
                    pl.Controls.Add(nud);
                }
                if (c is MyAGauge)
                {
                    AGauge ag = (c as MyAGauge).Control;
                    pl.Controls.Add(ag);
                }
            }
        }
    }
}
