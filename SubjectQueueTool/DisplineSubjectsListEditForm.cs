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
    public partial class DisplineSubjectsListEditForm : Form
    {
        public DisplineSubjectsListEditForm()
        {
            InitializeComponent();
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            var subjectEditDialog = new SubjectInfoEditForm();
            DialogResult rs = subjectEditDialog.ShowDialog();

            if (rs != DialogResult.OK)
            {
                return;
            }

            if( SubjectQueueToolModel.GetInstance().CurrDispline != null )
            {
               SubjectQueueToolModel.GetInstance().CurrDispline.Add(subjectEditDialog.info);
               UpdateUI();
            }
        }

        private void UpdateUI()
        {
            if( SubjectQueueToolModel.GetInstance().CurrDispline == null )
            {
                return;
            }

            SubjectListView.Items.Clear();
            var mainSortList = SubjectQueueToolModel.GetInstance().CurrDispline.GetMainSort();
            foreach (var s in mainSortList)
            {
                ListViewItem item = new ListViewItem(s.name);
                item.SubItems.Add(s.failedSubjectNum.ToString());
                item.SubItems.Add(s.changeFreq.ToString());
                item.SubItems.Add(s.passNum.ToString());
                item.Tag = s.id;
                SubjectListView.Items.Add(item);
            }

        }

        private void DisplineSubjectsListEditForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void DelSubjectBtn_Click(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                return;
            }

            if( SubjectListView.SelectedItems.Count == 0 )
            {
                MessageBox.Show("请选中一项删除！");
                return;
            }

            foreach( var item in SubjectListView.SelectedItems )
            {
                var listItem = item as ListViewItem;
                if( listItem != null )
                {
                    SubjectQueueToolModel.GetInstance().CurrDispline.Delete((Guid)listItem.Tag);
                }
            }
            UpdateUI();
        }

        private void SortByFailedNumBtn_Click(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                return;
            }

            SubjectQueueToolModel.GetInstance().CurrDispline.SortMainSortList(new SortByFailedNumComparer());
            UpdateUI();
        }

        private void SubjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubjectListView_DoubleClick(object sender, EventArgs e)
        {
            if (SubjectQueueToolModel.GetInstance().CurrDispline == null)
            {
                return;
            }

            if (SubjectListView.SelectedItems.Count == 0)
            { 
                return;
            }

            Guid editId = (Guid)SubjectListView.SelectedItems[0].Tag;

            var subjectEditDialog = new SubjectInfoEditForm();
            subjectEditDialog.editSubjectID = editId;
            DialogResult rs = subjectEditDialog.ShowDialog();

            if( rs == DialogResult.OK )
            {
                SubjectQueueToolModel.GetInstance().CurrDispline.Set(editId, subjectEditDialog.info); 
                UpdateUI();
            }

        }
    }
}
