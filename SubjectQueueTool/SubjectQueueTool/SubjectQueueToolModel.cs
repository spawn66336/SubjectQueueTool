using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectQueueTool.SubjectQueueTool
{

    public interface IPickSubjectStrategy
    {
        SubjectTypeInfo Pick(DisplineSubjectList displine);
    }

    public class DefaultPickStrategy : IPickSubjectStrategy
    {
        public SubjectTypeInfo Pick(DisplineSubjectList displine)
        {
            if( displine == null )
            {
                return SubjectTypeInfo.Empty;
            }

            var subjectList = displine.GetMainSort(); 
            foreach( var s in subjectList )
            {
                if( !s.done )
                {
                    return s;
                }
            }
            return SubjectTypeInfo.Empty;
        }
    }

    public class SubjectQueueToolModel
    {
        private SubjectQueueToolModel() { }

        public void SwitchDispline(string name)
        {
            currSubjectType = SubjectTypeInfo.Empty;
            currDispline = null;

            foreach( var d in subjectsDB.Displines )
            {
                if( d.Name.Equals(name) )
                {
                    currDispline = d;
                    _GenCurrentSubjectType();
                    return;
                }
            }
        }

        public List<string> GetDisplineNameList()
        {
            List<string> l = new List<string>();
            foreach( var d in subjectsDB.Displines )
            {
                l.Add(d.Name);
            }
            return l;
        }

        public void Pass()
        { 
            if (!currSubjectType.IsEmpty())
            {
                currSubjectType.done = true;
                currSubjectType.passNum++;
                currDispline.Set(currSubjectType.id, currSubjectType);
                _GenCurrentSubjectType();
            }
        }

        public void Fail()
        {
            if(!currSubjectType.IsEmpty())
            {
                currSubjectType.done = true;
                currSubjectType.passNum++;
                currDispline.Set(currSubjectType.id, currSubjectType); 
                currDispline.IncSubjectRanking(currSubjectType.id);
                _GenCurrentSubjectType();
            }
        }

        void _GenCurrentSubjectType()
        {
            IPickSubjectStrategy subjectPicker = new DefaultPickStrategy();
            currSubjectType = SubjectTypeInfo.Empty;

            if (currDispline != null)
            {
                SubjectTypeInfo sub = 
                subjectPicker.Pick(currDispline);
                if(sub.IsEmpty())
                {
                    currDispline.ClearDoneFlag();
                    sub = subjectPicker.Pick(currDispline);
                }
                currSubjectType = sub;
            } 
        }

        public SubjectTypeInfo CurrSubjectType
        {
            get
            {
                _GenCurrentSubjectType();
                return currSubjectType;
            }
        }

        public DisplineSubjectList CurrDispline { get { return currDispline; } }


        private SubjectTypeInfo currSubjectType = SubjectTypeInfo.Empty;

        private DisplineSubjectList currDispline = null;

        private SubjectDatabase subjectsDB = new SubjectDatabase("./Data/");

        public static SubjectQueueToolModel GetInstance()
        {
            if( s_instance == null )
            {
                s_instance = new SubjectQueueToolModel();
            }
            return s_instance;
        } 
        public static void DestoryInstance()
        {
            s_instance = null;
            GC.Collect();
        }

        private static SubjectQueueToolModel s_instance = null;

    }
}
