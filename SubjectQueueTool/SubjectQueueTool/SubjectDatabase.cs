using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SubjectQueueTool.SubjectQueueTool
{
    public class SubjectDatabase
    {
        public SubjectDatabase( string path )
        {
            dataDir = path;
            _TouchDataDir();
            _TouchBackupDir();
            //先备份当前文件
            _BackupAllDisplineDB();
            _ScanAllDisplineDB();
        }

        
        void _ScanAllDisplineDB()
        {

            var fileEnum = Directory.EnumerateFiles(dataDir,"*.db",SearchOption.AllDirectories).GetEnumerator();

            while(fileEnum.MoveNext())
            {
               var path = fileEnum.Current;
               DisplineSubjectList newDispline = new DisplineSubjectList(path);
               displines.Add(newDispline);
            }
        }

        void _BackupAllDisplineDB()
        {
            var fileEnum = Directory.EnumerateFiles(dataDir, "*.db", SearchOption.AllDirectories).GetEnumerator();
            while(fileEnum.MoveNext())
            {
                var path = fileEnum.Current;
                var fileName = Path.GetFileNameWithoutExtension(path);
                var backPath = _GetBackupDirPath()+_GetBackupFileName(fileName);
                File.CreateText(backPath).Close();
                File.Copy(path, backPath, true);
            }
        }

        void _TouchDataDir()
        {
            if( !Directory.Exists(dataDir) )
            {
                Directory.CreateDirectory(dataDir);
            }
        }

        void _TouchBackupDir()
        {
            if (!Directory.Exists(_GetBackupDirPath()))
            {
                Directory.CreateDirectory(_GetBackupDirPath());
            }
        }

        string _GetBackupDirPath()
        {
            return dataDir + "Backup/";
        }

        string _GetBackupFileName(string fileName )
        {
            return fileName + "_" + DateTime.Now.ToString("yyyy_MMM_d_HH_mm_ss") + ".backup";
        }


        public List<DisplineSubjectList> Displines
        {
            get { return displines; }
        }

        //学科列表
        List<DisplineSubjectList> displines = new List<DisplineSubjectList>();

        string dataDir;

    }
}
