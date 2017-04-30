namespace DirectoryExchanger
{
    partial class FrmShowTransferData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowTransferData));
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFromInfo = new System.Windows.Forms.Label();
            this.labelToInfo = new System.Windows.Forms.Label();
            this.labelFilesCount = new System.Windows.Forms.Label();
            this.labelFilesLength = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxFolder2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFolder1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 17;
            this.listBoxFrom.Location = new System.Drawing.Point(2, 41);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(655, 259);
            this.listBoxFrom.TabIndex = 0;
            this.listBoxFrom.SelectedIndexChanged += new System.EventHandler(this.listBoxFrom_SelectedIndexChanged);
            this.listBoxFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFrom_MouseDown);
            // 
            // listBoxTo
            // 
            this.listBoxTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 17;
            this.listBoxTo.Location = new System.Drawing.Point(800, 41);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(655, 259);
            this.listBoxTo.TabIndex = 1;
            this.listBoxTo.SelectedIndexChanged += new System.EventHandler(this.listBoxTo_SelectedIndexChanged);
            this.listBoxTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxTo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(830, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DirectoryExchanger.Properties.Resources.Cable;
            this.pictureBox1.Location = new System.Drawing.Point(311, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelFromInfo
            // 
            this.labelFromInfo.AutoSize = true;
            this.labelFromInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelFromInfo.Location = new System.Drawing.Point(98, 16);
            this.labelFromInfo.Name = "labelFromInfo";
            this.labelFromInfo.Size = new System.Drawing.Size(110, 20);
            this.labelFromInfo.TabIndex = 5;
            this.labelFromInfo.Text = "labelFromInfo";
            // 
            // labelToInfo
            // 
            this.labelToInfo.AutoSize = true;
            this.labelToInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelToInfo.Location = new System.Drawing.Point(868, 16);
            this.labelToInfo.Name = "labelToInfo";
            this.labelToInfo.Size = new System.Drawing.Size(90, 20);
            this.labelToInfo.TabIndex = 6;
            this.labelToInfo.Text = "labelToInfo";
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.AutoSize = true;
            this.labelFilesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelFilesCount.Location = new System.Drawing.Point(699, 51);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.Size = new System.Drawing.Size(67, 20);
            this.labelFilesCount.TabIndex = 7;
            this.labelFilesCount.Text = "XX files";
            // 
            // labelFilesLength
            // 
            this.labelFilesLength.AutoSize = true;
            this.labelFilesLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelFilesLength.Location = new System.Drawing.Point(681, 71);
            this.labelFilesLength.Name = "labelFilesLength";
            this.labelFilesLength.Size = new System.Drawing.Size(89, 20);
            this.labelFilesLength.TabIndex = 8;
            this.labelFilesLength.Text = "128.24 MB";
            // 
            // pictureBoxFolder2
            // 
            this.pictureBoxFolder2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFolder2.Image")));
            this.pictureBoxFolder2.Location = new System.Drawing.Point(801, 4);
            this.pictureBoxFolder2.Name = "pictureBoxFolder2";
            this.pictureBoxFolder2.Size = new System.Drawing.Size(30, 35);
            this.pictureBoxFolder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolder2.TabIndex = 27;
            this.pictureBoxFolder2.TabStop = false;
            // 
            // pictureBoxFolder1
            // 
            this.pictureBoxFolder1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFolder1.Image")));
            this.pictureBoxFolder1.Location = new System.Drawing.Point(2, 4);
            this.pictureBoxFolder1.Name = "pictureBoxFolder1";
            this.pictureBoxFolder1.Size = new System.Drawing.Size(30, 35);
            this.pictureBoxFolder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFolder1.TabIndex = 26;
            this.pictureBoxFolder1.TabStop = false;
            // 
            // FrmShowTransferData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 302);
            this.Controls.Add(this.pictureBoxFolder2);
            this.Controls.Add(this.pictureBoxFolder1);
            this.Controls.Add(this.labelFilesLength);
            this.Controls.Add(this.labelFilesCount);
            this.Controls.Add(this.labelToInfo);
            this.Controls.Add(this.labelFromInfo);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.listBoxFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmShowTransferData";
            this.Text = "Data to move";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFolder1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFromInfo;
        private System.Windows.Forms.Label labelToInfo;
        private System.Windows.Forms.Label labelFilesCount;
        private System.Windows.Forms.Label labelFilesLength;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBoxFolder2;
        private System.Windows.Forms.PictureBox pictureBoxFolder1;
    }
}