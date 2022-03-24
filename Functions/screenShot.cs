// Screenshot Class


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace EasyHCI.Functions
{
    class screenShot : IDisposable
    {
        #region Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        #endregion

        public void Dispose()
        {

        }



        public void Screenshot(string screenshot_path, byte RGB_Quality)
        {
            Bitmap ScreenBitmap;
            IntPtr DesktopHwnd = GetDesktopWindow();
            PixelFormat pixel_format = PixelFormat.Format32bppArgb;

            if (RGB_Quality == 0)
                pixel_format = PixelFormat.Format16bppRgb555;
            else if (RGB_Quality == 1)
                pixel_format = PixelFormat.Format24bppRgb;


            using (Graphics DesktopGr = Graphics.FromHwnd(DesktopHwnd))
            {
                // GetDeviceCaps 함수의 2번째 인자는 반환될 해상도 값을 결정 (width/height)
                IntPtr DesktopHdc = DesktopGr.GetHdc();
                int Width = GetDeviceCaps(DesktopHdc, 118);
                int Height = GetDeviceCaps(DesktopHdc, 117);

                ScreenBitmap = new Bitmap(Width, Height, pixel_format);

                using (Graphics ScreenBitmapGr = Graphics.FromImage(ScreenBitmap))
                    ScreenBitmapGr.CopyFromScreen(0, 0, 0, 0, new Size(Width, Height));

            }

            try 
            {
                ScreenBitmap.Save(screenshot_path + "\\" + DateTime.Now.ToString("(yyyy년 MM월 dd일) hh시 mm분 ss초") + ".png", ImageFormat.Png);
            }

            catch (Exception) { File.WriteAllText(screenshot_path + "\\" + DateTime.Now.ToString("(yyyy년 MM월 dd일) hh시 mm분 ss초 오류발생") + ".png", null, new UTF8Encoding(false)); }
        }
    }
}
