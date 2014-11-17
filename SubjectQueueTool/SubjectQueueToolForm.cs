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
    public partial class SubjectQueueToolForm : Form
    {
        public SubjectQueueToolForm()
        {
            InitializeComponent();
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                MessageBox.Show("请先选择一个科目");
                return;
            }

            if( MessageBox.Show("是否确定会做此题？","注意！",MessageBoxButtons.YesNo) == DialogResult.No )
            {
                return;
            }

            SubjectQueueToolModel.GetInstance().Pass();
            UpdateUI();
        }

        private void FailBtn_Click(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                MessageBox.Show("请先选择一个科目");
                return;
            }

            if (MessageBox.Show("是否确定不会做此题？", "注意！", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            InputFailedSubjectInfoForm failedSubjectDialog = new InputFailedSubjectInfoForm();
            failedSubjectDialog.ShowDialog();
            SubjectQueueToolModel.GetInstance().CurrSubjectType.subjectInfos.Add(failedSubjectDialog.failedSubjectInfo);
            SubjectQueueToolModel.GetInstance().SaveCurrSubjectType(); 

            SubjectQueueToolModel.GetInstance().Fail();
            UpdateUI();
        }

        private void EditSubjectListBtn_Click(object sender, EventArgs e)
        {
            if( SubjectQueueToolModel.GetInstance().CurrDispline == null )
            {
                MessageBox.Show("请先选择一个科目，再进行编辑！");
                return;
            }

            Form editDialog = new DisplineSubjectsListEditForm(); 
            editDialog.ShowDialog();
            UpdateUI();
        }

        private void SubjectQueueToolForm_Load(object sender, EventArgs e)
        {
            List<string> displineNames =  SubjectQueueToolModel.GetInstance().GetDisplineNameList();

            ToolStripMenuItem rootItem = null; 
            foreach( var item in MainMenu.Items )
            {
                if( item.ToString().Equals("科目") )
                {
                    rootItem = item as ToolStripMenuItem;
                    break;
                }
            }

            foreach( var n in displineNames )
            {
                rootItem.DropDownItems.Add(n,null,MenuItem_Click);
            }
            
            foreach( var col in ChangFreqListView.Columns )
            {
                var column = col as ColumnHeader;
                column.Width = 150;
            }

            UpdateUI();
        }
        

        private void MenuItem_Click(object sender , EventArgs e )
        {
            SubjectQueueToolModel.GetInstance().SwitchDispline(sender.ToString());
            UpdateUI();
        }

        private void UpdateUI()
        { 
            MainSortListView.Items.Clear();
            ChangFreqListView.Items.Clear();

            if( SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                DisplineLabel.Text = "请选择科目";
                return;
            }

            DisplineLabel.Text = SubjectQueueToolModel.GetInstance().CurrDispline.Name;  
            ProgressLabel.Text = "距离此遍完成还有"+SubjectQueueToolModel.GetInstance().CurrDispline.GetUndoneSubjectTypeCount()+"个题型";

            //更新主排序列表
            var mainSortList = SubjectQueueToolModel.GetInstance().CurrDispline.GetMainSort();   
            foreach( var s in mainSortList )
            {
                ListViewItem item = new ListViewItem(s.name);
                item.SubItems.Add(s.passNum.ToString());
                item.Tag = s.id;
                MainSortListView.Items.Add(item);
            }

            //更新遗忘频率列表
            var sortByChangeFreqList = SubjectQueueToolModel.GetInstance().CurrDispline.GetSortedList(new SortByChangeFreqComparer());
            foreach( var s in sortByChangeFreqList )
            {
                ListViewItem item = new ListViewItem(s.name);
                item.SubItems.Add(s.changeFreq.ToString());
                item.SubItems.Add(s.lastChangeTime);

                item.Tag = s.id;
                ChangFreqListView.Items.Add(item);
            }


            //更新当前题目列表
            SubjectTypeInfo currSubject = SubjectQueueToolModel.GetInstance().CurrSubjectType;
            if (currSubject.IsEmpty())
            {
                CurrSubjectTextBox.Text = "";
                ChangeFreqTextBox.Text = "";
                UserInfoTextBox.Text = "";
            }
            else
            { 
                CurrSubjectTextBox.Text = currSubject.name;
                ChangeFreqTextBox.Text = currSubject.changeFreq.ToString();
                UserInfoTextBox.Text = currSubject.userInfo;
            }
            
        }

        private void ExportFailedSubjectInfos_Click(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                MessageBox.Show("请先选择一个科目，再进行导出！");
                return;
            }

            SubjectQueueToolModel.GetInstance().CurrDispline.ExportFailedSubjectInfos();

        }

        private void ExportFailedSubjectPageNumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                MessageBox.Show("请先选择一个科目，再进行导出！");
                return;
            }

            SubjectQueueToolModel.GetInstance().CurrDispline.ExportFaileSubjectPageNums();
        }
 
    }
}
