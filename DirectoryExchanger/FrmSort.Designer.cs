namespace DirectoryExchanger
{
    partial class FrmSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSort));
            this.fileDataGridView = new System.Windows.Forms.DataGridView();
            this.FileIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownDigits = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDataSize = new System.Windows.Forms.ComboBox();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.pictureBoxFolder = new System.Windows.Forms.PictureBox();
            this.labelDataSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTopDirectoryOnly = new System.Windows.Forms.CheckBox();
            this.labelPreview = new System.Windows.Forms.Label();
            this.radioButtonDirectories = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.pictureBoxCheckDir = new System.Windows.Forms.PictureBox();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdvancedFilter = new System.Windows.Forms.Button();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseBack = new System.Windows.Forms.Button();
            this.labelFilesInFolder = new System.Windows.Forms.Label();
            this.labelFoldersInFolder = new System.Windows.Forms.Label();
            this.labelSizeOfFolder = new System.Windows.Forms.Label();
            this.pictureBoxSubfolders = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubfolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileDataGridView
            // 
            this.fileDataGridView.AllowUserToAddRows = false;
            this.fileDataGridView.AllowUserToDeleteRows = false;
            this.fileDataGridView.AllowUserToOrderColumns = true;
            this.fileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.fileDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.fileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileIcon,
            this.FileName,
            this.FileSize,
            this.Unit,
            this.FileBar,
            this.FilePath});
            this.fileDataGridView.Location = new System.Drawing.Point(8, 76);
            this.fileDataGridView.MultiSelect = false;
            this.fileDataGridView.Name = "fileDataGridView";
            this.fileDataGridView.ReadOnly = true;
            this.fileDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileDataGridView.Size = new System.Drawing.Size(876, 513);
            this.fileDataGridView.TabIndex = 0;
            this.fileDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fileDataGridView_CellContentDoubleClick);
            this.fileDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fileDataGridView_MouseDown);
            // 
            // FileIcon
            // 
            this.FileIcon.HeaderText = "Type";
            this.FileIcon.Name = "FileIcon";
            this.FileIcon.ReadOnly = true;
            this.FileIcon.Width = 5;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 5;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "Size";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Width = 5;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 5;
            // 
            // FileBar
            // 
            this.FileBar.HeaderText = "SizeBar";
            this.FileBar.Name = "FileBar";
            this.FileBar.ReadOnly = true;
            this.FileBar.Width = 5;
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Width = 5;
            // 
            // numericUpDownDigits
            // 
            this.numericUpDownDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDigits.Location = new System.Drawing.Point(661, 25);
            this.numericUpDownDigits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownDigits.Name = "numericUpDownDigits";
            this.numericUpDownDigits.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownDigits.TabIndex = 1;
            this.numericUpDownDigits.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDigits.ValueChanged += new System.EventHandler(this.numericUpDownDigits_ValueChanged);
            // 
            // comboBoxDataSize
            // 
            this.comboBoxDataSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDataSize.FormattingEnabled = true;
            this.comboBoxDataSize.Location = new System.Drawing.Point(548, 25);
            this.comboBoxDataSize.Name = "comboBoxDataSize";
            this.comboBoxDataSize.Size = new System.Drawing.Size(71, 21);
            this.comboBoxDataSize.TabIndex = 2;
            this.comboBoxDataSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataSize_SelectedIndexChanged);
            // 
            // btnRebuild
            // 
            this.btnRebuild.FlatAppearance.BorderSize = 0;
            this.btnRebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRebuild.Image = global::DirectoryExchanger.Properties.Resources.TickSmall;
            this.btnRebuild.Location = new System.Drawing.Point(852, 3);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(36, 41);
            this.btnRebuild.TabIndex = 3;
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnRebuild_Click);
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelFolderName.Location = new System.Drawing.Point(3, 41);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(206, 29);
            this.labelFolderName.TabIndex = 4;
            this.labelFolderName.Text = "labelFolderName";
            // 
            // pictureBoxFolder
            // 
            this.pictureBoxFolder.Image = global::DirectoryExchanger.Properties.Resources.Folder;
            this.pictureBoxFolder.Location = new System.Drawing.Point(8, 5);
            this.pictureBoxFolder.Name = "pictureBoxFolder";
            this.pictureBoxFolder.Size = new System.Drawing.Size(35, 39);
            this.pictureBoxFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolder.TabIndex = 53;
            this.pictureBoxFolder.TabStop = false;
            // 
            // labelDataSize
            // 
            this.labelDataSize.AutoSize = true;
            this.labelDataSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDataSize.Location = new System.Drawing.Point(620, 25);
            this.labelDataSize.Name = "labelDataSize";
            this.labelDataSize.Size = new System.Drawing.Size(39, 20);
            this.labelDataSize.TabIndex = 54;
            this.labelDataSize.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(706, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Digits";
            // 
            // checkBoxTopDirectoryOnly
            // 
            this.checkBoxTopDirectoryOnly.Image = global::DirectoryExchanger.Properties.Resources.Subfolders;
            this.checkBoxTopDirectoryOnly.Location = new System.Drawing.Point(485, 5);
            this.checkBoxTopDirectoryOnly.Name = "checkBoxTopDirectoryOnly";
            this.checkBoxTopDirectoryOnly.Size = new System.Drawing.Size(51, 45);
            this.checkBoxTopDirectoryOnly.TabIndex = 56;
            this.checkBoxTopDirectoryOnly.UseVisualStyleBackColor = true;
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelPreview.Location = new System.Drawing.Point(548, 3);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPreview.Size = new System.Drawing.Size(71, 20);
            this.labelPreview.TabIndex = 57;
            this.labelPreview.Text = "3,14 MB";
            // 
            // radioButtonDirectories
            // 
            this.radioButtonDirectories.AutoSize = true;
            this.radioButtonDirectories.Location = new System.Drawing.Point(769, 6);
            this.radioButtonDirectories.Name = "radioButtonDirectories";
            this.radioButtonDirectories.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDirectories.TabIndex = 58;
            this.radioButtonDirectories.TabStop = true;
            this.radioButtonDirectories.Text = "Directories";
            this.radioButtonDirectories.UseVisualStyleBackColor = true;
            this.radioButtonDirectories.CheckedChanged += new System.EventHandler(this.radioButtonDirectories_CheckedChanged);
            // 
            // radioButtonFiles
            // 
            this.radioButtonFiles.AutoSize = true;
            this.radioButtonFiles.Location = new System.Drawing.Point(769, 29);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.Size = new System.Drawing.Size(46, 17);
            this.radioButtonFiles.TabIndex = 59;
            this.radioButtonFiles.TabStop = true;
            this.radioButtonFiles.Text = "Files";
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.CheckedChanged += new System.EventHandler(this.radioButtonFiles_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(538, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 45);
            this.label2.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(842, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 45);
            this.label3.TabIndex = 61;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(83, 16);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(285, 20);
            this.textBoxDir.TabIndex = 62;
            this.textBoxDir.TextChanged += new System.EventHandler(this.textBoxDir_TextChanged);
            // 
            // pictureBoxCheckDir
            // 
            this.pictureBoxCheckDir.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheckDir.Image")));
            this.pictureBoxCheckDir.Location = new System.Drawing.Point(49, 14);
            this.pictureBoxCheckDir.Name = "pictureBoxCheckDir";
            this.pictureBoxCheckDir.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxCheckDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckDir.TabIndex = 64;
            this.pictureBoxCheckDir.TabStop = false;
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.FlatAppearance.BorderSize = 0;
            this.btnChooseDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDir.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseDir.Image")));
            this.btnChooseDir.Location = new System.Drawing.Point(369, 7);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(40, 35);
            this.btnChooseDir.TabIndex = 63;
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(475, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4, 45);
            this.label4.TabIndex = 65;
            // 
            // btnAdvancedFilter
            // 
            this.btnAdvancedFilter.FlatAppearance.BorderSize = 0;
            this.btnAdvancedFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedFilter.Image = global::DirectoryExchanger.Properties.Resources.Filter;
            this.btnAdvancedFilter.Location = new System.Drawing.Point(437, 3);
            this.btnAdvancedFilter.Name = "btnAdvancedFilter";
            this.btnAdvancedFilter.Size = new System.Drawing.Size(32, 44);
            this.btnAdvancedFilter.TabIndex = 67;
            this.btnAdvancedFilter.UseVisualStyleBackColor = true;
            this.btnAdvancedFilter.Click += new System.EventHandler(this.btnAdvancedFilter_Click);
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Location = new System.Drawing.Point(422, 23);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFilter.TabIndex = 68;
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(415, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(4, 45);
            this.label5.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(761, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(4, 45);
            this.label6.TabIndex = 70;
            // 
            // btnBrowseBack
            // 
            this.btnBrowseBack.FlatAppearance.BorderSize = 0;
            this.btnBrowseBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBack.Image = global::DirectoryExchanger.Properties.Resources.FolderUp32;
            this.btnBrowseBack.Location = new System.Drawing.Point(7, 3);
            this.btnBrowseBack.Name = "btnBrowseBack";
            this.btnBrowseBack.Size = new System.Drawing.Size(36, 41);
            this.btnBrowseBack.TabIndex = 71;
            this.btnBrowseBack.UseVisualStyleBackColor = true;
            this.btnBrowseBack.Visible = false;
            this.btnBrowseBack.Click += new System.EventHandler(this.btnBrowseBack_Click);
            // 
            // labelFilesInFolder
            // 
            this.labelFilesInFolder.AutoSize = true;
            this.labelFilesInFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelFilesInFolder.Location = new System.Drawing.Point(796, 55);
            this.labelFilesInFolder.Name = "labelFilesInFolder";
            this.labelFilesInFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFilesInFolder.Size = new System.Drawing.Size(91, 20);
            this.labelFilesInFolder.TabIndex = 72;
            this.labelFilesInFolder.Text = "1024 files";
            // 
            // labelFoldersInFolder
            // 
            this.labelFoldersInFolder.AutoSize = true;
            this.labelFoldersInFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelFoldersInFolder.Location = new System.Drawing.Point(604, 55);
            this.labelFoldersInFolder.Name = "labelFoldersInFolder";
            this.labelFoldersInFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFoldersInFolder.Size = new System.Drawing.Size(133, 20);
            this.labelFoldersInFolder.TabIndex = 73;
            this.labelFoldersInFolder.Text = "512 subfolders";
            // 
            // labelSizeOfFolder
            // 
            this.labelSizeOfFolder.AutoSize = true;
            this.labelSizeOfFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelSizeOfFolder.Location = new System.Drawing.Point(373, 53);
            this.labelSizeOfFolder.Name = "labelSizeOfFolder";
            this.labelSizeOfFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSizeOfFolder.Size = new System.Drawing.Size(118, 20);
            this.labelSizeOfFolder.TabIndex = 74;
            this.labelSizeOfFolder.Text = "2048 MBytes";
            // 
            // pictureBoxSubfolders
            // 
            this.pictureBoxSubfolders.Image = global::DirectoryExchanger.Properties.Resources.Subfolders;
            this.pictureBoxSubfolders.Location = new System.Drawing.Point(574, 47);
            this.pictureBoxSubfolders.Name = "pictureBoxSubfolders";
            this.pictureBoxSubfolders.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxSubfolders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubfolders.TabIndex = 75;
            this.pictureBoxSubfolders.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DirectoryExchanger.Properties.Resources.FilesBlank_png;
            this.pictureBox1.Location = new System.Drawing.Point(769, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DirectoryExchanger.Properties.Resources.Save;
            this.pictureBox2.Location = new System.Drawing.Point(340, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(538, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(4, 45);
            this.label7.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(761, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(4, 45);
            this.label8.TabIndex = 79;
            // 
            // FrmSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 601);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxSubfolders);
            this.Controls.Add(this.labelSizeOfFolder);
            this.Controls.Add(this.labelFoldersInFolder);
            this.Controls.Add(this.labelFilesInFolder);
            this.Controls.Add(this.btnBrowseBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.btnAdvancedFilter);
            this.Controls.Add(this.fileDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxCheckDir);
            this.Controls.Add(this.btnChooseDir);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonFiles);
            this.Controls.Add(this.radioButtonDirectories);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.checkBoxTopDirectoryOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDataSize);
            this.Controls.Add(this.pictureBoxFolder);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.btnRebuild);
            this.Controls.Add(this.comboBoxDataSize);
            this.Controls.Add(this.numericUpDownDigits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(910, 640);
            this.Name = "FrmSort";
            this.Text = "Sort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSort_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubfolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fileDataGridView;
        private System.Windows.Forms.NumericUpDown numericUpDownDigits;
        private System.Windows.Forms.ComboBox comboBoxDataSize;
        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.DataGridViewImageColumn FileIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.PictureBox pictureBoxFolder;
        private System.Windows.Forms.Label labelDataSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTopDirectoryOnly;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.RadioButton radioButtonDirectories;
        private System.Windows.Forms.RadioButton radioButtonFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.PictureBox pictureBoxCheckDir;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdvancedFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseBack;
        private System.Windows.Forms.Label labelFilesInFolder;
        private System.Windows.Forms.Label labelFoldersInFolder;
        private System.Windows.Forms.Label labelSizeOfFolder;
        private System.Windows.Forms.PictureBox pictureBoxSubfolders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}