using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DirectoryExchanger.Properties;

namespace DirectoryExchanger
{
    public partial class FrmDirectoryExchanger : Form
    {
        #region Konstruktoren

        /// <summary>
        ///
        /// </summary>
        public FrmDirectoryExchanger()
        {
            InitializeComponent();
            CreateMenuStrip();
            CheckPaths();
            LoadSettings();
        }


        /// <summary>
        /// Lädt die Zustände aus den Settings in die Checkboxen damit die Einstellungen aus der letzten Sitzung wiederherstellt werden können
        /// </summary>
        private void LoadSettings()
        {
            dataStore = new DataStore();
            Supporter = new Supporter();
            if (!string.IsNullOrEmpty(Settings.Default.Path1))
            {
                textBoxDir2.Text = Settings.Default.Path1;
            }
            if (!string.IsNullOrEmpty(Settings.Default.Path2))
            {
                textBoxDir1.Text = Settings.Default.Path2;
            }
            checkBoxSubfolders.Checked = Settings.Default.allDirs;
            checkBoxIgnoreTimeDiffs.Checked = Settings.Default.ignoreTimeDiffs;
            checkBoxInstantPreview.Checked = Settings.Default.instantPreview;
            checkBoxAdvancedFilter.Checked = Settings.Default.advancedFilter;
            checkBoxAutoSavePaths.Checked = Settings.Default.autoSavePaths;
            sortButtonisFiles = Settings.Default.isPaths;
            btnShowFiles1.Image = sortButtonisFiles ? Resources.Sort : Resources.Subfolders16;
            btnShowFiles2.Image = sortButtonisFiles ? Resources.Sort : Resources.Subfolders16;
        }

        private ContextMenuStrip BuildContextMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem sortFiles = new ToolStripMenuItem("Sort files", Resources.Sort) { Checked = sortButtonisFiles };
            sortFiles.Click += SortFiles_Click;
            ToolStripMenuItem sortFolder = new ToolStripMenuItem("Sort folders", Resources.Subfolders16) { Checked = !sortButtonisFiles };
            sortFolder.Click += SortFolder_Click;

            contextMenuStrip.Items.Add(sortFiles);
            contextMenuStrip.Items.Add(sortFolder);

            return contextMenuStrip;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Baut das ContextMenu in der oberen Leiste
        /// </summary>
        private void CreateMenuStrip()
        {
            this.Controls.Add(menuStrip);

            ToolStripMenuItem file = new ToolStripMenuItem
            {
                //Image = Resources.Exclamation,
                Text = "File",
                ImageAlign = ContentAlignment.MiddleRight,
                ToolTipText = "Test",
            };

            ToolStripMenuItem edit = new ToolStripMenuItem
            {
                ImageAlign = ContentAlignment.MiddleRight,
                //Image = Resources.Exclamation,
                Text = "Edit",
                ToolTipText = "Test123"
            };

            ToolStripMenuItem help = new ToolStripMenuItem
            {
                ImageAlign = ContentAlignment.MiddleRight,
                //Image = Resources.Exclamation,
                Text = "Help",
                ToolTipText = "Test123"
            };
            // File

            ToolStripMenuItem setSource = new ToolStripMenuItem("Set source", Resources.Write, btnChooseDir1_Click, "itemSource");
            ToolStripMenuItem setDest = new ToolStripMenuItem("Set destination", Resources.Write, btnChooseDir2_Click, "itemDest");
            ToolStripMenuItem savePaths = new ToolStripMenuItem("Save paths", Resources.Save, btnSavePaths_Click, "itemsavePaths");
            ToolStripSeparator sep = new ToolStripSeparator();
            ToolStripMenuItem quit = new ToolStripMenuItem("Quit", Resources.Exit, btnQuit_Click, "itemQuit");

            file.DropDownItems.Add(setSource);
            file.DropDownItems.Add(setDest);
            file.DropDownItems.Add(savePaths);
            file.DropDownItems.Add(sep);
            file.DropDownItems.Add(quit);

            // End File

            // Edit

            ToolStripMenuItem path1 = new ToolStripMenuItem("Source-path", Resources.FolderClosed);
            ToolStripMenuItem path1Duplicates = new ToolStripMenuItem("Search for duplicates", Resources.Search16);
            path1Duplicates.Click += Path1Duplicates_Click;

            ToolStripMenuItem path1SortFiles = new ToolStripMenuItem("Sort files", Resources.Sort);
            path1SortFiles.Click += Path1Sort_Click;

            ToolStripMenuItem path1SortFolder = new ToolStripMenuItem("Sort folders", Resources.Subfolders16);
            path1SortFolder.Click += Path1SortFolder_Click;

            ToolStripMenuItem path1OpenExplorer = new ToolStripMenuItem("Show in explorer", Resources.FolderOpened);
            path1OpenExplorer.Click += Path1OpenExplorer_Click;

            path1.DropDownItems.Add(path1Duplicates);
            path1.DropDownItems.Add(path1SortFiles);
            path1.DropDownItems.Add(path1SortFolder);
            path1.DropDownItems.Add(path1OpenExplorer);

            ToolStripMenuItem path2 = new ToolStripMenuItem("Dest-path", Resources.FolderClosed);
            ToolStripMenuItem path2Duplicates = new ToolStripMenuItem("Search for duplicates", Resources.Search16);
            path2Duplicates.Click += Path2Duplicates_Click;

            ToolStripMenuItem path2SortFiles = new ToolStripMenuItem("Sort files", Resources.Sort);
            path2SortFiles.Click += Path2Sort_Click;

            ToolStripMenuItem path2SortFolder = new ToolStripMenuItem("Sort folders", Resources.Subfolders16);
            path2SortFolder.Click += Path2SortFolder_Click;

            ToolStripMenuItem path2OpenExplorer = new ToolStripMenuItem("Show in explorer", Resources.FolderOpened);
            path2OpenExplorer.Click += Path2OpenExplorer_Click;

            path2.DropDownItems.Add(path2Duplicates);
            path2.DropDownItems.Add(path2SortFiles);
            path2.DropDownItems.Add(path2SortFolder);
            path2.DropDownItems.Add(path2OpenExplorer);

            ToolStripMenuItem openDuplicates = new ToolStripMenuItem("Search for duplicates", Resources.Search16);
            openDuplicates.Click += OpenDuplicates_Click;

            ToolStripMenuItem openSortFiles = new ToolStripMenuItem("Sort files in..", Resources.Sort);
            openSortFiles.Click += OpenSortFiles_Click;

            ToolStripMenuItem openSortFolders = new ToolStripMenuItem("Sort folders in..", Resources.Subfolders16);
            openSortFolders.Click += OpenSortFolders_Click;

            ToolStripMenuItem changePaths = new ToolStripMenuItem("Change paths", Resources.Exchange, btnChangeDirs_Click, "itemChangePaths");
            ToolStripMenuItem advancedFilter = new ToolStripMenuItem("Advanced filter settings", Resources.Filter, btnAdvancedFilter_Click, "itemAdvancedFilter");

            edit.DropDownItems.Add(path1);
            edit.DropDownItems.Add(path2);
            edit.DropDownItems.Add(openDuplicates);
            edit.DropDownItems.Add(openSortFiles);
            edit.DropDownItems.Add(openSortFolders);
            edit.DropDownItems.Add(changePaths);
            edit.DropDownItems.Add(advancedFilter);

            // End Edit

            // Help

            ToolStripMenuItem info = new ToolStripMenuItem("Info", Resources.Info, btnInfo_Click, "itemInfo");
            help.DropDownItems.Add(info);

            menuStrip.Items.Add(file);
            menuStrip.Items.Add(edit);
            menuStrip.Items.Add(help);

            // End Help

            menuStrip.Show();
        }
        #region MenuStrip Methoden

        private void OpenSortFolders_Click(object sender, EventArgs e)
        {
            OpenSortFolders();
        }

        private void OpenSortFiles_Click(object sender, EventArgs e)
        {
            OpenSortFiles();
        }

        private void OpenDuplicates_Click(object sender, EventArgs e)
        {
            FrmDuplicates duplicates = new FrmDuplicates();
            duplicates.ShowDialog();
        }

        private void Path1OpenExplorer_Click(object sender, EventArgs e)
        {
            if (!confirmPath1)
            {
                OpenFileBrowser(true);

            }
            if (confirmPath1)
            {
                Supporter.OpenPath(textBoxDir1.Text);
            }
        }

        private void Path2OpenExplorer_Click(object sender, EventArgs e)
        {
            if (!confirmPath2)
            {
                OpenFileBrowser(false);
            }
            if (confirmPath2)
            {
                Supporter.OpenPath(textBoxDir2.Text);
            }
        }

        private void Path1SortFolder_Click(object sender, EventArgs e)
        {
            if (!confirmPath1)
            {
                OpenFileBrowser(true);
            }
            if (confirmPath1)
            {
                FrmSort sort = new FrmSort(Directory.GetDirectories(textBoxDir1.Text, "*.*", checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly), textBoxDir1.Text, false, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        private void Path2SortFolder_Click(object sender, EventArgs e)
        {
            if (!confirmPath2)
            {
                OpenFileBrowser(false);
            }
            if (confirmPath2)
            {
                FrmSort sort = new FrmSort(Directory.GetDirectories(textBoxDir2.Text, "*.*", checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly), textBoxDir2.Text, false, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        private void Path1Sort_Click(object sender, EventArgs e)
        {
            if (!confirmPath1)
            {
                OpenFileBrowser(true);
            }
            if (confirmPath1)
            {
                FrmSort sort = new FrmSort(GetFilesFiltered(textBoxDir1.Text), textBoxDir1.Text, true, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        private void Path2Sort_Click(object sender, EventArgs e)
        {
            if (!confirmPath2)
            {
                OpenFileBrowser(false);
            }
            if (confirmPath2)
            {
                FrmSort sort = new FrmSort(GetFilesFiltered(textBoxDir2.Text), textBoxDir2.Text, true, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        private void Path1Duplicates_Click(object sender, EventArgs e)
        {
            if (!confirmPath1)
            {
                OpenFileBrowser(true);
            }
            if (confirmPath1)
            {
                FrmDuplicates duplicates = new FrmDuplicates(textBoxDir1.Text);
                duplicates.ShowDialog();
            }
        }

        private void Path2Duplicates_Click(object sender, EventArgs e)
        {
            if (!confirmPath2)
            {
                OpenFileBrowser(false);
            }
            if (confirmPath2)
            {
                FrmDuplicates duplicates = new FrmDuplicates(textBoxDir2.Text);
                duplicates.ShowDialog();
            }
        }

        #endregion MenuStrip Methoden

        private void SortFolder_Click(object sender, EventArgs e)
        {
            sortButtonisFiles = false;
            btnShowFiles1.Image = Resources.Subfolders16;
            btnShowFiles2.Image = Resources.Subfolders16;
        }

        private void SortFiles_Click(object sender, EventArgs e)
        {
            sortButtonisFiles = true;
            btnShowFiles1.Image = Resources.Sort;
            btnShowFiles2.Image = Resources.Sort;
        }

        #endregion Konstruktoren

        #region Properties

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Instanz des DataStores
        /// </summary>
        public static DataStore dataStore { get; set; }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Instanz des Supporter
        /// </summary>
        public static Supporter Supporter { get; set; }

        #endregion Properties

        #region Interne Variablen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Leiste am oberen Programm-rand
        /// </summary>
        private MenuStrip menuStrip = new MenuStrip();

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private string[] pathsTo;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private string[] pathsFrom;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private string globalMode = "update";

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private string globalSource;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private string globalDest;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private bool confirmPath1 = false;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Description
        /// </summary>
        private bool confirmPath2 = false;

        /// <summary>
        /// 
        /// </summary>
        private bool sortButtonisFiles;

        #endregion Interne Variablen

        #region Jobs

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Holt sich aus dem Zieverzeichnis alle neuen Dateien und kopiert diese ins Stammverzeichnis, lässt dabei das Zielverzeichnis unverändert
        /// </summary>
        private void UpdateJob(string source, string dest)
        {
            string[] filesToUpdate = GetMissingFiles(dest, source);

            string[] pathsToUpdate = BuildPaths(filesToUpdate, dest, source);

            CheckDirectories(filesToUpdate, dest, source, false);
            progressBar.Maximum = filesToUpdate.Length;
            progressBar.Value = 0;

            for (int i = 0; i < filesToUpdate.Length; i++)
            {
                File.Copy(filesToUpdate[i], pathsToUpdate[i], true);
                progressBar.Value++;
            }

            MessageBox.Show((string.Format("Folder {0} have now all files of Folder {1} \r\n Folder {0} includes {2} new files and {3} new directories",
                Supporter.GetFolderName(globalSource), Supporter.GetFolderName(globalDest), filesToUpdate.Length, labelFoldersCount.Text)), "Transfer successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnStart.Enabled = false;
            btnRefresh.Enabled = true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Entnimmt dem Stammverzeichnis die im Zielordner fehlenden dateien und gleich diese ab, lässt jedoch das Stammverzeichnis unverändert
        /// </summary>
        private void UpgradeJob(string source, string dest)
        {
            string[] filesToUpgrade = GetMissingFiles(source, dest);

            string[] pathsToUpgrade = BuildPaths(filesToUpgrade, source, dest);

            CheckDirectories(filesToUpgrade, source, dest, false);
            progressBar.Maximum = filesToUpgrade.Length;
            progressBar.Value = 0;

            for (int i = 0; i < filesToUpgrade.Length; i++)
            {
                File.Copy(filesToUpgrade[i], pathsToUpgrade[i], true);
                progressBar.Value++;
            }
            MessageBox.Show((string.Format("Folder {0} have now all files of Folder {1} \r\n Folder {0} includes {2} new files and {3} new directories",
                Supporter.GetFolderName(globalDest), Supporter.GetFolderName(globalSource), filesToUpgrade.Length, labelFoldersCount.Text)), "Transfer successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnStart.Enabled = false;
            btnRefresh.Enabled = true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bringt beide Verzeichnisse auf den jeweils neusten stand
        /// </summary>
        private void ExchangeJob(string source, string dest)
        {
            UpgradeJob(source, dest);
            UpdateJob(source, dest);
        }

        #endregion Jobs

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Desc
        /// </summary>
        private void SwitchJobs(string mode, string source, string dest)
        {
            labelProcess.Visible = false;
            btnRefresh.Enabled = false;
            switch (mode.ToLower())
            {
                case "update":
                    UpdateJob(source, dest);
                    break;

                case "upgrade":
                    UpgradeJob(source, dest);
                    break;

                case "mirror":
                    ExchangeJob(source, dest);
                    break;

                default:
                    DialogResult result = MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        SwitchJobs(mode, source, dest);
                    }
                    break;
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bekommt zu sichernde Dateien und schaut, ob die dafür benötigten Ordner im Zielverzeichnis vorhanden sind
        /// </summary>
        private void CheckDirectories(string[] filesToBackup, string rootDir, string destDir, bool preview = true)
        {
            List<string> allDirs = new List<string>();
            int l = rootDir.Length;
            int counter = 0;
            for (int i = 0; i < filesToBackup.Length; i++)
            {
                string directory = Path.GetDirectoryName(filesToBackup[i]);
                if (!allDirs.Contains(directory))
                {
                    allDirs.Add(directory);
                }
            }

            for (int i = 0; i < allDirs.Count; i++)
            {
                allDirs[i] = destDir + allDirs[i].Substring(l);
            }

            foreach (string path in allDirs)
            {
                counter++;
                if (!preview)
                {
                    Directory.CreateDirectory(path);
                }
            }
            labelFoldersCount.Text = counter.ToString();

            int fileCounter = Directory.GetFiles(rootDir, "*.*", SearchOption.AllDirectories).Length;
            if (counter == 0)
            {
                labelInfo.Text = "Source: There are no files in the maindirectory";
            }
            else if (counter == 1)
            {
                labelInfo.Text = string.Format("Source: There are {0} files in one sub-directory", fileCounter);
            }
            else
            {
                labelInfo.Text = string.Format("Source: There are {0} files in {1} directories", fileCounter, counter);
            }
        }

        /// <summary>
        /// Sucht alle Dateien im angegebenen Pfad mit Filteroptionen
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private string[] GetFilesFiltered(string source)
        {
            List<string> files = new List<string>();
            try
            {
                for (int i = 0; i < dataStore.filesExt.Length; i++)
                {
                    files.AddRange(Directory.GetFiles(source, dataStore.filesExt[i], checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                }

                if (files.Count == 0)
                {
                    return null;
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
        /// Gleicht zwei Verzeichnisse nach ihren Dateinamen ab und schaut ob diese bereits vorhanden sind
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        private string[] GetMissingFiles(string source, string dest)
        {
            string[] sourceFiles;
            List<string> toTransfer = new List<string>();
            if (checkBoxAdvancedFilter.Checked)
            {
                sourceFiles = GetFilesFiltered(source);
            }
            else
            {
                sourceFiles = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
            }

            List<string> sourceFileNames = new List<string>();
            if (sourceFiles != null)
            {
                foreach (string filePath in sourceFiles)
                {
                    sourceFileNames.Add(Path.GetFileName(filePath));
                }
                string[] destFiles = Directory.GetFiles(dest, "*.*", SearchOption.AllDirectories);
                progressBar.Maximum = destFiles.Length + 1;
                progressBar.Value = 0;
                List<string> destFileNames = new List<string>();
                foreach (string filePath in destFiles)
                {
                    destFileNames.Add(Path.GetFileName(filePath));
                    progressBar.Value++;
                }
                progressBar.Value = 0;
                progressBar.Maximum = sourceFiles.Length;
                List<string> containingFiles = new List<string>();
                labelProcess.Text = "Loading missing files...";
                for (int i = 0; i < sourceFileNames.Count; i++)
                {
                    progressBar.Value = i + 1;
                    if (!destFileNames.Contains(sourceFileNames[i]))
                    {
                        toTransfer.Add(sourceFiles[i]);
                    }
                    else
                    {
                        if (!checkBoxIgnoreTimeDiffs.Checked)
                        {
                            containingFiles.Add(sourceFiles[i]);
                        }
                    }
                }
                toTransfer.AddRange(GetUpdatedFiles(containingFiles, source, dest));

                labelProcess.Text = string.Format("Compared {0} files ", sourceFiles.Length + destFiles.Length);
                pathsFrom = toTransfer.ToArray();
                return toTransfer.ToArray();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Holt sich alle fehlenden Dateien aus dem angegeben Zielverzeichnis
        /// </summary>
        /// <param name="allContainingSourceFilePaths"></param>
        /// <param name="sourceDir"></param>
        /// <param name="destDir"></param>
        /// <returns></returns>
        private string[] GetUpdatedFiles(List<string> allContainingSourceFilePaths, string sourceDir, string destDir)
        {
            List<string> toBackup = new List<string>();
            List<string> sourceFiles = new List<string>();
            List<string> destFiles = new List<string>();
            List<string> allContainingSourceFileNames = Supporter.GetFileNameList(allContainingSourceFilePaths);
            string[] fileNamesInDestFolder = Directory.GetFiles(destDir, "*.*", SearchOption.AllDirectories);
            string[] filePathsInDestFolder = Directory.GetFiles(destDir, "*.*", SearchOption.AllDirectories);
            try
            {
                for (int i = 0; i < allContainingSourceFileNames.Count; i++) // ToDo: IndexOutOfRangeException aufgetreten
                {
                    if (i <= fileNamesInDestFolder.Length)
                    {
                        if (allContainingSourceFileNames.Contains(fileNamesInDestFolder[i]))
                        {
                            destFiles.Add(filePathsInDestFolder[i]);
                            sourceFiles.Add(allContainingSourceFilePaths[i]);
                        }
                    }
                    else
                    {
                        i = allContainingSourceFileNames.Count; // Ende der Schleife
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are hidden files in directory which wasn't included", "Compare not complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            for (int i = 0; i < destFiles.Count; i++)
            {
                FileInfo fileOne = new FileInfo(sourceFiles[i]);
                FileInfo fileTwo = new FileInfo(destFiles[i]);
                if (!checkBoxIgnoreFiledata.Checked)
                {
                    if (!FilesAreEqual_OneByte(fileOne, fileTwo) && fileOne.LastWriteTimeUtc.Ticks > fileTwo.LastWriteTimeUtc.Ticks)
                    {
                        toBackup.Add(sourceFiles[i]);
                    }
                }
                else if (!checkBoxIgnoreTimeDiffs.Checked)
                {
                    if (fileOne.LastWriteTimeUtc.Ticks > fileTwo.LastWriteTimeUtc.Ticks)
                    {
                        toBackup.Add(sourceFiles[i]);
                    }
                }
            }

            return toBackup.ToArray();
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Vergleich Dateien nach ihrem/r Binärwert/Größe
        /// </summary>
        private static bool FilesAreEqual_OneByte(FileInfo first, FileInfo second)
        {
            if (first.Length != second.Length)
                return false;

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (fs1.ReadByte() != fs2.ReadByte())
                        return false;
                }
            }

            return true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Baut die Pfade für die zu sicherenden Dateien
        /// </summary>
        private string[] BuildPaths(string[] toTransfer, string sourceDir, string destDir)
        {
            int l = sourceDir.Length;
            List<string> backupPaths = new List<string>();
            foreach (string file in toTransfer)
            {
                string path = destDir + file.Substring(l);
                if (!backupPaths.Contains(path))
                {
                    backupPaths.Add(path);
                }
            }
            pathsTo = backupPaths.ToArray();
            return backupPaths.ToArray();
        }

        /// <summary>
        /// Entscheidet anhand des ausgewählten Modus die auszuführenden Methoden
        /// </summary>
        private void BuildComponents()
        {
            if (radioButtonUpdate.Checked)
            {
                globalMode = "Update";
            }
            else if (radioButtonUpgrade.Checked)
            {
                globalMode = "Upgrade";
            }
            else
            {
                globalMode = "Mirror";
            }
            switch (globalMode)
            {
                case "Update":
                    SetExchangeInfos(globalDest, globalSource);
                    break;

                case "Upgrade":
                    SetExchangeInfos(globalSource, globalDest);
                    break;
                    // ToDo: Mirror Funktion einbauen
            }
        }

        /// <summary>
        /// Holt sich nötigen Informationen zum zusammenfügen der zwei mitgegebenen Pfade
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        private void SetExchangeInfos(string source, string dest)
        {
            string[] filesToUpdate = GetMissingFiles(source, dest);
            if (filesToUpdate != null)
            {
                BuildPaths(filesToUpdate, source, dest);

                CheckDirectories(filesToUpdate, source, dest);

                labelDirName1.Text = Supporter.GetFolderName(source);
                toolTip.SetToolTip(labelDirName1, source);
                toolTip.SetToolTip(pictureBoxFolder1, source);
                labelDirName2.Text = Supporter.GetFolderName(dest);
                toolTip.SetToolTip(labelDirName2, dest);
                toolTip.SetToolTip(pictureBoxFolder2, dest);

                labelDirLength2.Text = dataStore.getDataSizeString(Supporter.GetDirSize(textBoxDir2.Text));
                labelDirLength1.Text = dataStore.getDataSizeString(Supporter.GetDirSize(textBoxDir1.Text));

                labelDirFilesTotal2.Text = string.Format("{0} files and {1} folders total", Directory.GetFiles(textBoxDir2.Text, "*.*", SearchOption.AllDirectories).Length,
                    Directory.GetDirectories(textBoxDir2.Text, "*.*", SearchOption.AllDirectories).Length);

                labelDirFilesTotal1.Text = string.Format("{0} files and {1} folders total", Directory.GetFiles(textBoxDir1.Text, "*.*", SearchOption.AllDirectories).Length,
                    Directory.GetDirectories(textBoxDir1.Text, "*.*", SearchOption.AllDirectories).Length);

                labelFilesCount.Text = filesToUpdate.Length.ToString();
                labelFilesLength.Text = dataStore.getDataSizeString(Supporter.GetBytesOfFiles(filesToUpdate));
                SwitchLabels(true);
                btnStart.Text = "Sync";
            }
            else
            {
                MessageBox.Show("Make sure your filter settings are correct configured.", "No files found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Öffnet einen FolderBrowserDialog und gibt den entsprechenden Pfad in die Textbox zurück
        /// </summary>
        /// <param name="isTxtBox1"></param>
        private void OpenFileBrowser(bool isTxtBox1, string path = "")
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

            openPath.ShowDialog();
            if (!Directory.Exists(openPath.SelectedPath) || openPath.SelectedPath == desktop)
            {
                // ToDo: Pfad ist nicht verfügbar
                if (isTxtBox1)
                {
                    confirmPath1 = false;
                }
                else
                {
                    confirmPath2 = false;
                }
            }
            else
            {
                if (isTxtBox1)
                {
                    textBoxDir1.Text = openPath.SelectedPath;
                    globalDest = openPath.SelectedPath;
                    confirmPath1 = true;
                    Settings.Default.oldPath1 = Settings.Default.Path1;
                    Settings.Default.Path1 = openPath.SelectedPath;
                    Settings.Default.Save();
                }
                else
                {
                    textBoxDir2.Text = openPath.SelectedPath;
                    globalSource = openPath.SelectedPath;
                    confirmPath2 = true;
                    Settings.Default.oldPath2 = Settings.Default.Path2;
                    Settings.Default.Path2 = openPath.SelectedPath;
                    Settings.Default.Save();
                }

                if (confirmPath1 && confirmPath2 && checkBoxInstantPreview.Checked)
                {
                    BuildComponents();
                }
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Prüft beide Pfade und verändert dementsprechend den Validieren Button
        /// </summary>
        private void CheckPaths()
        {
            if (!string.IsNullOrWhiteSpace(textBoxDir1.Text) || !string.IsNullOrWhiteSpace(textBoxDir2.Text))
            {
                if (Directory.Exists(textBoxDir1.Text) && (textBoxDir2.Text != textBoxDir1.Text)) // Verzeichnis 1 existiert
                {
                    confirmPath1 = true;
                    globalSource = textBoxDir1.Text;
                    btnLink1.Enabled = true;
                    btnCompare1.Enabled = true;
                    btnShowFiles1.Enabled = true;
                    pictureBoxCheckDir1.Image = Resources.TickSmall;
                }
                else
                {
                    confirmPath1 = false;
                    btnLink1.Enabled = false;
                    btnCompare1.Enabled = false;
                    btnShowFiles1.Enabled = false;
                    pictureBoxCheckDir1.Image = Resources.Exclamation;
                }

                if (Directory.Exists(textBoxDir2.Text) && (textBoxDir1.Text != textBoxDir2.Text)) // Verzeichnis 2 existiert
                {
                    confirmPath2 = true;
                    globalDest = textBoxDir2.Text;
                    btnLink2.Enabled = true;
                    btnCompare2.Enabled = true;
                    btnShowFiles2.Enabled = true;
                    pictureBoxCheckDir2.Image = Resources.TickSmall;
                }
                else
                {
                    confirmPath2 = false;
                    btnLink2.Enabled = false;
                    btnCompare2.Enabled = false;
                    btnShowFiles2.Enabled = false;
                    pictureBoxCheckDir2.Image = Resources.Exclamation;
                }

                if (confirmPath1 && confirmPath2 && checkBoxInstantPreview.Checked) // Verzeichnisse existieren && Preview = ON
                {
                    BuildComponents();

                    btnStart.Enabled = true;
                }
                else if (confirmPath1 && confirmPath2) // Verzeichnisse existieren && Preview = OFF
                {
                    btnStart.Text = "Validate";
                    SwitchLabels(false);
                    btnStart.Enabled = true;
                }
                else
                {
                    btnStart.Text = "Validate";
                    SwitchLabels(false);
                    btnStart.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Verändert die Sichtbarkeit der Labels welche zum vergleichen von Ordnern verwendet werden
        /// </summary>
        /// <param name="toggle"></param>
        private void SwitchLabels(bool toggle)
        {
            labelAboutToAdd.Visible = (toggle);
            labelDirFilesTotal1.Visible = (toggle);
            labelDirFilesTotal2.Visible = (toggle);
            labelDirLength1.Visible = (toggle);
            labelDirLength2.Visible = (toggle);
            labelDirName1.Visible = (toggle);
            labelDirName2.Visible = (toggle);
            labelFilesCount.Visible = (toggle);
            labelFilesLength.Visible = (toggle);
            labelFilesTxt.Visible = (toggle);
            labelFoldersCount.Visible = (toggle);
            labelFoldersTxt.Visible = (toggle);
            labelInfo.Visible = (toggle);
            labelProcess.Visible = (toggle);
            pictureBoxFiles.Visible = (toggle);
            pictureBoxFolder1.Visible = (toggle);
            pictureBoxFolder2.Visible = (toggle);
            pictureBoxArrow.Visible = (toggle);
            btnShowTransfer.Enabled = (toggle);
            btnSortFiles.Visible = (!toggle);
            btnSortFolders.Visible = (!toggle);
            btnDuplicates.Visible = (!toggle);
            btnFilter.Visible = (!toggle);
            btnQuitApp.Visible = (!toggle);
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Speichert die angegeben Pfade in den TextBoxen in die Settings
        /// </summary>
        private void SavePaths()
        {
            Settings.Default.Path1 = textBoxDir2.Text;
            Settings.Default.Path2 = textBoxDir1.Text;
            Settings.Default.Save();
            btnSavePaths.Enabled = false;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Prüft, ob der Speichern button aktiviert oder deaktiviert ist
        /// </summary>
        private void CheckSaveButton()
        {
            if (textBoxDir2.Text != Settings.Default.Path1 || textBoxDir1.Text != Settings.Default.Path2)
            {
                btnSavePaths.Enabled = true;
            }
            else
            {
                btnSavePaths.Enabled = false;
            }
        }

        private void OpenSortFolders()
        {
            FolderBrowserDialogEx files = new FolderBrowserDialogEx()
            {
                Description = "Choose a directory",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowEditBox = true,
                ShowFullPathInEditBox = true
            };
            files.ShowDialog();

            if (Directory.Exists(files.SelectedPath))
            {
                FrmSort sort = new FrmSort(Directory.GetDirectories(files.SelectedPath, "*.*", checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly), files.SelectedPath, false, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        private void OpenSortFiles()
        {
            FolderBrowserDialogEx files = new FolderBrowserDialogEx()
            {
                Description = "Choose a directory",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowEditBox = true,
                ShowFullPathInEditBox = true
            };
            files.ShowDialog();
            if (Directory.Exists(files.SelectedPath))
            {
                FrmSort sort = new FrmSort(Directory.GetFiles(files.SelectedPath, "*.*", checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly), files.SelectedPath, true, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        private void ChangeDirs()
        {
            string dir1 = textBoxDir2.Text;
            textBoxDir2.Text = textBoxDir1.Text;
            textBoxDir1.Text = dir1;
        }
        #endregion Methoden

        #region Buttons

        /// <summary>
        /// Öffnet einen FolderBrowseDialog für den Anwender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseDir1_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(textBoxDir1.Text))
            {
                OpenFileBrowser(true, textBoxDir1.Text);
            }
            else if (Directory.Exists(Settings.Default.oldPath1))
            {
                OpenFileBrowser(true, Settings.Default.oldPath1);
            }
            else
            {
                OpenFileBrowser(true);
            }
        }

        /// <summary>
        /// Öffnet einen FolderBrowseDialog für den Anwender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseDir2_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(textBoxDir2.Text))
            {
                OpenFileBrowser(false, textBoxDir2.Text);
            }
            else if (Directory.Exists(Settings.Default.oldPath2))
            {
                OpenFileBrowser(false, Settings.Default.oldPath2);
            }
            else
            {
                OpenFileBrowser(false);
            }
        }

        /// <summary>
        /// Validiert/Synchronisiert die angegebenen Pfade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, System.EventArgs e)
        {
            if (btnStart.Text.Equals("Sync"))
            {
                SwitchJobs(globalMode, textBoxDir1.Text, textBoxDir2.Text);
                if (checkBoxAutoSavePaths.Checked)
                {
                    SavePaths();
                }
            }
            else
            {
                CheckPaths();
                BuildComponents();
            }
        }

        /// <summary>
        /// Vertauscht die angegebenen Pfade der Textboxen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeDirs_Click(object sender, EventArgs e)
        {
            ChangeDirs();
        }

        /// <summary>
        /// Öffnen den Filter-Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancedFilter_Click(object sender, EventArgs e)
        {
            Supporter.OpenFilter();
        }

        /// <summary>
        /// Speichert die angegeben Pfade in den TextBoxen in die Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePaths_Click(object sender, EventArgs e)
        {
            SavePaths();
        }

        /// <summary>
        /// Zeigt Info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DirectoryExchanger by Marley Finger \r\nAll Rights Reserved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Schließt die Anwendung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Zeigt einen Dialog zum auswählen des ersten Pfades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLink1_Click(object sender, EventArgs e)
        {
            Supporter.OpenPath(textBoxDir1.Text);
        }

        /// <summary>
        /// Zeigt einen Dialog zum auswählen des zweiten Pfades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLink2_Click(object sender, EventArgs e)
        {
            Supporter.OpenPath(textBoxDir2.Text);
        }

        /// <summary>
        /// Öffnet ein Fenster zum einsehen der zu transferierenden Daten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowTransferData_Click(object sender, EventArgs e)
        {
            FrmShowTransferData transferData;
            if (globalMode == "upgrade")
            {
                transferData = new FrmShowTransferData(pathsFrom, pathsTo, globalSource, globalDest, labelFilesLength.Text);
            }
            else /*if (globalMode == "update")*/
            {
                transferData = new FrmShowTransferData(pathsFrom, pathsTo, globalDest, globalSource, labelFilesLength.Text);
            }    
            transferData.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowFiles1_Click(object sender, EventArgs e)
        {
            if (sortButtonisFiles)
            {
                FrmSort sort = new FrmSort(GetFilesFiltered(textBoxDir1.Text), textBoxDir1.Text, true, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
            else
            {
                FrmSort sort = new FrmSort(Directory.GetDirectories(textBoxDir1.Text, "*.*", checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly), textBoxDir1.Text, false, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowFiles2_Click(object sender, EventArgs e)
        {
            if (sortButtonisFiles)
            {
                FrmSort sort = new FrmSort(GetFilesFiltered(textBoxDir2.Text), textBoxDir2.Text, true, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
            else
            {
                FrmSort sort = new FrmSort(Directory.GetDirectories(textBoxDir2.Text, "*.*", checkBoxSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly), textBoxDir2.Text, false, checkBoxSubfolders.Checked);
                sort.ShowDialog();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuplicates_Click(object sender, EventArgs e)
        {
            FrmDuplicates duplicates = new FrmDuplicates("", false);
            duplicates.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortFiles_Click(object sender, EventArgs e)
        {
            OpenSortFiles();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortFolders_Click(object sender, EventArgs e)
        {
            OpenSortFolders();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            Supporter.OpenFilter();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckPaths();
            CheckSaveButton();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare1_Click(object sender, EventArgs e)
        {
            FrmDuplicates compare = new FrmDuplicates(textBoxDir1.Text);
            compare.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare2_Click(object sender, EventArgs e)
        {
            FrmDuplicates compare = new FrmDuplicates(textBoxDir2.Text);
            compare.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowFiles1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BuildContextMenuStrip().Show(Cursor.Position);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowFiles2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BuildContextMenuStrip().Show(Cursor.Position);
            }
        }

        #endregion Buttons

        #region Events
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDirectoryExchanger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.allDirs = checkBoxSubfolders.Checked;
            Settings.Default.isPaths = sortButtonisFiles;
            Settings.Default.ignoreTimeDiffs = checkBoxIgnoreTimeDiffs.Checked;
            Settings.Default.instantPreview = checkBoxInstantPreview.Checked;
            Settings.Default.ignoreFileData = checkBoxIgnoreFiledata.Checked;
            Settings.Default.advancedFilter = checkBoxAdvancedFilter.Checked;
            Settings.Default.autoSavePaths = checkBoxAutoSavePaths.Checked;
            Settings.Default.Save();
        }

        /// <summary>
        /// Ändert den Globalmode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonUpgrade_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonUpdate.Checked)
            {
                globalMode = "upgrade";
                CheckPaths();
                MessageBox.Show("This function is currently not implemented, but you can do it as well if you switch the paths...", "Not implemented exception");
                radioButtonUpdate.Select();
                ChangeDirs();
            }
        }

        /// <summary>
        /// Ändert den Globalmode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            globalMode = "update";
            CheckPaths();
        }

        /// <summary>
        /// Ändert den Globalmode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMirror_CheckedChanged(object sender, EventArgs e)
        {
            //globalMode = "mirror";
            MessageBox.Show("This function is currently not implemented, but you can do it as well if update and upgrade two paths one after the other", "Not implemented exception");
            radioButtonUpdate.Select();
            ChangeDirs();
        }

        /// <summary>
        /// Führt prüfungen aus sobald sich der Inhalt ändert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDir1_TextChanged(object sender, EventArgs e)
        {
            CheckPaths();
            CheckSaveButton();
        }

        /// <summary>
        /// Führt prüfungen aus sobald sich der Inhalt ändert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDir2_TextChanged(object sender, EventArgs e)
        {
            CheckPaths();
            CheckSaveButton();
        }

        #endregion Events
    }
}