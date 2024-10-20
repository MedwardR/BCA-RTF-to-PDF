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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            llSettings = new LinkLabel();
            lblFolderDtl = new Label();
            progressBar1 = new ProgressBar();
            btnProcessFiles = new Button();
            tbPath = new TextBox();
            tabPage2 = new TabPage();
            lstLog = new ListView();
            ilLog = new ImageList(components);
            btnOpen = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnPaste = new Button();
            btnLaunch = new Button();
            progressBar2 = new ProgressBar();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(12, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(387, 134);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(llSettings);
            tabPage1.Controls.Add(lblFolderDtl);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(btnProcessFiles);
            tabPage1.Controls.Add(tbPath);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(379, 106);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Process Files";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // llSettings
            // 
            llSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            llSettings.AutoSize = true;
            llSettings.Location = new Point(324, 39);
            llSettings.Name = "llSettings";
            llSettings.Size = new Size(49, 15);
            llSettings.TabIndex = 6;
            llSettings.TabStop = true;
            llSettings.Text = "Settings";
            // 
            // lblFolderDtl
            // 
            lblFolderDtl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFolderDtl.AutoEllipsis = true;
            lblFolderDtl.Location = new Point(6, 39);
            lblFolderDtl.Name = "lblFolderDtl";
            lblFolderDtl.Size = new Size(312, 15);
            lblFolderDtl.TabIndex = 5;
            lblFolderDtl.Text = "Contains 0 RTF files";
            lblFolderDtl.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(61, 64);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(312, 36);
            progressBar1.TabIndex = 4;
            // 
            // btnProcessFiles
            // 
            btnProcessFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnProcessFiles.Location = new Point(6, 64);
            btnProcessFiles.Name = "btnProcessFiles";
            btnProcessFiles.Size = new Size(49, 36);
            btnProcessFiles.TabIndex = 3;
            btnProcessFiles.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            tbPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPath.Location = new Point(6, 6);
            tbPath.Name = "tbPath";
            tbPath.PlaceholderText = "Folder path";
            tbPath.Size = new Size(367, 23);
            tbPath.TabIndex = 0;
            tbPath.TextChanged += tbPath_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstLog);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(379, 106);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Details";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            lstLog.BackColor = Color.FromArgb(249, 249, 249);
            lstLog.BorderStyle = BorderStyle.None;
            lstLog.Dock = DockStyle.Fill;
            lstLog.HideSelection = true;
            lstLog.LabelWrap = false;
            lstLog.Location = new Point(3, 3);
            lstLog.Name = "lstLog";
            lstLog.ShowGroups = false;
            lstLog.Size = new Size(373, 100);
            lstLog.SmallImageList = ilLog;
            lstLog.TabIndex = 0;
            lstLog.UseCompatibleStateImageBehavior = false;
            lstLog.View = View.List;
            // 
            // ilLog
            // 
            ilLog.ColorDepth = ColorDepth.Depth4Bit;
            ilLog.ImageStream = (ImageListStreamer)resources.GetObject("ilLog.ImageStream");
            ilLog.TransparentColor = Color.Transparent;
            ilLog.Images.SetKeyName(0, "info.png");
            ilLog.Images.SetKeyName(1, "warning.png");
            ilLog.Images.SetKeyName(2, "error.png");
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.Location = new Point(359, 7);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(40, 26);
            btnOpen.TabIndex = 1;
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Open folder containing BCA RTF files";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.UseDescriptionForTitle = true;
            // 
            // btnPaste
            // 
            btnPaste.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPaste.Location = new Point(313, 7);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(40, 26);
            btnPaste.TabIndex = 2;
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnLaunch
            // 
            btnLaunch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLaunch.Location = new Point(267, 7);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(40, 26);
            btnLaunch.TabIndex = 3;
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // progressBar2
            // 
            progressBar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar2.Location = new Point(147, 19);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(250, 13);
            progressBar2.TabIndex = 6;
            progressBar2.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(411, 161);
            Controls.Add(progressBar2);
            Controls.Add(btnLaunch);
            Controls.Add(btnPaste);
            Controls.Add(btnOpen);
            Controls.Add(tabControl1);
            MinimumSize = new Size(309, 200);
            Name = "frmMain";
            Padding = new Padding(12, 15, 12, 12);
            Text = "BCA RTF to PDF";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnOpen;
        private TextBox tbPath;
        private Button btnProcessFiles;
        private ProgressBar progressBar1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lblFolderDtl;
        private ListView lstLog;
        private ImageList ilLog;
        private Button btnPaste;
        private Button btnLaunch;
        private ProgressBar progressBar2;
        private LinkLabel llSettings;
    }
}
