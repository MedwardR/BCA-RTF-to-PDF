using System.Runtime.InteropServices;

namespace BCA_RTF_to_PDF
{
    internal static class ShellIcons
    {
        internal static Icon? OpenFolder
        {
            get => GetIcon(4);
        }

        internal static Icon? RunArrow
        {
            get => GetIcon(137);
        }

        internal static Icon? CurvedUpArrow
        {
            get => GetIcon(146);
        }

        internal static Icon? Clipboard
        {
            get => GetIcon(260);
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int ExtractIconEx(string lpszFile, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

        [DllImport("user32.dll")]
        public static extern bool DestroyIcon(IntPtr hIcon);

        public static Icon? GetIcon(int iconIndex, bool small = true)
        {
            IntPtr[] hIconsLarge = new IntPtr[1];
            IntPtr[] hIconsSmall = new IntPtr[1];

            int iconsExtracted = ExtractIconEx("shell32.dll", iconIndex, hIconsLarge, hIconsSmall, 1);

            if (small)
            {
                if (iconsExtracted > 0 && hIconsSmall[0] != IntPtr.Zero)
                {
                    Icon folderIcon = Icon.FromHandle(hIconsSmall[0]);
                    return folderIcon;
                }
            }
            else
            {
                if (iconsExtracted > 0 && hIconsLarge[0] != IntPtr.Zero)
                {
                    Icon folderIcon = Icon.FromHandle(hIconsLarge[0]);
                    return folderIcon;
                }
            }

            return null;
        }
    }
}
