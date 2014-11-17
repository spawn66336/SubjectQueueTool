using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SubjectQueueTool
{
    public partial class InputFailedSubjectInfoForm : Form
    {
        public InputFailedSubjectInfoForm()
        {
            InitializeComponent();
        }
         
        public string failedSubjectInfo;

        private void OkBtn_Click(object sender, EventArgs e)
        {
            int pageNum = -1;
            string subjectNum = "";
            string otherInfo = ""; 
            string finalStr = "";

            if( !int.TryParse(PageNumTextBox.Text,out pageNum ))
            {
                MessageBox.Show("输入页号有误请重新输入！");
                return;
            }

            finalStr += "P" + pageNum + "---";

            if( SubjectNumTextBox.Text.Length == 0 )
            {
                MessageBox.Show("请填写题号描述信息！");
                return;
            }
            subjectNum = SubjectNumTextBox.Text;

            finalStr += subjectNum + "   "; 
            finalStr += "其他：" + SubjectOtherInfo.Text;

            failedSubjectInfo = finalStr;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void InputFailedSubjectInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void InputFailedSubjectInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
