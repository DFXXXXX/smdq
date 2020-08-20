namespace smdq.WinForm.CUST
{
    partial class AddCust
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
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_jr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_adr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.t_rem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(79, 23);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(152, 21);
            this.t_ID.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "客户编号";
            // 
            // t_jr
            // 
            this.t_jr.Location = new System.Drawing.Point(79, 167);
            this.t_jr.Name = "t_jr";
            this.t_jr.Size = new System.Drawing.Size(152, 21);
            this.t_jr.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "挂单金额";
            // 
            // t_tel
            // 
            this.t_tel.Location = new System.Drawing.Point(79, 131);
            this.t_tel.Name = "t_tel";
            this.t_tel.Size = new System.Drawing.Size(152, 21);
            this.t_tel.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "客户电话";
            // 
            // t_adr
            // 
            this.t_adr.Location = new System.Drawing.Point(79, 95);
            this.t_adr.Name = "t_adr";
            this.t_adr.Size = new System.Drawing.Size(152, 21);
            this.t_adr.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "客户地址";
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(79, 59);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(152, 21);
            this.t_Name.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "客户姓名";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(79, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "客户类型";
            // 
            // t_rem
            // 
            this.t_rem.Location = new System.Drawing.Point(79, 239);
            this.t_rem.Name = "t_rem";
            this.t_rem.Size = new System.Drawing.Size(152, 21);
            this.t_rem.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "客户备注";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "到店客户",
            "同行客户"});
            this.comboBox1.Location = new System.Drawing.Point(78, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 20);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Text = "进店客户";
            // 
            // AddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 325);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.t_rem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_jr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_adr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.label1);
            this.Name = "AddCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增客户";
            this.Load += new System.EventHandler(this.AddCust_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox t_jr;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox t_tel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox t_adr;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox t_rem;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}