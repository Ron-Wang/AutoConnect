using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class AutoTUNet : Form
    {
        private System.Timers.Timer timer = new System.Timers.Timer();
        public AutoTUNet()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                label4.Text = "\n    输入有误，请检查！\n";
            }
            else
            {
                webBrowser1.Navigate("http://net.tsinghua.edu.cn/");
                label4.Text = "\n    已开始自动连接\n\n    如未跳转登录成功界面，则用户名或密码有误\n";
                timer.Interval = 1000 * int.Parse(textBox3.Text);
                timer.Start();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label4.Text = "\n    已停止自动连接\n\n    如需断开网络请自行断开\n";
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            webBrowser1.Navigate("http://net.tsinghua.edu.cn/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement unameById = webBrowser1.Document.GetElementById("uname");//用户名
            HtmlElement passById = webBrowser1.Document.GetElementById("pass");//密码
            HtmlElement connectById = webBrowser1.Document.GetElementById("connect");//登录按钮
            if (unameById == null || passById == null || connectById == null)
            {
                return;
            }
            unameById.SetAttribute("value", textBox1.Text);
            passById.SetAttribute("value", textBox2.Text);
            connectById.InvokeMember("onclick");
            webBrowser1.Document.InvokeScript("eval", new string[] { "window.alert = null;" });
        }
    }
}
