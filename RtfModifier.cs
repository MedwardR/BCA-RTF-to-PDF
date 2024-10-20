using System.Text;

namespace BCA_RTF_to_PDF
{
    public class RtfModifier : IDisposable
    {
        private string _filePath;
        private string _rtfContent;
        private bool _disposed = false;

        public RtfModifier(string filePath)
        {
            _filePath = filePath;
            LoadRtfFile();
        }

        // Load the RTF content from the file
        private void LoadRtfFile()
        {
            _rtfContent = File.ReadAllText(_filePath);
        }

        // Save the modified RTF content back to the file
        public void SaveRtfFile()
        {
            File.WriteAllText(_filePath, _rtfContent);
        }

        // Append text to the end of the document
        public void AppendText(string textToAppend)
        {
            int closingBraceIndex = _rtfContent.LastIndexOf('}');
            if (closingBraceIndex > 0)
            {
                StringBuilder sb = new StringBuilder(_rtfContent);
                sb.Insert(closingBraceIndex, $"{EscapeRtfText(textToAppend)}\\par ");
                _rtfContent = sb.ToString();
            }
        }

        // Modify the footer by searching for the RTF footer section
        public void ModifyFooter(string newFooterContent)
        {
            string footerKeyword = @"\footer";
            int footerStartIndex = _rtfContent.IndexOf(footerKeyword);

            if (footerStartIndex > 0)
            {
                int footerEndIndex = _rtfContent.IndexOf('}', footerStartIndex);

                if (footerEndIndex > footerStartIndex)
                {
                    StringBuilder sb = new StringBuilder(_rtfContent);
                    string replacementFooter = $"{{\\footer\\pard\\fs20 {EscapeRtfText(newFooterContent)}\\par}}";
                    sb.Remove(footerStartIndex, footerEndIndex - footerStartIndex + 1);
                    sb.Insert(footerStartIndex, replacementFooter);
                    _rtfContent = sb.ToString();
                }
            }
            else
            {
                AppendText($"\\footer\\pard\\fs20 {EscapeRtfText(newFooterContent)}\\par");
            }
        }

        // Utility method to escape special RTF characters
        private string EscapeRtfText(string text)
        {
            return text.Replace("\\", "\\\\").Replace("{", "\\{").Replace("}", "\\}");
        }

        // Implementing IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free any managed resources if necessary (none in this case)
                    _rtfContent = null;
                }

                // Free any unmanaged resources if necessary

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Destructor (in case Dispose is not called explicitly)
        ~RtfModifier()
        {
            Dispose(false);
        }
    }
}
