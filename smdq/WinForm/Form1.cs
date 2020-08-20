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

namespace smdq
{
    public class PublicValue
    {
        public static string MyURL= "http://www.cltlkj.cn:8090/api/";
        public static string LoginToken = "";
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = PublicValue.MyURL+ $"Login?UserName={textBox1.Text}&pwd={textBox2.Text}";
            string json = WebServer.GetMeth(url);           
            MyToken token = WebServer.GetResult<MyToken>(json);
            PublicValue.LoginToken = token.token;
            mainform new_form = new mainform();
            new_form.Owner = this;
            this.Hide();
            new_form.WindowState = FormWindowState.Maximized;
            new_form.ShowDialog();
            Application.ExitThread(); Application.ExitThread();
        }     
    }
}
