// Process Cleaner


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EasyHCI.Functions
{
    class cleanMemory : IDisposable
    {
        #region Win32 API
        [DllImport("user32")]
        public static extern UInt16 GetAsyncKeyState(Int32 vKey);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool QueryFullProcessImageName(IntPtr hProcess, int dwFlags, StringBuilder lpExeName, ref int lpdwSize);

        private const int QueryLimitedInformation = 0x00001000;
        #endregion

        #region Region Variables
        private readonly string[] memExcept = new string[] { "csrss", "dasHost", "dllHost", "dwm", "explorer", "fontdrvhost", "audiodg", "lsass", "MsMpEng", "NisSrv", "Registry", "ntoskrnl", "RuntimeBroker", "SecurityHealthService", "services", "SgrmBroker", "sihost", "svchost", "smss", "spoolsv", "System", "taskhostw", "winlogon", "wininit", "Taskmgr", "Idle", "rundll32" };
        private string appPath = Application.StartupPath;
        private string file_path = Application.StartupPath + @"\Resources\Process_Exceptions.ini";
        #endregion




        public void Dispose()
        { 
        
        }

        // Process ID를 통해 해당 프로세스의 실행파일 경로를 가져오는 함수
        private string GetProcessPath(Process process)
        {
            int size = 1024;
            StringBuilder exeName = new StringBuilder(size);
            IntPtr handle = OpenProcess(QueryLimitedInformation, false, process.Id);

            if (handle == IntPtr.Zero)
                return null;

            bool success = QueryFullProcessImageName(handle, 0, exeName, ref size);
            CloseHandle(handle);

            if (!success)
                return null;

            return exeName.ToString();
        }

        public void clean_memory()
        {
            bool system_process;

            Process[] processCollection = Process.GetProcesses();

            foreach (Process proc in processCollection)
            {
                system_process = false;

                // 윈도우 구동에 필요한 프로세스인지 확인
                for (int index = 0; index < memExcept.Length; ++index)
                {
                    if (memExcept[index].ToLower() == proc.ProcessName.ToLower())
                    {
                        system_process = true;
                        break;
                    }
                }

                // 나 자신인지 확인
                if (Process.GetCurrentProcess().ProcessName == proc.ProcessName) { system_process = true; }

                // 사용자가 따로 예외처리한 프로세스인지 확인
                if (File.Exists(file_path))
                {
                    string[] eFile = File.ReadAllLines(file_path, Encoding.Default);

                    for (int index = 0; index < eFile.Length; ++index)
                    {
                        // 길이와 주석 확인
                        if (eFile[index].Length > 1 && !eFile[index].StartsWith("#"))
                        {
                            // 예외처리 확인
                            string processName = Path.GetFileName(GetProcessPath(proc));
                            if (processName == null)
                                continue;

                            if (eFile[index].ToLower().Trim() == processName.ToLower())
                            {
                                system_process = true;
                                break;
                            }
                        }

                    }
                }

                // 3가지 유형에 포함되지 않는 프로세스는 종료
                if (!system_process)
                {
                    try
                    {
                        proc.Kill();
                        proc.Dispose();
                    }

                    catch (Exception) { }
                }
            }
        }



    }
}
