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

namespace smdq.WinForm.ITEM
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var new_form = new AddItem()
            {
                Owner = this,
                Mytpe = 0
            };
            new_form.ShowDialog();
            if (new_form.DialogResult == DialogResult.OK)
            {
                Button1_Click(sender, e);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string url = $"http://218.106.157.204:8090/api/user/GetUserbyString?str={textBox1.Text}";

            var sjson = WebServer.GetMeth(url);
            //List<Cust> twoList = WebServer.GetResult<List<Cust>>(sjson);
            //foreach (Cust stu in twoList)
            //{
            //    ListViewItem item1 = new ListViewItem();
            //    item1.Text = stu.CustId.ToString();
            //    item1.SubItems.Add(stu.CustName);
            //    if (stu.CustType == 1)
            //    {
            //        item1.SubItems.Add("同行客户");
            //    }
            //    else
            //    {
            //        item1.SubItems.Add("到店客户");
            //    }

            //    item1.SubItems.Add(stu.CustTel);
            //    item1.SubItems.Add(stu.CustAdr);
            //    item1.SubItems.Add(stu.CustLv.ToString());
            //    item1.SubItems.Add(stu.CustAmount.ToString());
            //    item1.SubItems.Add(stu.CustRem);
            //    listView1.Items.Add(item1);                   //添加集体进去
            //}
            return;
        }
    }
}
