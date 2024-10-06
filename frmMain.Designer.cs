namespace BCA_RTF_to_PDF
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbFolderPath = new TextBox();
            btnOpen = new Button();
            btnProcessFiles = new Button();
            splitContainer1 = new SplitContainer();
            gbFolderInfo = new GroupBox();
            lbHasTOC = new Label();
            lbFileCount = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbFolderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tbFolderPath
            // 
            tbFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFolderPath.Location = new Point(13, 13);
            tbFolderPath.Margin = new Padding(4);
            tbFolderPath.Name = "tbFolderPath";
            tbFolderPath.Size = new Size(285, 23);
            tbFolderPath.TabIndex = 1;
            tbFolderPath.TextChanged += tbFolderPath_TextChanged;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.FlatStyle = FlatStyle.System;
            btnOpen.Location = new Point(306, 13);
            btnOpen.Margin = new Padding(4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(86, 24);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open Folder";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnProcessFiles
            // 
            btnProcessFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnProcessFiles.FlatStyle = FlatStyle.System;
            btnProcessFiles.Location = new Point(13, 138);
            btnProcessFiles.Margin = new Padding(4);
            btnProcessFiles.Name = "btnProcessFiles";
            btnProcessFiles.Size = new Size(379, 50);
            btnProcessFiles.TabIndex = 5;
            btnProcessFiles.Text = "Process Files";
            btnProcessFiles.UseVisualStyleBackColor = true;
            btnProcessFiles.Click += this.btnProcessFiles_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbFolderInfo);
            splitContainer1.Panel1.Controls.Add(btnProcessFiles);
            splitContainer1.Panel1.Controls.Add(tbFolderPath);
            splitContainer1.Panel1.Controls.Add(btnOpen);
            splitContainer1.Panel1.Padding = new Padding(0, 0, 4, 0);
            splitContainer1.Panel1MinSize = 300;
            splitContainer1.Size = new Size(800, 400);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 100;
            // 
            // gbFolderInfo
            // 
            gbFolderInfo.Controls.Add(lbHasTOC);
            gbFolderInfo.Controls.Add(lbFileCount);
            gbFolderInfo.FlatStyle = FlatStyle.System;
            gbFolderInfo.Location = new Point(13, 43);
            gbFolderInfo.Name = "gbFolderInfo";
            gbFolderInfo.Size = new Size(379, 88);
            gbFolderInfo.TabIndex = 7;
            gbFolderInfo.TabStop = false;
            gbFolderInfo.Text = "Folder Information";
            // 
            // lbHasTOC
            // 
            lbHasTOC.AutoSize = true;
            lbHasTOC.FlatStyle = FlatStyle.System;
            lbHasTOC.Location = new Point(9, 55);
            lbHasTOC.Name = "lbHasTOC";
            lbHasTOC.Size = new Size(119, 15);
            lbHasTOC.TabIndex = 2;
            lbHasTOC.Text = "Has table of contents";
            lbHasTOC.Visible = false;
            // 
            // lbFileCount
            // 
            lbFileCount.AutoSize = true;
            lbFileCount.FlatStyle = FlatStyle.System;
            lbFileCount.Location = new Point(9, 29);
            lbFileCount.Name = "lbFileCount";
            lbFileCount.Size = new Size(108, 15);
            lbFileCount.TabIndex = 0;
            lbFileCount.Text = "Contains 0 RTF files";
            lbFileCount.Visible = false;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Open folder containing BCA RTF files";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.UseDescriptionForTitle = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(800, 400);
            Controls.Add(splitContainer1);
            Name = "frmMain";
            Text = "BCA RTF to PDF";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbFolderInfo.ResumeLayout(false);
            gbFolderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbFolderPath;
        private Button btnOpen;
        private Button btnProcessFiles;
        private SplitContainer splitContainer1;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox gbFolderInfo;
        private Label lbHasTOC;
        private Label lbFileCount;
    }
}
