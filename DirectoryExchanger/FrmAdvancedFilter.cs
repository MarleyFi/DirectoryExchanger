using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryExchanger
{
    public partial class FrmAdvancedFilter : Form
    {
        #region Konstruktor
        
        /// <summary>
        /// 
        /// </summary>
        public FrmAdvancedFilter()
        {
            InitializeComponent();
            FillListBox(dataStore.filesExtNames, dataStore.filesExt);
        }

        #endregion Konstruktor

        #region Interne Variablen

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// DataStore für Werte
        /// </summary>
        DataStore dataStore = FrmDirectoryExchanger.dataStore;

        #endregion Interne Variablen

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Befüllt die listBox der Datei-Extensions mit den gegebenen Arrays
        /// </summary>
        private void FillListBox(string[] names, string[] extensions)
        {
            listBoxExtensions.Items.Clear();
            for (int i = 0; i < extensions.Length; i++)
            {
                listBoxExtensions.Items.Add(string.Format("{0} ({1})", names[i], extensions[i]));
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Fügt eine Extension dem Array hinzu
        /// </summary>
        private void AddExt(string ext)
        {
            if (!dataStore.filesExt.Contains<string>("*." + textBoxExt.Text))
            {
                List<string> extList = new List<string>(dataStore.filesExt);
                List<string> extListNames = new List<string>(dataStore.filesExtNames);
                extList.Add("*." + ext);
                extListNames.Add(ext.ToUpper() + "-File");
                dataStore.filesExt = extList.ToArray();
                dataStore.filesExtNames = extListNames.ToArray();
                FillListBox(dataStore.filesExtNames, dataStore.filesExt);
                textBoxExt.Text = string.Empty;
            }
            else
            {
                textBoxExt.Text = string.Empty;
            }

        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Löscht die Extension am ausgewählten Index
        /// </summary>
        private void DelExt(int index)
        {
            if (dataStore.filesExt.Length > 0)
            {
                List<string> extList = new List<string>(dataStore.filesExt);
                List<string> extListNames = new List<string>(dataStore.filesExtNames);
                extList.RemoveAt(index);
                extListNames.RemoveAt(index);
                dataStore.filesExt = extList.ToArray();
                dataStore.filesExtNames = extListNames.ToArray();
                FillListBox(dataStore.filesExtNames, dataStore.filesExt);
                btnDelFileExt.Enabled = false;
            }

        }

        #endregion Methoden

        #region Buttons

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button für das hinzufügen einer Extension im vorgegebenen Array
        /// </summary>
        private void btnAddFileExt_Click(object sender, EventArgs e)
        {
            AddExt(textBoxExt.Text);
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button für das löschen einer Extension im vorgegebenen Array
        /// </summary>
        private void btnDelFileExt_Click(object sender, EventArgs e)
        {
            int index = listBoxExtensions.SelectedIndex;
            DelExt(index);
            if (listBoxExtensions.Items.Count >= index + 1)
            {
                listBoxExtensions.SelectedIndex = index;
            }
            else if (listBoxExtensions.Items.Count >= 1)
            {
                listBoxExtensions.SelectedIndex = index - 1;
            }
        }

        #endregion Buttons

        #region Events

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Bestimmt den aktivierungsstatus des Buttons welcher eine Extension hinzufügt
        /// </summary>
        private void textBoxExt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxExt.Text))
            {
                btnAddFileExt.Enabled = true;
            }
            else
            {
                btnAddFileExt.Enabled = false;
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Sobald ein Index in der listBox ausgewählt wurde, wird der button zum löschen aktiviert
        /// </summary>
        private void listBoxExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelFileExt.Enabled = true;
        }

        #endregion Events
    }
}
