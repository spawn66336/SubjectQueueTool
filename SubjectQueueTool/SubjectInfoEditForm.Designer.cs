namespace SubjectQueueTool
{
    partial class SubjectInfoEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubjectTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FailedSubjectCountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ForgotFreqTextBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new DevComponents.DotNetBar.ButtonX();
            this.CancelBtn = new DevComponents.DotNetBar.ButtonX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PageNumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubjectTypeNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "题型名";
            // 
            // SubjectTypeNameTextBox
            // 
            this.SubjectTypeNameTextBox.Location = new System.Drawing.Point(18, 31);
            this.SubjectTypeNameTextBox.Name = "SubjectTypeNameTextBox";
            this.SubjectTypeNameTextBox.Size = new System.Drawing.Size(321, 21);
            this.SubjectTypeNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FailedSubjectCountTextBox);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "错题数";
            // 
            // FailedSubjectCountTextBox
            // 
            this.FailedSubjectCountTextBox.Location = new System.Drawing.Point(18, 32);
            this.FailedSubjectCountTextBox.Name = "FailedSubjectCountTextBox";
            this.FailedSubjectCountTextBox.Size = new System.Drawing.Size(321, 21);
            this.FailedSubjectCountTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ForgotFreqTextBox);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "遗忘频度";
            // 
            // ForgotFreqTextBox
            // 
            this.ForgotFreqTextBox.Location = new System.Drawing.Point(18, 34);
            this.ForgotFreqTextBox.Name = "ForgotFreqTextBox";
            this.ForgotFreqTextBox.Size = new System.Drawing.Size(321, 21);
            this.ForgotFreqTextBox.TabIndex = 2;
            // 
            // OkBtn
            // 
            this.OkBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OkBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OkBtn.Location = new System.Drawing.Point(12, 349);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(152, 40);
            this.OkBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "确定";
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CancelBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CancelBtn.Location = new System.Drawing.Point(199, 349);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(152, 40);
            this.CancelBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PageNumTextBox);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 71);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "页码";
            // 
            // PageNumTextBox
            // 
            this.PageNumTextBox.Location = new System.Drawing.Point(18, 34);
            this.PageNumTextBox.Name = "PageNumTextBox";
            this.PageNumTextBox.Size = new System.Drawing.Size(321, 21);
            this.PageNumTextBox.TabIndex = 2;
            // 
            // SubjectInfoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 401);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SubjectInfoEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "题型编辑";
            this.Load += new System.EventHandler(this.SubjectInfoEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SubjectTypeNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FailedSubjectCountTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ForgotFreqTextBox;
        private DevComponents.DotNetBar.ButtonX OkBtn;
        private DevComponents.DotNetBar.ButtonX CancelBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PageNumTextBox;
    }
}