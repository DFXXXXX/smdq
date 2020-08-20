using Newtonsoft.Json;
using smdq.model;
using smdq.webServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smdq.WinForm.USER
{
    public partial class UserTable : Form
    {
        public UserTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string url = PublicValue.MyURL+ $"user/GetUserbyString?str={textBox1.Text}";
            var sjson = WebServer.GetMeth(url);
            List<User> twoList = WebServer.GetResult<List<User>>(sjson);
            foreach (User stu in twoList)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = stu.perid.ToString();
                item1.SubItems.Add(stu.pername);
                item1.SubItems.Add(stu.pertel);
                item1.SubItems.Add(stu.adr);
                item1.SubItems.Add(stu.perlv.ToString());
                item1.SubItems.Add(stu.entrytime.ToString());
                item1.SubItems.Add(stu.flag.ToString());
                item1.SubItems.Add(stu.authorization1.ToString());
                item1.SubItems.Add(stu.authorization2.ToString());
                item1.SubItems.Add(stu.authorization3.ToString());
                item1.SubItems.Add(stu.authorization4.ToString());
                item1.SubItems.Add(stu.authorization5.ToString());
                listView1.Items.Add(item1);                   //添加集体进去
            }
            return;          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDUser new_form = new ADDUser();
            new_form.Owner = this;
            new_form.Mytpe = 0;
            new_form.ShowDialog();
            if (new_form.DialogResult == DialogResult.OK)
            {
                button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ADDUser new_form = new ADDUser();
            new_form.t_ID.Text = listView1.SelectedItems[0].Text;
            new_form.t_Name.Text = listView1.SelectedItems[0].SubItems[1].Text;
            new_form.t_tel.Text = listView1.SelectedItems[0].SubItems[2].Text;
            new_form.t_adr.Text = listView1.SelectedItems[0].SubItems[3].Text;
           // new_form.t_time = listView1.SelectedItems[0].SubItems[5].Text;
            new_form.t_pwd.Enabled = false;
            new_form.checkBox6.Checked = Convert.ToBoolean(Convert.ToInt32(listView1.SelectedItems[0].SubItems[6].Text));
            new_form.checkBox1.Checked = Convert.ToBoolean(Convert.ToInt32(listView1.SelectedItems[0].SubItems[7].Text));
            new_form.checkBox2.Checked = Convert.ToBoolean(Convert.ToInt32(listView1.SelectedItems[0].SubItems[8].Text));
            new_form.checkBox3.Checked = Convert.ToBoolean(Convert.ToInt32(listView1.SelectedItems[0].SubItems[9].Text));
            new_form.checkBox4.Checked = Convert.ToBoolean(Convert.ToInt32(listView1.SelectedItems[0].SubItems[10].Text));
            new_form.checkBox5.Checked = Convert.ToBoolean(Convert.ToInt32(listView1.SelectedItems[0].SubItems[11].Text));
            new_form.Owner = this;
            new_form.Mytpe = 1;
            new_form.ShowDialog();
            if (new_form.DialogResult == DialogResult.OK)
            {
                button1_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            string id = listView1.SelectedItems[0].Text;
            var url = "http://218.106.157.204:8090/api/user/DelUserbyId?id="+id;
           // MessageBox.Show(url);
            id=WebServer.GetMeth(url);
            button1_Click(sender, e);
        }
    }
}
