using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class DataNumberDisplayer : UserControl
    {
        public Font Font
        {
            get
            {
                return label1.Font;
            }
            set
            {
                label1.Font = value;
            }
        }
        public Color Forecolor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }
        public Color BackColor
        {
            get
            {
                return label1.BackColor;
            }
            set
            {
                label1.BackColor = BackColor;
            }
        }
        public int demic { get; set; }
        private string unit;
        private decimal displayvalue;
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                label1.Text = displayvalue.ToString("f" + demic.ToString()) + unit;
            }
        }
        public decimal Value
        {
            get
            {
                return displayvalue;
            }
            set
            {
                displayvalue = value;
            }
        }
    

        public DataNumberDisplayer()
        {
            InitializeComponent();
            label1.AutoSize = false;
        }

        private void DataNumberDisplayer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
