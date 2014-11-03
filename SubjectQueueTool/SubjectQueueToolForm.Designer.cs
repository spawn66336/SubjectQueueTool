namespace SubjectQueueTool
{
    partial class SubjectQueueToolForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectQueueToolForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.DisplineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UserInfoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChangeFreqTextBox = new System.Windows.Forms.TextBox();
            this.FailBtn = new System.Windows.Forms.Button();
            this.PassBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CurrSubjectTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SubjectListTabCtrl = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.MainSortListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainSortTab = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.ChangFreqListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangeFreqSortTab = new DevComponents.DotNetBar.TabItem(this.components);
            this.EditSubjectListBtn = new DevComponents.DotNetBar.ButtonX();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DisplineLabel = new DevComponents.DotNetBar.LabelX();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectListTabCtrl)).BeginInit();
            this.SubjectListTabCtrl.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplineMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(706, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // DisplineMenuItem
            // 
            this.DisplineMenuItem.Name = "DisplineMenuItem";
            this.DisplineMenuItem.Size = new System.Drawing.Size(44, 21);
            this.DisplineMenuItem.Text = "科目";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DisplineLabel);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(706, 498);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.FailBtn);
            this.groupBox1.Controls.Add(this.PassBtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前题型";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UserInfoTextBox);
            this.groupBox4.Location = new System.Drawing.Point(9, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 62);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "页码";
            // 
            // UserInfoTextBox
            // 
            this.UserInfoTextBox.Enabled = false;
            this.UserInfoTextBox.Location = new System.Drawing.Point(6, 20);
            this.UserInfoTextBox.Name = "UserInfoTextBox";
            this.UserInfoTextBox.Size = new System.Drawing.Size(232, 21);
            this.UserInfoTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChangeFreqTextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "遗忘次数";
            // 
            // ChangeFreqTextBox
            // 
            this.ChangeFreqTextBox.Enabled = false;
            this.ChangeFreqTextBox.Location = new System.Drawing.Point(6, 20);
            this.ChangeFreqTextBox.Name = "ChangeFreqTextBox";
            this.ChangeFreqTextBox.Size = new System.Drawing.Size(232, 21);
            this.ChangeFreqTextBox.TabIndex = 0;
            // 
            // FailBtn
            // 
            this.FailBtn.BackColor = System.Drawing.Color.DarkRed;
            this.FailBtn.Location = new System.Drawing.Point(135, 263);
            this.FailBtn.Name = "FailBtn";
            this.FailBtn.Size = new System.Drawing.Size(118, 106);
            this.FailBtn.TabIndex = 2;
            this.FailBtn.Text = "不会做";
            this.FailBtn.UseVisualStyleBackColor = false;
            this.FailBtn.Click += new System.EventHandler(this.FailBtn_Click);
            // 
            // PassBtn
            // 
            this.PassBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.PassBtn.Location = new System.Drawing.Point(9, 263);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(118, 106);
            this.PassBtn.TabIndex = 1;
            this.PassBtn.Text = "会做";
            this.PassBtn.UseVisualStyleBackColor = false;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CurrSubjectTextBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "题型名称";
            // 
            // CurrSubjectTextBox
            // 
            this.CurrSubjectTextBox.Enabled = false;
            this.CurrSubjectTextBox.Location = new System.Drawing.Point(6, 20);
            this.CurrSubjectTextBox.Name = "CurrSubjectTextBox";
            this.CurrSubjectTextBox.Size = new System.Drawing.Size(232, 21);
            this.CurrSubjectTextBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SubjectListTabCtrl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.EditSubjectListBtn);
            this.splitContainer2.Size = new System.Drawing.Size(437, 498);
            this.splitContainer2.SplitterDistance = 468;
            this.splitContainer2.TabIndex = 1;
            // 
            // SubjectListTabCtrl
            // 
            this.SubjectListTabCtrl.CanReorderTabs = true;
            this.SubjectListTabCtrl.Controls.Add(this.tabControlPanel2);
            this.SubjectListTabCtrl.Controls.Add(this.tabControlPanel1);
            this.SubjectListTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectListTabCtrl.Location = new System.Drawing.Point(0, 0);
            this.SubjectListTabCtrl.Name = "SubjectListTabCtrl";
            this.SubjectListTabCtrl.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.SubjectListTabCtrl.SelectedTabIndex = 0;
            this.SubjectListTabCtrl.Size = new System.Drawing.Size(437, 468);
            this.SubjectListTabCtrl.TabIndex = 0;
            this.SubjectListTabCtrl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.SubjectListTabCtrl.Tabs.Add(this.MainSortTab);
            this.SubjectListTabCtrl.Tabs.Add(this.ChangeFreqSortTab);
            this.SubjectListTabCtrl.Text = "SubjectListTabCtrl";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.button1);
            this.tabControlPanel1.Controls.Add(this.MainSortListView);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(437, 442);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.MainSortTab;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainSortListView
            // 
            this.MainSortListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.MainSortListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSortListView.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainSortListView.FullRowSelect = true;
            this.MainSortListView.GridLines = true;
            this.MainSortListView.Location = new System.Drawing.Point(1, 1);
            this.MainSortListView.Name = "MainSortListView";
            this.MainSortListView.Size = new System.Drawing.Size(435, 440);
            this.MainSortListView.TabIndex = 0;
            this.MainSortListView.UseCompatibleStateImageBehavior = false;
            this.MainSortListView.View = System.Windows.Forms.View.Details;
            this.MainSortListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "题型名";
            this.columnHeader1.Width = 228;
            // 
            // MainSortTab
            // 
            this.MainSortTab.AttachedControl = this.tabControlPanel1;
            this.MainSortTab.Name = "MainSortTab";
            this.MainSortTab.Text = "熟练度";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.ChangFreqListView);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(437, 442);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.ChangeFreqSortTab;
            // 
            // ChangFreqListView
            // 
            this.ChangFreqListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.ChangFreqListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangFreqListView.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangFreqListView.GridLines = true;
            this.ChangFreqListView.Location = new System.Drawing.Point(1, 1);
            this.ChangFreqListView.Name = "ChangFreqListView";
            this.ChangFreqListView.Size = new System.Drawing.Size(435, 440);
            this.ChangFreqListView.TabIndex = 0;
            this.ChangFreqListView.UseCompatibleStateImageBehavior = false;
            this.ChangFreqListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "题型名";
            this.columnHeader2.Width = 326;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "遗忘频度";
            this.columnHeader3.Width = 248;
            // 
            // ChangeFreqSortTab
            // 
            this.ChangeFreqSortTab.AttachedControl = this.tabControlPanel2;
            this.ChangeFreqSortTab.Name = "ChangeFreqSortTab";
            this.ChangeFreqSortTab.Text = "遗忘频度";
            // 
            // EditSubjectListBtn
            // 
            this.EditSubjectListBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.EditSubjectListBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.EditSubjectListBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditSubjectListBtn.Location = new System.Drawing.Point(0, 0);
            this.EditSubjectListBtn.Name = "EditSubjectListBtn";
            this.EditSubjectListBtn.Size = new System.Drawing.Size(437, 26);
            this.EditSubjectListBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EditSubjectListBtn.TabIndex = 0;
            this.EditSubjectListBtn.Text = "编辑题型列表";
            this.EditSubjectListBtn.Click += new System.EventHandler(this.EditSubjectListBtn_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "做题遍数";
            this.columnHeader4.Width = 199;
            // 
            // DisplineLabel
            // 
            // 
            // 
            // 
            this.DisplineLabel.BackgroundStyle.Class = "";
            this.DisplineLabel.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisplineLabel.Location = new System.Drawing.Point(4, 15);
            this.DisplineLabel.Name = "DisplineLabel";
            this.DisplineLabel.Size = new System.Drawing.Size(252, 58);
            this.DisplineLabel.TabIndex = 1;
            this.DisplineLabel.Text = "请选择科目";
            this.DisplineLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "最近一次遗忘时间点";
            this.columnHeader5.Width = 150;
            // 
            // SubjectQueueToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 523);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectQueueToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考研数学题型熟练度列表管理器";
            this.Load += new System.EventHandler(this.SubjectQueueToolForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectListTabCtrl)).EndInit();
            this.SubjectListTabCtrl.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem DisplineMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FailBtn;
        private System.Windows.Forms.Button PassBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CurrSubjectTextBox;
        private DevComponents.DotNetBar.TabControl SubjectListTabCtrl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private System.Windows.Forms.ListView MainSortListView;
        private DevComponents.DotNetBar.TabItem MainSortTab;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private System.Windows.Forms.ListView ChangFreqListView;
        private DevComponents.DotNetBar.TabItem ChangeFreqSortTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ChangeFreqTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.ButtonX EditSubjectListBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox UserInfoTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.LabelX DisplineLabel;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}

