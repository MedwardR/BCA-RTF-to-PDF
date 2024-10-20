using System.Runtime.InteropServices;

namespace BCA_RTF_to_PDF
{
    public class TaskbarProgress
    {
        private const int TBPF_NOPROGRESS = 0;
        private const int TBPF_INDETERMINATE = 1;
        private const int TBPF_NORMAL = 2;
        private const int TBPF_ERROR = 4;
        private const int TBPF_PAUSED = 8;

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetProgressState(IntPtr hwnd, int state);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetProgressValue(IntPtr hwnd, ulong completed, ulong total);

        private IntPtr _hwnd;

        public TaskbarProgress(Form form)
        {
            _hwnd = form.Handle;
        }

        public void SetProgressValue(ulong completed, ulong total)
        {
            DwmSetProgressValue(_hwnd, completed, total);
        }

        public void SetProgressState(ProgressState state)
        {
            DwmSetProgressState(_hwnd, state.Value);
        }

        public class ProgressState
        {
            public int Value { get; }

            private ProgressState(int value)
            {
                this.Value = value;
            }

            public static ProgressState NoProgress
            {
                get { return new ProgressState(TBPF_NOPROGRESS); }
            }

            public static ProgressState Intermediate
            {
                get { return new ProgressState(TBPF_INDETERMINATE); }
            }

            public static ProgressState Normal
            {
                get { return new ProgressState(TBPF_NORMAL); }
            }

            public static ProgressState Error
            {
                get { return new ProgressState(TBPF_ERROR); }
            }

            public static ProgressState Paused
            {
                get { return new ProgressState(TBPF_PAUSED); }
            }
        }
    }
}
