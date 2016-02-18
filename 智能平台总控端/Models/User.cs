using System;
using System.Collections.Generic;

namespace 智能平台总控端.Models
{
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Emial { get; set; }
        public System.DateTime SignDate { get; set; }
        public string Mobile { get; set; }
        public byte[] HeadIcon { get; set; }
    }
}
