namespace ItemEdit
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveBOTRefPr = new System.Windows.Forms.Button();
            this.NUDUsec = new System.Windows.Forms.NumericUpDown();
            this.NUDpmc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.cb_profile_list = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_UserProfile = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.List_Task = new System.Windows.Forms.ListBox();
            this.Tab_System = new System.Windows.Forms.TabPage();
            this.CMS_ListTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_avaviableforsuccess = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Success = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lbltaskdesc = new System.Windows.Forms.Label();
            this.lbl_codition = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDpmc)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab_UserProfile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Tab_System.SuspendLayout();
            this.CMS_ListTask.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(650, 196);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 664);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "全局属性编辑";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveBOTRefPr);
            this.groupBox1.Controls.Add(this.NUDUsec);
            this.groupBox1.Controls.Add(this.NUDpmc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "机器人刷新率";
            // 
            // btnSaveBOTRefPr
            // 
            this.btnSaveBOTRefPr.Location = new System.Drawing.Point(234, 23);
            this.btnSaveBOTRefPr.Name = "btnSaveBOTRefPr";
            this.btnSaveBOTRefPr.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBOTRefPr.TabIndex = 6;
            this.btnSaveBOTRefPr.Text = "保存";
            this.btnSaveBOTRefPr.UseVisualStyleBackColor = true;
            this.btnSaveBOTRefPr.Click += new System.EventHandler(this.btnSaveBOTRefPr_Click);
            // 
            // NUDUsec
            // 
            this.NUDUsec.Location = new System.Drawing.Point(178, 24);
            this.NUDUsec.Name = "NUDUsec";
            this.NUDUsec.Size = new System.Drawing.Size(50, 21);
            this.NUDUsec.TabIndex = 5;
            // 
            // NUDpmc
            // 
            this.NUDpmc.Location = new System.Drawing.Point(61, 25);
            this.NUDpmc.Name = "NUDpmc";
            this.NUDpmc.Size = new System.Drawing.Size(51, 21);
            this.NUDpmc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "USEC占比";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "PMC占比";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "物品查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(15, 17);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(53, 12);
            this.lbl_Account.TabIndex = 5;
            this.lbl_Account.Text = "游戏账号";
            // 
            // cb_profile_list
            // 
            this.cb_profile_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_profile_list.FormattingEnabled = true;
            this.cb_profile_list.Location = new System.Drawing.Point(85, 12);
            this.cb_profile_list.Name = "cb_profile_list";
            this.cb_profile_list.Size = new System.Drawing.Size(121, 20);
            this.cb_profile_list.TabIndex = 6;
            this.cb_profile_list.SelectedIndexChanged += new System.EventHandler(this.cb_profile_list_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(212, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_UserProfile);
            this.tabControl2.Controls.Add(this.Tab_System);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1000, 696);
            this.tabControl2.TabIndex = 9;
            // 
            // tab_UserProfile
            // 
            this.tab_UserProfile.Controls.Add(this.groupBox2);
            this.tab_UserProfile.Controls.Add(this.lbl_Account);
            this.tab_UserProfile.Controls.Add(this.btn_save);
            this.tab_UserProfile.Controls.Add(this.cb_profile_list);
            this.tab_UserProfile.Location = new System.Drawing.Point(4, 22);
            this.tab_UserProfile.Name = "tab_UserProfile";
            this.tab_UserProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tab_UserProfile.Size = new System.Drawing.Size(992, 670);
            this.tab_UserProfile.TabIndex = 0;
            this.tab_UserProfile.Text = "用户信息设置";
            this.tab_UserProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.List_Task);
            this.groupBox2.Location = new System.Drawing.Point(6, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 621);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "任务";
            // 
            // List_Task
            // 
            this.List_Task.ItemHeight = 12;
            this.List_Task.Location = new System.Drawing.Point(3, 17);
            this.List_Task.Name = "List_Task";
            this.List_Task.Size = new System.Drawing.Size(208, 592);
            this.List_Task.TabIndex = 11;
            this.List_Task.SelectedIndexChanged += new System.EventHandler(this.List_Task_SelectedIndexChanged);
            this.List_Task.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_Task_MouseDoubleClick);
            this.List_Task.MouseUp += new System.Windows.Forms.MouseEventHandler(this.List_Task_MouseUp);
            // 
            // Tab_System
            // 
            this.Tab_System.Controls.Add(this.tabControl1);
            this.Tab_System.Location = new System.Drawing.Point(4, 22);
            this.Tab_System.Name = "Tab_System";
            this.Tab_System.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_System.Size = new System.Drawing.Size(992, 670);
            this.Tab_System.TabIndex = 1;
            this.Tab_System.Text = "系统设置";
            this.Tab_System.UseVisualStyleBackColor = true;
            // 
            // CMS_ListTask
            // 
            this.CMS_ListTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_avaviableforsuccess,
            this.TSMI_Success,
            this.TSMI_Cancel});
            this.CMS_ListTask.Name = "CMS_ListTask";
            this.CMS_ListTask.Size = new System.Drawing.Size(137, 70);
            // 
            // TSMI_avaviableforsuccess
            // 
            this.TSMI_avaviableforsuccess.Name = "TSMI_avaviableforsuccess";
            this.TSMI_avaviableforsuccess.Size = new System.Drawing.Size(136, 22);
            this.TSMI_avaviableforsuccess.Text = "完成未提交";
            this.TSMI_avaviableforsuccess.Click += new System.EventHandler(this.TSMI_avaviableforsuccess_Click);
            // 
            // TSMI_Success
            // 
            this.TSMI_Success.Name = "TSMI_Success";
            this.TSMI_Success.Size = new System.Drawing.Size(136, 22);
            this.TSMI_Success.Text = "完成";
            this.TSMI_Success.Click += new System.EventHandler(this.TSMI_Success_Click);
            // 
            // TSMI_Cancel
            // 
            this.TSMI_Cancel.Name = "TSMI_Cancel";
            this.TSMI_Cancel.Size = new System.Drawing.Size(136, 22);
            this.TSMI_Cancel.Text = "取消";
            this.TSMI_Cancel.Click += new System.EventHandler(this.TSMI_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_codition);
            this.panel1.Controls.Add(this.lbltaskdesc);
            this.panel1.Controls.Add(this.lblTaskName);
            this.panel1.Location = new System.Drawing.Point(217, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 581);
            this.panel1.TabIndex = 12;
            // 
            // lblTaskName
            // 
            this.lblTaskName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskName.Location = new System.Drawing.Point(0, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(415, 23);
            this.lblTaskName.TabIndex = 0;
            // 
            // lbltaskdesc
            // 
            this.lbltaskdesc.Location = new System.Drawing.Point(3, 50);
            this.lbltaskdesc.Name = "lbltaskdesc";
            this.lbltaskdesc.Size = new System.Drawing.Size(409, 298);
            this.lbltaskdesc.TabIndex = 1;
            // 
            // lbl_codition
            // 
            this.lbl_codition.Location = new System.Drawing.Point(3, 348);
            this.lbl_codition.Name = "lbl_codition";
            this.lbl_codition.Size = new System.Drawing.Size(409, 233);
            this.lbl_codition.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 696);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "塔科夫修改器 By Dmankill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Main_MouseHover);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDpmc)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tab_UserProfile.ResumeLayout(false);
            this.tab_UserProfile.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Tab_System.ResumeLayout(false);
            this.CMS_ListTask.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUDUsec;
        private System.Windows.Forms.NumericUpDown NUDpmc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveBOTRefPr;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.ComboBox cb_profile_list;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_UserProfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage Tab_System;
        private System.Windows.Forms.ListBox List_Task;
        private System.Windows.Forms.ContextMenuStrip CMS_ListTask;
        private System.Windows.Forms.ToolStripMenuItem TSMI_avaviableforsuccess;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Success;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lbltaskdesc;
        private System.Windows.Forms.Label lbl_codition;
    }
}

