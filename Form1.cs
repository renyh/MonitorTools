using DigitalPlatform.SIP2;
using DigitalPlatform.SIP2.Request;
using DongshifangMessageInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 窗体装载和关闭

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetSipInfo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveSipInfo();

            // 窗口关闭前让循环退出
            this._cancel.Cancel();

            // 不再使用时，调用Dispose
            this._cancel.Dispose();
        }
        #endregion

        #region 保存界面参数

        public void GetSipInfo()
        {

            // 连接参数
            this.textBox_addr.Text = Properties.Settings.Default.SIPServerUrl;
            this.textBox_port.Text = Properties.Settings.Default.SIPServerPort;
            this.comboBox_encoding.Text = Properties.Settings.Default.SIPEncoding;

            // 登录参数
            this.textBox_username.Text = Properties.Settings.Default.SIPAccount;
            this.textBox_password.Text = Properties.Settings.Default.Password;
            this.textBox_locationCode.Text = Properties.Settings.Default.SipLoginCP;


            // 手机号
            this.textBox_photo.Text = Properties.Settings.Default.Photo;

            // 间隔秒数
            this.textBox_second.Text = Properties.Settings.Default.Second;
        }


        public void SaveSipInfo()
        {

            // 连接参数
            Properties.Settings.Default.SIPServerUrl = SipIP;
            Properties.Settings.Default.SIPServerPort = SipPort;
            Properties.Settings.Default.SIPEncoding = this.comboBox_encoding.Text.Trim();

            // 登录参数
            Properties.Settings.Default.SIPAccount = SipAccount;
            Properties.Settings.Default.Password = Password;
            Properties.Settings.Default.SipLoginCP = SipCP;


            // 手机号
            Properties.Settings.Default.Photo = Photo;

            // 间隔秒数
            Properties.Settings.Default.Second = Second;

            // 保存参数
            Properties.Settings.Default.Save();

        }
        public string SipIP
        {
            get
            {
                return this.textBox_addr.Text.Trim();
            }
        }
        public string SipPort
        {
            get
            {
                return this.textBox_port.Text.Trim();
            }
        }

        public string SipAccount
        {
            get
            {
                return this.textBox_username.Text.Trim();
            }
        }

        public string Password
        {
            get
            {
                return this.textBox_password.Text.Trim();
            }
        }

        public string SipCP
        {
            get
            {
                return this.textBox_locationCode.Text.Trim();
            }
        }

        Encoding _encoding
        {
            get
            {
                Encoding encoding = Encoding.UTF8;
                this.Invoke(new Action(() =>
                {

                    string strEncoding = this.comboBox_encoding.Text.Trim();
                    if (string.IsNullOrEmpty(strEncoding))
                        encoding= Encoding.UTF8;
                    else
                        encoding= Encoding.GetEncoding(strEncoding);
                }));

                return encoding;
            }
        }

        public string Second
        {
            get
            {
                return this.textBox_second.Text.Trim();
            }
        }


        public string Photo
        {
            get
            {
                return this.textBox_photo.Text.Trim();
            }
        }


        #endregion

        #region 按钮触发

        // 测试发送短信
        private void button_send_Click(object sender, EventArgs e)
        {
            string error = "";
            string photo = this.textBox_photo.Text.Trim();
            string message = this.textBox_messge.Text.Trim();
            int nRet = DongshifangMessageHost.SendMessage(photo,
                message,
                "",
                out error);
            if (nRet <= 0)
            {
                MessageBox.Show(this, "发送短信失败:" + error);
                return;
            }
            else
            {
                MessageBox.Show(this, "发送短信成功"+nRet+"条");
                return;
            }
        }


        // 测试连接
        private void button_connection_Click(object sender, EventArgs e)
        {
            string error = "";
            int nRet = this.Connection(out error);
            if (nRet == -1)
            {
                MessageBox.Show(this, error);
                return;
            }

            MessageBox.Show("连接服务器成功");
            return;
        }

        // 测试登录
        private void button_login_Click(object sender, EventArgs e)
        {
            string error = "";
            int nRet = this.login(out error);
            if (nRet == -1)
            {
                MessageBox.Show(this, "登录出错："+error);
                return;
            }

            MessageBox.Show("登录成功");
            return;
        }

        // 清除通讯信息
        private void button_clear_Click(object sender, EventArgs e)
        {
            this.ClearHtml();
        }
        // 测试发送99
        private void button_send99_Click(object sender, EventArgs e)
        {
            string message = "9900302.00";
            string cmdText = message;
            this.PrintSafe("send:" + cmdText);
            BaseMessage response = null;
            int nRet = SCHelper.Instance.SendAndRecvMessage(cmdText,
                out response,
                out string responseText,
                out string error);
            if (nRet == -1)
            {
                this.PrintSafe("error:" + error);
            }
            else
            {
                this.PrintSafe("recv:" + responseText);
            }
        }

        #endregion

        #region 通用函数

        // 连接
        private int Connection(out string error)
        {
            error = "";

            int nPort = 0;
            try
            {
                nPort = int.Parse(SipPort);
            }
            catch (Exception ex)
            {
                error = "端口[" + SipPort + "]不合法，必须是数字。";
                return -1;
            }

            string server = this.SipIP + ":" + this.SipPort;
            bool bRet = SCHelper.Instance.Connection(SipIP, nPort, _encoding, out error);
            if (bRet == false) // 出错
            {
                error = "连接服务器[" + server + "]出错：" + error;
                this.Print(error);
                return -1;
            }
            else
            {
                string info = "连接服务器[" + server + "]成功";
                this.Print(info);
                return 0;
            }
        }

        // 登录
        private int login(out string error)
        {
            string responseText = "";
             error = "";

            Login_93 request = new Login_93()
            {
                UIDAlgorithm_1 = " ",
                PWDAlgorithm_1 = " ",

                CN_LoginUserId_r = SipAccount,
                CO_LoginPassword_r = Password,
                CP_LocationCode_o = SipCP
            };
            string cmdText = request.ToText();

            this.Print("send:" + cmdText);
            BaseMessage response = null;
            int nRet = SCHelper.Instance.SendAndRecvMessage(cmdText,
                out response,
                out responseText,
                out error);
            if (nRet == -1)
            {
                MessageBox.Show(error);
                this.Print("error:" + error);
                return -1;
            }

            this.Print("recv:" + responseText);
            return nRet;
        }

        // 发送消息，接收消息
        public int SendAndRecvMessage(TcpClientWrapper clientWrapper,
            string requestText,
            out BaseMessage response,
            out string responseText,
            out string error)
        {
            error = "";
            response = null;
            responseText = "";
            int nRet = 0;

            if (clientWrapper == null)
            {
                error = "尚未创建TcpClient对象";
                return -1;
            }

            // 校验消息
            BaseMessage request = null;
            nRet = SIPUtility.ParseMessage(requestText, out request, out error);
            if (nRet == -1)
            {
                error = "校验发送消息异常:" + error;
                return -1;
            }

            // 发送消息
            nRet = clientWrapper.SendMessage(requestText, out error);
            if (nRet == -1)
            {
                error = "发送消息出错:" + error;
                return -1;
            }

            // 接收消息
            nRet = clientWrapper.RecvMessage(out responseText, out error);
            if (nRet == -1)
            {
                error = "接收消息出错:" + error;
                return -1;
            }

            //解析返回的消息
            nRet = SIPUtility.ParseMessage(responseText, out response, out error);
            if (nRet == -1)
            {
                error = "解析返回的消息异常:" + error + "\r\n" + responseText;
                return -1;
            }

            return 0;
        }

        #endregion

        #region 监控线程

        // 名字以用途命名即可。TokenSource 这种类型名称可以不出现在名字中
        CancellationTokenSource _cancel = new CancellationTokenSource();

        private void button_start_Click(object sender, EventArgs e)
        {
            // 检查手机号参数
            if (this.Photo.Length != 11)
            {
                MessageBox.Show(this, "手机号必须是11位");
                return;
            }

            // 检查秒数参数
            int nSecond = 0;
            try
            {
                nSecond = int.Parse(Second);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "秒数[" + Second + "]不合法，必须是数字。");
                return;
            }
           
            // 每次开头都重新 new 一个。这样避免受到上次遗留的 _cancel 对象的状态影响
            this._cancel.Dispose();
            this._cancel = new CancellationTokenSource();
            // 启动一个线程
            Task.Run(() =>
            {
                Monitor(this._cancel.Token,nSecond,Photo);
            });
        }

        // 停止
        private void button_stop_Click(object sender, EventArgs e)
        {
            // 停止
            this._cancel.Cancel();
        }

        int _seed = 0;

        // 干活
        void Monitor(CancellationToken token,int second,string photo)
        {
            // 设置按钮状态
            this.Invoke((Action)(() =>
                EnableControls(false)
                ));
            try
            {
                // 将跳转序号置为0
                this._seed = 0;

                while (token.IsCancellationRequested == false)
                {
                    // 中断也可以用
                    //token.ThrowIfCancellationRequested();

                    string error = "";

                    string requestText = "";
                    string responseText = "";
                    int nRet = this.doOnething(out requestText,
                        out responseText,
                        out error);
                    if (nRet == -1)
                    {
                        string sms = GetServerInfo() + error + "--" + responseText ;
                        this.PrintSafe(sms);  // 把出错信息打印在屏幕上

                        // 因为发短信要收钱，所以加了一个开关，测试的时候，可以关闭短信
                        if (IsSendSMS == true)
                        {
                            // 发送短信

                            if (sms.Length > 60)
                            {
                                sms = sms.Substring(0, 60);  // 1条短信最多70字符
                            }
                            this.PrintSafe("手机号[" + photo + "]，短信内容:" + sms);
                            nRet = DongshifangMessageHost.SendMessage(photo,
                                sms,
                                "",
                                out error);
                            if (nRet <= 0)
                                this.PrintSafe("发送短信失败:" + error);
                            else
                                this.PrintSafe("发送短信成功。");
                        }
                    }

                    Thread.Sleep(1000 * second);//间隔秒数
                }
            }
            finally
            {
                // 设置按置状态
                this.Invoke((Action)(() =>
                    EnableControls(true)
                    ));
            }
        }

        public int doOnething(out string requestText,
            out string responseText,
            out string error)
        {
            error = "";
            requestText = "";
            responseText = "";


            // 端口
            int nPort = 0;
            try
            {
                nPort = int.Parse(SipPort);
            }
            catch (Exception ex)
            {
                throw new Exception("端口[" + SipPort + "]不合法，必须是数字。");
            }

            _seed++;
            this.PrintSafe(_seed.ToString()); // 打印一个序号

            TcpClientWrapper clientWrapper = new TcpClientWrapper(this._encoding);
            try
            {

                // 连接
                string server = this.SipIP + ":" + this.SipPort;
                bool bRet = clientWrapper.Connection(this.SipIP, nPort, out error);
                if (bRet == false) // 出错
                {
                    error = "连接出错：" + error;
                    this.Print(error);
                    return -1;
                }

                string info = "连接服务器[" + server + "]成功";
                this.Print(info);


                // 登录
                Login_93 request = new Login_93()
                {
                    UIDAlgorithm_1 = " ",
                    PWDAlgorithm_1 = " ",

                    CN_LoginUserId_r = SipAccount,
                    CO_LoginPassword_r = Password,
                    CP_LocationCode_o = SipCP
                };
                requestText = request.ToText();

                this.Print("send:" + requestText);
                BaseMessage response = null;
                int nRet = this.SendAndRecvMessage(clientWrapper,
                    requestText,
                    out response,
                    out responseText,
                    out error);
                this.Print("recv:" + responseText);
                if (nRet == -1)
                {
                    this.Print("error:" + error);
                    return -1;
                }
                // 检查登录是否出错
                if (responseText.Length > 3 && responseText.Substring(2, 1) == "0")
                {
                    error = "登录异常";
                    return -1;
                }    


                // 发送99
                requestText = "9900302.00";
                this.PrintSafe("send:" + requestText);
                nRet = this.SendAndRecvMessage(clientWrapper,
                    requestText,
                    out response,
                    out responseText,
                    out error);
                this.Print("recv:" + responseText);
                if (nRet == -1)
                {
                    this.PrintSafe("error:" + error);
                    return -1;
                }
                // 检查98是否出错
                if (responseText.Length > 3 && responseText.Substring(2, 1) == "N")
                {
                    error = "98异常";
                    return -1;
                }

                return 0;
            }
            finally
            {
                clientWrapper.Close();
                clientWrapper = null;
            }
        }

        public void PrintSafe(string info)
        {
            // 界面显示信息
            this.Invoke((Action)(() =>
            {
                this.Print(info);
            }
            ));
        }

        public string GetServerInfo()
        {
            string info = "";
            // 界面显示信息
            this.Invoke((Action)(() =>
            {
                info= this.SipIP + ":" + this.SipPort;
            }
            ));

            return info;
        }


        public bool IsSendSMS
        {
            get
            {
                bool bRet = false;
                // 界面显示信息
                this.Invoke((Action)(() =>
                {
                    bRet = this.checkBox1.Checked;
                }
                ));

                return bRet;
            }
        }

        // 设置控件是否可用
        void EnableControls(bool bEnable)
        {
            this.button_start.Enabled = bEnable;
            this.button_stop.Enabled = !(bEnable);

            this.button_send.Enabled = bEnable;

            this.checkBox1.Enabled = bEnable;
        }

        #endregion


        #region 输出信息浏览器通用函数

        private void Print(string strHtml)
        {
            strHtml = String.Format("{0}  {1}<br />", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strHtml);
            WriteHtml(this.webBrowser1,
                strHtml);
        }

        // 不支持异步调用
        public  void WriteHtml(WebBrowser webBrowser,
            string strHtml)
        {
            this.Invoke(new Action(() =>
            {
                HtmlDocument doc = webBrowser.Document;

                if (doc == null)
                {
                    webBrowser.Navigate("about:blank");
                    doc = webBrowser.Document;
                    doc.Write("<pre>");
                }

                doc.Write(strHtml);

                // 保持末行可见
                ScrollToEnd(webBrowser);
            }));
        }

        public void ClearHtml()
        {
            HtmlDocument doc = webBrowser1.Document;

            if (doc == null)
            {
                webBrowser1.Navigate("about:blank");
                doc = webBrowser1.Document;
            }
            doc = doc.OpenNew(true);
            doc.Write("<pre>");
        }


        public static void ScrollToEnd(WebBrowser webBrowser1)
        {
            if (webBrowser1.Document != null
                && webBrowser1.Document.Window != null
                && webBrowser1.Document.Body != null)
                webBrowser1.Document.Window.ScrollTo(
                    0,
                    webBrowser1.Document.Body.ScrollRectangle.Height);
        }

        #endregion

    }
}
