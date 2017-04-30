using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using DirectoryExchanger.Properties;

namespace DirectoryExchanger
{
    public partial class FrmDuplicates : Form
    {
        #region Konstruktor

        public FrmDuplicates(string path = "", bool showFilebrowser = true)
        {
            InitializeComponent();
            Init();
            if ((path == string.Empty || !Directory.Exists(path)) && showFilebrowser)
            {
                textBoxPath.Text = OpenFileBrowser();
            }
            else
            {
                textBoxPath.Text = path;
            }
            directoryPath = textBoxPath.Text;
        }

        /// <summary>
        /// Erweiterter Konstruktor
        /// </summary>
        private void Init()
        {
            LoadSettings();
        }

        /// <summary>
        /// Lädt die Einstellungen in die checkboxen
        /// </summary>
        private void LoadSettings()
        {
            checkBoxAllDirectories.Checked = Settings.Default.allDirs;
            checkBoxIgnoreEmpty.Checked = Settings.Default.ignoreFileData;
            checkBoxAdvancedFilter.Checked = Settings.Default.advancedFilter;
            checkBoxInstantPreview.Checked = Settings.Default.instantPreview;
        }

        /// <summary>
        /// Speichert den CheckState der Checkboxen in die Anwendungseinstellungseigenschaften
        /// </summary>
        private void SaveSettings()
        {
            Settings.Default.allDirs = checkBoxAllDirectories.Checked;
            Settings.Default.ignoreFileData = checkBoxIgnoreEmpty.Checked;
            Settings.Default.advancedFilter = checkBoxAdvancedFilter.Checked;
            Settings.Default.instantPreview = checkBoxInstantPreview.Checked;
            Settings.Default.Save();
        }

        #endregion Konstruktor

        #region Interne Variablen

        /// <summary>
        /// Datastore für werte
        /// </summary>
        private DataStore dataStore = FrmDirectoryExchanger.dataStore;

        private string directoryPath;

        private string thisFile;

        private string otherFile;

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste der Pfade
        /// </summary>
        private List<string> allFiles = new List<string>();

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste der Pfade
        /// </summary>
        private List<DoubleFilePair> fileList = new List<DoubleFilePair>();

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste der Pfade
        /// </summary>
        private List<string> duplicatePathsOne = new List<string>();

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste der Pfade
        /// </summary>
        private List<string> duplicatePathsTwo = new List<string>();

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste der Namen
        /// </summary>
        private List<string> duplicateNamesOne = new List<string>();

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liste der Namen
        /// </summary>
        private List<string> duplicateNamesTwo = new List<string>();

        #endregion Interne Variablen

        #region Primäre Funktionen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Handler für das Vergleichen von kompletten Verzeichnissen
        /// </summary>
        private void DuplicateCheckJob(string dir)
        {
            try
            {
                CompareDirectory(allFiles.ToArray(), checkBoxAdvancedFilter.Checked);

                if (duplicatePathsOne.Count > 0)
                {
                    FillLists(duplicatePathsOne, duplicatePathsTwo);
                    MessageBox.Show("Found duplicates: " + duplicatePathsOne.Count.ToString(), "Compare successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There are no files duplicated\r\nDon't forget to check the 'All' checkbox if you want to"
                        , "Compare successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message, "Compare failed!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    DuplicateCheckJob(dir);
                }
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Druchsucht ein Verzeichnis nach Duplikaten
        /// </summary>
        private void CompareDirectory(string[] files, bool advanced = false)
        {
            progressBar.Maximum = allFiles.Count;
            if (!advanced)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    progressBar.Value = i + 1;
                    FileInfo one = new FileInfo(files[i]);

                    for (int i2 = 0; i2 < files.Length; i2++)
                    {
                        if (i != i2 && !duplicatePathsOne.Contains(files[i2]))
                        {
                            FileInfo two = new FileInfo(files[i2]);
                            if (checkBoxIgnoreEmpty.Checked && one.Length != 0 || two.Length != 0)
                            {
                                if (FilesAreEqual_OneByte(one, two))
                                {
                                    duplicatePathsOne.Add(files[i]);
                                    duplicateNamesOne.Add(Path.GetFileName(files[i]));
                                    duplicatePathsTwo.Add(files[i2]);
                                    duplicateNamesTwo.Add(Path.GetFileName(files[i2]));
                                    fileList.Add(new DoubleFilePair(files[i], files[i2]));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < files.Length; i++)
                {
                    progressBar.Value = i + 1;
                    FileInfo one = new FileInfo(files[i]);

                    for (int i2 = 0; i2 < files.Length; i2++)
                    {
                        if (i != i2 && !duplicatePathsOne.Contains(files[i2]))
                        {
                            FileInfo two = new FileInfo(files[i2]);
                            if (checkBoxIgnoreEmpty.Checked && one.Length != 0 || two.Length != 0)
                            {
                                if (FilesAreEqual_OneByte(one, two) && FilesAreEqual_Hash(one, two))
                                {
                                    duplicatePathsOne.Add(files[i]);
                                    duplicateNamesOne.Add(Path.GetFileName(files[i]));
                                    duplicatePathsTwo.Add(files[i2]);
                                    duplicateNamesTwo.Add(Path.GetFileName(files[i2]));
                                    fileList.Add(new DoubleFilePair(files[i], files[i2]));
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Befüllt die listen
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        private void FillLists(List<string> one, List<string> two)
        {
            int index = textBoxPath.Text.Length + 1;
            List<string> pathsOne = new List<string>(); // = one.ToArray();
            List<string> pathsTwo = new List<string>(); // = two.ToArray();
            for (int i = 0; i < one.Count; i++)
            {
                pathsOne.Add(one[i].Substring(index));
                pathsTwo.Add(two[i].Substring(index));
            }
            listBox1.DataSource = pathsOne;
            listBox2.DataSource = pathsTwo;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Vergleich Dateien nach ihrem Binärwert
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
        /// Vergleicht Dateien nach dem Hashcode
        /// </summary>
        private static bool FilesAreEqual_Hash(FileInfo first, FileInfo second)
        {
            byte[] firstHash = MD5.Create().ComputeHash(first.OpenRead());
            byte[] secondHash = MD5.Create().ComputeHash(second.OpenRead());

            for (int i = 0; i < firstHash.Length; i++)
            {
                if (firstHash[i] != secondHash[i])
                    return false;
            }
            return true;
        }

        #endregion

        #region Methoden



        private ContextMenuStrip BuildContextMenu(string thisFile, string otherFile)
        {
            this.thisFile = thisFile;
            this.otherFile = otherFile;
            Bitmap pic = Icon.ExtractAssociatedIcon(thisFile).ToBitmap();
            ToolStripMenuItem showThis = new ToolStripMenuItem("Open file", pic);
            showThis.Click += ShowThis_Click;
            ToolStripMenuItem showOpponent = new ToolStripMenuItem("Open folder", Resources.FolderOpened);
            showOpponent.Click += ShowOpponent_Click;
            ToolStripMenuItem[] fileMenus = { showThis, showOpponent };
            ToolStripMenuItem fileName = new ToolStripMenuItem(Path.GetFileNameWithoutExtension(thisFile), pic, fileMenus);
            ToolStripMenuItem keepThis = new ToolStripMenuItem("Keep", Resources.TickSmall);
            keepThis.Click += KeepThis_Click;
            ToolStripMenuItem delThis = new ToolStripMenuItem("Delete", Resources.Error);
            delThis.Click += DelThis_Click;
            ToolStripMenuItem ignoreBoth = new ToolStripMenuItem("Ignore both", Resources.Denied);
            ignoreBoth.Click += IgnoreBoth_Click;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add(fileName);
            menu.Items.Add(keepThis);
            menu.Items.Add(delThis);
            menu.Items.Add(ignoreBoth);

            return menu;
        }

        #region ContextMenuActions

        private void IgnoreBoth_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox2.SelectedIndex)
            {
                int index = listBox1.SelectedIndex;
                duplicatePathsOne.RemoveAt(index);
                duplicateNamesOne.RemoveAt(index);
                duplicatePathsTwo.RemoveAt(index);
                duplicateNamesTwo.RemoveAt(index);
                FillLists(duplicatePathsOne, duplicatePathsTwo);
            }
        }

        private void DelThis_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox2.SelectedIndex)
            {
                try
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();

                    File.Delete(thisFile);
                    int index = listBox1.SelectedIndex;
                    duplicatePathsOne.RemoveAt(index);
                    duplicateNamesOne.RemoveAt(index);
                    duplicatePathsTwo.RemoveAt(index);
                    duplicateNamesTwo.RemoveAt(index);
                    FillLists(duplicatePathsOne, duplicatePathsTwo);
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("This file is currently in use by another application\r\n\r\n" + ex.Message, "File access error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        DelThis_Click(this, null);
                    }
                }
            }
        }

        private void KeepThis_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox2.SelectedIndex)
            {
                try
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(otherFile);
                    int index = listBox1.SelectedIndex;
                    duplicatePathsOne.RemoveAt(index);
                    duplicateNamesOne.RemoveAt(index);
                    duplicatePathsTwo.RemoveAt(index);
                    duplicateNamesTwo.RemoveAt(index);
                    FillLists(duplicatePathsOne, duplicatePathsTwo);
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("This file is currently in use by another application\r\n\r\n" + ex.Message, "File access error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        DelThis_Click(this, null);
                    }
                }
            }
        }

        private void ShowOpponent_Click(object sender, EventArgs e)
        {
            dataStore.OpenPath(Path.GetDirectoryName(otherFile));
        }

        private void ShowThis_Click(object sender, EventArgs e)
        {
            dataStore.OpenFile(thisFile);
        }

        #endregion ContextMenuActions
        private void LoadFilePair(int index)
        {
            labelFileName1.Text = fileList[index].FileNameFirst;
            labelFileName2.Text = fileList[index].FileNameSecond;
            labelFilePath1.Text = fileList[index].FilePathFirst;
            labelFilePath2.Text = fileList[index].FilePathSecond;
            labelFileSize1.Text = Supporter.GetDataSizeString(fileList[index].FileLengthFirst);
            labelFileSize2.Text = Supporter.GetDataSizeString(fileList[index].FileLengthSecond);
            labelFileLastWrite1.Text = fileList[index].LastModifiedFirstFile.ToString();
            labelFileLastWrite2.Text = fileList[index].LastModifiedSecondFile.ToString();
            labelFileCreation1.Text = fileList[index].DateOfCreationFirstFile.ToString();
            labelFileCreation2.Text = fileList[index].DateOfCreationSecondFile.ToString();
            if (fileList[index].FileLengthFirst != fileList[index].FileLengthSecond)
            {
                labelSize.Text = (fileList[index].FileLengthFirst > fileList[index].FileLengthSecond) ? ">" : "<";
            }
            else
            {
                labelSize.Text = "=";
            }
           
            if(fileList[index].LastModifiedFirstFile.Ticks != fileList[index].LastModifiedSecondFile.Ticks)
            {
                labelLastWrite.Text = (fileList[index].LastModifiedFirstFile.Ticks > fileList[index].LastModifiedSecondFile.Ticks) ? ">" : "<";
            }
            else
            {
                labelLastWrite.Text = "=";
            }

            if(fileList[index].DateOfCreationFirstFile.Ticks != fileList[index].DateOfCreationSecondFile.Ticks)
            {
                labelDOC.Text = (fileList[index].DateOfCreationFirstFile.Ticks > fileList[index].DateOfCreationSecondFile.Ticks) ? ">" : "<";

            }
            else
            {
                labelDOC.Text = "=";
            }
        }

        /// <summary>
        /// Validiert den eingegebenen Pfad, legt vorschaudaten in die labels und erzeugt eine Liste aller Dateien
        /// </summary>
        private void ValidatePath()
        {
            if (Directory.Exists(textBoxPath.Text))
            {
                string path = textBoxPath.Text;
                directoryPath = textBoxPath.Text;
                int filesTotal;
                int foldersTotal;

                foldersTotal = Directory.GetDirectories(path, "*.*", checkBoxAllDirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Length;
                if (checkBoxAdvancedFilter.Checked)
                {
                    allFiles = Supporter.GetFilesFiltered(path, dataStore.filesExt, checkBoxAllDirectories.Checked).ToList<string>();

                    filesTotal = allFiles.Count;
                }
                else
                {
                    allFiles = Directory.GetFiles(path, "*.*", checkBoxAllDirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList<string>();
                    filesTotal = allFiles.Count;
                }

                if (foldersTotal >= 2)
                {
                    btnShowFolders.Enabled = true;
                }
                else
                {
                    btnShowFolders.Enabled = false;
                }

                labelFoldername.Text = Path.GetFileName(path);
                labelFilesTotal.Text = string.Format("{0} files total", filesTotal);
                labelFoldersTotal.Text = string.Format("{0} subfolders", foldersTotal);
                ToggleLabels(true);
            }
        }

        /// <summary>
        /// Öffnet einen FolderBrowserDialog und lässt den Benutzer einen Pfad auswählen
        /// </summary>
        /// <returns></returns>
        private string OpenFileBrowser(string path = "")
        {
            FolderBrowserDialogEx openPath = new FolderBrowserDialogEx()
            {
                Description = "Choose a directory",
                ShowNewFolderButton = false,
                SelectedPath = Directory.Exists(path) ? path : Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                ShowEditBox = true,
                ShowFullPathInEditBox = true
            };
            openPath.ShowDialog();
            if (Directory.Exists(openPath.SelectedPath))
            {
                return openPath.SelectedPath;
            }
            else
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// Ändert die sichtbarkeit der Labels
        /// </summary>
        /// <param name="visible"></param>
        private void ToggleLabels(bool visible)
        {
            labelFilesTotal.Visible = visible;
            labelFoldername.Visible = visible;
            labelFoldersTotal.Visible = visible;
            pictureBoxFiles.Visible = visible;
            pictureBoxFolder.Visible = visible;
            pictureBoxFolders.Visible = visible;
            btnShowFiles.Visible = visible;
            btnShowFolders.Visible = visible;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Leert die Listen für einen neuen Suchvorgang
        /// </summary>
        private void ClearLists()
        {
            duplicateNamesOne.Clear();
            duplicateNamesTwo.Clear();
            duplicatePathsOne.Clear();
            duplicatePathsTwo.Clear();
        }

        private void Check()
        {
            if (!(duplicatePathsOne.Count == duplicatePathsTwo.Count))
            {
                pictureBoxWarning.Visible = true;
                toolTip.SetToolTip(pictureBoxWarning, "The Arraylists don't have the same length");
            }
            else
            {
                pictureBoxWarning.Visible = false;
                toolTip.SetToolTip(pictureBoxWarning, "");
            }
        }
        #endregion Methoden

        #region Buttons
        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            FrmSort sort = new FrmSort(allFiles.ToArray(), directoryPath, true, checkBoxAllDirectories.Checked, checkBoxAdvancedFilter.Checked);
            sort.ShowDialog();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            string oldPath = textBoxPath.Text;
            string newPath = OpenFileBrowser();
            if (!string.IsNullOrWhiteSpace(newPath))
            {
                textBoxPath.Text = newPath;
            };
        }

        private void btnShowFolders_Click(object sender, EventArgs e)
        {
            FrmSort sort = new FrmSort(Directory.GetDirectories(directoryPath, "*.*", SearchOption.AllDirectories), directoryPath, false, checkBoxAllDirectories.Checked, false);
            sort.ShowDialog();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            ClearLists(); // Ansonten stacken sich die Duplicates
            if (btnStart.Text == "Validate" && Directory.Exists(textBoxPath.Text))
            {
                ValidatePath();
                btnStart.Text = "Search >>";
            }
            else if (Directory.Exists(textBoxPath.Text) && btnStart.Text == "Search >>")
            {
                DuplicateCheckJob(textBoxPath.Text);
            }
        }

        private void btnAdvancedFilter_Click(object sender, EventArgs e)
        {
            FrmAdvancedFilter advancedFilter = new FrmAdvancedFilter();
            advancedFilter.ShowDialog();
        }

        #endregion Buttons

        #region Events

        private void FrmDuplicates_Load(object sender, EventArgs e)
        {
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxPath.Text))
            {
                btnStart.Enabled = true;
                pictureBoxCheckPath.Image = Resources.TickSmall;
                if (checkBoxInstantPreview.Checked)
                {
                    ValidatePath();
                    btnStart.Text = "Start >>";
                }
                else
                {
                    btnStart.Text = "Validate";
                }
            }
            else
            {
                pictureBoxCheckPath.Image = Resources.Exclamation;
                btnStart.Enabled = false;
            }
        }

        private void FrmDuplicates_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }


        private void checkBoxIgnoreEmpty_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPath_TextChanged(this, null);
        }

        private void checkBoxAllDirectories_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPath_TextChanged(this, null);
        }

        private void checkBoxAdvancedFilter_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPath_TextChanged(this, null);
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BuildContextMenu(duplicatePathsOne[listBox1.SelectedIndex], duplicatePathsOne[listBox2.SelectedIndex]).Show(Cursor.Position);
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BuildContextMenu(duplicatePathsOne[listBox2.SelectedIndex], duplicatePathsOne[listBox1.SelectedIndex]).Show(Cursor.Position);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                LoadFilePair(listBox1.SelectedIndex);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.SelectedIndex = listBox2.SelectedIndex;
                LoadFilePair(listBox2.SelectedIndex);
            }
        }
        #endregion Events
    }
}