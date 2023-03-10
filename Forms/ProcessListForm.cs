using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;



namespace EasyHCI.Forms
{
    public partial class ProcessListForm : MaterialForm
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
        public string file_path { get; set; } = Application.StartupPath + @"\Resources\Process_Exceptions.ini";
        #endregion


        public ProcessListForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        #region Draw shadow on my Form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams crp = base.CreateParams;
                crp.ClassStyle = 0x00020000;
                return crp;
            }
        }
        #endregion




        // 폼이 종료될 때마다 행할 액션
        private void CloseForm()
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

        private void SelectExceptedProcesses()
        {
            if (!File.Exists(file_path))
            {
                Directory.CreateDirectory(Program.Path + "\\Resources");

                File.WriteAllText(file_path, Properties.Resources.Process_Exceptions_Default, new UTF8Encoding(false));
            }

            string[] file = File.ReadAllLines(file_path, new UTF8Encoding(false));
            for (int i_list=0; i_list<list.Items.Count; ++i_list)
            {
                for (int i_file = 0; i_file < file.Length; ++i_file)
                {

                    if (list.Items[i_list].Text.ToLower() == file[i_file].ToLower())
                    {
                        list.Items[i_list].Checked = true;
                    }
                }
            }
        }



        private ImageList imgList = new ImageList();
        private List<string> check_exist = new List<string>();
        private void addProcessesToList()
        {
            if (imgList.Images.Count > 0)
                imgList.Images.Clear();
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            list.BeginUpdate();     
            list.Items.Clear();
            list.Sorting = SortOrder.Ascending;
            list.SmallImageList = imgList;


            Process[] processes = Process.GetProcesses();
            check_exist.Clear();
            for (int i=0; i<processes.Length; ++i)
            {
                bool system_process = false;
                for (int i_sys=0; i_sys<memExcept.Length; ++i_sys)
                {
                    if (processes[i].ProcessName.ToLower() == memExcept[i_sys].ToLower())
                    {
                        system_process = true;
                        break;
                    }
                }


                if (!system_process)
                {
                    string process_filePath = GetProcessPath(processes[i]);

                    // 동일한 이름의 프로세스 중복 추가 방지
                    bool already_exist = false;
                    if (process_filePath == null)
                        already_exist = true;
                    else
                    {
                        for (int i_exist = 0; i_exist < check_exist.Count; ++i_exist)
                        {
                            if (Path.GetFileName(process_filePath).ToLower().Trim() == check_exist[i_exist].ToLower())
                            {
                                already_exist = true;
                                break;
                            }
                        }
                    }

                    if (already_exist)                  
                        continue;
                    


                    try { imgList.Images.Add(Icon.ExtractAssociatedIcon(process_filePath)); }

                    catch (Exception)
                    { imgList.Images.Add(new Icon(SystemIcons.Application, 32, 32));}

                    list.Items.Add(new ListViewItem(Path.GetFileName(process_filePath).Trim(), imgList.Images.Count - 1));
                    check_exist.Add(Path.GetFileName(process_filePath));
                }

            }


            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            list.EndUpdate();
        }



        private void RemoveEmptyLinesAndWriteFile(string fileData)
        {
            string[] file_lines = fileData.Split('\n');
            List<string> valid_data = new List<string>();
            string comments = "# 예외처리할 프로세스를 한 줄에 하나씩 써주세요.\r\n# 대소문자를 구별하지 않으셔도 됩니다.\r\n# 윈도우 구동에 필요한 기본 프로세스들은 적지 않으셔도 예외처리됩니다.\r\n# 가장 앞에 #을 붙이거나 아무것도 입력하지 않은 줄은 주석처리 되어 무시됩니다.\r\n\r\n# -------------------\r\n# ---이 밑에 입력---\r\n# -------------------\r\n\r\n";

            valid_data.Clear();
            for (int i=0; i<file_lines.Length; ++i)
            {
                if (file_lines[i].Length > 1 && !file_lines[i].StartsWith("#"))
                {
                    valid_data.Add(file_lines[i].ToLower().Trim());
                }
            }

            StringBuilder newFile = new StringBuilder(null);
            newFile.Append(comments);
            for (int i=0; i<valid_data.Count; ++i)         
                newFile.AppendLine(valid_data[i]);

            File.WriteAllText(file_path, newFile.ToString(), new UTF8Encoding(false));    
        }


        private void ProcessListForm_Load(object sender, EventArgs e)
        {
            addProcessesToList();
            SelectExceptedProcesses();
        }

        private void ProcessListForm_Resize(object sender, EventArgs e)
        {
            list.Size = new Size(this.Width - 24, this.Height - 167);

            addToExceptions.Location = new Point(12, this.Height - 60);
            addToExceptions.Size = new Size(this.Width - 24, 48);
        }

        private void list_Click(object sender, EventArgs e)
        {
            
            ListView.SelectedIndexCollection selects = list.SelectedIndices;

            list.Items[selects[selects.Count - 1]].Checked = !list.Items[selects[selects.Count - 1]].Checked;
        }




        private List<string> added_items = new List<string>();
        private List<string> removed_items = new List<string>();

        private void addToExceptions_Click(object sender, EventArgs e)
        {
            if (!File.Exists(file_path))
                File.WriteAllText(file_path, "# 예외처리할 프로세스를 한 줄에 하나씩 써주세요.\r\n# 대소문자를 구별하지 않으셔도 됩니다.\r\n# 윈도우 구동에 필요한 기본 프로세스들은 적지 않으셔도 예외처리됩니다.\r\n# 가장 앞에 #을 붙이거나 아무것도 입력하지 않은 줄은 주석처리 되어 무시됩니다.\r\n\r\n# -------------------\r\n# ---이 밑에 입력---\r\n# -------------------\r\n\r\nhwinfo32.exe\r\nhwinfo64.exe\r\nZenTimings.exe\r\nZenTimings-legacy.exe\r\naida64.exe", new UTF8Encoding(false));

            added_items.Clear();
            removed_items.Clear();

            string newFile = File.ReadAllText(file_path, new UTF8Encoding(false)).ToLower();
            string[] file = newFile.Split('\n');
            for (int i_list=0; i_list<list.Items.Count; ++i_list)
            {
                bool exist = false;
                string list_item = list.Items[i_list].Text.ToLower().Trim();

                // 파일을 열어 이미 존재하는 프로세스인지 확인
                for (int i_file=0; i_file<file.Length; ++i_file)
                {
                    if (file[i_file].Length < 2 || file[i_file].StartsWith("#"))
                        continue;


                    if (file[i_file].ToLower().Trim() == list_item)
                    {
                        exist = true;
                        break;
                    }
                }



                // 새로 예외추가할 항목이지만 기존 목록에 없으면 새로 추가
                if (list.Items[i_list].Checked && !exist)
                {
                    added_items.Add(list_item);
                    newFile += '\n' + list_item;
                }

                // 이미 예외추가 되어 있었는데 유저가 체크해제한 경우 예외목록에서 삭제
                else if (!list.Items[i_list].Checked && exist)
                {
                    removed_items.Add(list_item);
                    newFile = newFile.Replace(list_item, null);
                }

            }

            RemoveEmptyLinesAndWriteFile(newFile);
            
            string added_msg = null, removed_msg = null;
            for (int i=0; i<added_items.Count; ++i)         
                added_msg += added_items[i] + '\n';
            for (int i = 0; i < removed_items.Count; ++i)
                removed_msg += removed_items[i] + '\n';

            MessageBox.Show("▼ 예외 목록에 추가된 프로세스 ▼\r\n" + added_msg + "\r\n\r\n" + "▼ 예외 목록에서 제거된 프로세스 ▼ \r\n" + removed_msg + '\n', "알림", 0, MessageBoxIcon.Information);
            
        }


    }
}
