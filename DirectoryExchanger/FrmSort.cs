using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DirectoryExchanger.Properties;

namespace DirectoryExchanger
{
    public partial class FrmSort : Form
    {
        #region Konstruktor
        /// <summary>
        ///
        /// </summary>
        /// <param name="allPaths"></param>
        /// <param name="rootPath"></param>
        /// <param name="files"></param>
        /// <param name="subDirectories"></param>
        /// <param name="filtered"></param>
        public FrmSort(string[] allPaths, string rootPath, bool files, bool subDirectories = false, bool filtered = false)
        {
            InitializeComponent();
            this.files = files;
            this.pathsArray = allPaths;
            this.rootPath = rootPath;
            this.subDirectories = subDirectories;
            this.filtered = filtered;
            checkBoxTopDirectoryOnly.Checked = subDirectories;
            checkBoxFilter.Checked = filtered;
            textBoxDir.Text = rootPath;
            btnBrowseBack.Visible = !files;
            LoadSettings();
            if (CheckPaths(allPaths, files))
            {
                paths = new List<string>(allPaths);
                Init(allPaths, files);
            }
        }

        #endregion Konstruktor

        #region Interne Variablen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// DataStore für Werte
        /// </summary>
        private DataStore dataStore = FrmDirectoryExchanger.dataStore;

        /// <summary>
        ///
        /// </summary>
        private List<string> paths;

        /// <summary>
        ///
        /// </summary>
        private List<string> names = new List<string>();

        /// <summary>
        ///
        /// </summary>
        private List<long> lenghts = new List<long>();

        /// <summary>
        ///
        /// </summary>
        private List<string> barList = new List<string>();

        /// <summary>
        ///
        /// </summary>
        private string[] pathsArray;

        /// <summary>
        ///
        /// </summary>
        private string rootPath;

        /// <summary>
        ///
        /// </summary>
        private bool files;

        /// <summary>
        ///
        /// </summary>
        private bool subDirectories;

        /// <summary>
        ///
        /// </summary>
        private bool filtered;

        /// <summary>
        ///
        /// </summary>
        private bool firstUse = true;

        #endregion Interne Variablen

        #region Primary Functions

        /// <summary>
        ///
        /// </summary>
        /// <param name="pathsToParse"></param>
        /// <param name="files"></param>
        private void Init(string[] pathsToParse, bool files)
        {
            FillValues(pathsToParse, files);
            BuildBars(lenghts.ToArray());
            FillDataGrid();
        }

        /// <summary>
        ///
        /// </summary>
        private void LoadSettings()
        {
            comboBoxDataSize.DataSource = dataStore.dataSizes;
            numericUpDownDigits.Value = Settings.Default.sortDigits;
            comboBoxDataSize.SelectedIndex = Settings.Default.sortSizes;
            labelPreview.Text = Supporter.BuildPi(comboBoxDataSize.SelectedValue.ToString(), numericUpDownDigits.Value);
        }

        /// <summary>
        ///
        /// </summary>
        private void SetConfig()
        {
            files = radioButtonFiles.Checked ? true : false;
            btnBrowseBack.Visible = !files;
            ClearLists();
            if (rootPath != textBoxDir.Text || filtered != checkBoxFilter.Checked || subDirectories != checkBoxTopDirectoryOnly.Checked || files == radioButtonFiles.Checked)
            {
                rootPath = textBoxDir.Text;
                filtered = checkBoxFilter.Checked;
                subDirectories = checkBoxTopDirectoryOnly.Checked;
                if (files)
                {
                    if (filtered)
                    {
                        pathsArray = Supporter.GetFilesFiltered(rootPath, dataStore.filesExt, subDirectories);
                        paths = pathsArray.ToList<string>();
                        names = Supporter.GetFileNameList(paths);
                    }
                    else
                    {
                        pathsArray = Directory.GetFiles(rootPath, "*.*", subDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                        paths = pathsArray.ToList<string>();
                        names = Supporter.GetFileNameList(paths);
                    }
                }
                else
                {
                    pathsArray = Directory.GetDirectories(rootPath, "*.*", subDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                    paths = pathsArray.ToList<string>();
                    names = Supporter.GetFileNameList(paths);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pathsToParse"></param>
        /// <param name="files"></param>
        private void FillValues(string[] pathsToParse, bool files)
        {
            labelFolderName.Text = Path.GetFileName(rootPath);
            if (files)
            {
                radioButtonFiles.Checked = true;
                for (int i = 0; i < pathsToParse.Length; i++)
                {
                    lenghts.Add(new FileInfo(pathsToParse[i]).Length);
                }
                labelFilesInFolder.Text = string.Format("{0} files", pathsToParse.Length);
                //if (filtered)
                //{
                //    labelFoldersInFolder.Text = string.Format("{0} containing subfolders", Supporter.GetFoldersFiltered(rootPath, Array.SearchField, subDirectories);
                //}
                //else
                //{
                labelFoldersInFolder.Text = string.Format("{0} subfolders", Directory.GetDirectories(rootPath, "*.*", subDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Length);
                //}
            }
            else
            {
                radioButtonDirectories.Checked = true;
                checkBoxFilter.Enabled = false;
                for (int i = 0; i < pathsToParse.Length; i++)
                {
                    lenghts.Add(dataStore.GetDirSize(pathsToParse[i]));
                }
                labelFoldersInFolder.Text = string.Format("{0} subfolders", pathsToParse.Length);
                if (filtered)
                {
                    labelFilesInFolder.Text = string.Format("{0} files", Supporter.GetFilesFiltered(rootPath, dataStore.filesExt, subDirectories).Length);
                }
                else
                {
                    labelFilesInFolder.Text = string.Format("{0} files", Directory.GetFiles(rootPath, "*.*", subDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Length);
                }
            }
            labelSizeOfFolder.Text = Supporter.GetDataSizeString(Supporter.GetDirSize(rootPath), comboBoxDataSize.SelectedIndex, Convert.ToInt32(numericUpDownDigits.Value));
            for (int i = 0; i < pathsToParse.Length; i++)
            {
                names.Add(Path.GetFileNameWithoutExtension(pathsToParse[i]));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void FillDataGrid()
        {
            int index = rootPath.Length + 1;
            OptimizeDataGrid(paths.Count());
            for (int i = 0; i < paths.Count(); i++)
            {
                if (firstUse)
                {
                    fileDataGridView.Rows.Add(new DataGridViewRow());
                }
                fileDataGridView[1, i].Value = names[i];
                fileDataGridView[2, i].Value = dataStore.getDataSize(lenghts[i], comboBoxDataSize.SelectedIndex, Convert.ToInt32(numericUpDownDigits.Value));
                fileDataGridView[3, i].Value = dataStore.dataSizes[comboBoxDataSize.SelectedIndex];
                fileDataGridView[4, i].Value = barList[i];
                fileDataGridView.Columns[4].DefaultCellStyle.Font = new Font("Monaco", 8F);
                fileDataGridView[5, i].Value = pathsArray[i];
                //fileDataGridView[5, i].Value = @"..\"+pathsArray[i].Substring(index);
            }
            if (files)
            {
                for (int i = 0; i < paths.Count(); i++)
                {
                    fileDataGridView[0, i].Value = Icon.ExtractAssociatedIcon(paths[i]);
                }
            }
            else
            {
                for (int i = 0; i < paths.Count(); i++)
                {
                    fileDataGridView[0, i].Value = Resources.FolderSmall;
                }
            }
            this.Width = fileDataGridView.Width;
            firstUse = false;
        }

        #endregion Primary Functions

        #region Methoden

        /// <summary>
        ///
        /// </summary>
        /// <param name="rowCount"></param>
        private void OptimizeDataGrid(int rowCount)
        {
            if (firstUse)
            {
                return;
            }
            int gridCount = fileDataGridView.Rows.Count;

            if (gridCount > rowCount)
            {
                int diff = gridCount - rowCount;
                for (int i = 0; i < diff; i++)
                {
                    fileDataGridView.Rows.RemoveAt(0);
                }
            }
            else if (gridCount < rowCount)
            {
                int diff = rowCount - gridCount;
                for (int i = 0; i < diff; i++)
                {
                    fileDataGridView.Rows.AddCopy(0);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void ClearLists()
        {
            lenghts.Clear();
            paths.Clear();
            names.Clear();
            barList.Clear();
        }

        /// <summary>
        ///
        /// </summary>
        private void CheckPath()
        {
            string path = textBoxDir.Text;
            if (Directory.Exists(path))
            {
                pictureBoxCheckDir.Image = Resources.Tick;
                btnRebuild.Enabled = true;
            }
            else
            {
                pictureBoxCheckDir.Image = Resources.Error;
                btnRebuild.Enabled = false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private ContextMenuStrip BuildContextMenu()
        {
            ToolStripMenuItem compact = new ToolStripMenuItem("Compact", Resources.TinyList24);
            compact.Click += Compact_Click;
            ToolStripMenuItem bigger = new ToolStripMenuItem("Normal", Resources.List24);
            bigger.Click += Bigger_Click;
            compact.Checked = fileDataGridView.AutoSizeRowsMode == DataGridViewAutoSizeRowsMode.None ? true : false;

            compact.Checked = fileDataGridView.AutoSizeRowsMode == DataGridViewAutoSizeRowsMode.AllCells ? true : false;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add(compact);
            menu.Items.Add(bigger);

            return menu;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sizes"></param>
        private void BuildBars(long[] sizes)
        {
            Dictionary<int, long> bars = new Dictionary<int, long>();
            for (int i = 0; i < sizes.Length; i++)
            {
                bars.Add(i, sizes[i]);
            }
            var items = from pair in bars
                        orderby pair.Value descending
                        select pair;

            List<long> sortedList = new List<long>();
            List<long> unsortedList = new List<long>();
            List<int> sortedIndexList = new List<int>(bars.Count);
            sortedList.AddRange(bars.Values.ToArray());
            unsortedList.AddRange(bars.Values.ToArray());
            foreach (KeyValuePair<int, long> size in items)
            {
                sortedIndexList.Add(size.Key);
            }
            long max = Supporter.GetMaxValue(sortedList);
            for (int i = 0; i < sortedIndexList.Count(); i++)
            {
                barList.Add(BarBuilder(unsortedList[i], max));
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private string BarBuilder(long value, long max)
        {
            StringBuilder bar = new StringBuilder();
            double barValue = 0.0;

            bar.Append("[");
            barValue = (Convert.ToDouble(value)) / (Convert.ToDouble(max)) * 100;

            for (int i = 1; i < 50; i++)
            {
                bar.Append((barValue >= i) ? "|" : ":");
            }
            bar.Append(Convert.ToInt32(barValue) + "%");
            for (int i = 50; i < 100; i++)
            {
                bar.Append((barValue >= i) ? "|" : ":");
            }
            bar.Append("]");
            return bar.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private ContextMenuStrip ShowMenuStrip(/*string path*/)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem openFile = new ToolStripMenuItem("Open file", Resources.File);
            ToolStripMenuItem openFilebrowser = new ToolStripMenuItem("Open directory", Resources.FolderSmall);
            if (files)
            {
                menu.Items.Add(openFile);
                menu.Items.Add(openFilebrowser);
            }
            else
            {
                string path = fileDataGridView.SelectedCells[5].Value.ToString();
                if (Directory.GetDirectories(path).Length > 0)
                {
                    ToolStripMenuItem jumpInto = new ToolStripMenuItem("Jump into", Resources.FolderOpened);
                    jumpInto.Click += JumpInto_Click;
                    menu.Items.Add(jumpInto);
                }
                if (Directory.GetFiles(path).Length > 0)
                {
                    ToolStripMenuItem showFiles = new ToolStripMenuItem("Show files", Resources.File);
                    showFiles.Click += ShowFiles_Click;
                    menu.Items.Add(showFiles);
                }
                menu.Items.Add(openFilebrowser);
            }
            openFile.Click += OpenFile_Click;
            openFilebrowser.Click += OpenFilebrowser_Click;
            return menu;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private string GetSelectedPath()
        {
            return fileDataGridView.SelectedCells[5].Value.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="pathsToCheck"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        private bool CheckPaths(string[] pathsToCheck, bool files)
        {
            if (files)
            {
                for (int i = 0; i < pathsToCheck.Length; i++)
                {
                    if (!File.Exists(pathsToCheck[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < pathsToCheck.Length; i++)
                {
                    if (!Directory.Exists(pathsToCheck[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        #endregion Methoden

        #region Buttons

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRebuild_Click(object sender, EventArgs e)
        {
            SetConfig();
            if (paths.Count == 0)
            {
                if (!files)
                {
                    dataStore.Notify("The chosen directory includes no subfolders", "No way, dude", 250);
                    btnBrowseBack_Click(this, null);
                }
                else
                {
                    dataStore.Notify("The chosen directory includes no files", "No way, dude", 250);
                    radioButtonDirectories.Checked = true;
                }
                return;
            }
            Init(pathsArray, radioButtonFiles.Checked);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancedFilter_Click(object sender, EventArgs e)
        {
            Supporter.OpenFilter();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseBack_Click(object sender, EventArgs e)
        {
            textBoxDir.Text = Path.GetDirectoryName(textBoxDir.Text);
            btnRebuild_Click(this, null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFiles_Click(object sender, EventArgs e)
        {
            textBoxDir.Text = fileDataGridView.SelectedCells[5].Value.ToString();
            radioButtonFiles.Checked = true;
            btnRebuild_Click(this, null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseDir_Click(object sender, EventArgs e)
        {
            string openPath;
            if (Directory.Exists(textBoxDir.Text))
            {
                openPath = textBoxDir.Text;
            }
            else
            {
                openPath = rootPath;
            }

            string path = Supporter.OpenFolderBrowserDialog(openPath);
            if (path != string.Empty)
            {
                textBoxDir.Text = path;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFilebrowser_Click(object sender, EventArgs e)
        {
            string path = fileDataGridView.SelectedCells[5].Value.ToString();
            dataStore.OpenPath(Path.GetDirectoryName(path));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bigger_Click(object sender, EventArgs e)
        {
            fileDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            fileDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fileDataGridView.Update();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Compact_Click(object sender, EventArgs e)
        {
            fileDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            fileDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            fileDataGridView.Update();
        }

        #endregion Buttons

        #region Events

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JumpInto_Click(object sender, EventArgs e)
        {
            textBoxDir.Text = fileDataGridView.SelectedCells[5].Value.ToString();
            btnRebuild_Click(this, null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (files)
            {
                dataStore.OpenFile(fileDataGridView.SelectedCells[5].Value.ToString());
            }
            else
            {
                dataStore.OpenPath(fileDataGridView.SelectedCells[5].Value.ToString());
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDataSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDataSize.SelectedIndex == 0)
            {
                numericUpDownDigits.Enabled = false;
            }
            else
            {
                numericUpDownDigits.Enabled = true;
            }
            labelPreview.Text = Supporter.BuildPi(comboBoxDataSize.SelectedValue.ToString(), numericUpDownDigits.Value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowMenuStrip().Show(Cursor.Position);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownDigits_ValueChanged(object sender, EventArgs e)
        {
            if ((comboBoxDataSize.SelectedText != string.Empty || comboBoxDataSize.SelectedText != null) && (numericUpDownDigits.Value >= 0 || numericUpDownDigits.Value <= 8))
                labelPreview.Text = Supporter.BuildPi(comboBoxDataSize.SelectedValue.ToString(), numericUpDownDigits.Value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDir_TextChanged(object sender, EventArgs e)
        {
            CheckPath();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonDirectories_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDirectories.Checked)
            {
                checkBoxFilter.Enabled = false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFiles.Checked)
            {
                checkBoxFilter.Enabled = true;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!files)
            {
                string path = GetSelectedPath();
                if (Directory.GetDirectories(path).Length > 0)
                {
                    textBoxDir.Text = path;
                    btnRebuild_Click(this, null);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_MouseDown(object sender, MouseEventArgs e)
        {
            BuildContextMenu().Show(Cursor.Position);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.sortDigits = Convert.ToInt32(numericUpDownDigits.Value);
            Settings.Default.sortSizes = comboBoxDataSize.SelectedIndex;
            Settings.Default.Save();
        }

        #endregion Events
    }
}