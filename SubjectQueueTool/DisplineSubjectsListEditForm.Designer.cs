namespace SubjectQueueTool
{
    partial class DisplineSubjectsListEditForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SubjectListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SortByFailedNumBtn = new DevComponents.DotNetBar.ButtonX();
            this.DelSubjectBtn = new DevComponents.DotNetBar.ButtonX();
            this.AddSubjectBtn = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SubjectListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SortByFailedNumBtn);
            this.splitContainer1.Panel2.Controls.Add(this.DelSubjectBtn);
            this.splitContainer1.Panel2.Controls.Add(this.AddSubjectBtn);
            this.splitContainer1.Size = new System.Drawing.Size(539, 508);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 0;
            // 
            // SubjectListView
            // 
            this.SubjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.SubjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectListView.GridLines = true;
            this.SubjectListView.Location = new System.Drawing.Point(0, 0);
            this.SubjectListView.Name = "SubjectListView";
            this.SubjectListView.Size = new System.Drawing.Size(539, 460);
            this.SubjectListView.TabIndex = 0;
            this.SubjectListView.UseCompatibleStateImageBehavior = false;
            this.SubjectListView.View = System.Windows.Forms.View.Details;
            this.SubjectListView.SelectedIndexChanged += new System.EventHandler(this.SubjectListView_SelectedIndexChanged);
            this.SubjectListView.DoubleClick += new System.EventHandler(this.SubjectListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "题型名称";
            this.columnHeader1.Width = 302;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "错题数";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "遗忘次数";
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "做了多少遍";
            this.columnHeader4.Width = 308;
            // 
            // SortByFailedNumBtn
            // 
            this.SortByFailedNumBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SortByFailedNumBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SortByFailedNumBtn.Location = new System.Drawing.Point(361, 4);
            this.SortByFailedNumBtn.Name = "SortByFailedNumBtn";
            this.SortByFailedNumBtn.Size = new System.Drawing.Size(174, 37);
            this.SortByFailedNumBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SortByFailedNumBtn.TabIndex = 2;
            this.SortByFailedNumBtn.Text = "按错题数排序";
            this.SortByFailedNumBtn.Click += new System.EventHandler(this.SortByFailedNumBtn_Click);
            // 
            // DelSubjectBtn
            // 
            this.DelSubjectBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DelSubjectBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DelSubjectBtn.Location = new System.Drawing.Point(182, 4);
            this.DelSubjectBtn.Name = "DelSubjectBtn";
            this.DelSubjectBtn.Size = new System.Drawing.Size(174, 37);
            this.DelSubjectBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DelSubjectBtn.TabIndex = 1;
            this.DelSubjectBtn.Text = "删除";
            this.DelSubjectBtn.Click += new System.EventHandler(this.DelSubjectBtn_Click);
            // 
            // AddSubjectBtn
            // 
            this.AddSubjectBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddSubjectBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddSubjectBtn.Location = new System.Drawing.Point(3, 4);
            this.AddSubjectBtn.Name = "AddSubjectBtn";
            this.AddSubjectBtn.Size = new System.Drawing.Size(174, 37);
            this.AddSubjectBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddSubjectBtn.TabIndex = 0;
            this.AddSubjectBtn.Text = "添加";
            this.AddSubjectBtn.Click += new System.EventHandler(this.AddSubjectBtn_Click);
            // 
            // DisplineSubjectsListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 508);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DisplineSubjectsListEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑科目题型";
            this.Load += new System.EventHandler(this.DisplineSubjectsListEditForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView SubjectListView;
        private DevComponents.DotNetBar.ButtonX SortByFailedNumBtn;
        private DevComponents.DotNetBar.ButtonX DelSubjectBtn;
        private DevComponents.DotNetBar.ButtonX AddSubjectBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}