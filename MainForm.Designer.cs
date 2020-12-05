namespace EasyHCI
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Tip1 = new System.Windows.Forms.ToolTip(this.components);
            this.goblog = new System.Windows.Forms.LinkLabel();
            this.mtHide = new MaterialSkin.Controls.MaterialCheckBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.pbUse = new MaterialSkin.Controls.MaterialProgressBar();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabMain = new MaterialSkin.Controls.MaterialTabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.memGap = new System.Windows.Forms.Label();
            this.elTime = new System.Windows.Forms.Label();
            this.tmemText = new System.Windows.Forms.TextBox();
            this.stopTest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.passRate = new System.Windows.Forms.Label();
            this.LView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LB1 = new System.Windows.Forms.Label();
            this.goTest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.instant = new MaterialSkin.Controls.MaterialCheckBox();
            this.YAuto = new MaterialSkin.Controls.MaterialRadioButton();
            this.notAuto = new MaterialSkin.Controls.MaterialRadioButton();
            this.pdL2 = new System.Windows.Forms.Label();
            this.pdL1 = new System.Windows.Forms.Label();
            this.BatchY = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BatchX = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.yLB1 = new System.Windows.Forms.Label();
            this.XLB1 = new System.Windows.Forms.Label();
            this.LB31 = new System.Windows.Forms.Label();
            this.closePC = new MaterialSkin.Controls.MaterialCheckBox();
            this.closeMem = new MaterialSkin.Controls.MaterialCheckBox();
            this.mdLB3 = new System.Windows.Forms.Label();
            this.OpenEM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OpenPM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.musicRepeat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dsLB1 = new System.Windows.Forms.Label();
            this.LB123 = new System.Windows.Forms.Label();
            this.capTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.HCINText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.HCIMemory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.HCIMax = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb15 = new System.Windows.Forms.Label();
            this.deLB0 = new System.Windows.Forms.Label();
            this.OpenSCAP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tLB1 = new System.Windows.Forms.Label();
            this.capbyTime = new MaterialSkin.Controls.MaterialCheckBox();
            this.capAfter = new MaterialSkin.Controls.MaterialCheckBox();
            this.sLB2 = new System.Windows.Forms.Label();
            this.sLB1 = new System.Windows.Forms.Label();
            this.dLB2 = new System.Windows.Forms.Label();
            this.dLB1 = new System.Windows.Forms.Label();
            this.OpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.transparent = new System.Windows.Forms.HScrollBar();
            this.lvlb = new System.Windows.Forms.Label();
            this.TabMain.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.Tab3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goblog
            // 
            this.goblog.ActiveLinkColor = System.Drawing.Color.White;
            this.goblog.AutoSize = true;
            this.goblog.BackColor = System.Drawing.Color.Transparent;
            this.goblog.DisabledLinkColor = System.Drawing.Color.White;
            this.goblog.LinkColor = System.Drawing.Color.White;
            this.goblog.Location = new System.Drawing.Point(130, 38);
            this.goblog.Name = "goblog";
            this.goblog.Size = new System.Drawing.Size(96, 12);
            this.goblog.TabIndex = 6;
            this.goblog.TabStop = true;
            this.goblog.Text = "Github: bumju08";
            this.Tip1.SetToolTip(this.goblog, "제작자: debugprov@naver.com");
            this.goblog.VisitedLinkColor = System.Drawing.Color.White;
            this.goblog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goblog_LinkClicked);
            this.goblog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.goblog_MouseMove);
            // 
            // mtHide
            // 
            this.mtHide.AutoSize = true;
            this.mtHide.Checked = true;
            this.mtHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mtHide.Depth = 0;
            this.mtHide.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtHide.Location = new System.Drawing.Point(22, 58);
            this.mtHide.Margin = new System.Windows.Forms.Padding(0);
            this.mtHide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mtHide.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtHide.Name = "mtHide";
            this.mtHide.Ripple = true;
            this.mtHide.Size = new System.Drawing.Size(120, 30);
            this.mtHide.TabIndex = 29;
            this.mtHide.Text = "백그라운드 실행";
            this.mtHide.UseVisualStyleBackColor = true;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(277, 70);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(37, 12);
            this.lb2.TabIndex = 58;
            this.lb2.Text = "98.9%";
            // 
            // pbUse
            // 
            this.pbUse.Depth = 0;
            this.pbUse.Location = new System.Drawing.Point(109, 74);
            this.pbUse.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbUse.Name = "pbUse";
            this.pbUse.Size = new System.Drawing.Size(157, 5);
            this.pbUse.TabIndex = 57;
            this.pbUse.Value = 30;
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BaseTabControl = this.TabMain;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TabSelector.Location = new System.Drawing.Point(-13, 61);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(348, 28);
            this.TabSelector.TabIndex = 19;
            this.TabSelector.Text = "materialTabSelector2";
            // 
            // TabMain
            // 
            this.TabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabMain.Controls.Add(this.Tab1);
            this.TabMain.Controls.Add(this.Tab3);
            this.TabMain.Depth = 0;
            this.TabMain.Location = new System.Drawing.Point(2, 95);
            this.TabMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMain.Multiline = true;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(318, 524);
            this.TabMain.TabIndex = 20;
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.memGap);
            this.Tab1.Controls.Add(this.elTime);
            this.Tab1.Controls.Add(this.tmemText);
            this.Tab1.Controls.Add(this.stopTest);
            this.Tab1.Controls.Add(this.passRate);
            this.Tab1.Controls.Add(this.LView1);
            this.Tab1.Controls.Add(this.lb2);
            this.Tab1.Controls.Add(this.pbUse);
            this.Tab1.Controls.Add(this.LB1);
            this.Tab1.Controls.Add(this.goTest);
            this.Tab1.Location = new System.Drawing.Point(4, 22);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(310, 498);
            this.Tab1.TabIndex = 5;
            this.Tab1.Text = "테스트";
            this.Tab1.UseVisualStyleBackColor = true;
            // 
            // memGap
            // 
            this.memGap.AutoSize = true;
            this.memGap.Location = new System.Drawing.Point(95, 325);
            this.memGap.Name = "memGap";
            this.memGap.Size = new System.Drawing.Size(53, 12);
            this.memGap.TabIndex = 64;
            this.memGap.Text = "편차: 0%";
            // 
            // elTime
            // 
            this.elTime.AutoSize = true;
            this.elTime.Location = new System.Drawing.Point(175, 325);
            this.elTime.Name = "elTime";
            this.elTime.Size = new System.Drawing.Size(129, 12);
            this.elTime.TabIndex = 63;
            this.elTime.Text = "경과: 00시간 00분 00초";
            // 
            // tmemText
            // 
            this.tmemText.Location = new System.Drawing.Point(140, 19);
            this.tmemText.Name = "tmemText";
            this.tmemText.Size = new System.Drawing.Size(41, 21);
            this.tmemText.TabIndex = 61;
            this.tmemText.Text = "3500";
            // 
            // stopTest
            // 
            this.stopTest.AutoSize = true;
            this.stopTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopTest.BackColor = System.Drawing.Color.Transparent;
            this.stopTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopTest.Depth = 0;
            this.stopTest.Enabled = false;
            this.stopTest.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stopTest.Icon = null;
            this.stopTest.Location = new System.Drawing.Point(184, 6);
            this.stopTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopTest.Name = "stopTest";
            this.stopTest.Primary = true;
            this.stopTest.Size = new System.Drawing.Size(128, 36);
            this.stopTest.TabIndex = 60;
            this.stopTest.Text = "테스트 중단";
            this.stopTest.UseVisualStyleBackColor = false;
            this.stopTest.Click += new System.EventHandler(this.stopTest_Click);
            // 
            // passRate
            // 
            this.passRate.AutoSize = true;
            this.passRate.Location = new System.Drawing.Point(6, 325);
            this.passRate.Name = "passRate";
            this.passRate.Size = new System.Drawing.Size(65, 12);
            this.passRate.TabIndex = 62;
            this.passRate.Text = "통과율: 0%";
            // 
            // LView1
            // 
            this.LView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.LView1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LView1.FullRowSelect = true;
            this.LView1.GridLines = true;
            this.LView1.Location = new System.Drawing.Point(3, 93);
            this.LView1.Name = "LView1";
            this.LView1.Size = new System.Drawing.Size(313, 229);
            this.LView1.TabIndex = 59;
            this.LView1.UseCompatibleStateImageBehavior = false;
            this.LView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "통과율";
            this.ColumnHeader3.Width = 180;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "오류";
            this.ColumnHeader4.Width = 65;
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(6, 70);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(97, 12);
            this.LB1.TabIndex = 56;
            this.LB1.Text = "사용중인 메모리:";
            // 
            // goTest
            // 
            this.goTest.AutoSize = true;
            this.goTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTest.Depth = 0;
            this.goTest.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goTest.Icon = null;
            this.goTest.Location = new System.Drawing.Point(6, 6);
            this.goTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.goTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.goTest.Name = "goTest";
            this.goTest.Primary = true;
            this.goTest.Size = new System.Drawing.Size(128, 36);
            this.goTest.TabIndex = 9;
            this.goTest.Text = "테스트 시작";
            this.goTest.UseVisualStyleBackColor = true;
            this.goTest.Click += new System.EventHandler(this.goTest_Click);
            // 
            // Tab3
            // 
            this.Tab3.Controls.Add(this.Panel1);
            this.Tab3.Location = new System.Drawing.Point(4, 22);
            this.Tab3.Name = "Tab3";
            this.Tab3.Padding = new System.Windows.Forms.Padding(3);
            this.Tab3.Size = new System.Drawing.Size(310, 498);
            this.Tab3.TabIndex = 7;
            this.Tab3.Text = "설정";
            this.Tab3.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.lvlb);
            this.Panel1.Controls.Add(this.transparent);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.instant);
            this.Panel1.Controls.Add(this.YAuto);
            this.Panel1.Controls.Add(this.notAuto);
            this.Panel1.Controls.Add(this.pdL2);
            this.Panel1.Controls.Add(this.pdL1);
            this.Panel1.Controls.Add(this.BatchY);
            this.Panel1.Controls.Add(this.BatchX);
            this.Panel1.Controls.Add(this.yLB1);
            this.Panel1.Controls.Add(this.XLB1);
            this.Panel1.Controls.Add(this.LB31);
            this.Panel1.Controls.Add(this.closePC);
            this.Panel1.Controls.Add(this.closeMem);
            this.Panel1.Controls.Add(this.mdLB3);
            this.Panel1.Controls.Add(this.OpenEM);
            this.Panel1.Controls.Add(this.OpenPM);
            this.Panel1.Controls.Add(this.musicRepeat);
            this.Panel1.Controls.Add(this.dsLB1);
            this.Panel1.Controls.Add(this.LB123);
            this.Panel1.Controls.Add(this.capTime);
            this.Panel1.Controls.Add(this.HCINText);
            this.Panel1.Controls.Add(this.HCIMemory);
            this.Panel1.Controls.Add(this.HCIMax);
            this.Panel1.Controls.Add(this.lb15);
            this.Panel1.Controls.Add(this.deLB0);
            this.Panel1.Controls.Add(this.mtHide);
            this.Panel1.Controls.Add(this.OpenSCAP);
            this.Panel1.Controls.Add(this.tLB1);
            this.Panel1.Controls.Add(this.capbyTime);
            this.Panel1.Controls.Add(this.capAfter);
            this.Panel1.Controls.Add(this.sLB2);
            this.Panel1.Controls.Add(this.sLB1);
            this.Panel1.Controls.Add(this.dLB2);
            this.Panel1.Controls.Add(this.dLB1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(304, 492);
            this.Panel1.TabIndex = 13;
            // 
            // instant
            // 
            this.instant.AutoSize = true;
            this.instant.Checked = true;
            this.instant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.instant.Depth = 0;
            this.instant.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.instant.Location = new System.Drawing.Point(37, 747);
            this.instant.Margin = new System.Windows.Forms.Padding(0);
            this.instant.MouseLocation = new System.Drawing.Point(-1, -1);
            this.instant.MouseState = MaterialSkin.MouseState.HOVER;
            this.instant.Name = "instant";
            this.instant.Ripple = true;
            this.instant.Size = new System.Drawing.Size(207, 30);
            this.instant.TabIndex = 54;
            this.instant.Text = "프로그램이 켜질 때 즉시 테스트";
            this.instant.UseVisualStyleBackColor = true;
            // 
            // YAuto
            // 
            this.YAuto.AutoSize = true;
            this.YAuto.Checked = true;
            this.YAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YAuto.Depth = 0;
            this.YAuto.Font = new System.Drawing.Font("Roboto", 10F);
            this.YAuto.Location = new System.Drawing.Point(127, 88);
            this.YAuto.Margin = new System.Windows.Forms.Padding(0);
            this.YAuto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.YAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.YAuto.Name = "YAuto";
            this.YAuto.Ripple = true;
            this.YAuto.Size = new System.Drawing.Size(59, 30);
            this.YAuto.TabIndex = 52;
            this.YAuto.TabStop = true;
            this.YAuto.Text = "자동";
            this.YAuto.UseVisualStyleBackColor = true;
            this.YAuto.Click += new System.EventHandler(this.YAuto_Click);
            // 
            // notAuto
            // 
            this.notAuto.AutoSize = true;
            this.notAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notAuto.Depth = 0;
            this.notAuto.Font = new System.Drawing.Font("Roboto", 10F);
            this.notAuto.Location = new System.Drawing.Point(22, 88);
            this.notAuto.Margin = new System.Windows.Forms.Padding(0);
            this.notAuto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.notAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.notAuto.Name = "notAuto";
            this.notAuto.Ripple = true;
            this.notAuto.Size = new System.Drawing.Size(59, 30);
            this.notAuto.TabIndex = 51;
            this.notAuto.Text = "수동";
            this.notAuto.UseVisualStyleBackColor = true;
            this.notAuto.Click += new System.EventHandler(this.notAuto_Click);
            // 
            // pdL2
            // 
            this.pdL2.AutoSize = true;
            this.pdL2.Location = new System.Drawing.Point(172, 725);
            this.pdL2.Name = "pdL2";
            this.pdL2.Size = new System.Drawing.Size(29, 12);
            this.pdL2.TabIndex = 50;
            this.pdL2.Text = "픽셀";
            // 
            // pdL1
            // 
            this.pdL1.AutoSize = true;
            this.pdL1.Location = new System.Drawing.Point(172, 700);
            this.pdL1.Name = "pdL1";
            this.pdL1.Size = new System.Drawing.Size(29, 12);
            this.pdL1.TabIndex = 49;
            this.pdL1.Text = "픽셀";
            // 
            // BatchY
            // 
            this.BatchY.Depth = 0;
            this.BatchY.Hint = "";
            this.BatchY.Location = new System.Drawing.Point(147, 725);
            this.BatchY.MaxLength = 3;
            this.BatchY.MouseState = MaterialSkin.MouseState.HOVER;
            this.BatchY.Name = "BatchY";
            this.BatchY.PasswordChar = '\0';
            this.BatchY.SelectedText = "";
            this.BatchY.SelectionLength = 0;
            this.BatchY.SelectionStart = 0;
            this.BatchY.Size = new System.Drawing.Size(23, 19);
            this.BatchY.TabIndex = 48;
            this.BatchY.TabStop = false;
            this.BatchY.Text = "230";
            this.BatchY.UseSystemPasswordChar = false;
            this.BatchY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BatchY_KeyPress);
            // 
            // BatchX
            // 
            this.BatchX.Depth = 0;
            this.BatchX.Hint = "";
            this.BatchX.Location = new System.Drawing.Point(147, 700);
            this.BatchX.MaxLength = 3;
            this.BatchX.MouseState = MaterialSkin.MouseState.HOVER;
            this.BatchX.Name = "BatchX";
            this.BatchX.PasswordChar = '\0';
            this.BatchX.SelectedText = "";
            this.BatchX.SelectionLength = 0;
            this.BatchX.SelectionStart = 0;
            this.BatchX.Size = new System.Drawing.Size(23, 19);
            this.BatchX.TabIndex = 47;
            this.BatchX.TabStop = false;
            this.BatchX.Text = "240";
            this.BatchX.UseSystemPasswordChar = false;
            this.BatchX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BatchX_KeyPress);
            // 
            // yLB1
            // 
            this.yLB1.AutoSize = true;
            this.yLB1.Location = new System.Drawing.Point(40, 725);
            this.yLB1.Name = "yLB1";
            this.yLB1.Size = new System.Drawing.Size(101, 12);
            this.yLB1.TabIndex = 46;
            this.yLB1.Text = "창 Y축 배치 간격:";
            // 
            // XLB1
            // 
            this.XLB1.AutoSize = true;
            this.XLB1.Location = new System.Drawing.Point(40, 700);
            this.XLB1.Name = "XLB1";
            this.XLB1.Size = new System.Drawing.Size(101, 12);
            this.XLB1.TabIndex = 45;
            this.XLB1.Text = "창 X축 배치 간격:";
            // 
            // LB31
            // 
            this.LB31.AutoSize = true;
            this.LB31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB31.ForeColor = System.Drawing.Color.Blue;
            this.LB31.Location = new System.Drawing.Point(15, 670);
            this.LB31.Name = "LB31";
            this.LB31.Size = new System.Drawing.Size(42, 21);
            this.LB31.TabIndex = 44;
            this.LB31.Text = "기타";
            // 
            // closePC
            // 
            this.closePC.AutoSize = true;
            this.closePC.Depth = 0;
            this.closePC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closePC.Location = new System.Drawing.Point(32, 600);
            this.closePC.Margin = new System.Windows.Forms.Padding(0);
            this.closePC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.closePC.MouseState = MaterialSkin.MouseState.HOVER;
            this.closePC.Name = "closePC";
            this.closePC.Ripple = true;
            this.closePC.Size = new System.Drawing.Size(75, 30);
            this.closePC.TabIndex = 43;
            this.closePC.Text = "PC 종료";
            this.closePC.UseVisualStyleBackColor = true;
            this.closePC.Click += new System.EventHandler(this.closePC_Click);
            // 
            // closeMem
            // 
            this.closeMem.AutoSize = true;
            this.closeMem.Checked = true;
            this.closeMem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeMem.Depth = 0;
            this.closeMem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeMem.Location = new System.Drawing.Point(32, 570);
            this.closeMem.Margin = new System.Windows.Forms.Padding(0);
            this.closeMem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.closeMem.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeMem.Name = "closeMem";
            this.closeMem.Ripple = true;
            this.closeMem.Size = new System.Drawing.Size(108, 30);
            this.closeMem.TabIndex = 42;
            this.closeMem.Text = "멤테스트 종료";
            this.closeMem.UseVisualStyleBackColor = true;
            this.closeMem.Click += new System.EventHandler(this.closeMem_Click);
            // 
            // mdLB3
            // 
            this.mdLB3.AutoSize = true;
            this.mdLB3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdLB3.ForeColor = System.Drawing.Color.Blue;
            this.mdLB3.Location = new System.Drawing.Point(10, 545);
            this.mdLB3.Name = "mdLB3";
            this.mdLB3.Size = new System.Drawing.Size(94, 21);
            this.mdLB3.TabIndex = 41;
            this.mdLB3.Text = "마지막 행동";
            // 
            // OpenEM
            // 
            this.OpenEM.AutoSize = true;
            this.OpenEM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenEM.Depth = 0;
            this.OpenEM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenEM.Icon = null;
            this.OpenEM.Location = new System.Drawing.Point(37, 474);
            this.OpenEM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenEM.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenEM.Name = "OpenEM";
            this.OpenEM.Primary = true;
            this.OpenEM.Size = new System.Drawing.Size(152, 36);
            this.OpenEM.TabIndex = 40;
            this.OpenEM.Text = "오류 음악파일 경로설정";
            this.OpenEM.UseVisualStyleBackColor = true;
            this.OpenEM.Click += new System.EventHandler(this.OpenEM_Click);
            // 
            // OpenPM
            // 
            this.OpenPM.AutoSize = true;
            this.OpenPM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPM.Depth = 0;
            this.OpenPM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenPM.Icon = null;
            this.OpenPM.Location = new System.Drawing.Point(37, 435);
            this.OpenPM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenPM.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPM.Name = "OpenPM";
            this.OpenPM.Primary = true;
            this.OpenPM.Size = new System.Drawing.Size(152, 36);
            this.OpenPM.TabIndex = 39;
            this.OpenPM.Text = "통과 음악파일 경로설정";
            this.OpenPM.UseVisualStyleBackColor = true;
            this.OpenPM.Click += new System.EventHandler(this.OpenPM_Click);
            // 
            // musicRepeat
            // 
            this.musicRepeat.Depth = 0;
            this.musicRepeat.Hint = "";
            this.musicRepeat.Location = new System.Drawing.Point(37, 407);
            this.musicRepeat.MaxLength = 3;
            this.musicRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.musicRepeat.Name = "musicRepeat";
            this.musicRepeat.PasswordChar = '\0';
            this.musicRepeat.SelectedText = "";
            this.musicRepeat.SelectionLength = 0;
            this.musicRepeat.SelectionStart = 0;
            this.musicRepeat.Size = new System.Drawing.Size(23, 19);
            this.musicRepeat.TabIndex = 38;
            this.musicRepeat.TabStop = false;
            this.musicRepeat.Text = "3";
            this.musicRepeat.UseSystemPasswordChar = false;
            this.musicRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musicRepeat_KeyPress);
            // 
            // dsLB1
            // 
            this.dsLB1.AutoSize = true;
            this.dsLB1.Location = new System.Drawing.Point(64, 407);
            this.dsLB1.Name = "dsLB1";
            this.dsLB1.Size = new System.Drawing.Size(92, 12);
            this.dsLB1.TabIndex = 37;
            this.dsLB1.Text = "회 재생 (0~999)";
            // 
            // LB123
            // 
            this.LB123.AutoSize = true;
            this.LB123.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB123.ForeColor = System.Drawing.Color.Blue;
            this.LB123.Location = new System.Drawing.Point(10, 376);
            this.LB123.Name = "LB123";
            this.LB123.Size = new System.Drawing.Size(78, 21);
            this.LB123.TabIndex = 36;
            this.LB123.Text = "소리 알림";
            // 
            // capTime
            // 
            this.capTime.Depth = 0;
            this.capTime.Enabled = false;
            this.capTime.Hint = "";
            this.capTime.Location = new System.Drawing.Point(143, 267);
            this.capTime.MaxLength = 3;
            this.capTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.capTime.Name = "capTime";
            this.capTime.PasswordChar = '\0';
            this.capTime.SelectedText = "";
            this.capTime.SelectionLength = 0;
            this.capTime.SelectionStart = 0;
            this.capTime.Size = new System.Drawing.Size(25, 19);
            this.capTime.TabIndex = 35;
            this.capTime.TabStop = false;
            this.capTime.Text = "60";
            this.capTime.UseSystemPasswordChar = false;
            this.capTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capTime_KeyPress);
            // 
            // HCINText
            // 
            this.HCINText.Depth = 0;
            this.HCINText.Enabled = false;
            this.HCINText.Hint = "";
            this.HCINText.Location = new System.Drawing.Point(51, 142);
            this.HCINText.MaxLength = 3;
            this.HCINText.MouseState = MaterialSkin.MouseState.HOVER;
            this.HCINText.Name = "HCINText";
            this.HCINText.PasswordChar = '\0';
            this.HCINText.SelectedText = "";
            this.HCINText.SelectionLength = 0;
            this.HCINText.SelectionStart = 0;
            this.HCINText.Size = new System.Drawing.Size(38, 19);
            this.HCINText.TabIndex = 34;
            this.HCINText.TabStop = false;
            this.HCINText.Text = "8";
            this.HCINText.UseSystemPasswordChar = false;
            this.HCINText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HCINText_KeyPress);
            // 
            // HCIMemory
            // 
            this.HCIMemory.Depth = 0;
            this.HCIMemory.Enabled = false;
            this.HCIMemory.Hint = "";
            this.HCIMemory.Location = new System.Drawing.Point(50, 121);
            this.HCIMemory.MaxLength = 4;
            this.HCIMemory.MouseState = MaterialSkin.MouseState.HOVER;
            this.HCIMemory.Name = "HCIMemory";
            this.HCIMemory.PasswordChar = '\0';
            this.HCIMemory.SelectedText = "";
            this.HCIMemory.SelectionLength = 0;
            this.HCIMemory.SelectionStart = 0;
            this.HCIMemory.Size = new System.Drawing.Size(38, 19);
            this.HCIMemory.TabIndex = 33;
            this.HCIMemory.TabStop = false;
            this.HCIMemory.Text = "1750";
            this.HCIMemory.UseSystemPasswordChar = false;
            this.HCIMemory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HCIMemory_KeyPress);
            // 
            // HCIMax
            // 
            this.HCIMax.Depth = 0;
            this.HCIMax.Hint = "";
            this.HCIMax.Location = new System.Drawing.Point(71, 36);
            this.HCIMax.MaxLength = 4;
            this.HCIMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.HCIMax.Name = "HCIMax";
            this.HCIMax.PasswordChar = '\0';
            this.HCIMax.SelectedText = "";
            this.HCIMax.SelectionLength = 0;
            this.HCIMax.SelectionStart = 0;
            this.HCIMax.Size = new System.Drawing.Size(30, 19);
            this.HCIMax.TabIndex = 32;
            this.HCIMax.TabStop = false;
            this.HCIMax.Text = "400";
            this.HCIMax.UseSystemPasswordChar = false;
            this.HCIMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HCIMax_KeyPress);
            // 
            // lb15
            // 
            this.lb15.AutoSize = true;
            this.lb15.Location = new System.Drawing.Point(102, 36);
            this.lb15.Name = "lb15";
            this.lb15.Size = new System.Drawing.Size(15, 12);
            this.lb15.TabIndex = 31;
            this.lb15.Text = "%";
            // 
            // deLB0
            // 
            this.deLB0.AutoSize = true;
            this.deLB0.Location = new System.Drawing.Point(20, 36);
            this.deLB0.Name = "deLB0";
            this.deLB0.Size = new System.Drawing.Size(45, 12);
            this.deLB0.TabIndex = 30;
            this.deLB0.Text = "목표치:";
            // 
            // OpenSCAP
            // 
            this.OpenSCAP.AutoSize = true;
            this.OpenSCAP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenSCAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSCAP.Depth = 0;
            this.OpenSCAP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenSCAP.Icon = null;
            this.OpenSCAP.Location = new System.Drawing.Point(27, 297);
            this.OpenSCAP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenSCAP.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenSCAP.Name = "OpenSCAP";
            this.OpenSCAP.Primary = true;
            this.OpenSCAP.Size = new System.Drawing.Size(123, 36);
            this.OpenSCAP.TabIndex = 28;
            this.OpenSCAP.Text = "저장폴더 경로설정";
            this.OpenSCAP.UseVisualStyleBackColor = true;
            this.OpenSCAP.Click += new System.EventHandler(this.OpenSCAP_Click);
            // 
            // tLB1
            // 
            this.tLB1.AutoSize = true;
            this.tLB1.Enabled = false;
            this.tLB1.Location = new System.Drawing.Point(169, 267);
            this.tLB1.Name = "tLB1";
            this.tLB1.Size = new System.Drawing.Size(17, 12);
            this.tLB1.TabIndex = 27;
            this.tLB1.Text = "분";
            // 
            // capbyTime
            // 
            this.capbyTime.AutoSize = true;
            this.capbyTime.Depth = 0;
            this.capbyTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capbyTime.Location = new System.Drawing.Point(22, 261);
            this.capbyTime.Margin = new System.Windows.Forms.Padding(0);
            this.capbyTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.capbyTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.capbyTime.Name = "capbyTime";
            this.capbyTime.Ripple = true;
            this.capbyTime.Size = new System.Drawing.Size(91, 30);
            this.capbyTime.TabIndex = 25;
            this.capbyTime.Text = "주기적으로";
            this.capbyTime.UseVisualStyleBackColor = true;
            this.capbyTime.Click += new System.EventHandler(this.capbyTime_Click);
            // 
            // capAfter
            // 
            this.capAfter.AutoSize = true;
            this.capAfter.Checked = true;
            this.capAfter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.capAfter.Depth = 0;
            this.capAfter.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.capAfter.Location = new System.Drawing.Point(22, 231);
            this.capAfter.Margin = new System.Windows.Forms.Padding(0);
            this.capAfter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.capAfter.MouseState = MaterialSkin.MouseState.HOVER;
            this.capAfter.Name = "capAfter";
            this.capAfter.Ripple = true;
            this.capAfter.Size = new System.Drawing.Size(71, 30);
            this.capAfter.TabIndex = 23;
            this.capAfter.Text = "끝날 때";
            this.capAfter.UseVisualStyleBackColor = true;
            // 
            // sLB2
            // 
            this.sLB2.AutoSize = true;
            this.sLB2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLB2.ForeColor = System.Drawing.Color.Blue;
            this.sLB2.Location = new System.Drawing.Point(14, 200);
            this.sLB2.Name = "sLB2";
            this.sLB2.Size = new System.Drawing.Size(74, 21);
            this.sLB2.TabIndex = 22;
            this.sLB2.Text = "스크린샷";
            // 
            // sLB1
            // 
            this.sLB1.AutoSize = true;
            this.sLB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLB1.ForeColor = System.Drawing.Color.Blue;
            this.sLB1.Location = new System.Drawing.Point(6, 6);
            this.sLB1.Name = "sLB1";
            this.sLB1.Size = new System.Drawing.Size(58, 21);
            this.sLB1.TabIndex = 21;
            this.sLB1.Text = "테스트";
            // 
            // dLB2
            // 
            this.dLB2.AutoSize = true;
            this.dLB2.Enabled = false;
            this.dLB2.Location = new System.Drawing.Point(89, 142);
            this.dLB2.Name = "dLB2";
            this.dLB2.Size = new System.Drawing.Size(17, 12);
            this.dLB2.TabIndex = 20;
            this.dLB2.Text = "개";
            // 
            // dLB1
            // 
            this.dLB1.AutoSize = true;
            this.dLB1.Enabled = false;
            this.dLB1.Location = new System.Drawing.Point(89, 121);
            this.dLB1.Name = "dLB1";
            this.dLB1.Size = new System.Drawing.Size(24, 12);
            this.dLB1.TabIndex = 19;
            this.dLB1.Text = "MB";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            this.OpenFile.Title = "알림에 사용할 음악파일 선택";
            // 
            // tTimer
            // 
            this.tTimer.Interval = 1000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 805);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "투명도 조절:";
            // 
            // transparent
            // 
            this.transparent.Location = new System.Drawing.Point(123, 803);
            this.transparent.Minimum = 30;
            this.transparent.Name = "transparent";
            this.transparent.Size = new System.Drawing.Size(140, 17);
            this.transparent.TabIndex = 57;
            this.transparent.Value = 90;
            this.transparent.ValueChanged += new System.EventHandler(this.transparent_ValueChanged);
            // 
            // lvlb
            // 
            this.lvlb.AutoSize = true;
            this.lvlb.Location = new System.Drawing.Point(12, 841);
            this.lvlb.Name = "lvlb";
            this.lvlb.Size = new System.Drawing.Size(65, 12);
            this.lvlb.TabIndex = 58;
            this.lvlb.Text = "크기조절용";
            this.lvlb.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(322, 625);
            this.Controls.Add(this.goblog);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 1300);
            this.MinimumSize = new System.Drawing.Size(322, 250);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "EasyHCI 1.0.6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TabMain.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            this.Tab3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip Tip1;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabMain;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.LinkLabel goblog;
        private MaterialSkin.Controls.MaterialRaisedButton goTest;
        internal System.Windows.Forms.ListView LView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.Label lb2;
        private MaterialSkin.Controls.MaterialProgressBar pbUse;
        private System.Windows.Forms.Label LB1;
        private MaterialSkin.Controls.MaterialRaisedButton stopTest;
        private System.Windows.Forms.TextBox tmemText;
        private System.Windows.Forms.Label passRate;
        private System.Windows.Forms.Label elTime;
        private System.Windows.Forms.Panel Panel1;
        private MaterialSkin.Controls.MaterialRaisedButton OpenSCAP;
        private System.Windows.Forms.Label tLB1;
        private MaterialSkin.Controls.MaterialCheckBox capbyTime;
        private MaterialSkin.Controls.MaterialCheckBox capAfter;
        private System.Windows.Forms.Label sLB2;
        private System.Windows.Forms.Label sLB1;
        private System.Windows.Forms.Label dLB2;
        private System.Windows.Forms.Label dLB1;
        private MaterialSkin.Controls.MaterialCheckBox mtHide;
        private System.Windows.Forms.Label deLB0;
        private System.Windows.Forms.Label lb15;
        private MaterialSkin.Controls.MaterialSingleLineTextField HCIMax;
        private MaterialSkin.Controls.MaterialSingleLineTextField HCIMemory;
        private MaterialSkin.Controls.MaterialSingleLineTextField HCINText;
        private MaterialSkin.Controls.MaterialSingleLineTextField capTime;
        internal System.Windows.Forms.FolderBrowserDialog OpenFolder;
        internal System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label LB123;
        private MaterialSkin.Controls.MaterialSingleLineTextField musicRepeat;
        private System.Windows.Forms.Label dsLB1;
        private MaterialSkin.Controls.MaterialRaisedButton OpenEM;
        private MaterialSkin.Controls.MaterialRaisedButton OpenPM;
        private System.Windows.Forms.Label pdL2;
        private System.Windows.Forms.Label pdL1;
        private MaterialSkin.Controls.MaterialSingleLineTextField BatchY;
        private MaterialSkin.Controls.MaterialSingleLineTextField BatchX;
        private System.Windows.Forms.Label yLB1;
        private System.Windows.Forms.Label XLB1;
        private System.Windows.Forms.Label LB31;
        private MaterialSkin.Controls.MaterialCheckBox closePC;
        private MaterialSkin.Controls.MaterialCheckBox closeMem;
        private System.Windows.Forms.Label mdLB3;
        private MaterialSkin.Controls.MaterialRadioButton notAuto;
        private MaterialSkin.Controls.MaterialRadioButton YAuto;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.Label memGap;
        private MaterialSkin.Controls.MaterialCheckBox instant;
        private System.Windows.Forms.HScrollBar transparent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lvlb;
    }
}

