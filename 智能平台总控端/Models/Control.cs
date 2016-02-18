using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class Control
    {
        public int ControlID { get; set; }
        public int ControlName { get; set; }
        public Nullable<int> Value1 { get; set; }
        public Nullable<int> Value2 { get; set; }
        public Nullable<int> Value3 { get; set; }
        public Nullable<int> Value4 { get; set; }
        public Nullable<int> Value5 { get; set; }
        public decimal Decimal1 { get; set; }
        public decimal Decimal2 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
    }
}
