// Sound Player (.wav)


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace EasyHCI.Functions
{
    class soundPlayer : IDisposable
    {
        [DllImport("winmm.dll", SetLastError = true)] 
        private static extern int waveOutSetVolume(IntPtr device, uint volume);

        private Thread _soundThread;

        public void Dispose()
        {
        }


        public void SetVolumePercent(int volume_percent)
        {
            if (volume_percent < 0 || volume_percent > 100)
                return;

            uint volume = (uint)((0x0000FFFF * volume_percent) / 100);
            volume = volume * 65536 + volume;

            waveOutSetVolume(IntPtr.Zero, volume);
        }


        public void PlayMusic(string file_url, uint repeat_count, bool error_occured)
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(file_url);

            if (!File.Exists(file_url))
            {
                if (error_occured)
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.error);
                else
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.success);
            }

            for (uint index=0; index<repeat_count; ++index)
            {
                try
                {
                    soundPlayer.PlaySync();
                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show(file_url + "\r\n\r\n음악파일이 존재하지 않습니다.", "오류", 0, MessageBoxIcon.Error);
                    return;
                }

                catch (InvalidOperationException)
                {
                    MessageBox.Show(file_url + "\r\n\r\n올바른 웨이브 음악파일(.wav)이 아닙니다.", "오류", 0, MessageBoxIcon.Error);
                    return;
                }
            }

            soundPlayer.Dispose();
        }

        public void PlayMusicOnBackground(string file_url, uint repeat_count, bool error_occured)
        {
            TerminateMusic();

            _soundThread = new Thread(() => PlayMusic(file_url, repeat_count, error_occured));
            _soundThread.IsBackground = true;
            _soundThread.Start();
        }

        public void TerminateMusic()
        {
            if (_soundThread != null && _soundThread.IsAlive)
                _soundThread.Abort();
        }

    }
}
