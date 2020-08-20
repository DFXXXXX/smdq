using Newtonsoft.Json;
using smdq.model;
using smdq.webServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smdq.WinForm.USER
{
    public partial class ADDUser : Form
    {
        public ADDUser()
        {
            InitializeComponent();
        }
        private int _Mytpe;
        public int Mytpe
        {
            get
            {
                return _Mytpe;
            }

            set
            {
                _Mytpe = value;
                if (_Mytpe == 1)
                {
                    button1.Text = "修改";
                    t_ID.Enabled = false;
                    t_Name.Enabled = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_Mytpe == 0)
            {
                var us = new User
                {
                    Pername = t_Name.Text,
                    Pertel = t_tel.Text,
                    Adr = t_adr.Text,
                    Pwd = t_pwd.Text,
                    Entrytime = Convert.ToDateTime(t_time.Text),
                    Flag = Convert.ToInt32(checkBox6.Checked),
                    Authorization1 = Convert.ToInt32(checkBox1.Checked),
                    Authorization2 = Convert.ToInt32(checkBox2.Checked),
                    Authorization3 = Convert.ToInt32(checkBox3.Checked),
                    Authorization4 = Convert.ToInt32(checkBox4.Checked),
                    Authorization5 = Convert.ToInt32(checkBox5.Checked)
                };
                string jsonData = JsonConvert.SerializeObject(us);
                var url = "http://www.cltlkj.cn:8090/api/User/CreateUser";
                var res = WebServer.PostMeth(url, jsonData);
            }
            else
            {
                var us = new User
                {
                    Perid= Convert.ToInt32(t_ID.Text),
                    Pername = t_Name.Text,
                    Pertel = t_tel.Text,
                    Adr = t_adr.Text,
                    Pwd = t_pwd.Text,
                    Entrytime = Convert.ToDateTime(t_time.Text),
                    Flag = Convert.ToInt32(checkBox6.Checked),
                    Authorization1 = Convert.ToInt32(checkBox1.Checked),
                    Authorization2 = Convert.ToInt32(checkBox2.Checked),
                    Authorization3 = Convert.ToInt32(checkBox3.Checked),
                    Authorization4 = Convert.ToInt32(checkBox4.Checked),
                    Authorization5 = Convert.ToInt32(checkBox5.Checked)
                };
                string jsonData = JsonConvert.SerializeObject(us);
                var url = "http://www.cltlkj.cn:8090/api/User/UpdateUser";
                var res = WebServer.PostMeth(url, jsonData);               
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
