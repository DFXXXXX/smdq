namespace smdq.WinForm.ITEM
{
    partial class ItemForm
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
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.备注 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.售价 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.成本价 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.名称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.条形码 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.编号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.数量 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(640, 583);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 40);
            this.button5.TabIndex = 20;
            this.button5.Text = "启用";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "新建";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // 备注
            // 
            this.备注.Text = "备注";
            this.备注.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.备注.Width = 346;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // 售价
            // 
            this.售价.Text = "售价";
            this.售价.Width = 103;
            // 
            // 成本价
            // 
            this.成本价.Text = "成本价";
            this.成本价.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.成本价.Width = 165;
            // 
            // 名称
            // 
            this.名称.Text = "名称";
            this.名称.Width = 155;
            // 
            // 条形码
            // 
            this.条形码.Text = "条形码";
            this.条形码.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.条形码.Width = 187;
            // 
            // 编号
            // 
            this.编号.Text = "编号";
            this.编号.Width = 50;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.编号,
            this.条形码,
            this.名称,
            this.成本价,
            this.售价,
            this.数量,
            this.备注});
            this.listView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(11, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1070, 526);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 数量
            // 
            this.数量.Text = "数量";
            this.数量.Width = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 21);
            this.textBox1.TabIndex = 14;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 636);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仓库管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader 备注;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader 售价;
        private System.Windows.Forms.ColumnHeader 成本价;
        private System.Windows.Forms.ColumnHeader 名称;
        private System.Windows.Forms.ColumnHeader 条形码;
        private System.Windows.Forms.ColumnHeader 编号;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 数量;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}