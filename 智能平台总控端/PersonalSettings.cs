using EasySmartDataBaseService.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智能平台总控端
{
    [Serializable ]
    public class PersonalSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Image image { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public List<Device> UsedDevices { get; set; }
        public List<Mode> UsedModes { get; set; }
        public bool RememberPassword { get; set; }
        public bool AutoLogin { get; set; }
    }
}
