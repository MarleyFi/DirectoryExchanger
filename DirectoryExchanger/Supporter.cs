using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DirectoryExchanger
{
    public partial class Supporter
    {

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Hilfsvariable für das anzeigen der Nachkommastellen
        /// </summary>
        const string pi = "14159265359";

        public static void OpenFilter()
        {
            FrmAdvancedFilter advancedFilter = new FrmAdvancedFilter();
            advancedFilter.Show();
        }

        /// <summary>
        /// Öffnet einen FolderBrowserDialog und gibt den entsprechenden Pfad in die Textbox zurück || string.Empty
        /// </summary>
        public static string OpenFileBrowser(string path = "")
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FolderBrowserDialogEx openPath = new FolderBrowserDialogEx()
            {
                Description = "Choose a directory",
                ShowNewFolderButton = false,
                SelectedPath = Directory.Exists(path) ? path : desktop,
                ShowEditBox = true,
                ShowFullPathInEditBox = true
            };

            DialogResult result = openPath.ShowDialog();
            if ((Directory.Exists(openPath.SelectedPath) || openPath.SelectedPath == desktop) && result == DialogResult.OK)
            {
                return openPath.SelectedPath;
            }
            else
            {
                return string.Empty;
            }
        }

        public static string OpenFolderBrowserDialog(string path = "")
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FolderBrowserDialogEx openPath = new FolderBrowserDialogEx()
            {
                Description = "Choose a directory",
                ShowNewFolderButton = false,
                SelectedPath = Directory.Exists(path) ? path : desktop,
                ShowEditBox = true,
                ShowFullPathInEditBox = true
            };
            DialogResult result = openPath.ShowDialog();
            if ((Directory.Exists(openPath.SelectedPath) || openPath.SelectedPath == desktop) && result == DialogResult.OK)
            {
                return openPath.SelectedPath;
            }
            return string.Empty;
        }

        /// <summary>
        /// Sucht alle Dateien im angegebenen Pfad mit Filteroptionen
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string[] GetFilesFiltered(string source, string[] filterPatterns, bool allDirectories)
        {
            List<string> files = new List<string>();
            try
            {
                for (int i = 0; i < filterPatterns.Length; i++)
                {
                    files.AddRange(Directory.GetFiles(source, filterPatterns[i], allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                }

                if (files.Count == 0)
                {
                    return files.ToArray();
                }
                else
                {
                    return files.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Bitte wähle ein anderes Verzeichnis aus\r\n" + e.ToString(), "Fehler beim Lesen des angegebenen Pfades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// Sucht alle Dateien im angegebenen Pfad mit Filteroptionen
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string[] GetFoldersFiltered(string source, string[] filterPatterns, bool allDirectories)
        {
            List<string> folders = new List<string>();
            try
            {
                for (int i = 0; i < filterPatterns.Length; i++)
                {
                    folders.AddRange(Directory.GetDirectories(source, filterPatterns[i], allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                }

                if (folders.Count == 0)
                {
                    return folders.ToArray();
                }
                else
                {
                    return folders.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Bitte wähle ein anderes Verzeichnis aus\r\n" + e.ToString(), "Fehler beim Lesen des angegebenen Pfades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gibt einen String der mitgegebenen Datengröße und Nachkommastellen zurück
        /// </summary>
        public static double GetDataSize(long longBytes, int unit = -1, int digits = 2)
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
        public static string GetDataSizeString(long longBytes, int unit = -1, int digits = 2)
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
        /// Gibt den Namen des letzten Ordners in der Hierachie zurück
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFolderName(string path)
        {
            int index = path.LastIndexOf(@"\");
            return path.Substring(index + 1);
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Gibt die größe des Ordners in dem ausgewählten Größenverhältnis zurück
        /// </summary>
        public static long GetDirSize(string path)
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
        /// Gibt die anzahl an Bytes alle Dateien im angegebenen Pfad-Array wieder
        /// </summary>
        public static long GetBytesOfFiles(string[] paths)
        {
            long bytes = 0;
            foreach (string file in paths)
            {
                if (File.Exists(file))
                {
                    bytes += new FileInfo(file).Length;
                }
                else
                {
                    MessageBox.Show(string.Format("Error 404 not found\r\n{0}", file));
                }
            }
            return bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string[] GetFileNames(string[] paths)
        {
            List<string> fileNames = new List<string>();
            foreach (string path in paths)
            {
                if (File.Exists(path) || Directory.Exists(path))
                    fileNames.Add(Path.GetFileName(path));
            }
            return fileNames.ToArray();
        }

        /// <summary>
        /// Gibt ein Array mit Dateinamen zurück
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string[] GetFileNames(List<string> paths)
        {
            List<string> fileNames = new List<string>();
            foreach (string path in paths)
            {
                if (File.Exists(path) || Directory.Exists(path))
                    fileNames.Add(Path.GetFileName(path));
            }
            return fileNames.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static List<string> GetFileNameList(string[] paths)
        {
            List<string> fileNames = new List<string>();
            foreach (string path in paths)
            {
                if (File.Exists(path) || Directory.Exists(path))
                    fileNames.Add(Path.GetFileName(path));
            }
            return fileNames;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static List<string> GetFileNameList(List<string> paths)
        {
            List<string> fileNames = new List<string>();
            foreach (string path in paths)
            {
                if (File.Exists(path) || Directory.Exists(path))
                    fileNames.Add(Path.GetFileName(path));
            }
            return fileNames;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="longPaths"></param>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public static string[] GetShortPaths(string[] longPaths, string rootPath)
        {
            int index = rootPath.Length + 1;
            List<string> shortPathList = new List<string>();

            for (int i = 0; i < longPaths.Length; i++)
            {
                shortPathList.Add(@"..\" + longPaths[i].Substring(index));
            }
            return shortPathList.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static long GetMaxValue(List<long> list)
        {
            list.Sort();
            return list[list.Count - 1];
        }

        /// <summary>
        /// Öffnet den mitgegebenen Pfad im Windows-Explorer(Datei)
        /// </summary>
        /// <param name="path"></param>
        public static void OpenFile(string path)
        {
            if (File.Exists(path))
                Process.Start("explorer.exe", path);
        }

        /// <summary>
        /// Öffnet den mitgegebenen Pfad im Windows-Explorer(Ordner)
        /// </summary>
        /// <param name="path"></param>
        public static void OpenPath(string path)
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

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Befüllt das Label pi mit den ausgewählten Nachkommastellen
        /// </summary>
        public static string BuildPi(string unit, int degits)
        {
            if (degits == 0)
            {
                return string.Format("3 {0}", unit);
            }
            else
            {
                string preview = pi.Remove(degits);
                return string.Format("3.{0} {1}", preview, unit);
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Befüllt das Label pi mit den ausgewählten Nachkommastellen
        /// </summary>
        public static string BuildPi(string unit, decimal degits)
        {
            int degitsINT = Convert.ToInt32(degits);
            if (degits == 0)
            {
                return string.Format("3 {0}", unit);
            }
            else
            {
                string preview = pi.Remove(degitsINT);
                return string.Format("3.{0} {1}", preview, unit);
            }
        }

    }
}
