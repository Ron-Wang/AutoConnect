namespace AutoConnect
{
    partial class AutoConnect
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoConnect));
            this.webBrowserConnect = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxPasswrord = new System.Windows.Forms.CheckBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserConnect
            // 
            this.webBrowserConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserConnect.Location = new System.Drawing.Point(14, 132);
            this.webBrowserConnect.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowserConnect.Name = "webBrowserConnect";
            this.webBrowserConnect.Size = new System.Drawing.Size(706, 372);
            this.webBrowserConnect.TabIndex = 0;
            this.webBrowserConnect.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserConnect_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxName);
            this.panel1.Controls.Add(this.labelState);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.checkBoxPasswrord);
            this.panel1.Controls.Add(this.textBoxTime);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 111);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(115, 16);
            this.comboBoxName.MaxDropDownItems = 30;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(148, 22);
            this.comboBoxName.TabIndex = 11;
            this.comboBoxName.DropDown += new System.EventHandler(this.comboBoxName_DropDown);
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // labelState
            // 
            this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelState.BackColor = System.Drawing.SystemColors.Control;
            this.labelState.Location = new System.Drawing.Point(511, 14);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(192, 87);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "尚未开启AutoConnect";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(388, 49);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(117, 27);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "停止自动连接";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(388, 14);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 27);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "开始自动连接";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxPasswrord
            // 
            this.checkBoxPasswrord.AutoSize = true;
            this.checkBoxPasswrord.Location = new System.Drawing.Point(272, 49);
            this.checkBoxPasswrord.Name = "checkBoxPasswrord";
            this.checkBoxPasswrord.Size = new System.Drawing.Size(110, 18);
            this.checkBoxPasswrord.TabIndex = 6;
            this.checkBoxPasswrord.Text = "记住账号密码";
            this.checkBoxPasswrord.UseVisualStyleBackColor = true;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(173, 77);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(209, 23);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.Text = "300";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(115, 45);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(149, 23);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(6, 77);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(161, 26);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "检查连接时间（s）：";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(3, 44);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(106, 26);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "密码：";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(3, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(106, 26);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "用户名：";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowserConnect);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "AutoConnect";
            this.Text = "AutoConnect (Developed by Ron-Wang)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxPasswrord;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}

