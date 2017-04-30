using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DirectoryExchanger.Properties;

namespace DirectoryExchanger
{
    public partial class DataStore
    {
        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Desc
        /// </summary>
        public string[] filesExt =
            {
            "*.docx", // Word
            "*.odt", // OpenOffice
            "*.pdf", // PDFs
            "*.txt", // Textfiles
            "*.pages", // Pages-files
            "*.xls", // MS Excel
            "*.ods", // OO Excel
            "*.mp3", // Musikdateien
            "*.gdoc", // Google Document
            "*.gsheet", // Google Table
            "*.gslides" // Google Presentation
            };

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Desc
        /// </summary>
        public string[] filesExtNames =
            {
            "Word", // Word
            "OpenOffice", // OpenOffice
            "PDFs", // PDFs
            "Textfiles", // Textfiles
            "Pages-files", // Pages-files
            "MS Excel", // MS Excel
            "OO Excel", // OO Excel
            "Musik-Dateien", // Musicfiles
            "Google Document", // Google Document
            "Google Table", // Google Table
            "Google Presentation" // Google Presentation
            };

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Desc
        /// </summary>
        public string[] dataSizes =
            {
            "Bytes",
            "KBytes",
            "MBytes",
            "GBytes",
            "TBytes",
            };

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor für die SystemTray benachrichtigung
        /// </summary>
        public void Notify(string text, string title, int milliseconds)
        {
            NotifyIcon notify = new NotifyIcon() { Icon = Resources.Circulation, Visible = true };
            notify.ShowBalloonTip(milliseconds, title, text, ToolTipIcon.Info);
            notify.Visible = false;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gibt die größe des Ordners in dem ausgewählten Größenverhältnis zurück
        /// </summary>
        public long GetDirSize(string path)
        {
            long Size = 0;
            DirectoryInfo d;
            if (Directory.Exists(path))
            {
                d = new DirectoryInfo(path);
                FileInfo[] files = d.GetFiles();
                foreach (FileInfo file in files)
                {
                    Size += file.Length;
                }
                // Add subdirectory sizes.
                string[] subFolders = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string dir in subFolders)
                {
                    Size += GetDirSize(dir);
                }
            }
            return Size;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gibt einen String der mitgegebenen Datengröße und Nachkommastellen zurück
        /// </summary>
        public double getDataSize(long longBytes, int unit = -1, int digits = 2)
        {
            double bytes = Convert.ToDouble(longBytes);
            if (unit >= 0 && unit <= 4)
            {
                switch (unit)
                {
                    case 0:
                        return Math.Round(bytes, 2);

                    case 1:
                        return Math.Round(bytes / 1024, digits);

                    case 2:
                        return Math.Round(bytes / 1024 / 1024, digits);

                    case 3:
                        return Math.Round(bytes / 1024 / 1024 / 1024, digits);

                    case 4:
                        return Math.Round(bytes / 1024 / 1024 / 1024 / 1024, digits);

                    default:
                        return Math.Round(bytes, digits);
                }
            }
            else
            {
                return Math.Round(bytes / 1024 / 1024, digits);
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gibt einen String der mitgegebenen Datengröße und Nachkommastellen zurück
        /// </summary>
        public string getDataSizeString(long longBytes, int unit = -1, int digits = 2)
        {
            double bytes = Convert.ToDouble(longBytes);
            if (unit >= 0 && unit <= 4)
            {
                switch (unit)
                {
                    case 0:
                        return Math.Round(bytes, 2) + " Bytes";

                    case 1:
                        return Math.Round(bytes / 1024, digits) + " KBytes";

                    case 2:
                        return Math.Round(bytes / 1024 / 1024, digits) + " MBytes";

                    case 3:
                        return Math.Round(bytes / 1024 / 1024 / 1024, digits) + " GBytes";

                    case 4:
                        return Math.Round(bytes / 1024 / 1024 / 1024 / 1024, digits) + " TBytes";

                    default:
                        return Math.Round(bytes, digits) + " Bytes";
                }
            }
            else
            {
                return Math.Round(bytes / 1024 / 1024, digits) + " MBytes";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="longPaths"></param>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public string[] GetShortPaths(string[] longPaths, string rootPath)
        {
            int index = rootPath.Length + 1;
            List<string> shortPathList = new List<string>();
            
            for (int i = 0; i < longPaths.Length; i++)
            {
                shortPathList.Add(@"..\"+longPaths[i].Substring(index));
            }
            return shortPathList.ToArray();
        }

        /// <summary>
        /// Öffnet den mitgegebenen Pfad im Windows-Explorer
        /// </summary>
        /// <param name="path"></param>
        public void OpenFile(string path)
        {
            if (File.Exists(path))
                Process.Start("explorer.exe", path);
        }

        /// <summary>
        /// Öffnet den mitgegebenen Pfad im Windows-Explorer
        /// </summary>
        /// <param name="path"></param>
        public void OpenPath(string path)
        {
            if (Directory.Exists(path))
            {
                Process.Start("explorer.exe", path);
            }
            else if (Directory.Exists(Path.GetDirectoryName(path)))
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(path));
            }
        }
    }
}
