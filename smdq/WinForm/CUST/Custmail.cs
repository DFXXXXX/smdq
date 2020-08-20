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

namespace smdq.WinForm.CUST
{
    public partial class Custmail : Form
    {
        public Custmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string url = PublicValue.MyURL + $"Cust/GetCustbyString?str={textBox1.Text}";

            var sjson = WebServer.GetMeth(url);
            List<Cust> twoList = WebServer.GetResult<List<Cust>>(sjson);
            if (twoList== null)
                return;

            foreach (Cust stu in twoList)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = stu.CustId.ToString();
                item1.SubItems.Add(stu.CustName);
                if (stu.CustType == 1)
                {
                    item1.SubItems.Add("同行客户");
                }
                else {
                    item1.SubItems.Add("到店客户");
                }
                
                item1.SubItems.Add(stu.CustTel);
                item1.SubItems.Add(stu.CustAdr);
                item1.SubItems.Add(stu.CustLv.ToString());
                item1.SubItems.Add(stu.CustAmount.ToString());
                item1.SubItems.Add(stu.CustRem);
                listView1.Items.Add(item1);                   //添加集体进去
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var new_form = new AddCust()
            {
                Owner = this,
                Mytpe = 0
            };
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
            AddCust new_form = new AddCust();
            new_form.t_ID.Text = listView1.SelectedItems[0].Text;
            new_form.t_ID.Enabled = false;
            new_form.t_Name.Text = listView1.SelectedItems[0].SubItems[1].Text;
            new_form.t_Name.Enabled = false;
            new_form.t_tel.Text = listView1.SelectedItems[0].SubItems[3].Text;
            new_form.t_adr.Text = listView1.SelectedItems[0].SubItems[4].Text;
            new_form.t_jr.Text = listView1.SelectedItems[0].SubItems[6].Text;
            new_form.t_rem.Text= listView1.SelectedItems[0].SubItems[7].Text;
            new_form.button1.Text = "修改";
            if (listView1.SelectedItems[0].SubItems[2].Text == "到店客户")
            {
                new_form.comboBox1.SelectedIndex = 0;
            }
            else
            {
                new_form.comboBox1.SelectedIndex = 1;
            }

            new_form.Owner = this;
            new_form.Mytpe = 1;
            new_form.ShowDialog();
            if (new_form.DialogResult == DialogResult.OK)
            {
                button1_Click(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            string id = listView1.SelectedItems[0].Text;
            var url = "http://218.106.157.204:8090/api/Cust/DelCustbyId?id=" + id;
            // MessageBox.Show(url);
            id = WebServer.GetMeth(url);
            
            button1_Click(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
