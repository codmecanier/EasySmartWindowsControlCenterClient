using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能平台总控端
{
    public partial class login : Form
    {
        List<PersonalSettings> setting = new List<PersonalSettings>();
        public login()
        {
            InitializeComponent();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home.services.LoadAllServices();
            NowUser.CurrentUser = Home.services.userservice.Login(comboBox1.Text, textBox2.Text);
            if (NowUser.CurrentUser != null)
            {
                PersonalSettings ps = setting.Where<PersonalSettings>(P => P.Username == comboBox1.Text.Trim()).FirstOrDefault<PersonalSettings>();
                if (ps != null)
                {
                    setting.Remove(ps);
                    if (checkBox1.Checked)
                    {
                        setting.Insert(0, ps);
                        ps.RememberPassword = true;
                        ps.AutoLogin = checkBox2.Checked;
                    }
                }
                else if (checkBox1.Checked)
                {
                    PersonalSettings pss = new PersonalSettings();
                    pss.Username = comboBox1.Text;
                    pss.Password = textBox2.Text;
                    setting.Add(pss);
                }
                Home.file.Storge(setting, "UserPersonalSettings.bin");
                this.Close();
            }
            else
            {
                MessageBox.Show("登陆失败，请检查用户名和密码是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            setting = Home.file.GetObj("UserPersonalSettings.bin") as List<PersonalSettings>;
            comboBox1.DisplayMember = "UserName";
            comboBox1.DataSource = setting;
            List<PersonalSettings> fsettings = Home.file.GetObj("UserPersonalSettings.bin") as List<PersonalSettings>;
            if (fsettings != null)
            {
                setting = fsettings;
                PersonalSettings pls = setting.Where<PersonalSettings>(P => P.Username == comboBox1.Text).FirstOrDefault<PersonalSettings>();
                if (pls != null)
                {
                    textBox2.Text = pls.Password;
                    checkBox1.Checked = pls.RememberPassword;
                    checkBox2.Checked = pls.AutoLogin;
                }
            }
            else
            {
                setting = new List<PersonalSettings>();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PersonalSettings> fsettings = Home.file.GetObj("UserPersonalSettings.bin") as List<PersonalSettings>;
            if (fsettings != null)
            {
                setting = fsettings;
                PersonalSettings pls = setting.Where<PersonalSettings>(P => P.Username == comboBox1.Text).FirstOrDefault<PersonalSettings>();
                if(pls!=null)
                {
                    textBox2.Text = pls.Password;
                    checkBox1.Checked = pls.RememberPassword;
                    checkBox2.Checked = pls.AutoLogin;
                }
            }
            else
            {
                setting = new List<PersonalSettings>();
            }
        }
    }
}
