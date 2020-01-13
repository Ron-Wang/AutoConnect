using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoConnect
{
    public partial class AutoConnect : Form
    {
        private System.Timers.Timer timer = new System.Timers.Timer();



        public AutoConnect()
        {
            InitializeComponent();
            CheckAccount();
            webBrowserConnect.ScriptErrorsSuppressed = true;
            webBrowserConnect.DocumentCompleted += webBrowserConnect_DocumentCompleted;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxName.Text.Equals("") || textBoxPassword.Text.Equals("") || textBoxTime.Text.Equals(""))
            {
                labelState.Text = "\n    输入有误，请检查！\n";
            }
            else
            {
                webBrowserConnect.Navigate("http://net.tsinghua.edu.cn/");
                labelState.Text = "\n    已开始自动连接\n\n    如未跳转登录成功界面，则用户名或密码有误\n";
                timer.Interval = 1000 * int.Parse(textBoxTime.Text);
                timer.Start();
                CreateFile();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            labelState.Text = "\n    已停止自动连接\n\n    如需断开网络请自行断开\n";
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            webBrowserConnect.Navigate("http://net.tsinghua.edu.cn/");
        }

        private void webBrowserConnect_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement unameById = webBrowserConnect.Document.GetElementById("uname");//用户名
            HtmlElement passById = webBrowserConnect.Document.GetElementById("pass");//密码
            HtmlElement connectById = webBrowserConnect.Document.GetElementById("connect");//登录按钮
            if (unameById == null || passById == null || connectById == null)
            {
                return;
            }
            unameById.SetAttribute("value", comboBoxName.Text);
            passById.SetAttribute("value", textBoxPassword.Text);
            connectById.InvokeMember("onclick");
            webBrowserConnect.Document.InvokeScript("eval", new string[] { "window.alert = null;" });
        }

        void CreateFile()
        {
            string filePath = Environment.CurrentDirectory + "/data.int";
            if (File.Exists(filePath) == false)//如果不存在就创建file文件
            {
                FileStream fs = new FileStream(filePath,FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                if (checkBoxPasswrord.Checked)
                {
                    bw.Write(true);
                    bw.Write(1);
                    bw.Write(comboBoxName.Text);
                    bw.Write(textBoxPassword.Text);
                }
                else
                {
                    bw.Write(false);
                }
                bw.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                bool isRemember = br.ReadBoolean();
                if (checkBoxPasswrord.Checked)
                {
                    if (isRemember)
                    {
                        int accountNum = br.ReadInt32();
                        string[] accountName = new string[accountNum];
                        string[] accountPW = new string[accountNum];
                        for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                        {
                            accountName[accountIndex] = br.ReadString();
                            accountPW[accountIndex] = br.ReadString();
                        }
                        int MarkIndex = accountNum;
                        for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                            if (accountName[accountIndex] == comboBoxName.Text)
                                MarkIndex = accountIndex;
                        fs.Close();
                        fs = new FileStream(filePath, FileMode.Open);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(true);
                        if (MarkIndex < accountNum)
                        {
                            bw.Write(accountNum);
                            bw.Write(comboBoxName.Text);
                            bw.Write(textBoxPassword.Text);
                            for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                                if (accountIndex != MarkIndex)
                                {
                                    bw.Write(accountName[accountIndex]);
                                    bw.Write(accountPW[accountIndex]);
                                }
                        }
                        else
                        {
                            ++accountNum;
                            bw.Write(accountNum);
                            bw.Write(comboBoxName.Text);
                            bw.Write(textBoxPassword.Text);
                            for (int accountIndex = 0; accountIndex < accountNum - 1; ++accountIndex)
                            {
                                bw.Write(accountName[accountIndex]);
                                bw.Write(accountPW[accountIndex]);
                            }
                        }
                        bw.Close();
                    }
                    else
                    {
                        fs.Close();
                        fs = new FileStream(filePath, FileMode.Open);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(true);
                        bw.Write(1);
                        bw.Write(comboBoxName.Text);
                        bw.Write(textBoxPassword.Text);
                        bw.Close();
                    }
                }
                else
                {
                    br.Close();
                    fs.Close();
                }
            }
        }

        void CheckAccount()
        {
            comboBoxName.Items.Clear();
            string filePath = Environment.CurrentDirectory + "/data.int";
            if (File.Exists(filePath) == true)
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                bool isRemember = br.ReadBoolean();
                if (isRemember)
                {
                    int accountNum = br.ReadInt32();
                    string[] accountName = new string[accountNum];
                    string[] accountPW = new string[accountNum];
                    for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                    {
                        accountName[accountIndex] = br.ReadString();
                        comboBoxName.Items.Add(accountName[accountIndex]);
                        accountPW[accountIndex] = br.ReadString();
                    }
                    br.Close();
                    comboBoxName.Text = accountName[0];
                    textBoxPassword.Text = accountPW[0];
                }
                fs.Close();
            }
        }

        void SelectAccount()
        {
            string filePath = Environment.CurrentDirectory + "/data.int";
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            bool isRemember = br.ReadBoolean();
            if (isRemember)
            {
                int accountNum = br.ReadInt32();
                string[] accountName = new string[accountNum];
                string[] accountPW = new string[accountNum];
                for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                {
                    accountName[accountIndex] = br.ReadString();
                    accountPW[accountIndex] = br.ReadString();
                }
                int MarkIndex = 0;
                for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                    if (accountName[accountIndex] == comboBoxName.Text)
                    {
                        MarkIndex = accountIndex;
                        textBoxPassword.Text = accountPW[accountIndex];
                    }
                fs.Close();
                fs = new FileStream(filePath, FileMode.Open);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(true);
                bw.Write(accountNum);
                bw.Write(comboBoxName.Text);
                bw.Write(textBoxPassword.Text);
                for (int accountIndex = 0; accountIndex < accountNum; ++accountIndex)
                    if (accountIndex != MarkIndex)
                    {
                        bw.Write(accountName[accountIndex]);
                        bw.Write(accountPW[accountIndex]);
                    }
                bw.Close();
            }
            br.Close();
            fs.Close();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectAccount();
        }

        private void comboBoxName_DropDown(object sender, EventArgs e)
        {
            CheckAccount();
        }
    }
}
