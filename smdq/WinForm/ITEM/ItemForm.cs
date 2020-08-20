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
            //WebProxy proxyObject = new WebProxy("106.56.201.251", 27833);
            //string URL = "http://www.cltlkj.cn:8090/api/getip";
            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URL);
            //req.Proxy = proxyObject; //设置代理 
            //req.Method = "GET";
            //string line = "";
            //using (WebResponse wr = req.GetResponse())
            //{
            //    Stream strm = wr.GetResponseStream();
            //    StreamReader sr = new StreamReader(strm);
            //    line = sr.ReadToEnd();               
            //}
            //MessageBox.Show(line);
        }
    }
}
