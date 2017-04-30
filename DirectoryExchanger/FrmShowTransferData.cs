using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DirectoryExchanger.Properties;

namespace DirectoryExchanger
{
    public partial class FrmShowTransferData : Form
    {
        #region Konstruktor

        public FrmShowTransferData(string[] pathsFrom, string[] pathsTo, string source, string dest, string fileLength)
        {
            InitializeComponent();
            this.pathsFrom = pathsFrom;
            this.pathsTo = pathsTo;
            listBoxFrom.DataSource = dataStore.GetShortPaths(pathsFrom, source);
            listBoxTo.DataSource = dataStore.GetShortPaths(pathsTo, dest);
            labelFromInfo.Text = Supporter.GetFolderName(source);
            toolTip.SetToolTip(labelFromInfo, source);
            toolTip.SetToolTip(pictureBoxFolder1, source);
            labelToInfo.Text = Supporter.GetFolderName(dest);
            toolTip.SetToolTip(labelToInfo, dest);
            toolTip.SetToolTip(pictureBoxFolder2, dest);
            labelFilesCount.Text = string.Format("{0} files", pathsFrom.Length);
            labelFilesLength.Text = fileLength;
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
        private string[] pathsFrom;

        /// <summary>
        ///
        /// </summary>
        private string[] pathsTo;

        #endregion Interne Variablen

        #region Methoden

        /// <summary>
        ///
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private ContextMenuStrip BuildContextMenuStrip(string filePath)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            if (File.Exists(filePath))
            {
                Bitmap pic = Icon.ExtractAssociatedIcon(filePath).ToBitmap();
                ToolStripMenuItem showFile = new ToolStripMenuItem("Open file", pic);
                showFile.Click += ShowFile_Click;
                ToolStripMenuItem showFolder = new ToolStripMenuItem("Open folder", Resources.Folder);
                showFolder.Click += ShowFolder_Click;
                menu.Items.Add(showFile);
                menu.Items.Add(showFolder);
            }
            return menu;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetSelectedPath()
        {
            return pathsFrom[listBoxFrom.SelectedIndex];
        }

        #endregion Methoden

        #region Buttons

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFile_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            Supporter.OpenFile(path);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFolder_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            Supporter.OpenPath(path);
        }

        #endregion Buttons

        #region Events

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTo.SelectedIndex >= 0)
            {
                listBoxTo.SelectedIndex = listBoxFrom.SelectedIndex;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFrom.SelectedIndex >= 0)
            {
                listBoxFrom.SelectedIndex = listBoxTo.SelectedIndex;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFrom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BuildContextMenuStrip(GetSelectedPath()).Show(Cursor.Position);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxTo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BuildContextMenuStrip(GetSelectedPath()).Show(Cursor.Position);
            }
        }

        #endregion Events
    }
}