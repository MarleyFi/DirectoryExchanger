using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryExchanger
{
    class DoubleFilePair
    {
        #region Konstruktor
        public DoubleFilePair(string path1, string path2)
        {
            this.FilePathFirst = path1;
            this.FilePathSecond = path2;
            Init();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Init()
        {
            if (!File.Exists(FilePathFirst) && File.Exists(FilePathSecond))
            {
                return;
            }

            FirstFile = new FileInfo(FilePathFirst);
            SecondFile = new FileInfo(FilePathSecond);

            LastModifiedFirstFile = FirstFile.LastWriteTime;
            LastModifiedSecondFile = SecondFile.LastWriteTime;

            DateOfCreationFirstFile = FirstFile.CreationTime;
            DateOfCreationSecondFile = SecondFile.CreationTime;

            FileLengthFirst = FirstFile.Length;
            FileLengthSecond = SecondFile.Length;

            FileNameFirst = FirstFile.Name;
            FileNameSecond = SecondFile.Name;

            DecideNewer();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DecideNewer()
        {
            if (LastModifiedFirstFile.Ticks > LastModifiedSecondFile.Ticks)
            {
                NewerFile = FilePathFirst;
                OlderFile = FilePathSecond;
                IsSave = true;
                return;
            }
            else if (!(LastModifiedFirstFile.Ticks > LastModifiedSecondFile.Ticks))
            {
                NewerFile = FilePathSecond;
                OlderFile = FilePathFirst;
                IsSave = true;
                return;
            }
            else if (FileLengthFirst > FileLengthSecond)
            {
                NewerFile = FilePathFirst;
                OlderFile = FilePathSecond;
                IsSave = false;
                return;
            }
            else if (!(FileLengthFirst > FileLengthSecond))
            {
                NewerFile = FilePathSecond;
                OlderFile = FilePathFirst;
                IsSave = false;
                return;
            }
            else if (FirstFile.CreationTime.Ticks > SecondFile.CreationTime.Ticks)
            {
                NewerFile = FilePathFirst;
                OlderFile = FilePathSecond;
                IsSave = false;
                return;
            }
            else if (!(FirstFile.CreationTime.Ticks > SecondFile.CreationTime.Ticks))
            {
                NewerFile = FilePathSecond;
                OlderFile = FilePathFirst;
                IsSave = false;
                return;
            }

        }

        #endregion Konstruktor

        #region Variablen

        public FileInfo FirstFile { get; private set; }

        public FileInfo SecondFile { get; private set; }

        public bool IsSave { get; private set; }

        public string FilePathFirst { get; private set; }

        public string FilePathSecond { get; private set; }

        public string FileNameFirst { get; private set; }

        public string FileNameSecond { get; private set; }

        public string NewerFile { get; private set; }

        public string OlderFile { get; private set; }

        public DateTime LastModifiedFirstFile { get; private set; }

        public DateTime LastModifiedSecondFile { get; private set; }

        public DateTime DateOfCreationFirstFile { get; private set; }

        public DateTime DateOfCreationSecondFile { get; private set; }

        public long FileLengthFirst { get; private set; }

        public long FileLengthSecond { get; private set; }
        #endregion Variablen
    }
}
