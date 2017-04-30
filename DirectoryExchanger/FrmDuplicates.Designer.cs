namespace DirectoryExchanger
{
    partial class FrmDuplicates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuplicates));
            this.btnLink = new System.Windows.Forms.Button();
            this.pictureBoxCheckPath = new System.Windows.Forms.PictureBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnAdvancedFilter = new System.Windows.Forms.Button();
            this.checkBoxAdvancedFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxInstantPreview = new System.Windows.Forms.CheckBox();
            this.pictureBoxFolder = new System.Windows.Forms.PictureBox();
            this.labelFoldername = new System.Windows.Forms.Label();
            this.pictureBoxFolders = new System.Windows.Forms.PictureBox();
            this.labelFoldersTotal = new System.Windows.Forms.Label();
            this.pictureBoxFiles = new System.Windows.Forms.PictureBox();
            this.labelFilesTotal = new System.Windows.Forms.Label();
            this.btnShowFolders = new System.Windows.Forms.Button();
            this.btnShowFiles = new System.Windows.Forms.Button();
            this.checkBoxAllDirectories = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxIgnoreEmpty = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelFilePath2 = new System.Windows.Forms.Label();
            this.labelFileName2 = new System.Windows.Forms.Label();
            this.labelFileLastWrite2 = new System.Windows.Forms.Label();
            this.labelFileCreation2 = new System.Windows.Forms.Label();
            this.labelFileSize2 = new System.Windows.Forms.Label();
            this.labelFileSize1 = new System.Windows.Forms.Label();
            this.labelFileCreation1 = new System.Windows.Forms.Label();
            this.labelFileLastWrite1 = new System.Windows.Forms.Label();
            this.labelFileName1 = new System.Windows.Forms.Label();
            this.labelFilePath1 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelLastWrite = new System.Windows.Forms.Label();
            this.labelDOC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLink
            // 
            this.btnLink.Enabled = false;
            this.btnLink.Image = global::DirectoryExchanger.Properties.Resources.Link;
            this.btnLink.Location = new System.Drawing.Point(566, 65);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(20, 20);
            this.btnLink.TabIndex = 47;
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCheckPath
            // 
            this.pictureBoxCheckPath.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckPath.Image")));
            this.pictureBoxCheckPath.Location = new System.Drawing.Point(92, 61);
            this.pictureBoxCheckPath.Name = "pictureBoxCheckPath";
            this.pictureBoxCheckPath.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxCheckPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckPath.TabIndex = 46;
            this.pictureBoxCheckPath.TabStop = false;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Image = ((System.Drawing.Image)(resources.GetObject("btnChoosePath.Image")));
            this.btnChoosePath.Location = new System.Drawing.Point(520, 50);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(40, 35);
            this.btnChoosePath.TabIndex = 45;
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxPath.Location = new System.Drawing.Point(121, 59);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(393, 26);
            this.textBoxPath.TabIndex = 44;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // btnAdvancedFilter
            // 
            this.btnAdvancedFilter.FlatAppearance.BorderSize = 0;
            this.btnAdvancedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedFilter.Image = global::DirectoryExchanger.Properties.Resources.Filter;
            this.btnAdvancedFilter.Location = new System.Drawing.Point(103, 128);
            this.btnAdvancedFilter.Name = "btnAdvancedFilter";
            this.btnAdvancedFilter.Size = new System.Drawing.Size(30, 30);
            this.btnAdvancedFilter.TabIndex = 50;
            this.btnAdvancedFilter.UseVisualStyleBackColor = true;
            this.btnAdvancedFilter.Click += new System.EventHandler(this.btnAdvancedFilter_Click);
            // 
            // checkBoxAdvancedFilter
            // 
            this.checkBoxAdvancedFilter.AutoSize = true;
            this.checkBoxAdvancedFilter.Checked = true;
            this.checkBoxAdvancedFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdvancedFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxAdvancedFilter.Location = new System.Drawing.Point(12, 132);
            this.checkBoxAdvancedFilter.Name = "checkBoxAdvancedFilter";
            this.checkBoxAdvancedFilter.Size = new System.Drawing.Size(97, 17);
            this.checkBoxAdvancedFilter.TabIndex = 49;
            this.checkBoxAdvancedFilter.Text = "Advanced filter";
            this.checkBoxAdvancedFilter.UseVisualStyleBackColor = true;
            this.checkBoxAdvancedFilter.CheckedChanged += new System.EventHandler(this.checkBoxAdvancedFilter_CheckedChanged);
            // 
            // checkBoxInstantPreview
            // 
            this.checkBoxInstantPreview.AutoSize = true;
            this.checkBoxInstantPreview.Location = new System.Drawing.Point(12, 150);
            this.checkBoxInstantPreview.Name = "checkBoxInstantPreview";
            this.checkBoxInstantPreview.Size = new System.Drawing.Size(98, 17);
            this.checkBoxInstantPreview.TabIndex = 51;
            this.checkBoxInstantPreview.Text = "Instant preview";
            this.checkBoxInstantPreview.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFolder
            // 
            this.pictureBoxFolder.Image = global::DirectoryExchanger.Properties.Resources.Folder;
            this.pictureBoxFolder.Location = new System.Drawing.Point(6, 5);
            this.pictureBoxFolder.Name = "pictureBoxFolder";
            this.pictureBoxFolder.Size = new System.Drawing.Size(80, 88);
            this.pictureBoxFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolder.TabIndex = 52;
            this.pictureBoxFolder.TabStop = false;
            this.pictureBoxFolder.Visible = false;
            // 
            // labelFoldername
            // 
            this.labelFoldername.AutoSize = true;
            this.labelFoldername.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.labelFoldername.Location = new System.Drawing.Point(92, 20);
            this.labelFoldername.Name = "labelFoldername";
            this.labelFoldername.Size = new System.Drawing.Size(172, 36);
            this.labelFoldername.TabIndex = 53;
            this.labelFoldername.Text = "Foldername";
            this.labelFoldername.Visible = false;
            // 
            // pictureBoxFolders
            // 
            this.pictureBoxFolders.Image = global::DirectoryExchanger.Properties.Resources.Subfolders;
            this.pictureBoxFolders.Location = new System.Drawing.Point(312, 128);
            this.pictureBoxFolders.Name = "pictureBoxFolders";
            this.pictureBoxFolders.Size = new System.Drawing.Size(36, 32);
            this.pictureBoxFolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolders.TabIndex = 54;
            this.pictureBoxFolders.TabStop = false;
            this.pictureBoxFolders.Visible = false;
            // 
            // labelFoldersTotal
            // 
            this.labelFoldersTotal.AutoSize = true;
            this.labelFoldersTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelFoldersTotal.Location = new System.Drawing.Point(353, 135);
            this.labelFoldersTotal.Name = "labelFoldersTotal";
            this.labelFoldersTotal.Size = new System.Drawing.Size(142, 26);
            this.labelFoldersTotal.TabIndex = 55;
            this.labelFoldersTotal.Text = "42 subfolders";
            this.labelFoldersTotal.Visible = false;
            // 
            // pictureBoxFiles
            // 
            this.pictureBoxFiles.Image = global::DirectoryExchanger.Properties.Resources.FilesBlank_png;
            this.pictureBoxFiles.Location = new System.Drawing.Point(311, 89);
            this.pictureBoxFiles.Name = "pictureBoxFiles";
            this.pictureBoxFiles.Size = new System.Drawing.Size(36, 32);
            this.pictureBoxFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFiles.TabIndex = 56;
            this.pictureBoxFiles.TabStop = false;
            this.pictureBoxFiles.Visible = false;
            // 
            // labelFilesTotal
            // 
            this.labelFilesTotal.AutoSize = true;
            this.labelFilesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelFilesTotal.Location = new System.Drawing.Point(353, 95);
            this.labelFilesTotal.Name = "labelFilesTotal";
            this.labelFilesTotal.Size = new System.Drawing.Size(140, 26);
            this.labelFilesTotal.TabIndex = 57;
            this.labelFilesTotal.Text = "442 files total";
            this.labelFilesTotal.Visible = false;
            // 
            // btnShowFolders
            // 
            this.btnShowFolders.Image = global::DirectoryExchanger.Properties.Resources.Sort;
            this.btnShowFolders.Location = new System.Drawing.Point(285, 137);
            this.btnShowFolders.Name = "btnShowFolders";
            this.btnShowFolders.Size = new System.Drawing.Size(24, 24);
            this.btnShowFolders.TabIndex = 58;
            this.btnShowFolders.UseVisualStyleBackColor = true;
            this.btnShowFolders.Visible = false;
            this.btnShowFolders.Click += new System.EventHandler(this.btnShowFolders_Click);
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.Image = global::DirectoryExchanger.Properties.Resources.Sort;
            this.btnShowFiles.Location = new System.Drawing.Point(284, 99);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(24, 24);
            this.btnShowFiles.TabIndex = 59;
            this.btnShowFiles.UseVisualStyleBackColor = true;
            this.btnShowFiles.Visible = false;
            this.btnShowFiles.Click += new System.EventHandler(this.btnShowFiles_Click);
            // 
            // checkBoxAllDirectories
            // 
            this.checkBoxAllDirectories.AutoSize = true;
            this.checkBoxAllDirectories.Checked = true;
            this.checkBoxAllDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllDirectories.Location = new System.Drawing.Point(12, 96);
            this.checkBoxAllDirectories.Name = "checkBoxAllDirectories";
            this.checkBoxAllDirectories.Size = new System.Drawing.Size(88, 17);
            this.checkBoxAllDirectories.TabIndex = 60;
            this.checkBoxAllDirectories.Text = "All directories";
            this.checkBoxAllDirectories.UseVisualStyleBackColor = true;
            this.checkBoxAllDirectories.CheckedChanged += new System.EventHandler(this.checkBoxAllDirectories_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(4, 175);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(510, 10);
            this.progressBar.TabIndex = 61;
            // 
            // checkBoxIgnoreEmpty
            // 
            this.checkBoxIgnoreEmpty.AutoSize = true;
            this.checkBoxIgnoreEmpty.Checked = true;
            this.checkBoxIgnoreEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIgnoreEmpty.Location = new System.Drawing.Point(12, 114);
            this.checkBoxIgnoreEmpty.Name = "checkBoxIgnoreEmpty";
            this.checkBoxIgnoreEmpty.Size = new System.Drawing.Size(102, 17);
            this.checkBoxIgnoreEmpty.TabIndex = 62;
            this.checkBoxIgnoreEmpty.Text = "Ignor empty files";
            this.checkBoxIgnoreEmpty.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreEmpty.CheckedChanged += new System.EventHandler(this.checkBoxIgnoreEmpty_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(511, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 63;
            this.btnStart.Text = "Validate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 420);
            this.listBox1.TabIndex = 64;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(520, 191);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(510, 420);
            this.listBox2.TabIndex = 65;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // pictureBoxWarning
            // 
            this.pictureBoxWarning.Image = global::DirectoryExchanger.Properties.Resources.Warning;
            this.pictureBoxWarning.Location = new System.Drawing.Point(511, 128);
            this.pictureBoxWarning.Name = "pictureBoxWarning";
            this.pictureBoxWarning.Size = new System.Drawing.Size(40, 32);
            this.pictureBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWarning.TabIndex = 66;
            this.pictureBoxWarning.TabStop = false;
            this.pictureBoxWarning.Visible = false;
            // 
            // labelFilePath2
            // 
            this.labelFilePath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.labelFilePath2.Location = new System.Drawing.Point(815, 35);
            this.labelFilePath2.Name = "labelFilePath2";
            this.labelFilePath2.Size = new System.Drawing.Size(215, 13);
            this.labelFilePath2.TabIndex = 67;
            this.labelFilePath2.Text = "D:\\Expamle\\Path\\Of\\Doom\\..";
            // 
            // labelFileName2
            // 
            this.labelFileName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelFileName2.Location = new System.Drawing.Point(846, 6);
            this.labelFileName2.Name = "labelFileName2";
            this.labelFileName2.Size = new System.Drawing.Size(184, 24);
            this.labelFileName2.TabIndex = 68;
            this.labelFileName2.Text = "Test.docx";
            // 
            // labelFileLastWrite2
            // 
            this.labelFileLastWrite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFileLastWrite2.Location = new System.Drawing.Point(849, 110);
            this.labelFileLastWrite2.Name = "labelFileLastWrite2";
            this.labelFileLastWrite2.Size = new System.Drawing.Size(181, 17);
            this.labelFileLastWrite2.TabIndex = 69;
            this.labelFileLastWrite2.Text = "24.05.1997 04:20:00 PM";
            // 
            // labelFileCreation2
            // 
            this.labelFileCreation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFileCreation2.Location = new System.Drawing.Point(847, 150);
            this.labelFileCreation2.Name = "labelFileCreation2";
            this.labelFileCreation2.Size = new System.Drawing.Size(183, 17);
            this.labelFileCreation2.TabIndex = 70;
            this.labelFileCreation2.Text = "01.05.2001 04:20:00 PM";
            // 
            // labelFileSize2
            // 
            this.labelFileSize2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelFileSize2.Location = new System.Drawing.Point(846, 67);
            this.labelFileSize2.Name = "labelFileSize2";
            this.labelFileSize2.Size = new System.Drawing.Size(183, 22);
            this.labelFileSize2.TabIndex = 71;
            this.labelFileSize2.Text = "256 MB";
            // 
            // labelFileSize1
            // 
            this.labelFileSize1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelFileSize1.Location = new System.Drawing.Point(612, 67);
            this.labelFileSize1.Name = "labelFileSize1";
            this.labelFileSize1.Size = new System.Drawing.Size(159, 22);
            this.labelFileSize1.TabIndex = 76;
            this.labelFileSize1.Text = "256 MB";
            this.labelFileSize1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFileCreation1
            // 
            this.labelFileCreation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFileCreation1.Location = new System.Drawing.Point(605, 150);
            this.labelFileCreation1.Name = "labelFileCreation1";
            this.labelFileCreation1.Size = new System.Drawing.Size(164, 17);
            this.labelFileCreation1.TabIndex = 75;
            this.labelFileCreation1.Text = "01.05.2001 04:20:00 PM";
            this.labelFileCreation1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFileLastWrite1
            // 
            this.labelFileLastWrite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFileLastWrite1.Location = new System.Drawing.Point(607, 110);
            this.labelFileLastWrite1.Name = "labelFileLastWrite1";
            this.labelFileLastWrite1.Size = new System.Drawing.Size(164, 17);
            this.labelFileLastWrite1.TabIndex = 74;
            this.labelFileLastWrite1.Text = "24.05.1997 04:20:00 PM";
            this.labelFileLastWrite1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFileName1
            // 
            this.labelFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelFileName1.Location = new System.Drawing.Point(581, 5);
            this.labelFileName1.Name = "labelFileName1";
            this.labelFileName1.Size = new System.Drawing.Size(187, 24);
            this.labelFileName1.TabIndex = 73;
            this.labelFileName1.Text = "Example.docx";
            this.labelFileName1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFilePath1
            // 
            this.labelFilePath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.labelFilePath1.Location = new System.Drawing.Point(608, 35);
            this.labelFilePath1.Name = "labelFilePath1";
            this.labelFilePath1.Size = new System.Drawing.Size(201, 13);
            this.labelFilePath1.TabIndex = 72;
            this.labelFilePath1.Text = "D:\\Expamle\\Path\\Of\\Doom\\..";
            this.labelFilePath1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelSize.Location = new System.Drawing.Point(801, 67);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(21, 24);
            this.labelSize.TabIndex = 77;
            this.labelSize.Text = "=";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLastWrite
            // 
            this.labelLastWrite.AutoSize = true;
            this.labelLastWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelLastWrite.Location = new System.Drawing.Point(801, 105);
            this.labelLastWrite.Name = "labelLastWrite";
            this.labelLastWrite.Size = new System.Drawing.Size(21, 24);
            this.labelLastWrite.TabIndex = 78;
            this.labelLastWrite.Text = "=";
            this.labelLastWrite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDOC
            // 
            this.labelDOC.AutoSize = true;
            this.labelDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelDOC.Location = new System.Drawing.Point(801, 143);
            this.labelDOC.Name = "labelDOC";
            this.labelDOC.Size = new System.Drawing.Size(21, 24);
            this.labelDOC.TabIndex = 79;
            this.labelDOC.Text = "=";
            this.labelDOC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 614);
            this.Controls.Add(this.labelDOC);
            this.Controls.Add(this.labelLastWrite);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelFileSize1);
            this.Controls.Add(this.labelFileCreation1);
            this.Controls.Add(this.labelFileLastWrite1);
            this.Controls.Add(this.labelFileName1);
            this.Controls.Add(this.labelFilePath1);
            this.Controls.Add(this.labelFileSize2);
            this.Controls.Add(this.labelFileCreation2);
            this.Controls.Add(this.labelFileLastWrite2);
            this.Controls.Add(this.labelFileName2);
            this.Controls.Add(this.labelFilePath2);
            this.Controls.Add(this.pictureBoxWarning);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkBoxIgnoreEmpty);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBoxAllDirectories);
            this.Controls.Add(this.btnShowFiles);
            this.Controls.Add(this.btnShowFolders);
            this.Controls.Add(this.labelFilesTotal);
            this.Controls.Add(this.pictureBoxFiles);
            this.Controls.Add(this.labelFoldersTotal);
            this.Controls.Add(this.pictureBoxFolders);
            this.Controls.Add(this.labelFoldername);
            this.Controls.Add(this.pictureBoxFolder);
            this.Controls.Add(this.checkBoxInstantPreview);
            this.Controls.Add(this.btnAdvancedFilter);
            this.Controls.Add(this.checkBoxAdvancedFilter);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.pictureBoxCheckPath);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.textBoxPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDuplicates";
            this.Text = "Duplicates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDuplicates_FormClosing);
            this.Load += new System.EventHandler(this.FrmDuplicates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.PictureBox pictureBoxCheckPath;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnAdvancedFilter;
        private System.Windows.Forms.CheckBox checkBoxAdvancedFilter;
        private System.Windows.Forms.CheckBox checkBoxInstantPreview;
        private System.Windows.Forms.PictureBox pictureBoxFolder;
        private System.Windows.Forms.Label labelFoldername;
        private System.Windows.Forms.PictureBox pictureBoxFolders;
        private System.Windows.Forms.Label labelFoldersTotal;
        private System.Windows.Forms.PictureBox pictureBoxFiles;
        private System.Windows.Forms.Label labelFilesTotal;
        private System.Windows.Forms.Button btnShowFolders;
        private System.Windows.Forms.Button btnShowFiles;
        private System.Windows.Forms.CheckBox checkBoxAllDirectories;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox checkBoxIgnoreEmpty;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBoxWarning;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelFilePath2;
        private System.Windows.Forms.Label labelFileName2;
        private System.Windows.Forms.Label labelFileLastWrite2;
        private System.Windows.Forms.Label labelFileCreation2;
        private System.Windows.Forms.Label labelFileSize2;
        private System.Windows.Forms.Label labelFileSize1;
        private System.Windows.Forms.Label labelFileCreation1;
        private System.Windows.Forms.Label labelFileLastWrite1;
        private System.Windows.Forms.Label labelFileName1;
        private System.Windows.Forms.Label labelFilePath1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelLastWrite;
        private System.Windows.Forms.Label labelDOC;
    }
}