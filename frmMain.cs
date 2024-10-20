using System.Diagnostics;

namespace BCA_RTF_to_PDF
{
    public partial class frmMain : Form, IDisposable
    {
        private Settings m_Settings;
        private bool m_IsLoaded;

        public frmMain()
        {
            try
            {
                m_IsLoaded = false;
                InitializeComponent();
                LoadCoolShellIcons();

                m_Settings = Settings.Load();

                m_IsLoaded = true;
            }
            catch (Exception ex)
            {

            }
        }

        #region Event Handlers
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                tbPath.Text = m_Settings.LastValidPath;
            }
            catch (Exception ex)
            {

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bool firstTab = tabControl1.SelectedTab == tabPage1;
                btnLaunch.Visible = firstTab;
                btnPaste.Visible = firstTab;
                btnOpen.Visible = firstTab;
                progressBar2.Visible = !firstTab;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(tbPath.Text))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = tbPath.Text,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                tbPath.Text = Clipboard.GetText();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog(this);
                if (!string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
                {
                    LoadDirectoryData(folderBrowserDialog1.SelectedPath);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDirectoryData(tbPath.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                m_Settings.Save();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Process Files
        private void LoadDirectoryData(string dir)
        {
            try
            {
                if (!m_IsLoaded)
                {
                    return;
                }
                else
                {
                    m_IsLoaded = false;
                }

                tbPath.Text = dir;

                int rtfCount = 0;
                bool hasTOC = false;

                if (Directory.Exists(dir))
                {
                    string[] files = Directory.GetFiles(dir);

                    rtfCount = files.Count(f => Path.GetExtension(f).Trim().ToLower() == ".rtf");
                    hasTOC = files.Count(f => Path.GetFileName(f).Trim().ToLower() == "_table_of_contents.htm") > 0;

                    if (rtfCount > 0)
                    {
                        m_Settings.LastValidPath = dir;
                        m_Settings.Save();
                    }

                    btnLaunch.Enabled = true;
                }
                else
                {
                    btnLaunch.Enabled = false;
                }

                UpdateFolderDetail(rtfCount, hasTOC);
                AllowEdit(rtfCount > 0);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                m_IsLoaded = true;
            }
        }
        #endregion

        #region UI Methods
        private void LoadCoolShellIcons()
        {
            try
            {
                btnLaunch.Image = ShellIcons.CurvedUpArrow?.ToBitmap();
                btnPaste.Image = ShellIcons.Clipboard?.ToBitmap();
                btnOpen.Image = ShellIcons.OpenFolder?.ToBitmap();
                btnProcessFiles.Image = ShellIcons.RunArrow?.ToBitmap();
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateFolderDetail(int rtfCount, bool hasTOC)
        {
            try
            {
                if (lblFolderDtl.InvokeRequired)
                {
                    lblFolderDtl.Invoke(() => UpdateFolderDetail(rtfCount, hasTOC));
                }
                else
                {
                    lblFolderDtl.Visible = rtfCount > 0 || hasTOC;
                    if (lblFolderDtl.Visible)
                    {
                        HashSet<string> tokens = [];
                        if (rtfCount > 0)
                        {
                            tokens.Add(rtfCount + " RTF files");
                        }
                        if (hasTOC)
                        {
                            tokens.Add("table of contents");
                        }
                        lblFolderDtl.Text = "Contains " + string.Join(" and ", tokens.Where(t => !string.IsNullOrWhiteSpace(t)));
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void AllowEdit(bool canEdit)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(() => AllowEdit(canEdit));
                }
                else
                {
                    btnProcessFiles.Enabled = canEdit;
                    progressBar1.Enabled = canEdit;
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        void IDisposable.Dispose()
        {
            try
            {
                m_Settings.Dispose();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
