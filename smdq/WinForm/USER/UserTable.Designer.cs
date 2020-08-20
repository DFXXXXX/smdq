namespace smdq.WinForm.USER
{
    partial class UserTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.编号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.用户名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.电话 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.地址 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.等级 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.入职时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.是否启用 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.权限1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.权限2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.权限3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.权限4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.权限5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.编号,
            this.用户名,
            this.电话,
            this.地址,
            this.等级,
            this.入职时间,
            this.是否启用,
            this.权限1,
            this.权限2,
            this.权限3,
            this.权限4,
            this.权限5});
            this.listView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1070, 526);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 编号
            // 
            this.编号.Text = "编号";
            // 
            // 用户名
            // 
            this.用户名.Text = "用户名";
            this.用户名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.用户名.Width = 116;
            // 
            // 电话
            // 
            this.电话.Text = "电话";
            this.电话.Width = 146;
            // 
            // 地址
            // 
            this.地址.Text = "地址";
            this.地址.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.地址.Width = 179;
            // 
            // 等级
            // 
            this.等级.Text = "等级";
            // 
            // 入职时间
            // 
            this.入职时间.Text = "入职时间";
            this.入职时间.Width = 158;
            // 
            // 是否启用
            // 
            this.是否启用.Text = "是否启用";
            this.是否启用.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.是否启用.Width = 86;
            // 
            // 权限1
            // 
            this.权限1.Text = "权限1";
            this.权限1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.权限1.Width = 47;
            // 
            // 权限2
            // 
            this.权限2.Text = "权限2";
            this.权限2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.权限2.Width = 56;
            // 
            // 权限3
            // 
            this.权限3.Text = "权限3";
            this.权限3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.权限3.Width = 51;
            // 
            // 权限4
            // 
            this.权限4.Text = "权限4";
            this.权限4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.权限4.Width = 49;
            // 
            // 权限5
            // 
            this.权限5.Text = "权限5";
            this.权限5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.权限5.Width = 49;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "新建";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(505, 580);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(641, 580);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "启用";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // UserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1091, 632);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员设定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 编号;
        private System.Windows.Forms.ColumnHeader 用户名;
        private System.Windows.Forms.ColumnHeader 是否启用;
        private System.Windows.Forms.ColumnHeader 权限1;
        private System.Windows.Forms.ColumnHeader 权限2;
        private System.Windows.Forms.ColumnHeader 权限3;
        private System.Windows.Forms.ColumnHeader 权限4;
        private System.Windows.Forms.ColumnHeader 权限5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader 电话;
        private System.Windows.Forms.ColumnHeader 等级;
        private System.Windows.Forms.ColumnHeader 入职时间;
        private System.Windows.Forms.ColumnHeader 地址;
    }
}