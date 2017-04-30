namespace DirectoryExchanger
{
    partial class FrmAdvancedFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdvancedFilter));
            this.listBoxExtensions = new System.Windows.Forms.ListBox();
            this.labelExt = new System.Windows.Forms.Label();
            this.textBoxExt = new System.Windows.Forms.TextBox();
            this.btnDelFileExt = new System.Windows.Forms.Button();
            this.btnAddFileExt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxExtensions
            // 
            this.listBoxExtensions.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxExtensions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxExtensions.FormattingEnabled = true;
            this.listBoxExtensions.Items.AddRange(new object[] {
            "WordDoc (*.docx)",
            "OpenOfficeDoc (*.odt)",
            "PDFs (*.pdf)",
            "Textfiles (*.txt)",
            "Pages (*.pages)",
            "MS Excel (*.xls)",
            "OO Excel (*.ods)",
            "FAILURE!"});
            this.listBoxExtensions.Location = new System.Drawing.Point(12, 42);
            this.listBoxExtensions.Name = "listBoxExtensions";
            this.listBoxExtensions.Size = new System.Drawing.Size(129, 156);
            this.listBoxExtensions.TabIndex = 28;
            this.listBoxExtensions.SelectedIndexChanged += new System.EventHandler(this.listBoxExtensions_SelectedIndexChanged);
            // 
            // labelExt
            // 
            this.labelExt.AutoSize = true;
            this.labelExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelExt.Location = new System.Drawing.Point(40, 15);
            this.labelExt.Name = "labelExt";
            this.labelExt.Size = new System.Drawing.Size(22, 24);
            this.labelExt.TabIndex = 32;
            this.labelExt.Text = "*.";
            // 
            // textBoxExt
            // 
            this.textBoxExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxExt.Location = new System.Drawing.Point(57, 12);
            this.textBoxExt.Name = "textBoxExt";
            this.textBoxExt.Size = new System.Drawing.Size(53, 27);
            this.textBoxExt.TabIndex = 29;
            this.textBoxExt.TextChanged += new System.EventHandler(this.textBoxExt_TextChanged);
            // 
            // btnDelFileExt
            // 
            this.btnDelFileExt.Enabled = false;
            this.btnDelFileExt.Image = global::DirectoryExchanger.Properties.Resources.Error;
            this.btnDelFileExt.Location = new System.Drawing.Point(11, 10);
            this.btnDelFileExt.Name = "btnDelFileExt";
            this.btnDelFileExt.Size = new System.Drawing.Size(30, 30);
            this.btnDelFileExt.TabIndex = 33;
            this.btnDelFileExt.UseVisualStyleBackColor = true;
            this.btnDelFileExt.Click += new System.EventHandler(this.btnDelFileExt_Click);
            // 
            // btnAddFileExt
            // 
            this.btnAddFileExt.Enabled = false;
            this.btnAddFileExt.Image = global::DirectoryExchanger.Properties.Resources.Tick;
            this.btnAddFileExt.Location = new System.Drawing.Point(112, 10);
            this.btnAddFileExt.Name = "btnAddFileExt";
            this.btnAddFileExt.Size = new System.Drawing.Size(30, 30);
            this.btnAddFileExt.TabIndex = 30;
            this.btnAddFileExt.UseVisualStyleBackColor = true;
            this.btnAddFileExt.Click += new System.EventHandler(this.btnAddFileExt_Click);
            // 
            // FrmAdvancedFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 200);
            this.Controls.Add(this.listBoxExtensions);
            this.Controls.Add(this.btnDelFileExt);
            this.Controls.Add(this.textBoxExt);
            this.Controls.Add(this.btnAddFileExt);
            this.Controls.Add(this.labelExt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdvancedFilter";
            this.Text = "Advanced filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExtensions;
        private System.Windows.Forms.Button btnDelFileExt;
        private System.Windows.Forms.Label labelExt;
        private System.Windows.Forms.TextBox textBoxExt;
        private System.Windows.Forms.Button btnAddFileExt;
    }
}