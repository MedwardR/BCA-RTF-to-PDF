using System.Text.Json;

namespace BCA_RTF_to_PDF
{
    public class Settings : IDisposable
    {
        private CancellationTokenSource? m_SaveCTS;

        public string LastValidPath { get; set; } = string.Empty;

        internal static string GetFilePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "BCA-RTF-to-PDF", "settings.json");
        }

        internal static Settings Load()
        {
            try
            {
                string filePath = GetFilePath();
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<Settings>(json) ?? new();
                }
                else
                {
                    return new();
                }
            }
            catch
            {
                return new();
            }
        }

        internal void Save()
        {
            m_SaveCTS?.Cancel();
            m_SaveCTS?.Dispose();
            m_SaveCTS = null;

            string filePath = GetFilePath();
            string json = JsonSerializer.Serialize(this);

            try
            {
                File.WriteAllText(filePath, json);
            }
            catch
            {
                m_SaveCTS = new();
                Task.Run(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        try
                        {
                            File.WriteAllText(filePath, json);
                            break;
                        }
                        catch { }
                    }
                    m_SaveCTS = null;
                }, m_SaveCTS.Token);
            }
        }

        public void Dispose()
        {
            m_SaveCTS?.Cancel();
            m_SaveCTS?.Dispose();
        }
    }
}
