using SubjectQueueTool.SubjectQueueTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectQueueTool
{
    public partial class SubjectInfoEditForm : Form
    {
        public SubjectInfoEditForm()
        {
            InitializeComponent();
        }

        

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //若输入不合法！
            if( !ValidateInputData() )
            {
                return;
            }

            DialogResult = DialogResult.OK;

            info.name = SubjectTypeNameTextBox.Text;
            info.failedSubjectNum = Int32.Parse(FailedSubjectCountTextBox.Text);
            if (ForgotFreqTextBox.Text.Length != 0 )
            { 
                info.changeFreq = Int32.Parse(ForgotFreqTextBox.Text);
            }
            info.userInfo = PageNumTextBox.Text;
            if( info.subjectInfos == null )
            {
                info.subjectInfos = new List<string>();
            }

            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SubjectInfoEditForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            if( !editSubjectID.Equals(Guid.Empty))
            {//需要载入对应题型信息 
                SubjectQueueToolModel.GetInstance().CurrDispline.GetByID(editSubjectID, out info);
                SubjectTypeNameTextBox.Text = info.name;
                FailedSubjectCountTextBox.Text = info.failedSubjectNum.ToString();
                ForgotFreqTextBox.Text = info.changeFreq.ToString();
                PageNumTextBox.Text = info.userInfo;
            }
            else
            {
                ForgotFreqTextBox.Text = ((int)0).ToString();
            }
        }

        private bool ValidateInputData()
        {
            if( SubjectTypeNameTextBox.Text.Length == 0 )
            {
                MessageBox.Show("题型名不可为空！");
                return false;
            }

            if( FailedSubjectCountTextBox.Text.Length == 0 )
            {
                MessageBox.Show("请输入错题数！");
                return false;
            }

            int failedSubjectCount = Int32.Parse(FailedSubjectCountTextBox.Text);

            if( failedSubjectCount < 0 )
            {
                MessageBox.Show("错题数不可小于0");
                return false;
            }

 
            if (PageNumTextBox.Text.Length == 0)
            {
                MessageBox.Show("页码信息必需填写");
                return false;
            }

            return true;
        }

        public Guid editSubjectID;

        public SubjectTypeInfo info = SubjectTypeInfo.Empty;
    }
}
