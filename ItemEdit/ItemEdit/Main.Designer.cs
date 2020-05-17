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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_codition = new System.Windows.Forms.Label();
            this.lbltaskdesc = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.List_Task = new System.Windows.Forms.ListBox();
            this.Tab_System = new System.Windows.Forms.TabPage();
            this.tab_items = new System.Windows.Forms.TabPage();
            this.lbl_type_name = new System.Windows.Forms.Label();
            this.cb_items_list = new System.Windows.Forms.ComboBox();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.tab_copy = new System.Windows.Forms.TabPage();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_sel_dis = new System.Windows.Forms.Button();
            this.btn_sel_base_path = new System.Windows.Forms.Button();
            this.txt_dis_path = new System.Windows.Forms.TextBox();
            this.txt_base_path = new System.Windows.Forms.TextBox();
            this.txt_abs_path_list = new System.Windows.Forms.TextBox();
            this.tab_mods = new System.Windows.Forms.TabPage();
            this.btnSaveMod = new System.Windows.Forms.Button();
            this.lblMaxStackCount = new System.Windows.Forms.Label();
            this.nud_MaxStackCount = new System.Windows.Forms.NumericUpDown();
            this.cbx_modlist = new System.Windows.Forms.ComboBox();
            this.CMS_ListTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_avaviableforsuccess = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Success = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clear_cache = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDpmc)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab_UserProfile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Tab_System.SuspendLayout();
            this.tab_items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.tab_copy.SuspendLayout();
            this.tab_mods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxStackCount)).BeginInit();
            this.CMS_ListTask.SuspendLayout();
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
            this.listBox1.Size = new System.Drawing.Size(969, 580);
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
            this.tabControl2.Controls.Add(this.tab_items);
            this.tabControl2.Controls.Add(this.tab_copy);
            this.tabControl2.Controls.Add(this.tab_mods);
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
            // lbl_codition
            // 
            this.lbl_codition.Location = new System.Drawing.Point(3, 348);
            this.lbl_codition.Name = "lbl_codition";
            this.lbl_codition.Size = new System.Drawing.Size(409, 233);
            this.lbl_codition.TabIndex = 2;
            // 
            // lbltaskdesc
            // 
            this.lbltaskdesc.Location = new System.Drawing.Point(3, 50);
            this.lbltaskdesc.Name = "lbltaskdesc";
            this.lbltaskdesc.Size = new System.Drawing.Size(409, 298);
            this.lbltaskdesc.TabIndex = 1;
            // 
            // lblTaskName
            // 
            this.lblTaskName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskName.Location = new System.Drawing.Point(0, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(415, 23);
            this.lblTaskName.TabIndex = 0;
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
            // tab_items
            // 
            this.tab_items.Controls.Add(this.lbl_type_name);
            this.tab_items.Controls.Add(this.cb_items_list);
            this.tab_items.Controls.Add(this.DGV_Items);
            this.tab_items.Location = new System.Drawing.Point(4, 22);
            this.tab_items.Name = "tab_items";
            this.tab_items.Padding = new System.Windows.Forms.Padding(3);
            this.tab_items.Size = new System.Drawing.Size(992, 670);
            this.tab_items.TabIndex = 2;
            this.tab_items.Text = "物品数据库";
            this.tab_items.UseVisualStyleBackColor = true;
            // 
            // lbl_type_name
            // 
            this.lbl_type_name.AutoSize = true;
            this.lbl_type_name.Location = new System.Drawing.Point(8, 9);
            this.lbl_type_name.Name = "lbl_type_name";
            this.lbl_type_name.Size = new System.Drawing.Size(29, 12);
            this.lbl_type_name.TabIndex = 2;
            this.lbl_type_name.Text = "类型";
            // 
            // cb_items_list
            // 
            this.cb_items_list.FormattingEnabled = true;
            this.cb_items_list.Location = new System.Drawing.Point(43, 6);
            this.cb_items_list.Name = "cb_items_list";
            this.cb_items_list.Size = new System.Drawing.Size(193, 20);
            this.cb_items_list.TabIndex = 1;
            this.cb_items_list.SelectedIndexChanged += new System.EventHandler(this.cb_items_list_SelectedIndexChanged);
            // 
            // DGV_Items
            // 
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Location = new System.Drawing.Point(8, 32);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.RowTemplate.Height = 23;
            this.DGV_Items.Size = new System.Drawing.Size(981, 638);
            this.DGV_Items.TabIndex = 0;
            // 
            // tab_copy
            // 
            this.tab_copy.Controls.Add(this.btn_copy);
            this.tab_copy.Controls.Add(this.btn_sel_dis);
            this.tab_copy.Controls.Add(this.btn_sel_base_path);
            this.tab_copy.Controls.Add(this.txt_dis_path);
            this.tab_copy.Controls.Add(this.txt_base_path);
            this.tab_copy.Controls.Add(this.txt_abs_path_list);
            this.tab_copy.Location = new System.Drawing.Point(4, 22);
            this.tab_copy.Name = "tab_copy";
            this.tab_copy.Padding = new System.Windows.Forms.Padding(3);
            this.tab_copy.Size = new System.Drawing.Size(992, 670);
            this.tab_copy.TabIndex = 3;
            this.tab_copy.Text = "批量拷贝";
            this.tab_copy.UseVisualStyleBackColor = true;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(894, 340);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 5;
            this.btn_copy.Text = "拷贝";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_sel_dis
            // 
            this.btn_sel_dis.Location = new System.Drawing.Point(894, 311);
            this.btn_sel_dis.Name = "btn_sel_dis";
            this.btn_sel_dis.Size = new System.Drawing.Size(75, 23);
            this.btn_sel_dis.TabIndex = 4;
            this.btn_sel_dis.Text = "目标路径";
            this.btn_sel_dis.UseVisualStyleBackColor = true;
            this.btn_sel_dis.Click += new System.EventHandler(this.btn_sel_dis_Click);
            // 
            // btn_sel_base_path
            // 
            this.btn_sel_base_path.Location = new System.Drawing.Point(233, 311);
            this.btn_sel_base_path.Name = "btn_sel_base_path";
            this.btn_sel_base_path.Size = new System.Drawing.Size(75, 23);
            this.btn_sel_base_path.TabIndex = 3;
            this.btn_sel_base_path.Text = "根路径";
            this.btn_sel_base_path.UseVisualStyleBackColor = true;
            this.btn_sel_base_path.Click += new System.EventHandler(this.btn_sel_base_path_Click);
            // 
            // txt_dis_path
            // 
            this.txt_dis_path.Location = new System.Drawing.Point(691, 311);
            this.txt_dis_path.Name = "txt_dis_path";
            this.txt_dis_path.ReadOnly = true;
            this.txt_dis_path.Size = new System.Drawing.Size(196, 21);
            this.txt_dis_path.TabIndex = 2;
            // 
            // txt_base_path
            // 
            this.txt_base_path.Location = new System.Drawing.Point(3, 311);
            this.txt_base_path.Name = "txt_base_path";
            this.txt_base_path.ReadOnly = true;
            this.txt_base_path.Size = new System.Drawing.Size(224, 21);
            this.txt_base_path.TabIndex = 1;
            // 
            // txt_abs_path_list
            // 
            this.txt_abs_path_list.Location = new System.Drawing.Point(325, 0);
            this.txt_abs_path_list.MaxLength = 3276700;
            this.txt_abs_path_list.Multiline = true;
            this.txt_abs_path_list.Name = "txt_abs_path_list";
            this.txt_abs_path_list.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_abs_path_list.Size = new System.Drawing.Size(360, 670);
            this.txt_abs_path_list.TabIndex = 0;
            // 
            // tab_mods
            // 
            this.tab_mods.Controls.Add(this.btn_clear_cache);
            this.tab_mods.Controls.Add(this.btnSaveMod);
            this.tab_mods.Controls.Add(this.lblMaxStackCount);
            this.tab_mods.Controls.Add(this.nud_MaxStackCount);
            this.tab_mods.Controls.Add(this.cbx_modlist);
            this.tab_mods.Location = new System.Drawing.Point(4, 22);
            this.tab_mods.Name = "tab_mods";
            this.tab_mods.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mods.Size = new System.Drawing.Size(992, 670);
            this.tab_mods.TabIndex = 4;
            this.tab_mods.Text = "Mods";
            this.tab_mods.UseVisualStyleBackColor = true;
            // 
            // btnSaveMod
            // 
            this.btnSaveMod.Location = new System.Drawing.Point(217, 87);
            this.btnSaveMod.Name = "btnSaveMod";
            this.btnSaveMod.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMod.TabIndex = 3;
            this.btnSaveMod.Text = "保存";
            this.btnSaveMod.UseVisualStyleBackColor = true;
            this.btnSaveMod.Click += new System.EventHandler(this.btnSaveMod_Click);
            // 
            // lblMaxStackCount
            // 
            this.lblMaxStackCount.AutoSize = true;
            this.lblMaxStackCount.Location = new System.Drawing.Point(8, 90);
            this.lblMaxStackCount.Name = "lblMaxStackCount";
            this.lblMaxStackCount.Size = new System.Drawing.Size(77, 12);
            this.lblMaxStackCount.TabIndex = 2;
            this.lblMaxStackCount.Text = "弹药堆叠数量";
            // 
            // nud_MaxStackCount
            // 
            this.nud_MaxStackCount.Location = new System.Drawing.Point(91, 87);
            this.nud_MaxStackCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_MaxStackCount.Name = "nud_MaxStackCount";
            this.nud_MaxStackCount.Size = new System.Drawing.Size(120, 21);
            this.nud_MaxStackCount.TabIndex = 1;
            // 
            // cbx_modlist
            // 
            this.cbx_modlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_modlist.FormattingEnabled = true;
            this.cbx_modlist.Location = new System.Drawing.Point(6, 3);
            this.cbx_modlist.Name = "cbx_modlist";
            this.cbx_modlist.Size = new System.Drawing.Size(426, 20);
            this.cbx_modlist.TabIndex = 0;
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
            // btn_clear_cache
            // 
            this.btn_clear_cache.Location = new System.Drawing.Point(517, 7);
            this.btn_clear_cache.Name = "btn_clear_cache";
            this.btn_clear_cache.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_cache.TabIndex = 4;
            this.btn_clear_cache.Text = "清除缓存";
            this.btn_clear_cache.UseVisualStyleBackColor = true;
            this.btn_clear_cache.Click += new System.EventHandler(this.btn_clear_cache_Click);
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
            this.panel1.ResumeLayout(false);
            this.Tab_System.ResumeLayout(false);
            this.tab_items.ResumeLayout(false);
            this.tab_items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.tab_copy.ResumeLayout(false);
            this.tab_copy.PerformLayout();
            this.tab_mods.ResumeLayout(false);
            this.tab_mods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxStackCount)).EndInit();
            this.CMS_ListTask.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tab_items;
        private System.Windows.Forms.DataGridView DGV_Items;
        private System.Windows.Forms.ComboBox cb_items_list;
        private System.Windows.Forms.Label lbl_type_name;
        private System.Windows.Forms.TabPage tab_copy;
        private System.Windows.Forms.Button btn_sel_dis;
        private System.Windows.Forms.Button btn_sel_base_path;
        private System.Windows.Forms.TextBox txt_dis_path;
        private System.Windows.Forms.TextBox txt_base_path;
        private System.Windows.Forms.TextBox txt_abs_path_list;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TabPage tab_mods;
        private System.Windows.Forms.ComboBox cbx_modlist;
        private System.Windows.Forms.Label lblMaxStackCount;
        private System.Windows.Forms.NumericUpDown nud_MaxStackCount;
        private System.Windows.Forms.Button btnSaveMod;
        private System.Windows.Forms.Button btn_clear_cache;
    }
}

