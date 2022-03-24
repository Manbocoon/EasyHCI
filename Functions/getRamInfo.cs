// 메모리 총량과 사용량 정보를 알려줄 클래스


using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;




namespace EasyHCI.Functions
{
    class getRamInfo : IDisposable
    {


        public void Dispose()
        {

        }




        // 메모리 총량/사용량 반환 함수
        // [0] == Total,  [1] == Free
        public uint[] GetRamInfo()
        {
            uint[] ram_info = new uint[2];
            ManagementClass system = new ManagementClass("Win32_OperatingSystem");

            foreach (ManagementObject sysInfo in system.GetInstances())
            {
                ram_info[0] = uint.Parse(sysInfo["TotalVisibleMemorySize"].ToString()) / 1024;
                ram_info[1] = uint.Parse(sysInfo["FreePhysicalMemory"].ToString()) / 1024;
            }

            system.Dispose();

            return ram_info;
        }

    }
}
