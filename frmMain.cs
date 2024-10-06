namespace BCA_RTF_to_PDF
{
    public partial class frmMain : Form
    {
        private CancellationTokenSource? m_UiCts;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Input
        private void btnOpen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(this);
            string path = folderBrowserDialog1.SelectedPath;
            if (!string.IsNullOrWhiteSpace(path))
            {
                tbFolderPath.Text = path;
            }
        }

        private async void tbFolderPath_TextChanged(object sender, EventArgs e)
        {
            string path = tbFolderPath.Text;
            if (Directory.Exists(path))
            {
                if (m_UiCts != null)
                {
                    m_UiCts.Cancel();
                }

                m_UiCts = new();
                try
                {
                    await Task.Run(UpdateInputFilesList, m_UiCts.Token);
                }
                catch (OperationCanceledException ex)
                {
                    // ignore
                }
                finally
                {
                    m_UiCts?.Dispose();
                    m_UiCts = null;
                }
            }
            else
            {
                UpdateFolderInfo(false);
            }
        }

        private void UpdateInputFilesList()
        {
            if (gbFolderInfo.InvokeRequired)
            {
                gbFolderInfo.Invoke(UpdateInputFilesList);
            }
            else
            {
                string path = tbFolderPath.Text;
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path);
                    int fileCount = files.Where((f) => Path.GetExtension(f).Equals(".rtf", StringComparison.CurrentCultureIgnoreCase)).Count();
                    bool hasTOC = files.Where((f) => Path.GetFileName(f).Equals("_Table_of_Contents.htm", StringComparison.CurrentCultureIgnoreCase)).Count() > 0;

                    UpdateFolderInfo(true, fileCount, hasTOC);
                }
                else
                {
                    UpdateFolderInfo(false);
                }
            }
        }

        private void UpdateFolderInfo(bool folderExists, int fileCount = 0, bool hasTOC = false)
        {
            if (gbFolderInfo.InvokeRequired)
            {
                gbFolderInfo.Invoke(UpdateInputFilesList);
            }
            else
            {
                lbFileCount.Visible = folderExists;
                lbFileCount.Text = $"Contains {fileCount} RTF files";
                lbHasTOC.Visible = folderExists && hasTOC;
            }
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {
            ProcessFiles();
        }
        #endregion

        #region Output
        private async void ProcessFiles()
        {
            
        }
        #endregion
    }
}
