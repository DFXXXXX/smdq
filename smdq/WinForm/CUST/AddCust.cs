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

namespace smdq.WinForm.CUST
{
    public partial class AddCust : Form
    {
        public AddCust()
        {
            InitializeComponent();
        }

        public int Mytpe { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mytpe == 0)
            {
                var us = new Cust
                {
                    CustName = t_Name.Text,
                    CustAdr = t_adr.Text,
                    CustTel = t_tel.Text,
                    CustRem = t_rem.Text,
                    CustType = comboBox1.SelectedIndex,
                    CustAmount = Convert.ToInt32(t_jr.Text)
                };
                string jsonData = JsonConvert.SerializeObject(us);
                var url = "http://www.cltlkj.cn:8090/api/Cust/CreateCust";
                var res = WebServer.PostMeth(url, jsonData);
            }
            else
            {
                var us = new Cust
                {
                    CustId = Convert.ToInt32(t_ID.Text),
                    CustName = t_Name.Text,
                    CustAdr = t_adr.Text,
                    CustTel = t_tel.Text,
                    CustRem = t_rem.Text,
                    CustType = comboBox1.SelectedIndex,
                    CustAmount = Convert.ToInt32(t_jr.Text)
                };
                string jsonData = JsonConvert.SerializeObject(us);
                var url = "http://www.cltlkj.cn:8090/api/Cust/UpdateCust";
                var res = WebServer.PostMeth(url, jsonData);

            }
        }

        private void AddCust_Load(object sender, EventArgs e)
        {

        }
    }
}
