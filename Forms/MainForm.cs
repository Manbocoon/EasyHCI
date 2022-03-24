// 기본 UI와 기능이 포함된 클래스


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.Win32;

using System.Management;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

using MaterialSkin;
using MaterialSkin.Controls;
using EasyHCI.Functions;
using EasyHCI.Functions.UI;



namespace EasyHCI.Forms
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        #region Win32 API
        [DllImport("user32")]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr parentHWnd, IntPtr childAfterHWnd, string className, string windowTitle);
        [DllImport("user32")]
        public static extern Int32 SendMessage(IntPtr hWnd, Int32 uMsg, IntPtr WParam, IntPtr LParam);
        [DllImport("user32")]
        public static extern Int32 PostMessage(IntPtr hWnd, Int32 uMsg, IntPtr WParam, IntPtr LParam);
        [DllImport("user32")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32")]
        public static extern int MoveWindow(IntPtr hwnd, int x, int y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32")]
        public static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);



        private const int CLICK = 0x00F5;
        private const int WM_GetText = 0x000D;
        private const int WM_SetText = 0X000C;
        private const int Sw_Hide = 0;
        private const int Sw_Show = 5;
        #endregion

        #region Region Variables
        private uint totalMemMB = 0, freeMemMB = 0;
    
        private double coverage_min = 0, coverage_max = 0, coverage_avg = 0;

        private bool endProgram = false, user_stopped = false, error_occured = false;

        private string appPath = Application.StartupPath;

        private StringBuilder coverage_txt = new StringBuilder(null, 50), errorCount_txt = new StringBuilder(null, 50);
        private StringBuilder ErrMsg = new StringBuilder(null), finalRecord = new StringBuilder(null);
        #endregion




        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        #region Draw Shadow on the form
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



        #region Functions - Elapsed Time
        private Stopwatch std_timer = new Stopwatch();
        private void showTimeData()
        {
            TimeSpan time_span = std_timer.Elapsed;
            double pass_rate = 0;

            if (test_std_min.Checked)           
                pass_rate = coverage_min;           
            else if (test_std_avg.Checked)            
                pass_rate = coverage_avg;


            // 남은 시간을 계산하여 예측
            double passRate_perSecond = pass_rate / time_span.TotalSeconds;
            double remained_passRate = uint.Parse(test_target.Text) - pass_rate;
            uint remained_second = (uint)(remained_passRate / passRate_perSecond);

            uint hour = remained_second / 3600;
            uint minute = (remained_second % 3600) / 60;
            uint second = (remained_second % 3600) % 60;


            this.Invoke((MethodInvoker)delegate ()
            {
                elapsed_time.Text = "경과 시간: " + (time_span.Hours + "시간 ") + (time_span.Minutes + "분 ") + (time_span.Seconds + "초");
                remained_time.Text = "남은 시간: " + (hour + "시간 ") + (minute + "분 ") + (second + "초");
            });
        }
        #endregion

        #region Functions - Notify (Sound Player)
        private soundPlayer soundPlayer = new soundPlayer();

        // 소리알림 재생 함수
        private void PlayMusic(bool Error_Occured)
        {
            if (!uint.TryParse(notify_count.Text, out uint repeat_count))
            {
                MessageBox.Show("소리 알림을 \"" + notify_count.Text + "\"회 반복재생할 수 없습니다.\r\n\r\n반드시 양의 정수로 입력해주세요.", "오류", 0, MessageBoxIcon.Error);
                return;
            }

            if (Error_Occured)
                soundPlayer.PlayMusicOnBackground(notify_error_path.Text, repeat_count);

            else
                soundPlayer.PlayMusicOnBackground(notify_success_path.Text, repeat_count);          
        }



        private void notify_volume_bar_ValueChanged(object sender, EventArgs e)
        {
            notify_volume.Text = ((byte)notify_volume_bar.Value).ToString();
        }

        private void notify_count_bar_ValueChanged(object sender, EventArgs e)
        {
            notify_count.Text = ((uint)notify_count_bar.Value).ToString();
        }

        private void notify_success_setPath_Click(object sender, EventArgs e)
        {
            dialog_open_file.FileName = notify_success_path.Text;
            dialog_open_file.ShowDialog();


            if (!File.Exists(dialog_open_file.FileName))
                MessageBox.Show("파일을 선택하지 않으셨습니다.\r\n\r\n소리알림 기능을 사용할 경우 오류가 발생하거나 기능이 정상작동하지 않을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
                notify_success_path.Text = dialog_open_file.FileName;
        }

        private void notify_error_setPath_Click(object sender, EventArgs e)
        {
            dialog_open_file.FileName = notify_error_path.Text;
            dialog_open_file.ShowDialog();

            if (!File.Exists(dialog_open_file.FileName))
                MessageBox.Show("파일을 선택하지 않으셨습니다.\r\n\r\n소리알림 기능을 사용할 경우 오류가 발생하거나 기능이 정상작동하지 않을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
                notify_error_path.Text = dialog_open_file.FileName;
        }


        // 소리알림 테스트
        private Thread _soundTestThread;
        private void notify_test_Click(object sender, EventArgs e)
        {
            if (notify_test.BackColor.G > 100)
            {
                if (!File.Exists(notify_success_path.Text) || !File.Exists(notify_error_path.Text))
                {
                    MessageBox.Show("통과 알림음, 오류 알림음 중 존재하지 않는 파일이 있습니다.", "오류", 0, MessageBoxIcon.Error);
                    return;
                }

                ushort volume = ushort.Parse(notify_volume.Text);
                if (volume > 100)
                    volume = 100;

                SetButtonState(notify_test, true, "소리알림 테스트");

                soundPlayer.SetVolumePercent(volume);

                if (_soundTestThread != null && _soundTestThread.IsAlive)
                    _soundTestThread.Abort();

                _soundTestThread = new Thread(() =>
                {
                    soundPlayer.PlayMusic(notify_success_path.Text, 1);
                    soundPlayer.PlayMusic(notify_error_path.Text, 1);

                    this.Invoke((MethodInvoker)delegate ()
                    { SetButtonState(notify_test, false, "소리알림 테스트"); });
                });
                _soundTestThread.IsBackground = true;
                _soundTestThread.Start();
            }

            else
            {
                if (_soundTestThread != null && _soundTestThread.IsAlive)
                    _soundTestThread.Abort();

                SetButtonState(notify_test, false, "소리알림 테스트");
            }
        }

        #endregion

        #region Functions - Test and Monitoring
        private struct HCI_Memtest
        {
            public Process process;

            public IntPtr form;
            public IntPtr coverage;
            public IntPtr ram;
            public IntPtr start;
            public IntPtr exit;

            public double coverage_value;


            public Label title_label;
            public Label coverage_label;
            public Label error_label;
        }

        private HCI_Memtest[] HCI = new HCI_Memtest[1];
        private uint CPUThreads = 0, screen_width = 0, screen_height = 0, test_count = 0, test_ammount = 0, error_count = 0;
        private void StartTest()
        {
            byte capHour = (byte)DateTime.Now.Hour, capMinute = (byte)DateTime.Now.Minute;
            ushort mem_max = 0;
            bool mem_max_found = false;
            IntPtr welcome_form = IntPtr.Zero, welcome_button = IntPtr.Zero;
            StringBuilder allocate_msg = new StringBuilder(null, 40);
   



            // 자동 테스트인 경우 HCI Memtest 프로세스 하나가 테스트할 수 있는 최대 메모리 가용량을 알아냄
            if (!test_manual.Checked)
            {
                // 시작하기 전에 여유 메모리와 CPU 쓰레드 수에 따라 구간을 나누어 작업량 줄이기
                if ((freeMemMB / CPUThreads) <= 2000)
                { mem_max = 2030; }
                else if ((freeMemMB / CPUThreads) > 2000 && (freeMemMB / CPUThreads) < 2501)
                { mem_max = 2530; }
                else if ((freeMemMB / CPUThreads) > 2500 && (freeMemMB / CPUThreads) < 3001)
                { mem_max = 3030; }
                else
                { mem_max = 3530; }

                // 임시 최대값에서 천천히 최대값을 25MB씩 줄여가면서 최적의 값을 찾기 전까지 루프
                while (!mem_max_found)
                {
                    welcome_form = IntPtr.Zero; 
                    welcome_button = IntPtr.Zero;
                    HCI[0].form = IntPtr.Zero;
                    mem_max -= 25;

                    HCI[0].process = Process.Start(appPath + @"\Resources\memtest.exe");

                    while (welcome_form == IntPtr.Zero)
                    {
                        welcome_form = FindWindow("#32770", "어서오세요!");
                        Thread.Sleep(3);
                    }

                    welcome_button = FindWindowEx(welcome_form, IntPtr.Zero, "Button", "확인");
                    SendMessage(welcome_button, CLICK, 0, 0);

                    while (HCI[0].form == IntPtr.Zero)
                    {
                        HCI[0].form = HCI[0].process.MainWindowHandle;
                        ShowWindow(HCI[0].form, Sw_Hide);
                        Thread.Sleep(3);
                    }

                    HCI[0].start = FindWindowEx(HCI[0].form, IntPtr.Zero, "Button", "테스트 시작");
                    HCI[0].exit = FindWindowEx(HCI[0].form, IntPtr.Zero, "Button", "테스트 중단");
                    HCI[0].coverage = FindWindowEx(HCI[0].form, IntPtr.Zero, "Static", "무료 버전");
                    HCI[0].ram = FindWindowEx(HCI[0].form, IntPtr.Zero, "Edit", null);

                    SetHwndText(HCI[0].ram, mem_max.ToString());

                    // 테스트 시작
                    PostMessage(HCI[0].start, CLICK, IntPtr.Zero, IntPtr.Zero);
                    allocate_msg.Clear();
                    allocate_msg.Append("무료 버전");

                    while (allocate_msg.ToString() == "무료 버전")
                    {
                        GetWindowText(HCI[0].coverage, allocate_msg, 40);
                        Thread.Sleep(3);
                    }

                    if (allocate_msg.ToString() == "테스트 준비 중...")
                        mem_max_found = true;

                    else if (allocate_msg.ToString() == mem_max + " MB 할당 불가!") 
                        mem_max_found = false;

                    HCI[0].process.Kill();
                    HCI[0].process.Dispose();
                }



                // mem_max = 프로세스 하나 당 가용 가능한 최대 메모리
                // 탐색된 최대 메모리를 기반으로 테스트 정보 자동설정
                double.TryParse(test_except.Text, out double test_freeAmmount);

                test_ammount = (ushort)((freeMemMB - test_freeAmmount) / CPUThreads);
                test_count = CPUThreads;
                while (test_ammount > mem_max)
                {
                    ++test_count;
                    test_ammount = (ushort)((freeMemMB - test_freeAmmount) / test_count);
                }
            }

            // 수동 설정 시 값 그대로 복사
            else
            {
                uint.TryParse(test_manual_count.Text, out test_count);
                uint.TryParse(test_manual_ammount.Text, out test_ammount);
            }





            HCI = new HCI_Memtest[test_count];
            Thread.Sleep(100);
            
            // 편차 방지를 위해 HCI MEmtest 동시에 전부 실행
            for (int index=0; index<test_count; ++index)          
                HCI[index].process = Process.Start(appPath + @"\Resources\memtest.exe");

            Thread.Sleep(50);
            welcome_form = IntPtr.Zero; 
            welcome_button = IntPtr.Zero;

            // 시작 창을 모두 제거할 때까지 루프
            ushort removed_count = 0;
            while (removed_count < test_count || welcome_button != IntPtr.Zero)
            {
                welcome_form = FindWindow("#32770", "어서오세요!");
                welcome_button = FindWindowEx(welcome_form, IntPtr.Zero, "Button", "확인");

                if (welcome_button != IntPtr.Zero)
                {
                    SendMessage(welcome_button, CLICK, 0, 0);
                    ++removed_count;
                }
                
                Thread.Sleep(5);
            }






            // HCI Memtest가 모두 실행되었으므로 본격적으로 테스트 시작
            ushort formLoc_x = 1, formLoc_y = 1;
            for (int index = 0; index < test_count; ++index)
            {
                HCI[index].form = HCI[index].process.MainWindowHandle;
                HCI[index].coverage = FindWindowEx(HCI[index].form, IntPtr.Zero, "Static", "무료 버전");
                HCI[index].start = FindWindowEx(HCI[index].form, IntPtr.Zero, "Button", "테스트 시작");
                HCI[index].exit = FindWindowEx(HCI[index].form, IntPtr.Zero, "Button", "테스트 종료");
                HCI[index].ram = FindWindowEx(HCI[index].form, IntPtr.Zero, "Edit", null);
                HCI[index].coverage_value = 0;

                // 창 숨기기
                if (test_hide.Checked) 
                    ShowWindow(HCI[index].form, Sw_Hide); 

                // 창 배치하기
                // HCI Memtest 창 크기 = 255*236
                MoveWindow(HCI[index].form, formLoc_x, formLoc_y, 255, 236, true);
                formLoc_x += (ushort)(255 * (float.Parse(layout_x.Text) / 100));

                if (formLoc_x + 230 > screen_width)
                {
                    formLoc_x = 1;
                    formLoc_y += (ushort)(236 * (float.Parse(layout_y.Text) / 100));
                }

                if (formLoc_y + 235 > screen_height)
                {
                    formLoc_x = 1; 
                    formLoc_y = 1; 
                }

                SetHwndText(HCI[index].ram, test_ammount.ToString());
                PostMessage(HCI[index].start, CLICK, IntPtr.Zero, IntPtr.Zero);
            }



            // HCI 멤테스트 창의 개수만큼 알림창 제거
            removed_count = 0;
            while (removed_count < test_count || welcome_button != IntPtr.Zero)
            {
                welcome_form = FindWindow("#32770", "테스트 시작합니다.");
                welcome_button = FindWindowEx(welcome_form, IntPtr.Zero, "Button", "확인");

                if (welcome_button != IntPtr.Zero)
                {
                    SendMessage(welcome_button, CLICK, 0, 0);
                    ++removed_count;
                }

                Thread.Sleep(5);
            }

            // 프로그램을 최상단으로 가져오기
            this.Invoke((MethodInvoker)delegate ()
            {
                SetForegroundWindow((int)this.Handle);
            });


            // UI에 각 테스트 창에 대한 정보 나열
            int label_left = 15;
            int label_top = 300;
            int add_width = 125;
            int add_height = 25;

            this.Invoke((MethodInvoker)delegate () { this.SuspendLayout(); });
            for (int index=0; index<HCI.Length; ++index)
            {
                HCI[index].title_label = new Label()
                {
                    Name = "HCITitle_" + index,
                    Text = (index+1) + "번 프로세스",
                    Location = new Point(label_left, label_top),
                    ForeColor = Color.FromArgb(255, 81, 36),
                    Font = new Font("맑은 고딕", 10, FontStyle.Bold),
                    BackColor = Color.Transparent
                };
            
                HCI[index].coverage_label = new Label()
                {
                    Name = "HCICoverage_" + index,
                    Text = "통과율: 0%",
                    Location = new Point(label_left + 5, label_top + add_height),
                    BackColor = Color.Transparent,
                };

                HCI[index].error_label = new Label()
                {
                    Name = "HCIError_" + index,
                    Text = "오류: 0개",
                    Location = new Point(label_left + 5, label_top + (int)(add_height*1.95)),
                    BackColor = Color.Transparent,
                };

                if (label_left > 500)
                {
                    label_left = 15;
                    label_top += (int)(add_height * 3.5);
                }

                else
                {
                    label_left += add_width;
                }


                this.Invoke((MethodInvoker)delegate ()
                {
                    Tab1.Controls.Add(HCI[index].title_label);
                    Tab1.Controls.Add(HCI[index].coverage_label);
                    Tab1.Controls.Add(HCI[index].error_label);
                });
            }
            this.Invoke((MethodInvoker)delegate () { this.ResumeLayout(); });

            // 테스트가 완전히 시작되기 전까지 잠시 대기, 대기가 끝나면 혹시라도 남아있을 알림창 제거
            Thread.Sleep(2000);

            welcome_form = FindWindow("#32770", "테스트 시작합니다.");
            welcome_button = FindWindowEx(welcome_form, IntPtr.Zero, "Button", "확인");

            SendMessage(welcome_button, CLICK, 0, 0);













            // 모니터링 준비
            error_occured = false;
            error_count = 0; coverage_min = 0; coverage_max = 0;
            capHour = (byte)DateTime.Now.Hour; capMinute = (byte)DateTime.Now.Minute;
          
            // 테스트 경과시간 타이머 시작
            std_timer.Reset();
            std_timer.Start();

            // 모니터링 진행
            while (true)
            {
                error_occured = false;
                coverage_avg = 0;

                for (int index = 0; index < test_count; ++index)
                {
                    coverage_txt.Clear(); 
                    errorCount_txt.Clear();

                    // 하단 통과율/에러 바의 문자열을 읽어서 저장 후 테스트가 정상시작 되었는지 확인
                    GetWindowText(HCI[index].coverage, coverage_txt, 40);
                    if (coverage_txt.ToString() == "메모리 할당됨" || coverage_txt.ToString() == null) 
                        ++index;

                    // 테스트가 정상시작 되어있는 상태라면
                    else
                    {
                        // 하단 바의 문자열에서 통과율과 에러 수치만 뽑아오기
                        // errorCount_txt는 임시변수이며, 최종적으로 coverage_txt에 저장됨
                        coverage_txt.Remove(0, 7);
                        errorCount_txt.Append(coverage_txt.ToString());

                        errorCount_txt.Remove(errorCount_txt.ToString().IndexOf("개") + 1, 6);
                        errorCount_txt.Remove(0, errorCount_txt.ToString().IndexOf(",") + 2);

                        coverage_txt.Remove(coverage_txt.ToString().IndexOf("%"), 14);

                        // 리스트뷰의 현재 순번에 통과율 추가
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            HCI[index].coverage_label.Text = "통과율: " + coverage_txt.ToString() + "%";
                            HCI[index].error_label.Text = "오류: " + errorCount_txt.ToString();
                        });

                        // 오류가 발생한 경우 현재 순번에 기록
                        if (errorCount_txt.ToString() != "0개")
                        {
                            error_occured = true;
                            error_count = (uint)index + 1;
                        }

                        // 최소치, 평균치, 최대값, 편차 등을 알아내기 위해 값 저장
                        double.TryParse(coverage_txt.ToString(), out HCI[index].coverage_value);
                        coverage_avg += HCI[index].coverage_value;

                        if (index == 0) 
                            coverage_min = HCI[index].coverage_value; 

                        if (coverage_min > HCI[index].coverage_value)                       
                            coverage_min = HCI[index].coverage_value; 

                        else if (coverage_max < HCI[index].coverage_value)                         
                            coverage_max = HCI[index].coverage_value; 
                    }
                }

                // 모든 HCI Memtest 프로세스의 모니터링이 끝나면 리스트뷰 재개 + 통과율, 편차 표시
                coverage_avg = Math.Round(coverage_avg / test_count, 2);
                this.Invoke((MethodInvoker)delegate ()
                {
                    passRate_min.Text = "최소치: " + coverage_min + "%";
                    passRate_avg.Text = "평균치: " + coverage_avg + "%";
                    deviation_label.Text = Math.Round(coverage_max - coverage_min, 1) + "%";

                    // 테스트 정상시작했으므로 이제 유저가 중단가능 //
                    test.Enabled = true;
                });




                // 테스트 상태 판단 후 뒤처리
                bool test_passed = false;

                if (test_std_min.Checked)
                {
                    if (coverage_min > ushort.Parse(test_target.Text))
                        test_passed = true;
                }

                else if (test_std_avg.Checked)
                {
                    if (coverage_avg > ushort.Parse(test_target.Text))
                        test_passed = true;
                }

      
                if (test_passed)
                {
                    WriteTestLog();

                    StopMemtest();

                    if (finish_closeTest.Checked)
                        KillMemtest();

                    PlayMusic(false);

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        SetButtonState(test, false, "테스트");
                    });

                    std_timer.Stop();

                    Thread _msgThread = new Thread(() => 
                    {
                        MessageBox.Show("테스트 " + coverage_min + "%까지 통과하였습니다.", "통과", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    });
                    _msgThread.IsBackground = true;
                    _msgThread.Start();

                    Thread.Sleep(200);

                    if (screenshot_after.Checked)
                        screenshot.Screenshot(screenshot_path.Text, GetScreenshotRGBQuality());

                    if (finish_closePC.Checked)
                        ShutdownPC(0);

                    else if (finish_restartPC.Checked)
                        ShutdownPC(1);

                    return;
                }


                else if (error_occured)
                {
                    WriteTestLog();

                    StopMemtest();

                    if (finish_closeTest.Checked)
                        KillMemtest();

                    PlayMusic(false);

                    this.Invoke((MethodInvoker)delegate ()
                    {
                        SetButtonState(test, false, "테스트");
                    });

                    std_timer.Stop();

                    Thread _msgThread = new Thread(() =>
                    {
                        MessageBox.Show("테스트 " + coverage_min + "%에서 오류가 발생했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    });
                    _msgThread.IsBackground = true;
                    _msgThread.Start();

                    Thread.Sleep(200);

                    if (screenshot_after.Checked)
                        screenshot.Screenshot(screenshot_path.Text, GetScreenshotRGBQuality());

                    if (finish_closePC.Checked)
                        ShutdownPC(0);

                    else if (finish_restartPC.Checked)
                        ShutdownPC(1);

                    return;
                }




                else if (user_stopped)
                {
                    return;
                }



                if (screenshot_cycle.Checked)
                {
                    ushort nowTime = (ushort)((DateTime.Now.Hour * 60) + DateTime.Now.Minute);
                    ushort lastTime = (ushort)((capHour * 60) + capMinute);

                    //시간정보 초기화 후 스크린샷
                    if (lastTime + Convert.ToUInt16(screenshot_cycle_time.Text) <= nowTime ) 
                    {
                        capHour = (byte)DateTime.Now.Hour;
                        capMinute = (byte)DateTime.Now.Minute;
                        screenshot.Screenshot(screenshot_path.Text, GetScreenshotRGBQuality());
                    }
                }

                showTimeData();         

                Thread.Sleep(int.Parse(interval_test.Text));
            }

        }
        #endregion

        #region Functions - Extra
        private void ShutdownPC(byte type)
        {
            // type:0  Shutdown
            // type:1  Restart

            ProcessStartInfo processInfo = null;

            if (type == 0)
                processInfo = new ProcessStartInfo("shutdown.exe", "/s /t 2");
            else if (type == 1)
                processInfo = new ProcessStartInfo("shutdown.exe", "/r /t 2");

            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.Verb = "runas";
            Process.Start(processInfo);
        }

        private void prevent_double_executing()
        {
            Process this_process = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(this_process.ProcessName);

            if (processes.Length > 1)
            {
                for (int index = 0; index < processes.Count(); ++index)
                {
                    if (processes[index].MainWindowHandle != this_process.Handle)
                    {
                        SetForegroundWindow((int)processes[index].MainWindowHandle);
                    }
                }

                Environment.Exit(0);
            }
        }


        // CPU의 쓰레드 개수(논리적 프로세서 개수)를 가져오는 함수
        private uint getCPUThreadCount()
        {
            uint thread_count = 0;

            for (int index = 0; index < 8192; ++index)
            {
                if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\" + index, "FeatureSet", null) != null)
                    ++thread_count;

                else
                    break;
            }

            return thread_count;
        }

        // 타 프로그램의 핸들에 텍스트 입력하는 함수
        private void SetHwndText(IntPtr target_hwnd, string text)
        {
            IntPtr text_ptr = Marshal.StringToHGlobalAnsi(text);

            SendMessage(target_hwnd, WM_SetText, IntPtr.Zero, text_ptr);

            Marshal.FreeHGlobal(text_ptr);
        }
        #endregion







        #region 프로그램 설정 저장/불러오기 기능
        private void SaveSettings()
        {
            StringBuilder app_settings = new StringBuilder(null);
            StringBuilder control_data = new StringBuilder(null);
            string[] exception_controls = { "test_manual_ammount", "test_manual_count"};

            for (int index=0; index<panel_settings.Controls.Count; ++index)
            {
                Control current_control = panel_settings.Controls[index];

                // Except few controls
                bool exceptThis = false;
                for (int e_index=0; e_index<exception_controls.Length; ++e_index)
                {
                    if (current_control.Name == exception_controls[e_index])
                    {
                        exceptThis = true;
                        break;
                    }
                }
                if (exceptThis)
                    continue;

                

                control_data.Clear();

                control_data.Append(current_control.Name + "\\" + current_control.Text);

                if (current_control is MaterialCheckBox)
                    control_data.Append("\\" + ((MaterialCheckBox)current_control).Checked.ToString());
                else if (current_control is Slider)
                    control_data.Append("\\" + ((Slider)current_control).Value.ToString());
                else if (current_control is PictureBox)
                    control_data.Append("\\" + new ColorConverter().ConvertToString(current_control.BackColor));
                else
                    control_data.Append("\\" + "null");

                app_settings.AppendLine(control_data.ToString());
            }

            app_settings.Append('\n' + new SizeConverter().ConvertToString(this.Size));

            File.WriteAllText(appPath + @"\Resources\Settings.ini", app_settings.ToString(), new UTF8Encoding(false));
        }


        private void LoadSettings()
        {
            if (!File.Exists(appPath + @"\Resources\Settings.ini"))
                return;

            string[] file_data = File.ReadAllLines(appPath + @"\Resources\Settings.ini", new UTF8Encoding(false));

            for (int index=0; index<file_data.Length - 1; ++index)
            {
                if (file_data[index].IndexOf('\\') < 0 || file_data[index].Length < 4)
                    continue;

                // control_data:   [0]=Name,  [1]=Text,  [2]=Checked
                string[] control_data = file_data[index].Split('\\');
                Control current_control;

                try { current_control = panel_settings.Controls.Find(control_data[0], false)[0]; }
                catch (IndexOutOfRangeException) { continue; }

                // 데이터 불러오기
                if (current_control is MaterialSingleLineTextField)
                {
                    if (uint.TryParse(control_data[1], out uint text_num))
                        current_control.Text = control_data[1];
                }

                else
                    current_control.Text = control_data[1];
                
                if (current_control is MaterialCheckBox)
                {
                    if (bool.TryParse(control_data[2], out bool text_bool))
                        ((MaterialCheckBox)current_control).Checked = text_bool;
                }

                else if (current_control is Slider)
                {
                    if (float.TryParse(control_data[2], out float text_double))
                        ((Slider)current_control).Value = text_double;
                }

                else if (current_control is PictureBox)
                {
                    try { current_control.BackColor = (Color)new ColorConverter().ConvertFromString(control_data[2]); }
                    catch (Exception) { MessageBox.Show("설정에 저장된 RGB Color 데이터가 올바르지 않습니다.", "오류", 0, MessageBoxIcon.Error); }
                }
            }

            // 마지막 일부 수동 작업
            string size_str = file_data[file_data.Length - 1];
            this.Size = (Size)new SizeConverter().ConvertFromString(size_str);
            MainForm_Resize(this, new EventArgs());

            ram_usage.BarBackColor = ramUsageBar_backColor.BackColor;
            ram_usage.BarForeColor = ramUsageBar_foreColor.BackColor;


            // 올바른 설정을 위한 이벤트들 1회씩 실행
            test_manual_Click(test_manual, new EventArgs());
            finish_closePC_Click(finish_closePC, new EventArgs());
            finish_restartPC_Click(finish_closeTest, new EventArgs());
            screenshot_cycle_Click(screenshot_cycle, new EventArgs());
            
        }
        #endregion






        private void KillMemtest()
        {
            Process[] processes = Process.GetProcessesByName("memtest");

            for (int index = 0; index < processes.Length; index++)
            {
                try { processes[index].Kill(); processes[index].Dispose(); }
                catch (Exception) { }
            }
        }

        private void StopMemtest()
        {
            for (int index=0; index<HCI.Length; ++index)
            {
                PostMessage(HCI[index].exit, CLICK, (IntPtr)0, (IntPtr)0);
            }
        }


        // 테스트 결과를 기록하는 함수
        private void WriteTestLog()
        {
            IntPtr ErrMsgHwnd = IntPtr.Zero, ErrChildHwnd;
            ErrMsg.Clear(); finalRecord.Clear();


            if (error_occured)
            {
                // 오류 메세지 찾을 때까지
                while (ErrMsgHwnd == IntPtr.Zero)
                {
                    ErrMsgHwnd = FindWindow("#32770", "멤테스트 오류");
                    Thread.Sleep(10);
                }
                Thread.Sleep(20);

                ErrChildHwnd = FindWindowEx(ErrMsgHwnd, IntPtr.Zero, "Static", null);

                GetWindowText(ErrChildHwnd, ErrMsg, 250);

                finalRecord.Append("!!! 오류 발생 !!!");
            }

            else if (user_stopped) 
                finalRecord.Append("◆ 중도 포기 ◆"); 
            else
                finalRecord.Append("★ 통과 ★"); 

            // 통과율, 편차, 경과시간 기록
            finalRecord.Append("\r\n종료 시각: " + DateTime.Now.ToString("yyyy년 MM월 dd일 --- H시 mm분 ss초") + "\r\n" + elapsed_time.Text + "\r\n테스트한 메모리: " + test_ammount + "MB * " + test_count + "  =  " + (test_ammount * test_count) + "MB   |총 메모리의 " + ram_usage_label.Text + "|\r\n\r\n최소 통과율: " + coverage_min + "%\r\n평균 통과율: " + coverage_avg + "%\r\n편차: " + deviation_label.Text);

            // 오류정보 추가기록
            if (error_occured) 
                finalRecord.Append("\r\n\r\n[오류 정보]\r\n" + error_count + "번째 멤테스트에서 오류 발생\r\n" + ErrMsgHwnd.ToString()); 
            
            finalRecord.Append("\r\n---------------------------------\r\n\r\n\r\n");

            // 로그 파일로 저장
            if (File.Exists(appPath + "\\EasyHCI_Log.txt"))
            {
                string origLog = File.ReadAllText(appPath + "\\EasyHCI_Log.txt", new UTF8Encoding(false));
                File.WriteAllText(appPath + "\\EasyHCI_Log.txt", origLog + finalRecord.ToString(), new UTF8Encoding(false));
            }

            else 
                File.WriteAllText(appPath + "\\EasyHCI_Log.txt", finalRecord.ToString(), new UTF8Encoding(false)); 

        }





        #region Function - Ram Information
        private getRamInfo ram_info = new getRamInfo();

        private void ShowRamUsage()
        {
            uint[] ramInfo = ram_info.GetRamInfo();
            totalMemMB = ramInfo[0];
            freeMemMB = ramInfo[1];

            // UI에 표시
            this.Invoke((MethodInvoker)delegate ()
            {
                ram_usage_label.Text = Math.Round(((double)totalMemMB - freeMemMB) / totalMemMB, 3) * 100 + "%";
                ram_usage.Value = Convert.ToInt32(totalMemMB - freeMemMB);
            });
        }

        private Color GetUserColorInput()
        {
            using (ColorDialog color_dialog = new ColorDialog())
            {
                color_dialog.AllowFullOpen = true;
                color_dialog.ShowHelp = true;

                if (color_dialog.ShowDialog() == DialogResult.OK)
                    return color_dialog.Color;
            }

            return Color.Black;
        }

        private void ramUsageBar_foreColor_Click(object sender, EventArgs e)
        {
            Color user_input = GetUserColorInput();

            ram_usage.BarForeColor = user_input;
            ramUsageBar_foreColor.BackColor = user_input;
        }

        private void ramUsageBar_backColor_Click(object sender, EventArgs e)
        {
            Color user_input = GetUserColorInput();

            ram_usage.BarBackColor = user_input;
            ramUsageBar_backColor.BackColor = user_input;
        }
        #endregion



        private void start_test()
        {
            bool start_success = true;

            // memtest.exe 존재유무 확인
            if (!File.Exists(appPath + "\\Resources\\memtest.exe"))
            {
                start_success = false;
                MessageBox.Show(appPath + "\\Resources\\memtest.exe\r\n\r\n memtest 실행파일이 발견되지 않았습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 메모리 정리
            if (MessageBox.Show("테스트 할 메모리 공간을 확보하기 위해 불필요한 모든 프로세스를 모두 종료하시겠습니까?\r\n\r\n※ 중요한 작업을 하고 있다면 미리 백업해주시거나, 예외처리 해주십시오.", "메모리 정리", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var cleanMem = new cleanMemory())
                    cleanMem.clean_memory();
            }

            // 메모리 현황 업데이트
            ShowRamUsage();

            // 수동 테스트일 경우 테스트 메모리 설정량이 시스템의 메모리 여유량을 초과하는지 확인
            if (test_manual.Checked)
            {
                ushort.TryParse(test_manual_count.Text, out ushort test_count);
                ushort.TryParse(test_manual_ammount.Text, out ushort test_ammount);

                // 최소한 50MB의 메모리가 남지 않는다면
                if (test_count * test_ammount > (freeMemMB - 50))
                {
                    start_success = false;
                    MessageBox.Show("테스트할 메모리 양을 여유 메모리보다 크게 입력하셨습니다.\r\n\r\n" + ((Convert.ToInt16(test_manual_count.Text) * Convert.ToInt16(test_manual_ammount.Text)) - (freeMemMB - 50)).ToString() + "MB만큼 줄여서 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            // 테스트 시작
            if (start_success)
            {
                user_stopped = false;

                test.Enabled = false;

                _testThread = new Thread(StartTest);
                _testThread.Start();
            }

            // 테스트 실패
            else
            {
                test.Enabled = true;
                SetButtonState(test, false, "테스트");
            }

        }


        private void stop_test()
        {
            // 테스트 도중이라면 기록을 위해 종료신호 보내고 기다리기
            if (_testThread != null && _testThread.IsAlive)
            {
                user_stopped = true;

                WriteTestLog();

                StopMemtest();

                if (finish_closeTest.Checked)
                    KillMemtest();

                std_timer.Stop();

                _testThread.Abort();
            }


            soundPlayer.TerminateMusic();

            test.Enabled = true;
            SetButtonState(test, false, "테스트");
        }

        private Color testButton_green = Color.FromArgb(0, 145, 0);
        private Color testButton_red = Color.FromArgb(230, 0, 0);
        private void SetButtonState(Button button, bool current_test_state, string baseString)
        {
            if (current_test_state)
            {
                button.BackColor = testButton_red;

                button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(button.BackColor.R - 40, button.BackColor.G, button.BackColor.B);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(button.BackColor.R - 80, button.BackColor.G, button.BackColor.B);

                if (button.Image != null)
                    button.Image = null;

                button.Image = Image.FromFile(appPath + @"\Resources\test_stop.png");

                button.Text = baseString + " 중단";
            }

            else
            {
                button.BackColor = testButton_green;

                button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(button.BackColor.R, button.BackColor.G - 40, button.BackColor.B);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(button.BackColor.R, button.BackColor.G - 80, button.BackColor.B);

                if (button.Image != null)
                    button.Image = null;
               
                button.Image = Image.FromFile(appPath + @"\Resources\test_play.png");

                button.Text = baseString + " 시작";
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            // 테스트 설정의 수치들에 문자가 입력되었는지 확인
            for (int index=0; index<panel_settings.Controls.Count; ++index)
            {
                Control current_control = panel_settings.Controls[index];

                if (current_control is MaterialSingleLineTextField && !current_control.Name.EndsWith("path"))
                {
                    if (!double.TryParse(current_control.Text, out double textBox_number))
                    {
                        MessageBox.Show(current_control.Name + ": " + current_control.Text + "\r\n\r\n숫자가 아닌 다른 문자가 입력되어 테스트를 시작할 수 없습니다.", "오류", 0, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            
            test.Enabled = false;

            // 테스트를 하고있지 않다면
            if (test.BackColor.G > 140)
            {
                SetButtonState(test, true, "테스트");

                // HCI Memtest가 이미 실행중인지 확인
                Process[] memtests = Process.GetProcessesByName("memtest");
                if (memtests.Length > 0)
                {
                    if (MessageBox.Show("시스템에 이미 HCI Memtest가 실행중입니다.\r\n\r\n기존 HCI Memtest들을 모두 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        KillMemtest();

                        for (int index = 0; index < memtests.Length; ++index)
                            memtests[index].Dispose();
                    }
                }


                // UI에 남아있는 이전 테스트 정보 제거
                for (int index=0; index<HCI.Length; ++index)
                {
                    if (HCI[index].title_label != null)
                        HCI[index].title_label.Dispose();
                    if (HCI[index].coverage_label != null)
                        HCI[index].coverage_label.Dispose();
                    if (HCI[index].error_label != null)
                        HCI[index].error_label.Dispose();


                }

                start_test();
            }

            // 테스트 도중이라면
            else if (test.BackColor.R > 140)
            {
                SetButtonState(test, false, "테스트");

                stop_test();
            }
        }





        #region Functions - Background Thread
        private Thread _testThread = null, _ramThread = null;

        // 스레드를 강제종료시키는 함수
        private void TerminateThread(ref Thread thread)
        {
            if (thread == null)
                return;

            if (thread.IsAlive)
                thread.Abort();
        }
        #endregion



        #region Event Handlers - Test Settings
        private void test_target_bar_ValueChanged(object sender, EventArgs e)
        {
            SetSliderSmallestUnit((Slider)sender, test_target, 20);
        }

        private void test_except_bar_ValueChanged(object sender, EventArgs e)
        {
            SetSliderSmallestUnit((Slider)sender, test_except, 10);
        }

        private void test_hide_Click(object sender, EventArgs e)
        {
            if (test_hide.Checked)
            {
                for (int index = 0; index < HCI.Length; ++index)
                    ShowWindow(HCI[index].form, Sw_Hide);
            }
            
            else
            {
                for (int index = 0; index < HCI.Length; ++index)
                    ShowWindow(HCI[index].form, Sw_Show);
            }
        }

        private void test_manual_Click(object sender, EventArgs e)
        {
            bool enabled_value = test_manual.Checked;

            for (int index = 0; index < panel_settings.Controls.Count; ++index)
            {
                Control current_control = panel_settings.Controls[index];

                if (current_control.Name.StartsWith("test_manual_"))
                    current_control.Enabled = enabled_value;

                if (current_control.Name.StartsWith("test_except"))
                    current_control.Enabled = !enabled_value;
            }
        }

        private void test_std_min_Click(object sender, EventArgs e)
        {
            test_std_min.Checked = true;
            test_std_avg.Checked = false;
        }

        private void test_std_avg_Click(object sender, EventArgs e)
        {
            test_std_min.Checked = false;
            test_std_avg.Checked = true;
        }
        #endregion



















        #region Functions - Screenshot
        private screenShot screenshot = new screenShot();
        
        private byte GetScreenshotRGBQuality()
        {
            byte quality = 1;

            if (screenshot_quality_low.Checked)
                quality = 0;
            else if (screenshot_quality_middle.Checked)
                quality = 1;
            else if (screenshot_quality_high.Checked)
                quality = 2;

            return quality;
        }

        private void ChooseScreenshotRGBQuality(object clicked_object)
        {
            for (int index = 0; index < panel_settings.Controls.Count; ++index)
            {
                Control current_control = panel_settings.Controls[index];

                if (current_control.Name.StartsWith("screenshot_quality_") && current_control is MaterialCheckBox)
                    ((MaterialCheckBox)current_control).Checked = false;
            }

            ((MaterialCheckBox)clicked_object).Checked = true;
        }


        private void screenshot_quality_high_Click(object sender, EventArgs e)
        {
            ChooseScreenshotRGBQuality(sender);
        }

        private void screenshot_quality_middle_Click(object sender, EventArgs e)
        {
            ChooseScreenshotRGBQuality(sender);
        }

        private void screenshot_quality_low_Click(object sender, EventArgs e)
        {
            ChooseScreenshotRGBQuality(sender);
        }

        private void screenshot_cycle_Click(object sender, EventArgs e)
        {
            for (int index=0; index<panel_settings.Controls.Count; ++index)
            {
                Control current_control = panel_settings.Controls[index];

                if (current_control.Name.StartsWith("screenshot_cycle_"))
                    current_control.Enabled = screenshot_cycle.Checked;
            }
          
        }


        #endregion

        #region Event Handlers - After Finish
        private void finish_closePC_Click(object sender, EventArgs e)
        {
            if (finish_closePC.Checked)
                finish_restartPC.Checked = false;
        }

        private void finish_restartPC_Click(object sender, EventArgs e)
        {
            if (finish_restartPC.Checked)          
                finish_closePC.Checked = false;
            
        }

        #endregion



        //폴더,파일 선택창 열기
        private void screenshot_setPath_Click(object sender, EventArgs e)
        {
            dialog_open_directory.Description = "스크린샷을 저장할 폴더를 선택해주세요.";
            dialog_open_directory.ShowDialog();


            if (!Directory.Exists(dialog_open_directory.SelectedPath))          
                MessageBox.Show("폴더를 선택하지 않으셨습니다.\r\n\r\n스크린샷 기능을 사용할 경우 오류가 발생하거나 기능이 정상작동하지 않을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 
            else          
                screenshot_path.Text = dialog_open_directory.SelectedPath;
            
        }



        private void openProcessList_Click(object sender, EventArgs e)
        {
            ProcessListForm procForm = new ProcessListForm();
            procForm.ShowDialog();

            procForm.Dispose();
        }







        #region Event Handlers - Sliders
        private void SetSliderSmallestUnit(Slider slider, Control textBox, ushort smallest_unit)
        {
            uint value = (uint)slider.Value;

            value -= value % smallest_unit;
            textBox.Text = value.ToString();
        }



        private void screenshot_cycle_time_bar_ValueChanged(object sender, EventArgs e)
        {
            SetSliderSmallestUnit((Slider)sender, screenshot_cycle_time, 2);
        }




        #endregion

        #region Event Handlers - Layout
        private void layout_x_bar_ValueChanged(object sender, EventArgs e)
        {
            layout_x.Text = ((byte)layout_x_bar.Value).ToString();
        }

        private void layout_y_bar_ValueChanged(object sender, EventArgs e)
        {
            layout_y.Text = ((byte)layout_y_bar.Value).ToString();
        }

        #endregion

        #region Event Handlers - Monitoring Interval
        private void interval_memory_bar_ValueChanged(object sender, EventArgs e)
        {
            interval_memory.Text = ((uint)interval_memory_bar.Value).ToString();
        }

        private void interval_test_bar_ValueChanged(object sender, EventArgs e)
        {
            interval_test.Text = ((uint)interval_test_bar.Value).ToString();
        }
        #endregion




        #region Event Handlers - Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            prevent_double_executing();

            this.Size = new Size(700, 750);

            if (!Directory.Exists(appPath + @"\Resources"))
                Directory.CreateDirectory(appPath + @"\Resources");
            if (!Directory.Exists(appPath + @"\Screenshots"))
                Directory.CreateDirectory(appPath + @"\Screenshots");

            File.Open(Application.ExecutablePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            CPUThreads = getCPUThreadCount();

            screen_width = (ushort)Screen.PrimaryScreen.Bounds.Width;
            screen_height = (ushort)Screen.PrimaryScreen.Bounds.Height;


            // This thread will update the RAM Usage, and display it to the progress bar
            ShowRamUsage();
            ram_usage.Max = (int)totalMemMB;
            _ramThread = new Thread(() =>
            {
                while (true)
                {
                    ShowRamUsage();

                    Thread.Sleep(int.Parse(interval_memory.Text));
                }
            });
            _ramThread.IsBackground = true;
            _ramThread.Start();


            // Calculate the manual test settings for your PC
            uint test_count = CPUThreads, test_ammount = (ushort)((freeMemMB - 300) / CPUThreads);

            while (test_ammount > 2048)
            {
                ++test_count;
                test_ammount = (ushort)((freeMemMB - 300) / test_count);
            }

            test_manual_ammount.Text = test_ammount.ToString();
            test_manual_count.Text = test_count.ToString();

            dialog_open_directory.SelectedPath = appPath + @"\Screenshots";
            dialog_open_file.InitialDirectory = appPath + @"\Resources";

            screenshot_path.Text = appPath + @"\Screenshots";
            notify_error_path.Text = appPath + @"\Resources\error.wav";
            notify_success_path.Text = appPath + @"\Resources\success.wav";

            label_for_size.Text = null;


            // Add Event Handlers to TextField, cancel key inputs except numbers
            for (int index = 0; index < panel_settings.Controls.Count; ++index)
            {
                Control current_control = panel_settings.Controls[index];

                if (current_control is MaterialSingleLineTextField)
                {
                    MaterialSingleLineTextField text_control = (MaterialSingleLineTextField)current_control;

                    text_control.KeyPress += (object obj, KeyPressEventArgs evt) =>
                    {
                        if (!char.IsDigit(evt.KeyChar) && evt.KeyChar != (char)Keys.Back)
                            evt.Handled = true;
                    };
                }
            }


            LoadSettings(); 

            if (instant.Checked)
                test_Click(test, new EventArgs());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            // 테스트 도중이라면 기록을 위해 종료신호 보내고 기다리기
            if (_testThread != null && _testThread.IsAlive)
            {
                user_stopped = true;

                WriteTestLog();

                StopMemtest();

                KillMemtest();

                SetButtonState(test, false, "테스트");

                std_timer.Stop();

                _testThread.Abort();
            }



            SaveSettings();

            Environment.Exit(0);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            TabMain.Size = new Size(this.Size.Width - 4, this.Size.Height - 99);
            ram_usage.Size = new Size(this.Size.Width - 165, ram_usage.Height);
            test.Size = new Size(this.Size.Width - 38, test.Height);

            ram_usage_label.Location = new Point(this.Size.Width - 48, 70);
        }
        #endregion


        // 투명도 조절
        private void transparency_bar_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = transparency_bar.Value / 100;
        }


        // 업데이트 확인
        private void check_version_Click(object sender, EventArgs e)
        {
            string data = null;
            string app_version = this.Text.Remove(0, 8);

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                data = client.DownloadString("https://github.com/bumju08/EasyHCI/releases/latest");
            }

            string[] data_lines = data.Split('\n');
            for (uint index = 0; index < data_lines.Length; ++index)
            {
                if (data_lines[index].Contains("<title>Release"))
                {
                    data = data_lines[index];
                    break;
                }
            }


            data = data.Remove(0, data.IndexOf('<') + 1);
            data = data.Remove(0, data.IndexOf(' ') + 1);
            data = data.Remove(data.IndexOf('·') - 1, data.Length - data.IndexOf('·') + 1);
            data = data.Remove(0, 8);

            DialogResult user_input = MessageBox.Show("현재 버전: " + app_version + "\r\n최신 버전: " + data + "\r\n\r\n최신버전 파일이 올려진 사이트로 이동할까요?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (user_input == DialogResult.Yes)
                Process.Start("https://github.com/bumju08/EasyHCI/releases");
        }



    }
}
