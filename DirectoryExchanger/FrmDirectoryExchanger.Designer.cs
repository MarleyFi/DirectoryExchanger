using System;

namespace DirectoryExchanger
{
    partial class FrmDirectoryExchanger
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectoryExchanger));
            this.textBoxDir2 = new System.Windows.Forms.TextBox();
            this.textBoxDir1 = new System.Windows.Forms.TextBox();
            this.labelDirText1 = new System.Windows.Forms.Label();
            this.labelDirText2 = new System.Windows.Forms.Label();
            this.checkBoxSubfolders = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxIgnoreTimeDiffs = new System.Windows.Forms.CheckBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxIgnoreFiledata = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSavePaths = new System.Windows.Forms.CheckBox();
            this.btnAdvancedFilter = new System.Windows.Forms.Button();
            this.checkBoxAdvancedFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxInstantPreview = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.labelAboutToAdd = new System.Windows.Forms.Label();
            this.labelFilesCount = new System.Windows.Forms.Label();
            this.labelFilesTxt = new System.Windows.Forms.Label();
            this.labelFoldersTxt = new System.Windows.Forms.Label();
            this.labelFoldersCount = new System.Windows.Forms.Label();
            this.labelDirName2 = new System.Windows.Forms.Label();
            this.labelDirName1 = new System.Windows.Forms.Label();
            this.labelFilesLength = new System.Windows.Forms.Label();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonUpgrade = new System.Windows.Forms.RadioButton();
            this.radioButtonMirror = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDirLength2 = new System.Windows.Forms.Label();
            this.labelDirLength1 = new System.Windows.Forms.Label();
            this.labelDirFilesTotal1 = new System.Windows.Forms.Label();
            this.labelDirFilesTotal2 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnShowTransfer = new System.Windows.Forms.Button();
            this.btnLink2 = new System.Windows.Forms.Button();
            this.btnLink1 = new System.Windows.Forms.Button();
            this.btnChangeDirs = new System.Windows.Forms.Button();
            this.btnChooseDir2 = new System.Windows.Forms.Button();
            this.btnChooseDir1 = new System.Windows.Forms.Button();
            this.btnCompare1 = new System.Windows.Forms.Button();
            this.btnCompare2 = new System.Windows.Forms.Button();
            this.btnSortFiles = new System.Windows.Forms.Button();
            this.btnSortFolders = new System.Windows.Forms.Button();
            this.btnDuplicates = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSavePaths = new System.Windows.Forms.Button();
            this.pictureBoxCheckDir2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckDir1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFolder2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFiles = new System.Windows.Forms.PictureBox();
            this.pictureBoxFolder1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowFiles1 = new System.Windows.Forms.Button();
            this.btnShowFiles2 = new System.Windows.Forms.Button();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckDir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckDir1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDir2
            // 
            this.textBoxDir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxDir2.Location = new System.Drawing.Point(9, 129);
            this.textBoxDir2.Name = "textBoxDir2";
            this.textBoxDir2.Size = new System.Drawing.Size(453, 26);
            this.textBoxDir2.TabIndex = 1;
            this.textBoxDir2.TextChanged += new System.EventHandler(this.textBoxDir1_TextChanged);
            // 
            // textBoxDir1
            // 
            this.textBoxDir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxDir1.Location = new System.Drawing.Point(9, 58);
            this.textBoxDir1.Name = "textBoxDir1";
            this.textBoxDir1.Size = new System.Drawing.Size(453, 26);
            this.textBoxDir1.TabIndex = 0;
            this.textBoxDir1.TextChanged += new System.EventHandler(this.textBoxDir2_TextChanged);
            // 
            // labelDirText1
            // 
            this.labelDirText1.AutoSize = true;
            this.labelDirText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelDirText1.Location = new System.Drawing.Point(28, 30);
            this.labelDirText1.Name = "labelDirText1";
            this.labelDirText1.Size = new System.Drawing.Size(63, 26);
            this.labelDirText1.TabIndex = 3;
            this.labelDirText1.Text = "From";
            // 
            // labelDirText2
            // 
            this.labelDirText2.AutoSize = true;
            this.labelDirText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelDirText2.Location = new System.Drawing.Point(28, 103);
            this.labelDirText2.Name = "labelDirText2";
            this.labelDirText2.Size = new System.Drawing.Size(36, 26);
            this.labelDirText2.TabIndex = 4;
            this.labelDirText2.Text = "To";
            // 
            // checkBoxSubfolders
            // 
            this.checkBoxSubfolders.AutoSize = true;
            this.checkBoxSubfolders.Checked = true;
            this.checkBoxSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSubfolders.Location = new System.Drawing.Point(6, 15);
            this.checkBoxSubfolders.Name = "checkBoxSubfolders";
            this.checkBoxSubfolders.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSubfolders.TabIndex = 6;
            this.checkBoxSubfolders.Text = "All directories";
            this.toolTip.SetToolTip(this.checkBoxSubfolders, "Entscheidet ob nur das oberste Verzeichnis durchsucht wird oder alle mit sämtlich" +
        "en Unterordnern");
            this.checkBoxSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(430, 268);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(66, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Validate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(157, 296);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 10);
            this.progressBar.TabIndex = 10;
            // 
            // checkBoxIgnoreTimeDiffs
            // 
            this.checkBoxIgnoreTimeDiffs.AutoSize = true;
            this.checkBoxIgnoreTimeDiffs.Location = new System.Drawing.Point(6, 35);
            this.checkBoxIgnoreTimeDiffs.Name = "checkBoxIgnoreTimeDiffs";
            this.checkBoxIgnoreTimeDiffs.Size = new System.Drawing.Size(135, 17);
            this.checkBoxIgnoreTimeDiffs.TabIndex = 11;
            this.checkBoxIgnoreTimeDiffs.Text = "Ignore time differencies";
            this.toolTip.SetToolTip(this.checkBoxIgnoreTimeDiffs, "Zeitunterschieder beim Dateivergleich ignorieren oder berücksichtigen");
            this.checkBoxIgnoreTimeDiffs.UseVisualStyleBackColor = true;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(883, 296);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(92, 13);
            this.labelProcess.TabIndex = 12;
            this.labelProcess.Text = "Files are loading...";
            this.labelProcess.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(154, 280);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(163, 13);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "There are XX files in X directories";
            this.labelInfo.Visible = false;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxIgnoreFiledata);
            this.groupBoxOptions.Controls.Add(this.checkBoxAutoSavePaths);
            this.groupBoxOptions.Controls.Add(this.btnAdvancedFilter);
            this.groupBoxOptions.Controls.Add(this.checkBoxAdvancedFilter);
            this.groupBoxOptions.Controls.Add(this.checkBoxInstantPreview);
            this.groupBoxOptions.Controls.Add(this.checkBoxSubfolders);
            this.groupBoxOptions.Controls.Add(this.checkBoxIgnoreTimeDiffs);
            this.groupBoxOptions.Controls.Add(this.btnQuit);
            this.groupBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxOptions.Location = new System.Drawing.Point(9, 161);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(142, 145);
            this.groupBoxOptions.TabIndex = 14;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Settings";
            // 
            // checkBoxIgnoreFiledata
            // 
            this.checkBoxIgnoreFiledata.AutoSize = true;
            this.checkBoxIgnoreFiledata.Location = new System.Drawing.Point(6, 55);
            this.checkBoxIgnoreFiledata.Name = "checkBoxIgnoreFiledata";
            this.checkBoxIgnoreFiledata.Size = new System.Drawing.Size(93, 17);
            this.checkBoxIgnoreFiledata.TabIndex = 45;
            this.checkBoxIgnoreFiledata.Text = "Ignore filedata";
            this.toolTip.SetToolTip(this.checkBoxIgnoreFiledata, "Wenn ja, dann führt das Programm sobald beide Pfade geprüft sind automatisch eine" +
        " Vorschau durch. Kann zu Leistungseinschränkungen führen!");
            this.checkBoxIgnoreFiledata.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSavePaths
            // 
            this.checkBoxAutoSavePaths.AutoSize = true;
            this.checkBoxAutoSavePaths.Location = new System.Drawing.Point(6, 115);
            this.checkBoxAutoSavePaths.Name = "checkBoxAutoSavePaths";
            this.checkBoxAutoSavePaths.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAutoSavePaths.TabIndex = 44;
            this.checkBoxAutoSavePaths.Text = "Save paths on sync";
            this.toolTip.SetToolTip(this.checkBoxAutoSavePaths, "Wenn ja, werden die verwendeten Pfade beim Synchronisieren gespeichert");
            this.checkBoxAutoSavePaths.UseVisualStyleBackColor = true;
            // 
            // btnAdvancedFilter
            // 
            this.btnAdvancedFilter.FlatAppearance.BorderSize = 0;
            this.btnAdvancedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedFilter.Image = global::DirectoryExchanger.Properties.Resources.Filter;
            this.btnAdvancedFilter.Location = new System.Drawing.Point(104, 84);
            this.btnAdvancedFilter.Name = "btnAdvancedFilter";
            this.btnAdvancedFilter.Size = new System.Drawing.Size(30, 30);
            this.btnAdvancedFilter.TabIndex = 14;
            this.toolTip.SetToolTip(this.btnAdvancedFilter, "Öffnet die Einstellungen für die Filter-Optionen");
            this.btnAdvancedFilter.UseVisualStyleBackColor = true;
            this.btnAdvancedFilter.Click += new System.EventHandler(this.btnAdvancedFilter_Click);
            // 
            // checkBoxAdvancedFilter
            // 
            this.checkBoxAdvancedFilter.AutoSize = true;
            this.checkBoxAdvancedFilter.Checked = true;
            this.checkBoxAdvancedFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdvancedFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxAdvancedFilter.Location = new System.Drawing.Point(6, 95);
            this.checkBoxAdvancedFilter.Name = "checkBoxAdvancedFilter";
            this.checkBoxAdvancedFilter.Size = new System.Drawing.Size(97, 17);
            this.checkBoxAdvancedFilter.TabIndex = 13;
            this.checkBoxAdvancedFilter.Text = "Advanced filter";
            this.toolTip.SetToolTip(this.checkBoxAdvancedFilter, "Aktiviert oder deaktiviert den Filter für die nächste Suche");
            this.checkBoxAdvancedFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstantPreview
            // 
            this.checkBoxInstantPreview.AutoSize = true;
            this.checkBoxInstantPreview.Location = new System.Drawing.Point(6, 75);
            this.checkBoxInstantPreview.Name = "checkBoxInstantPreview";
            this.checkBoxInstantPreview.Size = new System.Drawing.Size(98, 17);
            this.checkBoxInstantPreview.TabIndex = 12;
            this.checkBoxInstantPreview.Text = "Instant preview";
            this.toolTip.SetToolTip(this.checkBoxInstantPreview, "Wenn ja, dann führt das Programm sobald beide Pfade geprüft sind automatisch eine" +
        " Vorschau durch. Kann zu Leistungseinschränkungen führen!");
            this.checkBoxInstantPreview.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(103, 102);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(23, 23);
            this.btnQuit.TabIndex = 43;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // labelAboutToAdd
            // 
            this.labelAboutToAdd.AutoSize = true;
            this.labelAboutToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelAboutToAdd.Location = new System.Drawing.Point(524, 29);
            this.labelAboutToAdd.Name = "labelAboutToAdd";
            this.labelAboutToAdd.Size = new System.Drawing.Size(135, 26);
            this.labelAboutToAdd.TabIndex = 17;
            this.labelAboutToAdd.Text = "About to add";
            this.labelAboutToAdd.Visible = false;
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.labelFilesCount.Location = new System.Drawing.Point(584, 75);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFilesCount.Size = new System.Drawing.Size(103, 39);
            this.labelFilesCount.TabIndex = 18;
            this.labelFilesCount.Text = "42";
            this.labelFilesCount.Visible = false;
            // 
            // labelFilesTxt
            // 
            this.labelFilesTxt.AutoSize = true;
            this.labelFilesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelFilesTxt.Location = new System.Drawing.Point(680, 86);
            this.labelFilesTxt.Name = "labelFilesTxt";
            this.labelFilesTxt.Size = new System.Drawing.Size(74, 26);
            this.labelFilesTxt.TabIndex = 19;
            this.labelFilesTxt.Text = "files in";
            this.labelFilesTxt.Visible = false;
            // 
            // labelFoldersTxt
            // 
            this.labelFoldersTxt.AutoSize = true;
            this.labelFoldersTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelFoldersTxt.Location = new System.Drawing.Point(790, 118);
            this.labelFoldersTxt.Name = "labelFoldersTxt";
            this.labelFoldersTxt.Size = new System.Drawing.Size(100, 26);
            this.labelFoldersTxt.TabIndex = 21;
            this.labelFoldersTxt.Text = "folders in";
            this.labelFoldersTxt.Visible = false;
            // 
            // labelFoldersCount
            // 
            this.labelFoldersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.labelFoldersCount.Location = new System.Drawing.Point(700, 107);
            this.labelFoldersCount.Name = "labelFoldersCount";
            this.labelFoldersCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFoldersCount.Size = new System.Drawing.Size(90, 39);
            this.labelFoldersCount.TabIndex = 20;
            this.labelFoldersCount.Text = "8";
            this.labelFoldersCount.Visible = false;
            // 
            // labelDirName2
            // 
            this.labelDirName2.AutoSize = true;
            this.labelDirName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelDirName2.Location = new System.Drawing.Point(829, 174);
            this.labelDirName2.Name = "labelDirName2";
            this.labelDirName2.Size = new System.Drawing.Size(158, 26);
            this.labelDirName2.TabIndex = 22;
            this.labelDirName2.Text = "Music Lib HDD";
            this.labelDirName2.Visible = false;
            // 
            // labelDirName1
            // 
            this.labelDirName1.AutoSize = true;
            this.labelDirName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelDirName1.Location = new System.Drawing.Point(554, 171);
            this.labelDirName1.Name = "labelDirName1";
            this.labelDirName1.Size = new System.Drawing.Size(156, 26);
            this.labelDirName1.TabIndex = 23;
            this.labelDirName1.Text = "Music Lib NAS";
            this.labelDirName1.Visible = false;
            // 
            // labelFilesLength
            // 
            this.labelFilesLength.AutoSize = true;
            this.labelFilesLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelFilesLength.Location = new System.Drawing.Point(591, 112);
            this.labelFilesLength.Name = "labelFilesLength";
            this.labelFilesLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFilesLength.Size = new System.Drawing.Size(110, 20);
            this.labelFilesLength.TabIndex = 24;
            this.labelFilesLength.Text = "(128.314 MB)";
            this.labelFilesLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelFilesLength.Visible = false;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Checked = true;
            this.radioButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUpdate.Location = new System.Drawing.Point(162, 194);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(66, 17);
            this.radioButtonUpdate.TabIndex = 26;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonUpgrade
            // 
            this.radioButtonUpgrade.AutoSize = true;
            this.radioButtonUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUpgrade.Location = new System.Drawing.Point(274, 194);
            this.radioButtonUpgrade.Name = "radioButtonUpgrade";
            this.radioButtonUpgrade.Size = new System.Drawing.Size(73, 17);
            this.radioButtonUpgrade.TabIndex = 27;
            this.radioButtonUpgrade.TabStop = true;
            this.radioButtonUpgrade.Text = "Upgrade";
            this.radioButtonUpgrade.UseVisualStyleBackColor = true;
            this.radioButtonUpgrade.CheckedChanged += new System.EventHandler(this.radioButtonUpgrade_CheckedChanged);
            // 
            // radioButtonMirror
            // 
            this.radioButtonMirror.AutoSize = true;
            this.radioButtonMirror.Enabled = false;
            this.radioButtonMirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMirror.Location = new System.Drawing.Point(382, 194);
            this.radioButtonMirror.Name = "radioButtonMirror";
            this.radioButtonMirror.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMirror.TabIndex = 28;
            this.radioButtonMirror.TabStop = true;
            this.radioButtonMirror.Text = "Mirror";
            this.radioButtonMirror.UseVisualStyleBackColor = true;
            this.radioButtonMirror.CheckedChanged += new System.EventHandler(this.radioButtonMirror_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 53);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search for all files which aren\'t exists in the source directory";
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(383, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 53);
            this.label2.TabIndex = 31;
            this.label2.Text = "Sync both directories";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(271, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 53);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tranfers all files which aren\'t exists in the destination directory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(157, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(61, 110);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "(Destination)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(87, 37);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "(Source)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDirLength2
            // 
            this.labelDirLength2.AutoSize = true;
            this.labelDirLength2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDirLength2.Location = new System.Drawing.Point(790, 247);
            this.labelDirLength2.Name = "labelDirLength2";
            this.labelDirLength2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDirLength2.Size = new System.Drawing.Size(110, 20);
            this.labelDirLength2.TabIndex = 36;
            this.labelDirLength2.Text = "(128.314 MB)";
            this.labelDirLength2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDirLength2.Visible = false;
            // 
            // labelDirLength1
            // 
            this.labelDirLength1.AutoSize = true;
            this.labelDirLength1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDirLength1.Location = new System.Drawing.Point(506, 247);
            this.labelDirLength1.Name = "labelDirLength1";
            this.labelDirLength1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDirLength1.Size = new System.Drawing.Size(110, 20);
            this.labelDirLength1.TabIndex = 37;
            this.labelDirLength1.Text = "(128.314 MB)";
            this.labelDirLength1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDirLength1.Visible = false;
            // 
            // labelDirFilesTotal1
            // 
            this.labelDirFilesTotal1.AutoSize = true;
            this.labelDirFilesTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDirFilesTotal1.Location = new System.Drawing.Point(506, 222);
            this.labelDirFilesTotal1.Name = "labelDirFilesTotal1";
            this.labelDirFilesTotal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDirFilesTotal1.Size = new System.Drawing.Size(213, 20);
            this.labelDirFilesTotal1.TabIndex = 38;
            this.labelDirFilesTotal1.Text = "XX files  and X folders total";
            this.labelDirFilesTotal1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDirFilesTotal1.Visible = false;
            // 
            // labelDirFilesTotal2
            // 
            this.labelDirFilesTotal2.AutoSize = true;
            this.labelDirFilesTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDirFilesTotal2.Location = new System.Drawing.Point(790, 222);
            this.labelDirFilesTotal2.Name = "labelDirFilesTotal2";
            this.labelDirFilesTotal2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDirFilesTotal2.Size = new System.Drawing.Size(213, 20);
            this.labelDirFilesTotal2.TabIndex = 39;
            this.labelDirFilesTotal2.Text = "XX files  and X folders total";
            this.labelDirFilesTotal2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDirFilesTotal2.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(428, 94);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(23, 23);
            this.btnInfo.TabIndex = 15;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnShowTransfer
            // 
            this.btnShowTransfer.Enabled = false;
            this.btnShowTransfer.FlatAppearance.BorderSize = 0;
            this.btnShowTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTransfer.Image = global::DirectoryExchanger.Properties.Resources.View;
            this.btnShowTransfer.Location = new System.Drawing.Point(499, 267);
            this.btnShowTransfer.Name = "btnShowTransfer";
            this.btnShowTransfer.Size = new System.Drawing.Size(40, 40);
            this.btnShowTransfer.TabIndex = 45;
            this.toolTip.SetToolTip(this.btnShowTransfer, "Zeigt eine Listenansicht der zu verschiebenden Elemente an");
            this.btnShowTransfer.UseVisualStyleBackColor = true;
            this.btnShowTransfer.Click += new System.EventHandler(this.btnShowTransferData_Click);
            // 
            // btnLink2
            // 
            this.btnLink2.Enabled = false;
            this.btnLink2.FlatAppearance.BorderSize = 0;
            this.btnLink2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink2.Image = global::DirectoryExchanger.Properties.Resources.Link;
            this.btnLink2.Location = new System.Drawing.Point(145, 107);
            this.btnLink2.Name = "btnLink2";
            this.btnLink2.Size = new System.Drawing.Size(20, 20);
            this.btnLink2.TabIndex = 44;
            this.toolTip.SetToolTip(this.btnLink2, "Öffnet das Verzeichnis im Windows-Explorer");
            this.btnLink2.UseVisualStyleBackColor = true;
            this.btnLink2.Click += new System.EventHandler(this.btnLink2_Click);
            // 
            // btnLink1
            // 
            this.btnLink1.Enabled = false;
            this.btnLink1.FlatAppearance.BorderSize = 0;
            this.btnLink1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink1.Image = global::DirectoryExchanger.Properties.Resources.Link;
            this.btnLink1.Location = new System.Drawing.Point(146, 36);
            this.btnLink1.Name = "btnLink1";
            this.btnLink1.Size = new System.Drawing.Size(20, 20);
            this.btnLink1.TabIndex = 43;
            this.toolTip.SetToolTip(this.btnLink1, "Öffnet das Verzeichnis im Windows-Explorer");
            this.btnLink1.UseVisualStyleBackColor = true;
            this.btnLink1.Click += new System.EventHandler(this.btnLink1_Click);
            // 
            // btnChangeDirs
            // 
            this.btnChangeDirs.FlatAppearance.BorderSize = 0;
            this.btnChangeDirs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDirs.Image = global::DirectoryExchanger.Properties.Resources.Exchange;
            this.btnChangeDirs.Location = new System.Drawing.Point(421, 87);
            this.btnChangeDirs.Name = "btnChangeDirs";
            this.btnChangeDirs.Size = new System.Drawing.Size(41, 37);
            this.btnChangeDirs.TabIndex = 29;
            this.toolTip.SetToolTip(this.btnChangeDirs, "Vertauscht die jeweilig angegebenen Pfade");
            this.btnChangeDirs.UseVisualStyleBackColor = true;
            this.btnChangeDirs.Click += new System.EventHandler(this.btnChangeDirs_Click);
            // 
            // btnChooseDir2
            // 
            this.btnChooseDir2.FlatAppearance.BorderSize = 0;
            this.btnChooseDir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDir2.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseDir2.Image")));
            this.btnChooseDir2.Location = new System.Drawing.Point(464, 126);
            this.btnChooseDir2.Name = "btnChooseDir2";
            this.btnChooseDir2.Size = new System.Drawing.Size(40, 35);
            this.btnChooseDir2.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnChooseDir2, "Pfad für die Quelle auswählen");
            this.btnChooseDir2.UseVisualStyleBackColor = true;
            this.btnChooseDir2.Click += new System.EventHandler(this.btnChooseDir2_Click);
            // 
            // btnChooseDir1
            // 
            this.btnChooseDir1.FlatAppearance.BorderSize = 0;
            this.btnChooseDir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDir1.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseDir1.Image")));
            this.btnChooseDir1.Location = new System.Drawing.Point(463, 53);
            this.btnChooseDir1.Name = "btnChooseDir1";
            this.btnChooseDir1.Size = new System.Drawing.Size(40, 35);
            this.btnChooseDir1.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnChooseDir1, "Pfad für das Zielverzeichnis auswählen");
            this.btnChooseDir1.UseVisualStyleBackColor = true;
            this.btnChooseDir1.Click += new System.EventHandler(this.btnChooseDir1_Click);
            // 
            // btnCompare1
            // 
            this.btnCompare1.Enabled = false;
            this.btnCompare1.FlatAppearance.BorderSize = 0;
            this.btnCompare1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare1.Image = ((System.Drawing.Image)(resources.GetObject("btnCompare1.Image")));
            this.btnCompare1.Location = new System.Drawing.Point(169, 34);
            this.btnCompare1.Name = "btnCompare1";
            this.btnCompare1.Size = new System.Drawing.Size(24, 24);
            this.btnCompare1.TabIndex = 47;
            this.toolTip.SetToolTip(this.btnCompare1, "Öffnet das Verzeichnis im Windows-Explorer");
            this.btnCompare1.UseVisualStyleBackColor = true;
            this.btnCompare1.Click += new System.EventHandler(this.btnCompare1_Click);
            // 
            // btnCompare2
            // 
            this.btnCompare2.Enabled = false;
            this.btnCompare2.FlatAppearance.BorderSize = 0;
            this.btnCompare2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare2.Image = ((System.Drawing.Image)(resources.GetObject("btnCompare2.Image")));
            this.btnCompare2.Location = new System.Drawing.Point(169, 105);
            this.btnCompare2.Name = "btnCompare2";
            this.btnCompare2.Size = new System.Drawing.Size(24, 24);
            this.btnCompare2.TabIndex = 48;
            this.toolTip.SetToolTip(this.btnCompare2, "Öffnet das Verzeichnis im Windows-Explorer");
            this.btnCompare2.UseVisualStyleBackColor = true;
            this.btnCompare2.Click += new System.EventHandler(this.btnCompare2_Click);
            // 
            // btnSortFiles
            // 
            this.btnSortFiles.FlatAppearance.BorderSize = 0;
            this.btnSortFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortFiles.Image = global::DirectoryExchanger.Properties.Resources.File128;
            this.btnSortFiles.Location = new System.Drawing.Point(548, 32);
            this.btnSortFiles.Name = "btnSortFiles";
            this.btnSortFiles.Size = new System.Drawing.Size(132, 132);
            this.btnSortFiles.TabIndex = 62;
            this.toolTip.SetToolTip(this.btnSortFiles, "Sort files of a folder");
            this.btnSortFiles.UseVisualStyleBackColor = true;
            this.btnSortFiles.Click += new System.EventHandler(this.btnSortFiles_Click);
            // 
            // btnSortFolders
            // 
            this.btnSortFolders.FlatAppearance.BorderSize = 0;
            this.btnSortFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortFolders.Image = global::DirectoryExchanger.Properties.Resources.Folder128;
            this.btnSortFolders.Location = new System.Drawing.Point(699, 32);
            this.btnSortFolders.Name = "btnSortFolders";
            this.btnSortFolders.Size = new System.Drawing.Size(132, 132);
            this.btnSortFolders.TabIndex = 63;
            this.toolTip.SetToolTip(this.btnSortFolders, "Sort folders in a directory");
            this.btnSortFolders.UseVisualStyleBackColor = true;
            this.btnSortFolders.Click += new System.EventHandler(this.btnSortFolders_Click);
            // 
            // btnDuplicates
            // 
            this.btnDuplicates.FlatAppearance.BorderSize = 0;
            this.btnDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplicates.Image = global::DirectoryExchanger.Properties.Resources.Search128;
            this.btnDuplicates.Location = new System.Drawing.Point(548, 170);
            this.btnDuplicates.Name = "btnDuplicates";
            this.btnDuplicates.Size = new System.Drawing.Size(132, 132);
            this.btnDuplicates.TabIndex = 64;
            this.toolTip.SetToolTip(this.btnDuplicates, "Search for duplicates");
            this.btnDuplicates.UseVisualStyleBackColor = true;
            this.btnDuplicates.Click += new System.EventHandler(this.btnDuplicates_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.FlatAppearance.BorderSize = 0;
            this.btnQuitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitApp.Image = global::DirectoryExchanger.Properties.Resources.Shutdown128;
            this.btnQuitApp.Location = new System.Drawing.Point(856, 170);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(132, 132);
            this.btnQuitApp.TabIndex = 65;
            this.toolTip.SetToolTip(this.btnQuitApp, "Quit DirectoryExchanger");
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.btnQuitApp_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = global::DirectoryExchanger.Properties.Resources.FilterFlat128;
            this.btnFilter.Location = new System.Drawing.Point(699, 170);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(132, 132);
            this.btnFilter.TabIndex = 66;
            this.toolTip.SetToolTip(this.btnFilter, "Filter settings");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSavePaths
            // 
            this.btnSavePaths.Enabled = false;
            this.btnSavePaths.FlatAppearance.BorderSize = 0;
            this.btnSavePaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePaths.Image = global::DirectoryExchanger.Properties.Resources.Save;
            this.btnSavePaths.Location = new System.Drawing.Point(468, 94);
            this.btnSavePaths.Name = "btnSavePaths";
            this.btnSavePaths.Size = new System.Drawing.Size(31, 27);
            this.btnSavePaths.TabIndex = 42;
            this.btnSavePaths.UseVisualStyleBackColor = true;
            this.btnSavePaths.Click += new System.EventHandler(this.btnSavePaths_Click);
            // 
            // pictureBoxCheckDir2
            // 
            this.pictureBoxCheckDir2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckDir2.Image")));
            this.pictureBoxCheckDir2.Location = new System.Drawing.Point(4, 104);
            this.pictureBoxCheckDir2.Name = "pictureBoxCheckDir2";
            this.pictureBoxCheckDir2.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxCheckDir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckDir2.TabIndex = 41;
            this.pictureBoxCheckDir2.TabStop = false;
            // 
            // pictureBoxCheckDir1
            // 
            this.pictureBoxCheckDir1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckDir1.Image")));
            this.pictureBoxCheckDir1.Location = new System.Drawing.Point(4, 32);
            this.pictureBoxCheckDir1.Name = "pictureBoxCheckDir1";
            this.pictureBoxCheckDir1.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxCheckDir1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckDir1.TabIndex = 40;
            this.pictureBoxCheckDir1.TabStop = false;
            // 
            // pictureBoxFolder2
            // 
            this.pictureBoxFolder2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFolder2.Image")));
            this.pictureBoxFolder2.Location = new System.Drawing.Point(789, 158);
            this.pictureBoxFolder2.Name = "pictureBoxFolder2";
            this.pictureBoxFolder2.Size = new System.Drawing.Size(46, 53);
            this.pictureBoxFolder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolder2.TabIndex = 25;
            this.pictureBoxFolder2.TabStop = false;
            this.pictureBoxFolder2.Visible = false;
            // 
            // pictureBoxFiles
            // 
            this.pictureBoxFiles.Image = global::DirectoryExchanger.Properties.Resources.File;
            this.pictureBoxFiles.Location = new System.Drawing.Point(529, 77);
            this.pictureBoxFiles.Name = "pictureBoxFiles";
            this.pictureBoxFiles.Size = new System.Drawing.Size(49, 55);
            this.pictureBoxFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFiles.TabIndex = 16;
            this.pictureBoxFiles.TabStop = false;
            this.pictureBoxFiles.Visible = false;
            // 
            // pictureBoxFolder1
            // 
            this.pictureBoxFolder1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFolder1.Image")));
            this.pictureBoxFolder1.Location = new System.Drawing.Point(508, 159);
            this.pictureBoxFolder1.Name = "pictureBoxFolder1";
            this.pictureBoxFolder1.Size = new System.Drawing.Size(46, 53);
            this.pictureBoxFolder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolder1.TabIndex = 15;
            this.pictureBoxFolder1.TabStop = false;
            this.pictureBoxFolder1.Visible = false;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = global::DirectoryExchanger.Properties.Resources.ArrowRight;
            this.pictureBoxArrow.Location = new System.Drawing.Point(710, 149);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(74, 71);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrow.TabIndex = 5;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::DirectoryExchanger.Properties.Resources.Refresh;
            this.btnRefresh.Location = new System.Drawing.Point(405, 268);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowFiles1
            // 
            this.btnShowFiles1.Enabled = false;
            this.btnShowFiles1.FlatAppearance.BorderSize = 0;
            this.btnShowFiles1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFiles1.Image = global::DirectoryExchanger.Properties.Resources.Sort;
            this.btnShowFiles1.Location = new System.Drawing.Point(199, 34);
            this.btnShowFiles1.Name = "btnShowFiles1";
            this.btnShowFiles1.Size = new System.Drawing.Size(24, 24);
            this.btnShowFiles1.TabIndex = 60;
            this.btnShowFiles1.UseVisualStyleBackColor = true;
            this.btnShowFiles1.Click += new System.EventHandler(this.btnShowFiles1_Click);
            this.btnShowFiles1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowFiles1_MouseDown);
            // 
            // btnShowFiles2
            // 
            this.btnShowFiles2.Enabled = false;
            this.btnShowFiles2.FlatAppearance.BorderSize = 0;
            this.btnShowFiles2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFiles2.Image = global::DirectoryExchanger.Properties.Resources.Sort;
            this.btnShowFiles2.Location = new System.Drawing.Point(199, 105);
            this.btnShowFiles2.Name = "btnShowFiles2";
            this.btnShowFiles2.Size = new System.Drawing.Size(24, 24);
            this.btnShowFiles2.TabIndex = 61;
            this.btnShowFiles2.UseVisualStyleBackColor = true;
            this.btnShowFiles2.Click += new System.EventHandler(this.btnShowFiles2_Click);
            this.btnShowFiles2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowFiles2_MouseDown);
            // 
            // FrmDirectoryExchanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1020, 312);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnQuitApp);
            this.Controls.Add(this.btnDuplicates);
            this.Controls.Add(this.btnSortFolders);
            this.Controls.Add(this.btnSortFiles);
            this.Controls.Add(this.btnShowFiles2);
            this.Controls.Add(this.btnShowFiles1);
            this.Controls.Add(this.btnCompare2);
            this.Controls.Add(this.btnCompare1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShowTransfer);
            this.Controls.Add(this.btnLink2);
            this.Controls.Add(this.btnLink1);
            this.Controls.Add(this.btnSavePaths);
            this.Controls.Add(this.pictureBoxCheckDir2);
            this.Controls.Add(this.pictureBoxCheckDir1);
            this.Controls.Add(this.labelDirFilesTotal2);
            this.Controls.Add(this.labelDirFilesTotal1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelDirLength1);
            this.Controls.Add(this.labelDirLength2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeDirs);
            this.Controls.Add(this.radioButtonMirror);
            this.Controls.Add(this.radioButtonUpgrade);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.pictureBoxFolder2);
            this.Controls.Add(this.labelFilesLength);
            this.Controls.Add(this.labelDirName1);
            this.Controls.Add(this.labelDirName2);
            this.Controls.Add(this.labelFoldersTxt);
            this.Controls.Add(this.labelFoldersCount);
            this.Controls.Add(this.labelFilesTxt);
            this.Controls.Add(this.labelFilesCount);
            this.Controls.Add(this.labelAboutToAdd);
            this.Controls.Add(this.pictureBoxFiles);
            this.Controls.Add(this.pictureBoxFolder1);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnChooseDir2);
            this.Controls.Add(this.btnChooseDir1);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.labelDirText2);
            this.Controls.Add(this.labelDirText1);
            this.Controls.Add(this.textBoxDir1);
            this.Controls.Add(this.textBoxDir2);
            this.Controls.Add(this.btnInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDirectoryExchanger";
            this.Text = "DirectoryExchanger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDirectoryExchanger_FormClosing);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckDir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckDir1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
               
        #endregion

        private System.Windows.Forms.TextBox textBoxDir2;
        private System.Windows.Forms.TextBox textBoxDir1;
        private System.Windows.Forms.Label labelDirText1;
        private System.Windows.Forms.Label labelDirText2;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.CheckBox checkBoxSubfolders;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChooseDir1;
        private System.Windows.Forms.Button btnChooseDir2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox checkBoxIgnoreTimeDiffs;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.PictureBox pictureBoxFolder1;
        private System.Windows.Forms.PictureBox pictureBoxFiles;
        private System.Windows.Forms.Label labelAboutToAdd;
        private System.Windows.Forms.Label labelFilesCount;
        private System.Windows.Forms.Label labelFilesTxt;
        private System.Windows.Forms.Label labelFoldersTxt;
        private System.Windows.Forms.Label labelFoldersCount;
        private System.Windows.Forms.Label labelDirName2;
        private System.Windows.Forms.Label labelDirName1;
        private System.Windows.Forms.Label labelFilesLength;
        private System.Windows.Forms.PictureBox pictureBoxFolder2;
        private System.Windows.Forms.CheckBox checkBoxInstantPreview;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonUpgrade;
        private System.Windows.Forms.RadioButton radioButtonMirror;
        private System.Windows.Forms.Button btnChangeDirs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDirLength2;
        private System.Windows.Forms.Label labelDirLength1;
        private System.Windows.Forms.Label labelDirFilesTotal1;
        private System.Windows.Forms.Label labelDirFilesTotal2;
        private System.Windows.Forms.PictureBox pictureBoxCheckDir1;
        private System.Windows.Forms.PictureBox pictureBoxCheckDir2;
        private System.Windows.Forms.Button btnAdvancedFilter;
        private System.Windows.Forms.CheckBox checkBoxAdvancedFilter;
        private System.Windows.Forms.Button btnSavePaths;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox checkBoxAutoSavePaths;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnLink1;
        private System.Windows.Forms.Button btnLink2;
        private System.Windows.Forms.Button btnShowTransfer;
        private System.Windows.Forms.CheckBox checkBoxIgnoreFiledata;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCompare1;
        private System.Windows.Forms.Button btnCompare2;
        private System.Windows.Forms.Button btnShowFiles1;
        private System.Windows.Forms.Button btnShowFiles2;
        private System.Windows.Forms.Button btnSortFiles;
        private System.Windows.Forms.Button btnSortFolders;
        private System.Windows.Forms.Button btnDuplicates;
        private System.Windows.Forms.Button btnQuitApp;
        private System.Windows.Forms.Button btnFilter;
    }
}

