namespace MonitorTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_messge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_photo = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.comboBox_encoding = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.button_connection = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox_locationCode = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.textBox_second = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_send99 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_messge
            // 
            this.textBox_messge.Location = new System.Drawing.Point(98, 19);
            this.textBox_messge.Name = "textBox_messge";
            this.textBox_messge.Size = new System.Drawing.Size(187, 28);
            this.textBox_messge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "短信内容:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "手机号:";
            // 
            // textBox_photo
            // 
            this.textBox_photo.Location = new System.Drawing.Point(98, 53);
            this.textBox_photo.Name = "textBox_photo";
            this.textBox_photo.Size = new System.Drawing.Size(187, 28);
            this.textBox_photo.TabIndex = 2;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(98, 88);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(133, 31);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "测试发送短信";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // comboBox_encoding
            // 
            this.comboBox_encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_encoding.FormattingEnabled = true;
            this.comboBox_encoding.Items.AddRange(new object[] {
            "GB2312",
            "UTF-8"});
            this.comboBox_encoding.Location = new System.Drawing.Point(108, 93);
            this.comboBox_encoding.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_encoding.Name = "comboBox_encoding";
            this.comboBox_encoding.Size = new System.Drawing.Size(148, 26);
            this.comboBox_encoding.TabIndex = 3;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(17, 93);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(89, 18);
            this.label67.TabIndex = 2;
            this.label67.Text = "编码方式:";
            // 
            // button_connection
            // 
            this.button_connection.Location = new System.Drawing.Point(108, 127);
            this.button_connection.Margin = new System.Windows.Forms.Padding(4);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(112, 34);
            this.button_connection.TabIndex = 2;
            this.button_connection.Text = "测试连接";
            this.button_connection.UseVisualStyleBackColor = true;
            this.button_connection.Click += new System.EventHandler(this.button_connection_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(108, 57);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(148, 28);
            this.textBox_port.TabIndex = 2;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(17, 60);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(53, 18);
            this.label65.TabIndex = 2;
            this.label65.Text = "端口:";
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(108, 21);
            this.textBox_addr.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(195, 28);
            this.textBox_addr.TabIndex = 2;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(17, 24);
            this.label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(71, 18);
            this.label64.TabIndex = 2;
            this.label64.Text = "IP地址:";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(213, 176);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(423, 50);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "启动监控服务器(发送99)";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(98, 126);
            this.button_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(112, 34);
            this.button_login.TabIndex = 15;
            this.button_login.Text = "测试登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(98, 21);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(181, 28);
            this.textBox_username.TabIndex = 12;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(98, 54);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(181, 28);
            this.textBox_password.TabIndex = 11;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(7, 57);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(53, 18);
            this.label70.TabIndex = 0;
            this.label70.Text = "密码:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(7, 24);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(71, 18);
            this.label69.TabIndex = 0;
            this.label69.Text = "账户名:";
            // 
            // textBox_locationCode
            // 
            this.textBox_locationCode.Location = new System.Drawing.Point(98, 90);
            this.textBox_locationCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_locationCode.Name = "textBox_locationCode";
            this.textBox_locationCode.Size = new System.Drawing.Size(181, 28);
            this.textBox_locationCode.TabIndex = 17;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(7, 93);
            this.label71.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(35, 18);
            this.label71.TabIndex = 16;
            this.label71.Text = "CP:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 233);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(949, 374);
            this.webBrowser1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label64);
            this.groupBox1.Controls.Add(this.label65);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.textBox_addr);
            this.groupBox1.Controls.Add(this.button_connection);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.comboBox_encoding);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 168);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label69);
            this.groupBox2.Controls.Add(this.label70);
            this.groupBox2.Controls.Add(this.textBox_password);
            this.groupBox2.Controls.Add(this.label71);
            this.groupBox2.Controls.Add(this.textBox_locationCode);
            this.groupBox2.Controls.Add(this.textBox_username);
            this.groupBox2.Controls.Add(this.button_login);
            this.groupBox2.Location = new System.Drawing.Point(327, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 165);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_messge);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_photo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button_send);
            this.groupBox3.Location = new System.Drawing.Point(652, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 122);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(652, 176);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(160, 50);
            this.button_stop.TabIndex = 23;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textBox_second
            // 
            this.textBox_second.Location = new System.Drawing.Point(111, 184);
            this.textBox_second.Name = "textBox_second";
            this.textBox_second.Size = new System.Drawing.Size(95, 28);
            this.textBox_second.TabIndex = 24;
            this.textBox_second.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "间隔秒数:";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(834, 184);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(93, 31);
            this.button_clear.TabIndex = 26;
            this.button_clear.Text = "清除信息";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_send99
            // 
            this.button_send99.Location = new System.Drawing.Point(652, 140);
            this.button_send99.Name = "button_send99";
            this.button_send99.Size = new System.Drawing.Size(133, 31);
            this.button_send99.TabIndex = 27;
            this.button_send99.Text = "测试发送99";
            this.button_send99.UseVisualStyleBackColor = true;
            this.button_send99.Click += new System.EventHandler(this.button_send99_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 630);
            this.Controls.Add(this.button_send99);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_messge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_photo;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ComboBox comboBox_encoding;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox textBox_addr;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox textBox_locationCode;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox_second;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_send99;
    }
}

