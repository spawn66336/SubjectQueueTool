using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectQueueTool.SubjectQueueTool
{
    public class SubjectTypeKeyValuePair
    {
        public SubjectTypeKeyValuePair() { }

        public SubjectTypeKeyValuePair(string k , SubjectType value )
        {
            key = k;
            v = value;
        }

        public string Key { get { return key; } set { key = value; } }

        public SubjectType Value { get { return v; }  set {v = value;}}

        string key;
        SubjectType v;
    }

    [Serializable]
    public class SubjectType
    {
        public SubjectType() { }

        public string StrID
        {
            get { return id.ToString(); }
            set { id = new Guid(value); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public int PassNum 
        { 
            get { return passNum; } 
            set { passNum = value; } 
        }

        public int ChangeFreq
        {
            get { return changeFreq; }
            set { changeFreq = value; }
        }

        public int FailedSubjectNum
        {
            get { return failedSubjectNum; }
            set { failedSubjectNum = value; }
        }

        public string UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }

        public List<string> ChangeTimeList
        {
            get
            {
                List<string> l = new List<string>();
                foreach( var t in changeTimeList )
                {
                    l.Add(t.ToString());
                }
                return l;
            }

            set
            {
                changeTimeList.Clear();
                foreach( var strT in value )
                {
                    changeTimeList.Add(DateTime.Parse(strT));
                }
            }
        }

        public List<string> SubjectInfos
        {
            get
            {
                return subjectInfos;
            }
            set
            {
                subjectInfos = value;
            }
        }

        public Guid GetGUID() { return id; }
        public void SetGUID(Guid guid) { id = guid; }

        //提升变更优先级数量
        public void IncChangeFreq()
        {
            changeFreq++;
            changeTimeList.Add(DateTime.Now);
        }

        //题型id
        private Guid id;
        //题型名
        private string name;
        //此遍是否完成
        private bool done = false;
        //当前题型已经做过几遍
        private int passNum = 0;
        //题型变更优先级数量
        private int changeFreq = 0;
        //错题数
        private int failedSubjectNum = 0;
        //用户自定义信息
        private string userInfo;
        //变更优先级时间点
        private List<DateTime> changeTimeList = new List<DateTime>();
        //错题信息
        private List<string> subjectInfos = new List<string>();
    }
}
