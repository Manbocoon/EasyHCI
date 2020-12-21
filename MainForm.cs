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
using Microsoft.Win32;

using System.Management;
using MaterialSkin;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;





namespace EasyHCI
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {

        //Win32 API
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
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("gdi32.dll")]
        private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);


        //API에 사용될 상수
        private const int CLICK = 0x00F5;
        private const int WM_GetText = 0x000D;
        private const int WM_SetText = 0X000C;
        private const int Sw_Hide = 0;
        private const int Sw_Show = 5;




        //공용 변수들
        private byte Gc1 = 0, hour, minute, second;
        private ushort CPUThreads = 0, ScreenX = 0, ScreenY = 0, hcinum = 0, hcimem = 0, errNum = 0;
        private uint totalMemMB = 0, freeMemMB = 0;
        private string capPath, sucPath, errPath, musicURL;
        private bool endProgram = false, endMonitoring = false, activateTimer = false, errorIncreased = false;
        private IntPtr[] hci, hcicoverage, startbtn, exitbtn;
        public Process[] hciProcess;

        private Thread StartTestThread, MemStatusThread, musicThread;

        StringBuilder NewText1 = new StringBuilder(null, 40), NewText2 = new StringBuilder(null, 40), ErrMsg = new StringBuilder(null), finalRecord = new StringBuilder(null), tSetting = new StringBuilder(null);
        double minValue = 0, maxValue = 0;
        byte capHour = (byte)DateTime.Now.Hour, capMinute = (byte)DateTime.Now.Minute;

















        //                   //
        //                   //
        //   프로젝트 시작   //
        //                   //
        //                   //
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        } //스킨!



        protected override CreateParams CreateParams
        { //그림자 생성!
            get
            {
                CreateParams crp = base.CreateParams;
                crp.ClassStyle = 0x00020000;
                return crp;
            }
        }








        //                  //
        // 테스트 시작 함수 //
        //                  //
        private void StartTest()
        { 
            ushort WindowX = 1, WindowY = 1, tmem = 0;
            bool findMem = false;
            IntPtr Hwnd1 = IntPtr.Zero, Hwnd2 = IntPtr.Zero;
            StringBuilder canAllocate = new StringBuilder(null, 20);
            IntPtr[] hci = new IntPtr[1], hcicoverage = new IntPtr[1], startbtn = new IntPtr[1], exitbtn = new IntPtr[1];
            Process[] hciProcess = new Process[1];
            Process tempProcess = Process.GetCurrentProcess();



            //           //
            // 자동 설정 //
            //           //
            if (notAuto.Checked == false)
            {
                // 시작하기 전에 메모리 값에 따라 임시최대값 줄여서 작업량 줄이기
                if ((freeMemMB / CPUThreads) <= 2000)
                { tmem = 2030; }
                else if ((freeMemMB / CPUThreads) > 2000 && (freeMemMB / CPUThreads) < 2501)
                { tmem = 2530; }
                else if ((freeMemMB / CPUThreads) > 2500 && (freeMemMB / CPUThreads) < 3001)
                { tmem = 3030; }
                else
                { tmem = 3530; }

                while (findMem == false) //최대 메모리값을 찾기 전까지 무한루프
                {
                    Hwnd1 = IntPtr.Zero; Hwnd2 = IntPtr.Zero; hci[0] = IntPtr.Zero;
                    tmem -= 25; //최대메모리가 몇인지 25MB씩 감소시켜가며 테스트

                    //멤테스트 실행
                    tempProcess = Process.Start(Application.StartupPath + "\\Resources\\memtest.exe");

                    while (Hwnd1 == IntPtr.Zero)
                    { //첫 알림 나올 때까지 탐색
                        Hwnd1 = FindWindow("#32770", "어서오세요!");
                        Thread.Sleep(3);
                    }

                    //첫 알림창 나오면 버튼 찾아서 클릭
                    Hwnd2 = FindWindowEx(Hwnd1, IntPtr.Zero, "Button", "확인");
                    SendMessage(Hwnd2, CLICK, 0, 0);

                    //메인 화면 및 필요한 모든 윈도우(창)의 핸들값 탐색
                    while (hci[0] == IntPtr.Zero)
                    {
                        hci[0] = tempProcess.MainWindowHandle;
                        ShowWindow(hci[0], Sw_Hide); //안 지저분하게 메인창은 숨기기
                        Thread.Sleep(3);
                    }

                    startbtn[0] = FindWindowEx(hci[0], IntPtr.Zero, "Button", "테스트 시작");
                    exitbtn[0] = FindWindowEx(hci[0], IntPtr.Zero, "Button", "테스트 중단");
                    hcicoverage[0] = FindWindowEx(hci[0], IntPtr.Zero, "Static", "무료 버전");
                    IntPtr hTextBox = FindWindowEx(hci[0], IntPtr.Zero, "Edit", null);

                    //텍스트에 숫자 입력하고 테스트 시작
                    tmemText.Invoke((MethodInvoker)delegate ()
                    { tmemText.Text = tmem.ToString(); });
                    IntPtr textPtr = Marshal.AllocHGlobal(8);
                    tmemText.Invoke((MethodInvoker)delegate ()
                    { SendMessage(tmemText.Handle, WM_GetText, new IntPtr(8), textPtr); });               
                    String text1 = Marshal.PtrToStringUni(textPtr, 8);
                    SendMessage(hTextBox, WM_SetText, IntPtr.Zero, textPtr);
                    Marshal.FreeHGlobal(textPtr);


                    PostMessage(startbtn[0], CLICK, IntPtr.Zero, IntPtr.Zero); // 테스트 시작
                    canAllocate.Clear();
                    canAllocate.Append("무료 버전");


                    // 할당불가 하단 바 찾기
                    while (canAllocate.ToString() == "무료 버전")
                    {
                        GetWindowText(hcicoverage[0], canAllocate, 20);
                        Thread.Sleep(3);
                    }


                    if (canAllocate.ToString() == "테스트 준비 중...") // 값 찾기 성공 시
                    { findMem = true; }
                    else if (canAllocate.ToString() == tmem + " MB 할당 불가!") //할당불가 시
                    { findMem = false; }

                    tempProcess.Kill();
                    tempProcess.Dispose();
                }


                //                                                    //
                // 자동설정- 최대메모리 탐색완료. tmem 변수에 저장됨. //
                //              
                
                //                     //
                // 실행 정보 계산 시작 //
                //                     //
                hcimem = (ushort)((freeMemMB - Convert.ToUInt32(AutoHCIM.Text)) / CPUThreads);
                hcinum = CPUThreads;
                while (hcimem > tmem)
                {
                    hcinum++;
                    hcimem = (ushort)((freeMemMB - Convert.ToUInt32(AutoHCIM.Text)) / hcinum);
                }
            }

            else
            { // 수동설정: 값 그대로 복사 //
                hcinum = Convert.ToUInt16(HCINText.Text);
                hcimem = Convert.ToUInt16(HCIMemory.Text);
            }





            // 배열변수들 실행할 멤테 개수만큼 초기화 //
            hci = new IntPtr[hcinum]; hcicoverage = new IntPtr[hcinum]; startbtn = new IntPtr[hcinum]; exitbtn = new IntPtr[hcinum];
            hciProcess = new Process[hcinum];

            //휴식
            Thread.Sleep(100);
            
            for (int i1=0; i1<hcinum; i1++)
            {
                hciProcess[i1] = Process.Start(Application.StartupPath + "\\Resources\\memtest.exe");
            }
            //편차방지를 위해 멤테 동시에 전부 실행//


            Thread.Sleep(50);
            Hwnd1 = IntPtr.Zero; Hwnd2 = IntPtr.Zero; //변수 비운 뒤 재활용
            while (Hwnd1 == IntPtr.Zero)
            { //시작창 처음 발견할 때까지 루프 반복
                Hwnd1 = FindWindow("#32770", "어서오세요!");
                Thread.Sleep(3);
            }

            Thread.Sleep(50); //발견하고 0.05초 쉬기
            while (Hwnd1 != IntPtr.Zero)
            {//시작창을 발견하지 못할 때까지 무한반복
                Hwnd1 = FindWindow("#32770", "어서오세요!");
                Hwnd2 = FindWindowEx(Hwnd1, IntPtr.Zero, "Button", "확인");
                if (Hwnd2 != IntPtr.Zero)
                {//발견 시 버튼찾고 클릭
                    SendMessage(Hwnd2, CLICK, 0, 0);
                }
                Thread.Sleep(3);
            }






            //                 //
            // 본격적 멤테실행 //
            //                 //

            LView1.Invoke((MethodInvoker)delegate () { LView1.Items.Clear(); });
             //모니터링 목록 비워두기

            for (int i1 = 0; i1 < hcinum; i1++)
            { //멤테 개수만큼 반복
                LView1.Invoke((MethodInvoker)delegate () {
                LView1.BeginUpdate(); //리스트뷰를 잠시 멈춤
                LView1.Items.Add(new ListViewItem(new string[] { "대기", "0개" })); // 0.0%, 0개 추가
                LView1.EndUpdate(); //리스트뷰 다시 재생
                });
                hci[i1] = hciProcess[i1].MainWindowHandle; //메인창 및 여러가지 윈도우의 핸들 가져오기
                hcicoverage[i1] = FindWindowEx(hci[i1], IntPtr.Zero, "Static", "무료 버전");
                startbtn[i1] = FindWindowEx(hci[i1], IntPtr.Zero, "Button", "테스트 시작");
                exitbtn[i1] = FindWindowEx(hci[i1], IntPtr.Zero, "Button", "테스트 종료");
                IntPtr hTextBox = FindWindowEx(hci[i1], IntPtr.Zero, "Edit", null);

                // 창 숨기기 //
                if (mtHide.Checked) { ShowWindow(hci[i1], 0); }


                //             //
                // 창 배치하기 //
                //             //
                MoveWindow(hci[i1], WindowX, WindowY, 255, 236, true);
                WindowX += Convert.ToUInt16(BatchX.Text); // 우선 X축부터 쫙 깔고

                if (WindowX + 230 > ScreenX) //멤테 창이 화면 오른쪽 끝에서 가릴 것 같으면
                {
                    WindowX = 1; //X값 1로 초기화
                    WindowY = (ushort)(WindowY + Convert.ToUInt16(BatchY.Text)); //Y값 다음줄로 넘기기
                }

                if (WindowY + 235 > ScreenY) //Y축조차 다 써서 더이상 화면에 남은 공간이 없다면
                {
                    WindowX = 1; WindowY = 1;  //값 초기화하고 첫 위치부터 다시 깔기
                }


                // 메모리값 멤테 텍스트칸에 옮겨적기//
                tmemText.Invoke((MethodInvoker)delegate ()
                { tmemText.Text = hcimem.ToString(); });            
                IntPtr textPtr = Marshal.AllocHGlobal(8);
                tmemText.Invoke((MethodInvoker)delegate ()
                {SendMessage(tmemText.Handle, WM_GetText, new IntPtr(8), textPtr); });
                String text1 = Marshal.PtrToStringUni(textPtr, 8);
                SendMessage(hTextBox, WM_SetText, IntPtr.Zero, textPtr);
                Marshal.FreeHGlobal(textPtr);

                // 테스트 시작하기 //
                PostMessage(startbtn[i1], CLICK, IntPtr.Zero, IntPtr.Zero);
            }


            ushort remAlarmCount = 0; //알림창제거 횟수 초기화
            while (remAlarmCount < hcinum)
            { //멤테 개수만큼 알림창제거 무한반복.
                Hwnd1 = IntPtr.Zero; //변수 재활용
                Hwnd1 = FindWindow("#32770", "테스트 시작합니다.");

                if (Hwnd1 != IntPtr.Zero) //알림창 발견 시
                {
                    Hwnd2 = FindWindowEx(Hwnd1, IntPtr.Zero, "Button", "확인");
                    SendMessage(Hwnd2, CLICK, 0, 0);
                    remAlarmCount++;
                    Thread.Sleep(3);
                }
                Thread.Sleep(20);
            }

            //프로그램을 맨 앞으로 가져오기
            this.Invoke((MethodInvoker)delegate () {SetForegroundWindow((int)this.Handle);});
            




            // 2초 휴식 후 혹시나 남아있을 알림창 1개 있으면 제거 //
            Thread.Sleep(2000);
            Hwnd1 = FindWindow("#32770", "테스트 시작합니다.");
            Hwnd2 = FindWindowEx(Hwnd1, IntPtr.Zero, "Button", "확인");
            SendMessage(Hwnd2, CLICK, 0, 0);

            goblog.Text = "Github: bumju08";






            





            // //////////////  //
            //                 //
            //  모니터링 시작  //
            //                 //
            // //////////////  //


           
            errorIncreased = false;
            errNum = 0; minValue = 0; maxValue = 0;
            capHour = (byte)DateTime.Now.Hour; capMinute = (byte)DateTime.Now.Minute;


            //타이머 시작
            activateTimer = true;



            //          //
            // 모니터링 //
            //          //
            while (true)
            {
                errorIncreased = false;
                LView1.Invoke((MethodInvoker)delegate ()
                {LView1.BeginUpdate(); //리스트뷰를 잠시 멈춤
                });
                for (int i1 = 0; i1 < hcinum; i1++)
                { //멤테 개수만큼 반복
                    NewText1.Clear(); NewText2.Clear(); //문자열 초기화

                    GetWindowText(hcicoverage[i1], NewText1, 40); //하단 바 읽어서 변수1에 저장(통과율/에러)
                    if (NewText1.ToString() == "메모리 할당됨" || NewText1.ToString() == null) { i1++; } //만약 읽어왔는데 아직 시작 안됐거나 창 꺼졌으면 다음멤테로 패스
                    else
                    {//아니라면 읽어서 리스트뷰에 작성
                        NewText1.Remove(0, 7); //변수1 앞부분 제거
                        NewText2.Append(NewText1.ToString()); //변수2에 읽은 값의 뒷부분 복사

                        NewText2.Remove(NewText2.ToString().IndexOf("개") + 1, 6); //변수2 에러수치 뒷부분 삭제
                        NewText2.Remove(0, NewText2.ToString().IndexOf(",") + 2); // 변수2 앞부분 삭제

                        NewText1.Remove(NewText1.ToString().IndexOf("%"), 14); //변수1 숫자만 남기고 뒷부분 다 삭제
                        LView1.Invoke((MethodInvoker)delegate () {
                            LView1.Items.RemoveAt(i1);
                            LView1.Items.Insert(i1, new ListViewItem(new string[] { NewText1.ToString() + "%", NewText2.ToString() })); //원하는 순번에 통과율 추가
                        });

                        if (NewText2.ToString() != "0개")
                        { //오류가 발생한 경우
                            errorIncreased = true; errNum = (ushort)(i1 + 1); // 오류 발생한 멤테 순번 기록
                        }

                        if (i1 == 0) { minValue = Convert.ToDouble(NewText1.ToString()); } // 첫항목이면 값 옮겨놓고 비교 (최솟값 찾기 때문에)
                        if (minValue > Convert.ToDouble(NewText1.ToString()))  //최솟값 찾기
                        { minValue = Convert.ToDouble(NewText1.ToString()); }
                        if (maxValue < Convert.ToDouble(NewText1.ToString()))  //최댓값 구하기
                        { maxValue = Convert.ToDouble(NewText1.ToString()); }
                    }
                } //통과율,에러 스캔 종료

                LView1.Invoke((MethodInvoker)delegate () { 
                LView1.EndUpdate(); //리스트뷰 재개
                
                // 통과율, 편차 표시 //
                passRate.Text = "통과율: " + minValue + "%";
                memGap.Text = "편차: " + Math.Round(maxValue - minValue, 1) + "%";
           


                // 테스트 정상시작했으므로 이제 유저가 중단가능 //
                    stopTest.Enabled = true;
                    stopTest.Text = "테스트 중단";
                });








                //                //
                // 테스트 통과 시 //
                //                //

                if (minValue > Convert.ToUInt16(HCIMax.Text))
                {
                    // 로그 작성
                    WriteLog();

                    // 끝날 때 스크린샷
                    if (capAfter.Checked)
                    { Screenshot(); }

                    
                    // 만약 설정이 멤테 종료라면 //
                    if (closeMem.Checked)
                    {
                        KillMemtest();

                        if (Convert.ToUInt16(musicRepeat.Text) > 0)
                        { PlayMusic(); }
                        //음악 재생

                        stopTest.Invoke((MethodInvoker)delegate () {
                            stopTest.Enabled = false;
                            mtHide.Enabled = true; 
                            goTest.Enabled = true;
                            goTest.Text = "테스트 시작";
                        });
                        tTimer.Enabled = false;


                        MessageBox.Show("테스트 " + minValue + "%까지 통과하였습니다.", "통과", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        goto abortTest; //종료
                    }


                    // 만약 설정이 PC 종료라면 //
                    else if (closePC.Checked)
                    {
                        var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                    }

                }



                //              //
                // 에러 발생 시 //
                //              //

                else if (errorIncreased)
                {
                    // 로그 작성
                    WriteLog();

                    // 끝날 때 스크린샷
                    if (capAfter.Checked)
                    {  Screenshot(); }

                    // 만약 설정이 멤테 종료라면 //
                    if (closeMem.Checked)
                    {
                        KillMemtest();

                        if (Convert.ToUInt16(musicRepeat.Text) > 0)
                        { PlayMusic(); }
                        //음악 재생

                        stopTest.Invoke((MethodInvoker)delegate () {
                            stopTest.Enabled = false;
                            mtHide.Enabled = true;
                            goTest.Enabled = true;
                            goTest.Text = "테스트 시작";
                        });
                        tTimer.Enabled = false;

                        goto abortTest; //종료
                    }


                    // 만약 설정이 PC 종료라면 //
                    else if (closePC.Checked)
                    {
                        var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                    }
                }





                //                                                   //
                // 만약 중도포기라면 로그작성과 프로그램 설정저장만  //
                //                                                   //

               else if (endMonitoring)
                    {
                        WriteLog();

                        KillMemtest();

                        stopTest.Invoke((MethodInvoker)delegate () {
                            stopTest.Enabled = false;
                            mtHide.Enabled = true; 
                            goTest.Enabled = true;
                            goTest.Text = "테스트 시작";
                        });
                        tTimer.Enabled = false;
                       


                    if (endProgram)
                    {
                        SaveSettings();

                        Environment.Exit(0);
                    }



                        goto abortTest;
                    }






       






                //                   //
                // 주기적인 스크린샷 //
                //                   //
                if (capbyTime.Checked)
                {
                    ushort nowTime = (ushort)((DateTime.Now.Hour * 60) + DateTime.Now.Minute);
                    ushort lastTime = (ushort)((capHour * 60) + capMinute);

                   if (lastTime + Convert.ToUInt16(capTime.Text) <= nowTime )   {
                        capHour = (byte)DateTime.Now.Hour;
                        capMinute = (byte)DateTime.Now.Minute; //시간정보 초기화 후 스크린샷
                        Screenshot();
                    }
                }






                Thread.Sleep(1250);
            } //모니터링 반복문 while 종료

            abortTest:
            StartTestThread.Abort();
        } //StartTest 쓰레드 종료














        private void SaveSettings()
        {//프로그램 설정 저장 함수
            tSetting.Clear();

            tSetting.Append("목표치: " + HCIMax.Text + "\r\n백그라운드 실행: " + mtHide.Checked + "\r\n테스트 유형: ");

            if (notAuto.Checked == true)
            { tSetting.Append("Manual"); }
            else { tSetting.Append("Auto"); }

            tSetting.Append("\r\n\r\n끝날 때 스크린샷: " + capAfter.Checked);
            tSetting.Append("\r\n주기적인 스크린샷: " + capbyTime.Checked);
            tSetting.Append("\r\n주기적인 스크린샷 값(분): " + capTime.Text);
            tSetting.Append("\r\n스크린샷 저장폴더: " + capPath);

            tSetting.Append("\r\n\r\n소리알림 반복 횟수: " + musicRepeat.Text);
            tSetting.Append("\r\n통과 알림파일 경로: " + sucPath);
            tSetting.Append("\r\n오류 알림파일 경로: " + errPath);

            tSetting.Append("\r\n\r\n마지막에 끌 항목: ");
            if (closeMem.Checked == true) { tSetting.Append("Memtest"); }
            else { tSetting.Append("PC"); }

            tSetting.Append("\r\n\r\n창 배치 간격(x축): " + BatchX.Text);
            tSetting.Append("\r\n창 배치 간격(y축): " + BatchY.Text);
            tSetting.Append("\r\n프로그램이 켜질 때 즉시 테스트: " + instant.Checked);
            File.WriteAllText(Application.StartupPath + "\\Resources\\Settings.txt", tSetting.ToString(), Encoding.Default);
        }







        private void PlayMusic()
        {
            if (errorIncreased == true) { musicURL = errPath; }
            else { musicURL = sucPath; }
            musicThread = new Thread(musicFunction);
            musicThread.Start(); //음악 재생
        }




        private void KillMemtest()
        {
            Process[] proc1 = Process.GetProcessesByName("memtest");

            for (int i1 = 0; i1 < proc1.Length; i1++)
            {
                try { proc1[i1].Kill(); proc1[i1].Dispose(); }
                catch (Exception) { }
            }
        }







        private void WriteLog()
        {
            //           //
            // 로그 작성 //
            //           //

            IntPtr ErrMsgHwnd = IntPtr.Zero, ErrChildHwnd;
            ErrMsg.Clear(); finalRecord.Clear();


            if (errorIncreased == true)
            {

                while (ErrMsgHwnd == IntPtr.Zero)
                { //오류메세지 내용 찾을 때까지
                    ErrMsgHwnd = FindWindow("#32770", "멤테스트 오류");
                    Thread.Sleep(10);
                }
                Thread.Sleep(20);
                ErrChildHwnd = FindWindowEx(ErrMsgHwnd, IntPtr.Zero, "Static", null);
                GetWindowText(ErrChildHwnd, ErrMsg, 250);
                finalRecord.Append("!!! 오류 발생 !!!");
            }  //오류발생 if문 끝

            else if (endMonitoring == true) { finalRecord.Append("◆ 중도 포기 ◆"); }
            else { finalRecord.Append("★ 통과 ★"); }

            //통과율, 편차, 경과시간 가져와서 로그 작성
            finalRecord.Append("\r\n종료 시각: " + DateTime.Now.ToString("yyyy년 MM월 dd일 --- H시 mm분 ss초") + "\r\n" + elTime.Text + "\r\n테스트한 메모리: " + hcimem + "MB * " + hcinum + "  =  " + (hcimem * hcinum) + "MB   |총 메모리의 " + lb2.Text + "|\r\n\r\n전체 통과율: " + minValue + "%\r\n" + memGap.Text);

            //오류났을 경우에만 오류정보 추가기록
            if (errorIncreased == true) { finalRecord.Append("\r\n\r\n[오류 정보]\r\n" + errNum + "번째 멤테스트에서 오류 발생\r\n" + ErrMsgHwnd.ToString()); }
            finalRecord.Append("\r\n---------------------------------\r\n\r\n\r\n");

            //로그 작성 끝//
            if (File.Exists(Application.StartupPath + "\\EasyHCI Log.txt"))
            {
                string origLog = File.ReadAllText(Application.StartupPath + "\\EasyHCI Log.txt", Encoding.Default);
                File.WriteAllText(Application.StartupPath + "\\EasyHCI Log.txt", origLog + finalRecord.ToString(), Encoding.Default);
            }
            else { File.WriteAllText(Application.StartupPath + "\\EasyHCI Log.txt", finalRecord.ToString(), Encoding.Default); }

        }



        private void tTimer_Tick(object sender, EventArgs e)
        { //테스트 모니터링 때 작동할 타이머
            if (activateTimer == true) // second 변수가 0이 아니어야 작동
            {
                second++; //1초 증가
                if (second >= 60)  //만약 60초가 되면
                {
                    second = 0; minute++; //0초로 초기화 후 1분 증가
                    if (minute >= 60) //만약 60분이 되면
                    {
                        minute = 0; hour++; //0분으로 초기화 후 1시간 증가
                    }
                }

                elTime.Text = "경과: " + hour + "시간 " + minute + "분 " + second + "초";
            }
        }



        private void Screenshot()
        { //스크린샷 함수

                Bitmap ScreenBitmap;
                IntPtr DesktopHwnd = GetDesktopWindow();
                using (Graphics DesktopGr = Graphics.FromHwnd(DesktopHwnd))
                {
                    IntPtr DesktopHdc = DesktopGr.GetHdc();
                    int XRes = GetDeviceCaps(DesktopHdc, 118); // 118 = horizontal size
                    int YRes = GetDeviceCaps(DesktopHdc, 117); // 117 = vertical size

                    ScreenBitmap = new Bitmap(XRes, YRes, PixelFormat.Format16bppRgb555);
                
                    using (Graphics ScreenBitmapGr = Graphics.FromImage(ScreenBitmap))
                    {
                        ScreenBitmapGr.CopyFromScreen(0, 0, 0, 0, new Size(XRes, YRes));
                    }
                }

            try { ScreenBitmap.Save(capPath + "\\" + DateTime.Now.ToString("(yyyy년 MM월 dd일) hh시 mm분 ss초") + ".png", ImageFormat.Png);}
            catch (DirectoryNotFoundException) { }
        }






        private void showUsedMemory()
        {// 메모리 사용량 표시
            while (true)
            {
                ManagementClass cls = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection instances = cls.GetInstances();

                foreach (ManagementObject info in instances)
                {
                    freeMemMB = uint.Parse(info["FreePhysicalMemory"].ToString()) / 1024;

                    lb2.Invoke((MethodInvoker)delegate () { //크로스스레드 오류 해결
                     lb2.Text = Math.Round(((double)totalMemMB - freeMemMB) / totalMemMB, 3) * 100 + "%"; // 옆 라벨 %값
                     pbUse.Value = Convert.ToInt32(totalMemMB - freeMemMB);  //프로그래스바 값
                    });
                }
                cls.Dispose(); instances.Dispose();

                Gc1++;
                if (Gc1 >= 100) { Gc1 = 0; GC.Collect(); } //2분마다 가비지컬렉터 실행

                Thread.Sleep(1250);
            }
        }






        //소리알림(음악 재생) 함수
        private void musicFunction()
        {
            try
            {
                System.Media.SoundPlayer music1 = new System.Media.SoundPlayer(musicURL);
                for (int i1=0; i1<Convert.ToUInt16(musicRepeat.Text); i1++)
                { music1.PlaySync(); }
                music1.Dispose();
            } catch (FileNotFoundException)
            {
                MessageBox.Show("소리파일이 잘못 되었거나 오류가 발생했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            musicThread.Abort();
        }







        // 마우스 올리면 도움말 표시하는 기능
        private void goblog_MouseMove(object sender, MouseEventArgs e)
        {
            Tip1.ToolTipTitle = "제작자";
            Tip1.IsBalloon = true;
        }








        private void goblog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { //블로그 이동
            Process.Start("https://github.com/bumju08");
        }











        private void goTest_Click(object sender, EventArgs e)
        { //테스트 시작버튼

            
            if (!File.Exists(Application.StartupPath + "\\Resources\\memtest.exe"))
            { // memtest.exe 존재유무 확인하고 없으면 취소
                goTest.Enabled = false;
                MessageBox.Show(Application.StartupPath + "\\Resources\\memtest.exe\r\n\r\n memtest 실행파일이 발견되지 않았습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goTest.Enabled = true;
                return;
            }


            //메모리 현황 업데이트.
            ManagementClass cls = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection instances = cls.GetInstances();

            foreach (ManagementObject info in instances)
            {
                freeMemMB = uint.Parse(info["FreePhysicalMemory"].ToString()) / 1024;

                lb2.Text = Math.Round(((double)totalMemMB - freeMemMB) / totalMemMB, 3) * 100 + "%"; // 옆 라벨 %값
                pbUse.Value = Convert.ToInt32(totalMemMB - freeMemMB);  //프로그래스바 값
            }
            cls.Dispose(); instances.Dispose();


            if (notAuto.Checked == true) { //만약 수동설정인데
                if (Convert.ToInt16(HCINText.Text) * Convert.ToInt16(HCIMemory.Text) > (freeMemMB - 50)) {
                    //여유 메모리보다 크게 입력했는지 확인.
                    goTest.Enabled = false;
                    MessageBox.Show("테스트할 양을 여유 메모리보다 크게 입력하셨습니다.\r\n\r\n" + ((Convert.ToInt16(HCINText.Text) * Convert.ToInt16(HCIMemory.Text)) - (freeMemMB - 50)).ToString() + "MB만큼 줄여서 입력해주세요." , "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goTest.Enabled = true;
                    return;
                }
            }




            //값 초기화
            hour = 0; minute = 0; second = 0;
            activateTimer = false; endMonitoring = false;
   
            mtHide.Enabled = false;
            tTimer.Enabled = true;
            goTest.Enabled = false;

            StartTestThread = new Thread(StartTest);
            StartTestThread.Start();
        }



        private void stopTest_Click(object sender, EventArgs e)
        {
            // 스레드 종료 신호 보냄
            endMonitoring = true;
            if (musicThread.IsAlive == true) { musicThread.Abort(); }


            //다시 활성화
            stopTest.Enabled = false;
            mtHide.Enabled = true;
            goTest.Enabled = true;
            tTimer.Enabled = false;
            goTest.Text = "테스트 시작";
        }



        private void notAuto_Click(object sender, EventArgs e)
        { //수동설정 라디오버튼
                HCIMemory.Enabled = true; HCINText.Enabled = true; dLB1.Enabled = true; dLB2.Enabled = true; AutoHCIM.Enabled = false; yLLB.Enabled = false;
        }



        private void YAuto_Click(object sender, EventArgs e)
        { //자동설정 라디오버튼
            HCIMemory.Enabled = false; HCINText.Enabled = false; dLB1.Enabled = false; dLB2.Enabled = false; AutoHCIM.Enabled = true; yLLB.Enabled = true;
        }







        private void capbyTime_Click(object sender, EventArgs e)
        {//스크린샷-주기적으로 체크박스
            if (capbyTime.Checked == true)
            {
                capTime.Enabled = true;
                tLB1.Enabled = true;

            } else {
                capTime.Enabled = false;
                tLB1.Enabled = false;
            }
          
        }









        //멤테 종료, PC 종료 체크박스
        private void closeMem_Click(object sender, EventArgs e)
        {
            closeMem.Checked = true; closePC.Checked = false;
        }

        private void closePC_Click(object sender, EventArgs e)
        {
            closePC.Checked = true; closeMem.Checked = false;
        }






        //각 텍스트박스 모두 숫자만 입력 가능하도록
        private void HCIMax_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void HCIMemory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }



        private void musicRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }


        private void HCINText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void BatchY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void BatchX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void capTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void AutoHCIM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }








        //폴더,파일 선택창 열기
        private void OpenSCAP_Click(object sender, EventArgs e)
        {
            OpenFolder.Description = "스크린샷을 저장할 폴더를 선택해주세요.";
            OpenFolder.ShowDialog();

            if (!Directory.Exists(OpenFolder.SelectedPath))
            {
                MessageBox.Show("폴더를 선택하지 않으셨습니다.\r\n\r\n스크린샷 기능을 사용할 경우 오류가 발생하거나 기능이 정상작동하지 않을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else {
                capPath = OpenFolder.SelectedPath;
            }
        }



        private void OpenPM_Click(object sender, EventArgs e)
        {
            OpenFile.FileName = sucPath;
            OpenFile.ShowDialog();

            if (!File.Exists(OpenFile.FileName)) {
                MessageBox.Show("파일을 선택하지 않으셨습니다.\r\n\r\n소리알림 기능을 사용할 경우 오류가 발생하거나 기능이 정상작동하지 않을 수 있습니다.","알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                sucPath = OpenFile.FileName;  }
        }



        private void OpenEM_Click(object sender, EventArgs e)
        {
            OpenFile.FileName = errPath;
            OpenFile.ShowDialog();

            if (!File.Exists(OpenFile.FileName))
            {
                MessageBox.Show("파일을 선택하지 않으셨습니다.\r\n\r\n소리알림 기능을 사용할 경우 오류가 발생하거나 기능이 정상작동하지 않을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                errPath = OpenFile.FileName;
            }
        }




        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {//프로그램 종료신호 보내기 (기록 작성)
            e.Cancel = true;

            if (StartTestThread.IsAlive)
            { //테스트 도중이라면 기록을 위해 종료신호 보내고 기다리기
                endMonitoring = true;
                endProgram = true;
            }
            else
            { //아니라면 설정 저장 후 종료
                SaveSettings();

                Environment.Exit(0);
            }
        }




        private void MainForm_Load(object sender, EventArgs e)
        { //프로그램 시작 시 모든 작업 완료 전까지 잠시 숨김
            this.Hide();


            //중복실행 시 기존 프로그램을 앞으로 보이고 종료
            Process[] proc1 = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (proc1.Length > 1)
            {
                for (int i1=0; i1<proc1.Count(); i1++)
                {
                    if (proc1[i1].MainWindowHandle != this.Handle)
                    {
                        SetForegroundWindow((int)proc1[i1].MainWindowHandle);
                    }
                }
                Environment.Exit(0);
            }

            proc1[0].Dispose();


            
            //폼 크기 조정, 임시텍스트파일 폼밖으로 옮기기 (Visible로 숨김처리하면 멤테 개당 최대메모리 오류발생)
            this.Size = new Size(330, 500);


            //리소스와 스크린샷 폴더 없을 경우 생성
            if (Directory.Exists(Application.StartupPath + "\\Resources") == false) {
                Directory.CreateDirectory(Application.StartupPath + "\\Resources");
            }
            if (Directory.Exists(Application.StartupPath + "\\HCI Screenshots") == false) {
                Directory.CreateDirectory(Application.StartupPath + "\\HCI Screenshots");
            }

            //프로그램 락 걸기
            File.Open(Application.ExecutablePath, FileMode.Open, FileAccess.Read, FileShare.Read);


            //레지스트리를 통해 CPU 쓰레드 개수 읽기
            for (int i1=0; i1 < 999; i1++)
            {
                if (Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\" + i1, "FeatureSet", null) != null)
                {
                    CPUThreads++;
                }  else break; 
            }


            //모니터 해상도 크기
            ScreenX = (ushort)Screen.PrimaryScreen.Bounds.Width;
            ScreenY = (ushort)Screen.PrimaryScreen.Bounds.Height;


            //현재 메모리 가져오기
            ManagementClass cls = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection instances = cls.GetInstances();

            foreach (ManagementObject info in instances)
            {
                totalMemMB = uint.Parse(info["TotalVisibleMemorySize"].ToString()) / 1024;
                freeMemMB = uint.Parse(info["FreePhysicalMemory"].ToString()) / 1024;

                pbUse.Maximum = (int)totalMemMB;
                lb2.Text = Math.Round(((double)totalMemMB - freeMemMB) / totalMemMB, 3) * 100 + "%"; // 옆 라벨 %값
                pbUse.Value = Convert.ToInt32(totalMemMB - freeMemMB);  //프로그래스바 값
            }
            cls.Dispose(); instances.Dispose();

            //메모리 현황 스레드 실행
            MemStatusThread = new Thread(new ThreadStart(showUsedMemory));
            MemStatusThread.Start();



            //바로 종료 시 오류 안나도록 스레드에 값 지정
            StartTestThread = new Thread(StartTest);
            musicThread = new Thread(musicFunction);

            //수동설정에 값 저장
            ushort tempN = CPUThreads, hciMem = (ushort)((freeMemMB - 280) / CPUThreads);
            
            while (hciMem > 2048)
            {
                tempN++;
                hciMem = (ushort)((freeMemMB - 280) / tempN);
            }
            HCIMemory.Text = hciMem.ToString();
            HCINText.Text = tempN.ToString();



            //경로 설정
            OpenFolder.SelectedPath = Application.StartupPath + "\\HCI Screenshots";
            capPath = Application.StartupPath + "\\HCI Screenshots";

            OpenFile.InitialDirectory = Application.StartupPath + "\\Resources";
            errPath = Application.StartupPath + "\\Resources\\error.wav";
            sucPath = Application.StartupPath + "\\Resources\\success.wav";



            //설정 불러오기
            if (File.Exists(Application.StartupPath + "\\Resources\\Settings.txt"))
            {
                string[] tfile1 = File.ReadAllLines(Application.StartupPath + "\\Resources\\Settings.txt", Encoding.Default);

                HCIMax.Text = tfile1[0].Remove(0, tfile1[0].IndexOf(":") + 2);
                mtHide.Checked = Convert.ToBoolean(tfile1[1].Remove(0, tfile1[1].IndexOf(":") + 2));

                if (tfile1[2].Remove(0, tfile1[2].IndexOf(":") + 2) == "Manual") { notAuto.Checked = true; HCIMemory.Enabled = true; HCINText.Enabled = true; dLB1.Enabled = true; dLB2.Enabled = true; AutoHCIM.Enabled = false; yLLB.Enabled = false; }

                capAfter.Checked = Convert.ToBoolean(tfile1[4].Remove(0, tfile1[4].IndexOf(":") + 2));
                capbyTime.Checked = Convert.ToBoolean(tfile1[5].Remove(0, tfile1[5].IndexOf(":") + 2));
                capTime.Text = tfile1[6].Remove(0, tfile1[6].IndexOf(":") + 2);

                if (Directory.Exists(tfile1[7].Remove(0, tfile1[7].IndexOf(":") + 2)))
                {
                    OpenFolder.SelectedPath = tfile1[7].Remove(0, tfile1[7].IndexOf(":") + 2);
                    capPath = tfile1[7].Remove(0, tfile1[7].IndexOf(":") + 2);
                }

                musicRepeat.Text = tfile1[9].Remove(0, tfile1[9].IndexOf(":") + 2);

                if (File.Exists(tfile1[10].Remove(0, tfile1[10].IndexOf(":") + 2)))
                    sucPath = tfile1[10].Remove(0, tfile1[10].IndexOf(":") + 2);

                if (File.Exists(tfile1[11].Remove(0, tfile1[11].IndexOf(":") + 2)))
                    errPath = tfile1[11].Remove(0, tfile1[11].IndexOf(":") + 2);

                if (tfile1[13].Remove(0, tfile1[13].IndexOf(":") + 2) == "Memtest")
                { closeMem.Checked = true; closePC.Checked = false; }
                else { closeMem.Checked = false; closePC.Checked = true; }

                BatchX.Text = tfile1[15].Remove(0, tfile1[15].IndexOf(":") + 2);
                BatchY.Text = tfile1[16].Remove(0, tfile1[16].IndexOf(":") + 2);
                instant.Checked = Convert.ToBoolean(tfile1[17].Remove(0, tfile1[17].IndexOf(":") + 2));
            }

            //즉시 테스트
            if (instant.Checked)
            { goTest_Click(new object(), new EventArgs()); }

        }



        private void MainForm_Resize(object sender, EventArgs e)
        { //폼 아래로 당기면 일부 항목 같이 커지기
            TabMain.Size = new Size(this.Size.Width - 4, this.Size.Height - 99);
            LView1.Size = new Size(this.Size.Width - 9, this.Size.Height - 213);
            pbUse.Size = new Size(this.Size.Width - 165, 5);

            tmemText.Location = new Point(this.Size.Width + 100, 100);
            passRate.Location = new Point(4, this.Size.Height - 115);
            memGap.Location = new Point(this.Size.Width / 3 - 15, this.Size.Height - 115);
            elTime.Location = new Point(this.Size.Width - 145, this.Size.Height - 115);
            lb2.Location = new Point(this.Size.Width - 48, 70);
            stopTest.Location = new Point(this.Size.Width - 138, 6);
        }



        private void transparent_ValueChanged(object sender, EventArgs e)
        { //투명도 조절
            this.Opacity = (double)transparent.Value/100;
        }

    }
}
