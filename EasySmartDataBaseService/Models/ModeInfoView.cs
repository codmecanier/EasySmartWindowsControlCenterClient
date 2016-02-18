using System;
using System.Collections.Generic;

namespace EasySmartDataBaseService.Models
{
    public partial class ModeInfoView
    {
        public int UserID { get; set; }
        public int ModeID { get; set; }
        public int Expr1 { get; set; }
        public string ModeName { get; set; }
        public string ModeInfo { get; set; }
        public string UserName { get; set; }
        public int PerformID { get; set; }
    }
}
