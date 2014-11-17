namespace SubjectQueueTool
{
    partial class InputFailedSubjectInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputFailedSubjectInfoForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PageNumTextBox = new System.Windows.Forms.TextBox();
            this.SubjectNumTextBox = new System.Windows.Forms.TextBox();
            this.SubjectOtherInfo = new System.Windows.Forms.TextBox();
            this.OkBtn = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PageNumTextBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "页号（只须输数字）";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SubjectNumTextBox);
            this.groupBox2.Location = new System.Drawing.Point(21, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "题号（例如：例1 、例2...）";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SubjectOtherInfo);
            this.groupBox3.Location = new System.Drawing.Point(21, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他信息（选填）";
            // 
            // PageNumTextBox
            // 
            this.PageNumTextBox.Location = new System.Drawing.Point(10, 21);
            this.PageNumTextBox.Name = "PageNumTextBox";
            this.PageNumTextBox.Size = new System.Drawing.Size(259, 21);
            this.PageNumTextBox.TabIndex = 0;
            // 
            // SubjectNumTextBox
            // 
            this.SubjectNumTextBox.Location = new System.Drawing.Point(10, 21);
            this.SubjectNumTextBox.Name = "SubjectNumTextBox";
            this.SubjectNumTextBox.Size = new System.Drawing.Size(259, 21);
            this.SubjectNumTextBox.TabIndex = 0;
            // 
            // SubjectOtherInfo
            // 
            this.SubjectOtherInfo.Location = new System.Drawing.Point(10, 19);
            this.SubjectOtherInfo.Multiline = true;
            this.SubjectOtherInfo.Name = "SubjectOtherInfo";
            this.SubjectOtherInfo.Size = new System.Drawing.Size(259, 58);
            this.SubjectOtherInfo.TabIndex = 0;
            // 
            // OkBtn
            // 
            this.OkBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OkBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OkBtn.Location = new System.Drawing.Point(21, 238);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(276, 38);
            this.OkBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "确认";
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // InputFailedSubjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 287);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputFailedSubjectInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请输入不会题详细信息";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputFailedSubjectInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.InputFailedSubjectInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PageNumTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SubjectNumTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SubjectOtherInfo;
        private DevComponents.DotNetBar.ButtonX OkBtn;
    }
}