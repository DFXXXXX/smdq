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

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Mytpe == 0)
            {
                var us = new User
                {
                    pername = t_Name.Text,
                    pertel = t_tel.Text,
                    adr = t_adr.Text,
                    pwd = t_pwd.Text,
                    entrytime = Convert.ToDateTime(t_time.Text),
                    flag = Convert.ToInt32(checkBox6.Checked),
                    authorization1 = Convert.ToInt32(checkBox1.Checked),
                    authorization2 = Convert.ToInt32(checkBox2.Checked),
                    authorization3 = Convert.ToInt32(checkBox3.Checked),
                    authorization4 = Convert.ToInt32(checkBox4.Checked),
                    authorization5 = Convert.ToInt32(checkBox5.Checked)
                };
                string jsonData = JsonConvert.SerializeObject(us);
                var url = "http://www.cltlkj.cn:8090/api/User/CreateUser";
                var res = WebServer.PostMeth(url, jsonData);
            }
            else
            {
                var us = new User
                {
                    perid= Convert.ToInt32(t_ID.Text),
                    pername = t_Name.Text,
                    pertel = t_tel.Text,
                    adr = t_adr.Text,
                    pwd = t_pwd.Text,
                    entrytime = Convert.ToDateTime(t_time.Text),
                    flag = Convert.ToInt32(checkBox6.Checked),
                    authorization1 = Convert.ToInt32(checkBox1.Checked),
                    authorization2 = Convert.ToInt32(checkBox2.Checked),
                    authorization3 = Convert.ToInt32(checkBox3.Checked),
                    authorization4 = Convert.ToInt32(checkBox4.Checked),
                    authorization5 = Convert.ToInt32(checkBox5.Checked)
                };
                string jsonData = JsonConvert.SerializeObject(us);
                var url = "http://www.cltlkj.cn:8090/api/User/UpdateUser";
                var res = WebServer.PostMeth(url, jsonData);               
            }
        }

        private void t_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void t_adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void t_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
