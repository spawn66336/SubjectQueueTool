using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Core;



namespace SubjectQueueTool.SubjectQueueTool
{
    public struct SubjectTypeInfo
    {
        public Guid id;
        public string name;
        public int failedSubjectNum;
        public int changeFreq;
        public bool done;
        public int passNum;
        public string userInfo;
        public string lastChangeTime;

        public bool IsEmpty()
        {
            return id.Equals(Guid.Empty);
        }

        public void Apply(SubjectType t)
        {
            t.Name = name; 
            t.FailedSubjectNum = failedSubjectNum; 
            t.ChangeFreq = changeFreq;
            t.Done = done;
            t.PassNum = passNum;
            t.UserInfo = userInfo;
        }

        public static SubjectTypeInfo GetInfo(SubjectType t)
        {
            SubjectTypeInfo info = new SubjectTypeInfo();
            info.id = t.GetGUID();
            info.name = t.Name;
            info.done = t.Done;
            info.passNum = t.PassNum;
            info.failedSubjectNum = t.FailedSubjectNum;
            info.changeFreq = t.ChangeFreq;
            info.userInfo = t.UserInfo; 
            
            if( t.ChangeTimeList.Count == 0 )
            {
                info.lastChangeTime = "------";
            }
            else
            {
                info.lastChangeTime = t.ChangeTimeList[t.ChangeTimeList.Count - 1];
            }


            return info;
        }

        public static SubjectTypeInfo Empty;
    }

    [Serializable]
    public class DisplineSubjectListSerializeObject
    {
        public DisplineSubjectListSerializeObject() { }

        //最近一次更新时间
        public string LastSyncTime { get { return lastSyncTime; } set { lastSyncTime = value; } }

        public List<SubjectTypeKeyValuePair> SubjectTypeTable { get { return subjectTypeTable; } set { subjectTypeTable = value; } }

        public List<string> MainSort { get { return mainSort; } set { mainSort = value; } }

        private string lastSyncTime;

        private List<SubjectTypeKeyValuePair> subjectTypeTable = new List<SubjectTypeKeyValuePair>();

        private List<string> mainSort = new List<string>();
    }

    //按遗忘频率递减排序
    public class SortByChangeFreqComparer : IComparer<SubjectType>
    {
        public int Compare(SubjectType x, SubjectType y)
        {
            return y.ChangeFreq - x.ChangeFreq;
        }
    }


    //按错题数递减排序
    public class SortByFailedNumComparer : IComparer<SubjectType>
    {
        public int Compare(SubjectType x, SubjectType y)
        {
            return y.FailedSubjectNum - x.FailedSubjectNum;
        }
    }

    public class DisplineSubjectList
    {
        private DisplineSubjectList() { }

        public DisplineSubjectList(string path) 
        {
            filePath = path;
            name = Path.GetFileNameWithoutExtension(path);
            _Sync();
        }

        public void Add(SubjectTypeInfo info)
        {
            SubjectType newType = new SubjectType();
            newType.SetGUID(Guid.NewGuid());
            info.Apply(newType); 

            subjectTypeTable.Add(newType.GetGUID(),newType);
            mainSort.Add(newType.GetGUID());
            _Sync();
        }

        public bool Delete(Guid id)
        {
            if (!subjectTypeTable.ContainsKey(id))
            {
                return false;
            }

            subjectTypeTable.Remove(id);
            mainSort.Remove(id);
            _Sync();
            return true;
        }      

        public bool GetByID(Guid id , out SubjectTypeInfo info )
        {
            SubjectType s = null;
            info = SubjectTypeInfo.Empty;
            if( _GetByID(id,out s))
            {
                info = SubjectTypeInfo.GetInfo(s);
                return true;
            }
            return false;
        }

        public bool Set(Guid id , SubjectTypeInfo info )
        {
            SubjectType s = null;
            if(_GetByID(id,out s))
            {
                info.Apply(s);
                _Sync();
                return true;
            }
            return false;
        }

        public int GetMinPassNum()
        {
            int currPass = Int32.MaxValue;
            foreach( var s in subjectTypeTable )
            {
                currPass = Math.Min(currPass, s.Value.PassNum);
            }
            return currPass;
        }

        public bool IncSubjectRanking(Guid id)
        {
            SubjectType t = null;
            if(_GetByID(id,out t))
            { 
                t.IncChangeFreq();
                mainSort.Remove(id);
                mainSort.Insert(0, id);
                _Sync();                
                return true;
            }
            return false;
        }

        public void ClearDoneFlag()
        {
            foreach( var s in subjectTypeTable)
            {
                s.Value.Done = false;
            }
            _Sync();
        }

        public void SortMainSortList( IComparer<SubjectType> cmp )
        {
            var l = _GetMainSort();
            l.Sort(cmp);

            mainSort.Clear();
            foreach( var s in l )
            {
                mainSort.Add(s.GetGUID());
            }
            _Sync();
        }

        public List<SubjectTypeInfo> GetMainSort()
        {
            var l = new List<SubjectTypeInfo>();
            var ml = _GetMainSort();
            foreach( var s in ml )
            {
                l.Add(SubjectTypeInfo.GetInfo(s));
            }
            return l;
        }

        public List<SubjectTypeInfo> GetSortedList( IComparer<SubjectType> cmp )
        {
            var l = new List<SubjectTypeInfo>();
            var ml = _GetMainSort();
            ml.Sort(cmp);

            foreach (var s in ml)
            {
                l.Add(SubjectTypeInfo.GetInfo(s));
            }
            return l;
        }




        private List<SubjectType> _GetMainSort()
        {
            var l = new List<SubjectType>();
            foreach (var id in mainSort)
            {
                SubjectType s = null;
                _GetByID(id, out s);
                l.Add(s);
            }
            return l;
        }

        private bool _GetByID(Guid id, out SubjectType t)
        {
            t = null;
            if (!subjectTypeTable.ContainsKey(id))
            {
                return false;
            }
            subjectTypeTable.TryGetValue(id, out t);
            return true;
        }

        //同步至文件
        private void _Sync()
        {
            if( !initFlag )
            {
                _Load();
                initFlag = true;
                return;
            }
            _Save();
        }

        private void _Load()
        {
            StreamReader yamlReader = null; 
            yamlReader = File.OpenText(filePath);   
            Deserializer yamlDeserializer = new Deserializer();
            var obj = yamlDeserializer.Deserialize<DisplineSubjectListSerializeObject>(yamlReader);
            _ApplySerializeObject(obj);
            yamlReader.Close();
        }

        private void _Save()
        {
            lastSyncTime = DateTime.Now;
            StreamWriter yamlWriter = File.CreateText(filePath);
            Serializer yamlSerializer = new Serializer();
            yamlSerializer.Serialize(yamlWriter, _GetSerializeObject());
            yamlWriter.Close();
        }


        private DisplineSubjectListSerializeObject _GetSerializeObject()
        {
            var obj = new DisplineSubjectListSerializeObject();
            obj.LastSyncTime = LastSyncTime;
            obj.SubjectTypeTable = SubjectTypeTable;
            obj.MainSort = MainSort;
            return obj;
        }

        private void _ApplySerializeObject( DisplineSubjectListSerializeObject obj )
        {
            if( obj == null )
            {
                return;
            }

            LastSyncTime = obj.LastSyncTime;
            SubjectTypeTable = obj.SubjectTypeTable;
            MainSort = obj.MainSort;
        }

        public string Name { get { return name; } }

        public string LastSyncTime
        {
            get { return lastSyncTime.ToString(); }
            set { lastSyncTime = DateTime.Parse(value); }
        }

        public List<SubjectTypeKeyValuePair> SubjectTypeTable
        {
            get
            {
                var l = new List<SubjectTypeKeyValuePair>();
                foreach( var s in subjectTypeTable )
                {
                    var pair = new SubjectTypeKeyValuePair(s.Key.ToString(), s.Value);
                    l.Add(pair);
                }
                return l;
            }

            set
            {
                subjectTypeTable.Clear();
                foreach( var s in value )
                {
                    subjectTypeTable.Add(new Guid(s.Key), s.Value);
                }
            }
        }

        public List<string> MainSort
        {
            get
            {
                var l = new List<string>();
                foreach( var id in mainSort )
                {
                    l.Add(id.ToString());
                }
                return l;
            }

            set
            {
                mainSort.Clear();
                foreach(var id in value)
                {
                    mainSort.Add(new Guid(id));
                }
            }
        }

        //科目名称
        string name;
        //最近一次更新时间
        DateTime lastSyncTime; 
        //科目数据库所在位置
        string filePath;

        bool initFlag = false;

        Dictionary<Guid, SubjectType> subjectTypeTable = new Dictionary<Guid,SubjectType>();

        List<Guid> mainSort = new List<Guid>();
    }
}
