using smdq.WinForm.CUST;
using smdq.WinForm.ITEM;
using smdq.WinForm.SUP;
using smdq.WinForm.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smdq
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var new_form = new Custmail
            {
                Owner = this
            };
            new_form.ShowDialog();
        }

        private void 添加帐号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTable new_form = new UserTable();
            new_form.Owner = this;            
            new_form.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var new_form = new SupForm()
            {
                Owner = this
            };
            new_form.ShowDialog();
        }

        private void 仓库管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var new_form = new ItemForm()
            {
                Owner = this
            };
            new_form.ShowDialog();
        }
    }
}
