namespace EasyHCI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.check_version = new System.Windows.Forms.LinkLabel();
            this.test_hide = new MaterialSkin.Controls.MaterialCheckBox();
            this.ram_usage_label = new System.Windows.Forms.Label();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabMain = new MaterialSkin.Controls.MaterialTabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.line_2 = new System.Windows.Forms.Label();
            this.line_1 = new System.Windows.Forms.Label();
            this.remained_time = new System.Windows.Forms.Label();
            this.elapsed_time = new System.Windows.Forms.Label();
            this.elapsed_time_title = new System.Windows.Forms.Label();
            this.deviation_label = new System.Windows.Forms.Label();
            this.deviation_title = new System.Windows.Forms.Label();
            this.passRate_avg = new System.Windows.Forms.Label();
            this.passRate_min = new System.Windows.Forms.Label();
            this.ram_usage = new EasyHCI.Functions.UI.Slider();
            this.test = new System.Windows.Forms.Button();
            this.passRate_title = new System.Windows.Forms.Label();
            this.ram_usage_title = new System.Windows.Forms.Label();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.interval_test_bar = new EasyHCI.Functions.UI.Slider();
            this.interval_memory_bar = new EasyHCI.Functions.UI.Slider();
            this.label1 = new System.Windows.Forms.Label();
            this.interval_memory_title = new System.Windows.Forms.Label();
            this.interval_test_label = new System.Windows.Forms.Label();
            this.interval_memory_label = new System.Windows.Forms.Label();
            this.interval_test = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.interval_memory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.test_std_avg = new MaterialSkin.Controls.MaterialCheckBox();
            this.test_std_min = new MaterialSkin.Controls.MaterialCheckBox();
            this.test_std_title = new System.Windows.Forms.Label();
            this.extra_title = new System.Windows.Forms.Label();
            this.openProcessList = new System.Windows.Forms.Button();
            this.transparency_bar = new EasyHCI.Functions.UI.Slider();
            this.ramUsageBar_backColor = new System.Windows.Forms.PictureBox();
            this.ramUsageBar_foreColor = new System.Windows.Forms.PictureBox();
            this.ramUsageBar_title = new System.Windows.Forms.Label();
            this.layout_y_bar = new EasyHCI.Functions.UI.Slider();
            this.layout_x_bar = new EasyHCI.Functions.UI.Slider();
            this.layout_y_title = new System.Windows.Forms.Label();
            this.layout_x_title = new System.Windows.Forms.Label();
            this.notify_test = new System.Windows.Forms.Button();
            this.notify_volume_bar = new EasyHCI.Functions.UI.Slider();
            this.notify_volume = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.notify_volume_title = new System.Windows.Forms.Label();
            this.notify_count_bar = new EasyHCI.Functions.UI.Slider();
            this.finish_restartPC = new MaterialSkin.Controls.MaterialCheckBox();
            this.notify_error_setPath = new System.Windows.Forms.Button();
            this.notify_success_setPath = new System.Windows.Forms.Button();
            this.notify_error_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.notify_error_title = new System.Windows.Forms.Label();
            this.notify_success_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.notify_success_title = new System.Windows.Forms.Label();
            this.screenshot_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.screenshot_path_title = new System.Windows.Forms.Label();
            this.test_except_bar = new EasyHCI.Functions.UI.Slider();
            this.test_target_bar = new EasyHCI.Functions.UI.Slider();
            this.screenshot_cycle_time_bar = new EasyHCI.Functions.UI.Slider();
            this.screenshot_quality_low = new MaterialSkin.Controls.MaterialCheckBox();
            this.screenshot_quality_middle = new MaterialSkin.Controls.MaterialCheckBox();
            this.screenshot_quality_high = new MaterialSkin.Controls.MaterialCheckBox();
            this.screenshot_setPath = new System.Windows.Forms.Button();
            this.screenshot_quality_title = new System.Windows.Forms.Label();
            this.test_manual = new MaterialSkin.Controls.MaterialCheckBox();
            this.test_except_title = new System.Windows.Forms.Label();
            this.test_except = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.test_except_label_1 = new System.Windows.Forms.Label();
            this.label_for_size = new System.Windows.Forms.Label();
            this.transparency_title = new System.Windows.Forms.Label();
            this.instant = new MaterialSkin.Controls.MaterialCheckBox();
            this.layout_y_label = new System.Windows.Forms.Label();
            this.layout_x_label = new System.Windows.Forms.Label();
            this.layout_y = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.layout_x = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.layout_title = new System.Windows.Forms.Label();
            this.finish_closePC = new MaterialSkin.Controls.MaterialCheckBox();
            this.finish_closeTest = new MaterialSkin.Controls.MaterialCheckBox();
            this.finish_title = new System.Windows.Forms.Label();
            this.notify_count = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.notify_count_label = new System.Windows.Forms.Label();
            this.notify_title = new System.Windows.Forms.Label();
            this.screenshot_cycle_time = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.test_manual_count = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.test_manual_ammount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.test_target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.test_target_label_1 = new System.Windows.Forms.Label();
            this.test_target_title = new System.Windows.Forms.Label();
            this.screenshot_cycle_label = new System.Windows.Forms.Label();
            this.screenshot_cycle = new MaterialSkin.Controls.MaterialCheckBox();
            this.screenshot_after = new MaterialSkin.Controls.MaterialCheckBox();
            this.screenshot_title = new System.Windows.Forms.Label();
            this.test_title = new System.Windows.Forms.Label();
            this.test_manual_label_2 = new System.Windows.Forms.Label();
            this.test_manual_label_1 = new System.Windows.Forms.Label();
            this.dialog_open_directory = new System.Windows.Forms.FolderBrowserDialog();
            this.dialog_open_file = new System.Windows.Forms.OpenFileDialog();
            this.TabMain.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.Tab3.SuspendLayout();
            this.panel_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageBar_backColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageBar_foreColor)).BeginInit();
            this.SuspendLayout();
            // 
            // check_version
            // 
            this.check_version.ActiveLinkColor = System.Drawing.Color.White;
            this.check_version.AutoSize = true;
            this.check_version.BackColor = System.Drawing.Color.Transparent;
            this.check_version.DisabledLinkColor = System.Drawing.Color.White;
            this.check_version.LinkColor = System.Drawing.Color.White;
            this.check_version.Location = new System.Drawing.Point(140, 38);
            this.check_version.Name = "check_version";
            this.check_version.Size = new System.Drawing.Size(81, 12);
            this.check_version.TabIndex = 6;
            this.check_version.TabStop = true;
            this.check_version.Text = "업데이트 확인";
            this.check_version.VisitedLinkColor = System.Drawing.Color.White;
            this.check_version.Click += new System.EventHandler(this.check_version_Click);
            // 
            // test_hide
            // 
            this.test_hide.AutoSize = true;
            this.test_hide.Checked = true;
            this.test_hide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.test_hide.Depth = 0;
            this.test_hide.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test_hide.Location = new System.Drawing.Point(35, 168);
            this.test_hide.Margin = new System.Windows.Forms.Padding(0);
            this.test_hide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.test_hide.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_hide.Name = "test_hide";
            this.test_hide.Ripple = true;
            this.test_hide.Size = new System.Drawing.Size(124, 30);
            this.test_hide.TabIndex = 29;
            this.test_hide.Text = "테스트 창 숨기기";
            this.test_hide.UseVisualStyleBackColor = true;
            this.test_hide.Click += new System.EventHandler(this.test_hide_Click);
            // 
            // ram_usage_label
            // 
            this.ram_usage_label.AutoSize = true;
            this.ram_usage_label.Location = new System.Drawing.Point(501, 69);
            this.ram_usage_label.Name = "ram_usage_label";
            this.ram_usage_label.Size = new System.Drawing.Size(37, 12);
            this.ram_usage_label.TabIndex = 58;
            this.ram_usage_label.Text = "98.9%";
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BaseTabControl = this.TabMain;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TabSelector.Location = new System.Drawing.Point(-13, 61);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(863, 28);
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
            this.TabMain.Size = new System.Drawing.Size(662, 524);
            this.TabMain.TabIndex = 20;
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.line_2);
            this.Tab1.Controls.Add(this.line_1);
            this.Tab1.Controls.Add(this.remained_time);
            this.Tab1.Controls.Add(this.elapsed_time);
            this.Tab1.Controls.Add(this.elapsed_time_title);
            this.Tab1.Controls.Add(this.deviation_label);
            this.Tab1.Controls.Add(this.deviation_title);
            this.Tab1.Controls.Add(this.passRate_avg);
            this.Tab1.Controls.Add(this.passRate_min);
            this.Tab1.Controls.Add(this.ram_usage);
            this.Tab1.Controls.Add(this.test);
            this.Tab1.Controls.Add(this.passRate_title);
            this.Tab1.Controls.Add(this.ram_usage_label);
            this.Tab1.Controls.Add(this.ram_usage_title);
            this.Tab1.Location = new System.Drawing.Point(4, 22);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(654, 498);
            this.Tab1.TabIndex = 5;
            this.Tab1.Text = "테스트";
            this.Tab1.UseVisualStyleBackColor = true;
            // 
            // line_2
            // 
            this.line_2.AutoSize = true;
            this.line_2.ForeColor = System.Drawing.Color.DarkGray;
            this.line_2.Location = new System.Drawing.Point(18, 253);
            this.line_2.Name = "line_2";
            this.line_2.Size = new System.Drawing.Size(635, 12);
            this.line_2.TabIndex = 75;
            this.line_2.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // line_1
            // 
            this.line_1.AutoSize = true;
            this.line_1.ForeColor = System.Drawing.Color.DarkGray;
            this.line_1.Location = new System.Drawing.Point(18, 113);
            this.line_1.Name = "line_1";
            this.line_1.Size = new System.Drawing.Size(635, 12);
            this.line_1.TabIndex = 74;
            this.line_1.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // remained_time
            // 
            this.remained_time.AutoSize = true;
            this.remained_time.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remained_time.Location = new System.Drawing.Point(404, 208);
            this.remained_time.Name = "remained_time";
            this.remained_time.Size = new System.Drawing.Size(176, 12);
            this.remained_time.TabIndex = 73;
            this.remained_time.Text = "남은 시간: 00시간 00분 00초";
            // 
            // elapsed_time
            // 
            this.elapsed_time.AutoSize = true;
            this.elapsed_time.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.elapsed_time.Location = new System.Drawing.Point(404, 184);
            this.elapsed_time.Name = "elapsed_time";
            this.elapsed_time.Size = new System.Drawing.Size(176, 12);
            this.elapsed_time.TabIndex = 72;
            this.elapsed_time.Text = "경과 시간: 00시간 00분 00초";
            // 
            // elapsed_time_title
            // 
            this.elapsed_time_title.AutoSize = true;
            this.elapsed_time_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.elapsed_time_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.elapsed_time_title.Location = new System.Drawing.Point(385, 146);
            this.elapsed_time_title.Name = "elapsed_time_title";
            this.elapsed_time_title.Size = new System.Drawing.Size(50, 25);
            this.elapsed_time_title.TabIndex = 71;
            this.elapsed_time_title.Text = "시간";
            // 
            // deviation_label
            // 
            this.deviation_label.AutoSize = true;
            this.deviation_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deviation_label.Location = new System.Drawing.Point(219, 184);
            this.deviation_label.Name = "deviation_label";
            this.deviation_label.Size = new System.Drawing.Size(23, 12);
            this.deviation_label.TabIndex = 70;
            this.deviation_label.Text = "0%";
            // 
            // deviation_title
            // 
            this.deviation_title.AutoSize = true;
            this.deviation_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.deviation_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.deviation_title.Location = new System.Drawing.Point(200, 146);
            this.deviation_title.Name = "deviation_title";
            this.deviation_title.Size = new System.Drawing.Size(50, 25);
            this.deviation_title.TabIndex = 69;
            this.deviation_title.Text = "편차";
            // 
            // passRate_avg
            // 
            this.passRate_avg.AutoSize = true;
            this.passRate_avg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passRate_avg.Location = new System.Drawing.Point(34, 208);
            this.passRate_avg.Name = "passRate_avg";
            this.passRate_avg.Size = new System.Drawing.Size(72, 12);
            this.passRate_avg.TabIndex = 68;
            this.passRate_avg.Text = "평균치: 0%";
            // 
            // passRate_min
            // 
            this.passRate_min.AutoSize = true;
            this.passRate_min.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passRate_min.Location = new System.Drawing.Point(34, 184);
            this.passRate_min.Name = "passRate_min";
            this.passRate_min.Size = new System.Drawing.Size(72, 12);
            this.passRate_min.TabIndex = 67;
            this.passRate_min.Text = "최소치: 0%";
            // 
            // ram_usage
            // 
            this.ram_usage.BarBackColor = System.Drawing.Color.DimGray;
            this.ram_usage.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ram_usage.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ram_usage.Location = new System.Drawing.Point(116, 66);
            this.ram_usage.Max = 999999F;
            this.ram_usage.Min = 0F;
            this.ram_usage.Name = "ram_usage";
            this.ram_usage.Size = new System.Drawing.Size(379, 17);
            this.ram_usage.TabIndex = 66;
            this.ram_usage.UseBox = false;
            this.ram_usage.Value = 30F;
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Image = ((System.Drawing.Image)(resources.GetObject("test.Image")));
            this.test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.test.Location = new System.Drawing.Point(15, 15);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(523, 39);
            this.test.TabIndex = 65;
            this.test.Text = "테스트 시작";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // passRate_title
            // 
            this.passRate_title.AutoSize = true;
            this.passRate_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.passRate_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.passRate_title.Location = new System.Drawing.Point(15, 146);
            this.passRate_title.Name = "passRate_title";
            this.passRate_title.Size = new System.Drawing.Size(69, 25);
            this.passRate_title.TabIndex = 62;
            this.passRate_title.Text = "통과율";
            // 
            // ram_usage_title
            // 
            this.ram_usage_title.AutoSize = true;
            this.ram_usage_title.Location = new System.Drawing.Point(13, 69);
            this.ram_usage_title.Name = "ram_usage_title";
            this.ram_usage_title.Size = new System.Drawing.Size(97, 12);
            this.ram_usage_title.TabIndex = 56;
            this.ram_usage_title.Text = "사용중인 메모리:";
            // 
            // Tab3
            // 
            this.Tab3.Controls.Add(this.panel_settings);
            this.Tab3.Location = new System.Drawing.Point(4, 22);
            this.Tab3.Name = "Tab3";
            this.Tab3.Padding = new System.Windows.Forms.Padding(3);
            this.Tab3.Size = new System.Drawing.Size(654, 498);
            this.Tab3.TabIndex = 7;
            this.Tab3.Text = "설정";
            this.Tab3.UseVisualStyleBackColor = true;
            // 
            // panel_settings
            // 
            this.panel_settings.AutoScroll = true;
            this.panel_settings.BackColor = System.Drawing.Color.White;
            this.panel_settings.Controls.Add(this.interval_test_bar);
            this.panel_settings.Controls.Add(this.interval_memory_bar);
            this.panel_settings.Controls.Add(this.label1);
            this.panel_settings.Controls.Add(this.interval_memory_title);
            this.panel_settings.Controls.Add(this.interval_test_label);
            this.panel_settings.Controls.Add(this.interval_memory_label);
            this.panel_settings.Controls.Add(this.interval_test);
            this.panel_settings.Controls.Add(this.interval_memory);
            this.panel_settings.Controls.Add(this.test_std_avg);
            this.panel_settings.Controls.Add(this.test_std_min);
            this.panel_settings.Controls.Add(this.test_std_title);
            this.panel_settings.Controls.Add(this.extra_title);
            this.panel_settings.Controls.Add(this.openProcessList);
            this.panel_settings.Controls.Add(this.transparency_bar);
            this.panel_settings.Controls.Add(this.ramUsageBar_backColor);
            this.panel_settings.Controls.Add(this.ramUsageBar_foreColor);
            this.panel_settings.Controls.Add(this.ramUsageBar_title);
            this.panel_settings.Controls.Add(this.layout_y_bar);
            this.panel_settings.Controls.Add(this.layout_x_bar);
            this.panel_settings.Controls.Add(this.layout_y_title);
            this.panel_settings.Controls.Add(this.layout_x_title);
            this.panel_settings.Controls.Add(this.notify_test);
            this.panel_settings.Controls.Add(this.notify_volume_bar);
            this.panel_settings.Controls.Add(this.notify_volume);
            this.panel_settings.Controls.Add(this.notify_volume_title);
            this.panel_settings.Controls.Add(this.notify_count_bar);
            this.panel_settings.Controls.Add(this.finish_restartPC);
            this.panel_settings.Controls.Add(this.notify_error_setPath);
            this.panel_settings.Controls.Add(this.notify_success_setPath);
            this.panel_settings.Controls.Add(this.notify_error_path);
            this.panel_settings.Controls.Add(this.notify_error_title);
            this.panel_settings.Controls.Add(this.notify_success_path);
            this.panel_settings.Controls.Add(this.notify_success_title);
            this.panel_settings.Controls.Add(this.screenshot_path);
            this.panel_settings.Controls.Add(this.screenshot_path_title);
            this.panel_settings.Controls.Add(this.test_except_bar);
            this.panel_settings.Controls.Add(this.test_target_bar);
            this.panel_settings.Controls.Add(this.screenshot_cycle_time_bar);
            this.panel_settings.Controls.Add(this.screenshot_quality_low);
            this.panel_settings.Controls.Add(this.screenshot_quality_middle);
            this.panel_settings.Controls.Add(this.screenshot_quality_high);
            this.panel_settings.Controls.Add(this.screenshot_setPath);
            this.panel_settings.Controls.Add(this.screenshot_quality_title);
            this.panel_settings.Controls.Add(this.test_manual);
            this.panel_settings.Controls.Add(this.test_except_title);
            this.panel_settings.Controls.Add(this.test_except);
            this.panel_settings.Controls.Add(this.test_except_label_1);
            this.panel_settings.Controls.Add(this.label_for_size);
            this.panel_settings.Controls.Add(this.transparency_title);
            this.panel_settings.Controls.Add(this.instant);
            this.panel_settings.Controls.Add(this.layout_y_label);
            this.panel_settings.Controls.Add(this.layout_x_label);
            this.panel_settings.Controls.Add(this.layout_y);
            this.panel_settings.Controls.Add(this.layout_x);
            this.panel_settings.Controls.Add(this.layout_title);
            this.panel_settings.Controls.Add(this.finish_closePC);
            this.panel_settings.Controls.Add(this.finish_closeTest);
            this.panel_settings.Controls.Add(this.finish_title);
            this.panel_settings.Controls.Add(this.notify_count);
            this.panel_settings.Controls.Add(this.notify_count_label);
            this.panel_settings.Controls.Add(this.notify_title);
            this.panel_settings.Controls.Add(this.screenshot_cycle_time);
            this.panel_settings.Controls.Add(this.test_manual_count);
            this.panel_settings.Controls.Add(this.test_manual_ammount);
            this.panel_settings.Controls.Add(this.test_target);
            this.panel_settings.Controls.Add(this.test_target_label_1);
            this.panel_settings.Controls.Add(this.test_target_title);
            this.panel_settings.Controls.Add(this.test_hide);
            this.panel_settings.Controls.Add(this.screenshot_cycle_label);
            this.panel_settings.Controls.Add(this.screenshot_cycle);
            this.panel_settings.Controls.Add(this.screenshot_after);
            this.panel_settings.Controls.Add(this.screenshot_title);
            this.panel_settings.Controls.Add(this.test_title);
            this.panel_settings.Controls.Add(this.test_manual_label_2);
            this.panel_settings.Controls.Add(this.test_manual_label_1);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings.Location = new System.Drawing.Point(3, 3);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(648, 492);
            this.panel_settings.TabIndex = 13;
            // 
            // interval_test_bar
            // 
            this.interval_test_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.interval_test_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.interval_test_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.interval_test_bar.Location = new System.Drawing.Point(196, 1635);
            this.interval_test_bar.Max = 3000F;
            this.interval_test_bar.Min = 100F;
            this.interval_test_bar.Name = "interval_test_bar";
            this.interval_test_bar.Size = new System.Drawing.Size(319, 18);
            this.interval_test_bar.TabIndex = 112;
            this.interval_test_bar.UseBox = true;
            this.interval_test_bar.Value = 1500F;
            this.interval_test_bar.ValueChanged += new System.EventHandler(this.interval_test_bar_ValueChanged);
            // 
            // interval_memory_bar
            // 
            this.interval_memory_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.interval_memory_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.interval_memory_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.interval_memory_bar.Location = new System.Drawing.Point(196, 1602);
            this.interval_memory_bar.Max = 3000F;
            this.interval_memory_bar.Min = 100F;
            this.interval_memory_bar.Name = "interval_memory_bar";
            this.interval_memory_bar.Size = new System.Drawing.Size(319, 18);
            this.interval_memory_bar.TabIndex = 111;
            this.interval_memory_bar.UseBox = true;
            this.interval_memory_bar.Value = 1500F;
            this.interval_memory_bar.ValueChanged += new System.EventHandler(this.interval_memory_bar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 1639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 110;
            this.label1.Text = "모니터링 주기 - 테스트:";
            // 
            // interval_memory_title
            // 
            this.interval_memory_title.AutoSize = true;
            this.interval_memory_title.Location = new System.Drawing.Point(39, 1606);
            this.interval_memory_title.Name = "interval_memory_title";
            this.interval_memory_title.Size = new System.Drawing.Size(135, 12);
            this.interval_memory_title.TabIndex = 109;
            this.interval_memory_title.Text = "모니터링 주기 - 메모리:";
            // 
            // interval_test_label
            // 
            this.interval_test_label.AutoSize = true;
            this.interval_test_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.interval_test_label.Location = new System.Drawing.Point(579, 1638);
            this.interval_test_label.Name = "interval_test_label";
            this.interval_test_label.Size = new System.Drawing.Size(25, 12);
            this.interval_test_label.TabIndex = 108;
            this.interval_test_label.Text = "ms";
            // 
            // interval_memory_label
            // 
            this.interval_memory_label.AutoSize = true;
            this.interval_memory_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.interval_memory_label.Location = new System.Drawing.Point(578, 1606);
            this.interval_memory_label.Name = "interval_memory_label";
            this.interval_memory_label.Size = new System.Drawing.Size(25, 12);
            this.interval_memory_label.TabIndex = 107;
            this.interval_memory_label.Text = "ms";
            // 
            // interval_test
            // 
            this.interval_test.Depth = 0;
            this.interval_test.Hint = "";
            this.interval_test.Location = new System.Drawing.Point(530, 1637);
            this.interval_test.MaxLength = 5;
            this.interval_test.MouseState = MaterialSkin.MouseState.HOVER;
            this.interval_test.Name = "interval_test";
            this.interval_test.PasswordChar = '\0';
            this.interval_test.SelectedText = "";
            this.interval_test.SelectionLength = 0;
            this.interval_test.SelectionStart = 0;
            this.interval_test.Size = new System.Drawing.Size(45, 19);
            this.interval_test.TabIndex = 106;
            this.interval_test.TabStop = false;
            this.interval_test.Text = "1500";
            this.interval_test.UseSystemPasswordChar = false;
            // 
            // interval_memory
            // 
            this.interval_memory.Depth = 0;
            this.interval_memory.Hint = "";
            this.interval_memory.Location = new System.Drawing.Point(530, 1605);
            this.interval_memory.MaxLength = 5;
            this.interval_memory.MouseState = MaterialSkin.MouseState.HOVER;
            this.interval_memory.Name = "interval_memory";
            this.interval_memory.PasswordChar = '\0';
            this.interval_memory.SelectedText = "";
            this.interval_memory.SelectionLength = 0;
            this.interval_memory.SelectionStart = 0;
            this.interval_memory.Size = new System.Drawing.Size(45, 19);
            this.interval_memory.TabIndex = 105;
            this.interval_memory.TabStop = false;
            this.interval_memory.Text = "1500";
            this.interval_memory.UseSystemPasswordChar = false;
            // 
            // test_std_avg
            // 
            this.test_std_avg.AutoSize = true;
            this.test_std_avg.Depth = 0;
            this.test_std_avg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test_std_avg.Location = new System.Drawing.Point(305, 120);
            this.test_std_avg.Margin = new System.Windows.Forms.Padding(0);
            this.test_std_avg.MouseLocation = new System.Drawing.Point(-1, -1);
            this.test_std_avg.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_std_avg.Name = "test_std_avg";
            this.test_std_avg.Ripple = true;
            this.test_std_avg.Size = new System.Drawing.Size(54, 30);
            this.test_std_avg.TabIndex = 104;
            this.test_std_avg.Text = "평균";
            this.test_std_avg.UseVisualStyleBackColor = true;
            this.test_std_avg.Click += new System.EventHandler(this.test_std_avg_Click);
            // 
            // test_std_min
            // 
            this.test_std_min.AutoSize = true;
            this.test_std_min.Checked = true;
            this.test_std_min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.test_std_min.Depth = 0;
            this.test_std_min.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test_std_min.Location = new System.Drawing.Point(200, 120);
            this.test_std_min.Margin = new System.Windows.Forms.Padding(0);
            this.test_std_min.MouseLocation = new System.Drawing.Point(-1, -1);
            this.test_std_min.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_std_min.Name = "test_std_min";
            this.test_std_min.Ripple = true;
            this.test_std_min.Size = new System.Drawing.Size(54, 30);
            this.test_std_min.TabIndex = 103;
            this.test_std_min.Text = "최소";
            this.test_std_min.UseVisualStyleBackColor = true;
            this.test_std_min.Click += new System.EventHandler(this.test_std_min_Click);
            // 
            // test_std_title
            // 
            this.test_std_title.AutoSize = true;
            this.test_std_title.Location = new System.Drawing.Point(39, 128);
            this.test_std_title.Name = "test_std_title";
            this.test_std_title.Size = new System.Drawing.Size(61, 12);
            this.test_std_title.TabIndex = 102;
            this.test_std_title.Text = "통과 기준:";
            // 
            // extra_title
            // 
            this.extra_title.AutoSize = true;
            this.extra_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.extra_title.ForeColor = System.Drawing.Color.Blue;
            this.extra_title.Location = new System.Drawing.Point(24, 1550);
            this.extra_title.Name = "extra_title";
            this.extra_title.Size = new System.Drawing.Size(50, 25);
            this.extra_title.TabIndex = 101;
            this.extra_title.Text = "기타";
            // 
            // openProcessList
            // 
            this.openProcessList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.openProcessList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openProcessList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openProcessList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.openProcessList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.openProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProcessList.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.openProcessList.ForeColor = System.Drawing.Color.White;
            this.openProcessList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openProcessList.Location = new System.Drawing.Point(41, 1740);
            this.openProcessList.Name = "openProcessList";
            this.openProcessList.Size = new System.Drawing.Size(208, 39);
            this.openProcessList.TabIndex = 100;
            this.openProcessList.Text = "메모리 정리 예외 프로세스 설정";
            this.openProcessList.UseVisualStyleBackColor = false;
            this.openProcessList.Click += new System.EventHandler(this.openProcessList_Click);
            // 
            // transparency_bar
            // 
            this.transparency_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.transparency_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.transparency_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.transparency_bar.Location = new System.Drawing.Point(196, 1393);
            this.transparency_bar.Max = 100F;
            this.transparency_bar.Min = 25F;
            this.transparency_bar.Name = "transparency_bar";
            this.transparency_bar.Size = new System.Drawing.Size(319, 18);
            this.transparency_bar.TabIndex = 99;
            this.transparency_bar.UseBox = true;
            this.transparency_bar.Value = 95F;
            this.transparency_bar.ValueChanged += new System.EventHandler(this.transparency_bar_ValueChanged);
            // 
            // ramUsageBar_backColor
            // 
            this.ramUsageBar_backColor.BackColor = System.Drawing.Color.DimGray;
            this.ramUsageBar_backColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramUsageBar_backColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ramUsageBar_backColor.Location = new System.Drawing.Point(264, 1427);
            this.ramUsageBar_backColor.Name = "ramUsageBar_backColor";
            this.ramUsageBar_backColor.Size = new System.Drawing.Size(44, 36);
            this.ramUsageBar_backColor.TabIndex = 98;
            this.ramUsageBar_backColor.TabStop = false;
            this.ramUsageBar_backColor.Click += new System.EventHandler(this.ramUsageBar_backColor_Click);
            // 
            // ramUsageBar_foreColor
            // 
            this.ramUsageBar_foreColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ramUsageBar_foreColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramUsageBar_foreColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ramUsageBar_foreColor.Location = new System.Drawing.Point(205, 1427);
            this.ramUsageBar_foreColor.Name = "ramUsageBar_foreColor";
            this.ramUsageBar_foreColor.Size = new System.Drawing.Size(44, 36);
            this.ramUsageBar_foreColor.TabIndex = 97;
            this.ramUsageBar_foreColor.TabStop = false;
            this.ramUsageBar_foreColor.Click += new System.EventHandler(this.ramUsageBar_foreColor_Click);
            // 
            // ramUsageBar_title
            // 
            this.ramUsageBar_title.AutoSize = true;
            this.ramUsageBar_title.Location = new System.Drawing.Point(39, 1440);
            this.ramUsageBar_title.Name = "ramUsageBar_title";
            this.ramUsageBar_title.Size = new System.Drawing.Size(123, 12);
            this.ramUsageBar_title.TabIndex = 96;
            this.ramUsageBar_title.Text = "메모리 사용량 - 색상:";
            // 
            // layout_y_bar
            // 
            this.layout_y_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.layout_y_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.layout_y_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.layout_y_bar.Location = new System.Drawing.Point(196, 1342);
            this.layout_y_bar.Max = 250F;
            this.layout_y_bar.Min = 0F;
            this.layout_y_bar.Name = "layout_y_bar";
            this.layout_y_bar.Size = new System.Drawing.Size(319, 18);
            this.layout_y_bar.TabIndex = 95;
            this.layout_y_bar.UseBox = true;
            this.layout_y_bar.Value = 90F;
            this.layout_y_bar.ValueChanged += new System.EventHandler(this.layout_y_bar_ValueChanged);
            // 
            // layout_x_bar
            // 
            this.layout_x_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.layout_x_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.layout_x_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.layout_x_bar.Location = new System.Drawing.Point(196, 1309);
            this.layout_x_bar.Max = 250F;
            this.layout_x_bar.Min = 0F;
            this.layout_x_bar.Name = "layout_x_bar";
            this.layout_x_bar.Size = new System.Drawing.Size(319, 18);
            this.layout_x_bar.TabIndex = 94;
            this.layout_x_bar.UseBox = true;
            this.layout_x_bar.Value = 90F;
            this.layout_x_bar.ValueChanged += new System.EventHandler(this.layout_x_bar_ValueChanged);
            // 
            // layout_y_title
            // 
            this.layout_y_title.AutoSize = true;
            this.layout_y_title.Location = new System.Drawing.Point(39, 1346);
            this.layout_y_title.Name = "layout_y_title";
            this.layout_y_title.Size = new System.Drawing.Size(147, 12);
            this.layout_y_title.TabIndex = 93;
            this.layout_y_title.Text = "테스트 창 배치간격 - Y축:";
            // 
            // layout_x_title
            // 
            this.layout_x_title.AutoSize = true;
            this.layout_x_title.Location = new System.Drawing.Point(39, 1313);
            this.layout_x_title.Name = "layout_x_title";
            this.layout_x_title.Size = new System.Drawing.Size(147, 12);
            this.layout_x_title.TabIndex = 88;
            this.layout_x_title.Text = "테스트 창 배치간격 - X축:";
            // 
            // notify_test
            // 
            this.notify_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.notify_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notify_test.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notify_test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.notify_test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.notify_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notify_test.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.notify_test.ForeColor = System.Drawing.Color.White;
            this.notify_test.Image = ((System.Drawing.Image)(resources.GetObject("notify_test.Image")));
            this.notify_test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notify_test.Location = new System.Drawing.Point(201, 785);
            this.notify_test.Name = "notify_test";
            this.notify_test.Size = new System.Drawing.Size(374, 39);
            this.notify_test.TabIndex = 87;
            this.notify_test.Text = "소리알림 테스트 시작";
            this.notify_test.UseVisualStyleBackColor = false;
            this.notify_test.Click += new System.EventHandler(this.notify_test_Click);
            // 
            // notify_volume_bar
            // 
            this.notify_volume_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.notify_volume_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.notify_volume_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.notify_volume_bar.Location = new System.Drawing.Point(196, 752);
            this.notify_volume_bar.Max = 100F;
            this.notify_volume_bar.Min = 0F;
            this.notify_volume_bar.Name = "notify_volume_bar";
            this.notify_volume_bar.Size = new System.Drawing.Size(320, 18);
            this.notify_volume_bar.TabIndex = 86;
            this.notify_volume_bar.UseBox = true;
            this.notify_volume_bar.Value = 70F;
            this.notify_volume_bar.ValueChanged += new System.EventHandler(this.notify_volume_bar_ValueChanged);
            // 
            // notify_volume
            // 
            this.notify_volume.Depth = 0;
            this.notify_volume.Hint = "";
            this.notify_volume.Location = new System.Drawing.Point(530, 753);
            this.notify_volume.MaxLength = 3;
            this.notify_volume.MouseState = MaterialSkin.MouseState.HOVER;
            this.notify_volume.Name = "notify_volume";
            this.notify_volume.PasswordChar = '\0';
            this.notify_volume.SelectedText = "";
            this.notify_volume.SelectionLength = 0;
            this.notify_volume.SelectionStart = 0;
            this.notify_volume.Size = new System.Drawing.Size(45, 19);
            this.notify_volume.TabIndex = 85;
            this.notify_volume.TabStop = false;
            this.notify_volume.Text = "70";
            this.notify_volume.UseSystemPasswordChar = false;
            // 
            // notify_volume_title
            // 
            this.notify_volume_title.AutoSize = true;
            this.notify_volume_title.Location = new System.Drawing.Point(39, 756);
            this.notify_volume_title.Name = "notify_volume_title";
            this.notify_volume_title.Size = new System.Drawing.Size(33, 12);
            this.notify_volume_title.TabIndex = 84;
            this.notify_volume_title.Text = "볼륨:";
            // 
            // notify_count_bar
            // 
            this.notify_count_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.notify_count_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.notify_count_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.notify_count_bar.Location = new System.Drawing.Point(196, 719);
            this.notify_count_bar.Max = 50F;
            this.notify_count_bar.Min = 0F;
            this.notify_count_bar.Name = "notify_count_bar";
            this.notify_count_bar.Size = new System.Drawing.Size(320, 18);
            this.notify_count_bar.TabIndex = 83;
            this.notify_count_bar.UseBox = true;
            this.notify_count_bar.Value = 5F;
            this.notify_count_bar.ValueChanged += new System.EventHandler(this.notify_count_bar_ValueChanged);
            // 
            // finish_restartPC
            // 
            this.finish_restartPC.AutoSize = true;
            this.finish_restartPC.Depth = 0;
            this.finish_restartPC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.finish_restartPC.Location = new System.Drawing.Point(36, 1144);
            this.finish_restartPC.Margin = new System.Windows.Forms.Padding(0);
            this.finish_restartPC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.finish_restartPC.MouseState = MaterialSkin.MouseState.HOVER;
            this.finish_restartPC.Name = "finish_restartPC";
            this.finish_restartPC.Ripple = true;
            this.finish_restartPC.Size = new System.Drawing.Size(87, 30);
            this.finish_restartPC.TabIndex = 82;
            this.finish_restartPC.Text = "PC 재시작";
            this.finish_restartPC.UseVisualStyleBackColor = true;
            this.finish_restartPC.Click += new System.EventHandler(this.finish_restartPC_Click);
            // 
            // notify_error_setPath
            // 
            this.notify_error_setPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.notify_error_setPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notify_error_setPath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notify_error_setPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.notify_error_setPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.notify_error_setPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notify_error_setPath.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.notify_error_setPath.ForeColor = System.Drawing.Color.White;
            this.notify_error_setPath.Image = ((System.Drawing.Image)(resources.GetObject("notify_error_setPath.Image")));
            this.notify_error_setPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notify_error_setPath.Location = new System.Drawing.Point(530, 905);
            this.notify_error_setPath.Name = "notify_error_setPath";
            this.notify_error_setPath.Size = new System.Drawing.Size(99, 25);
            this.notify_error_setPath.TabIndex = 81;
            this.notify_error_setPath.Text = "찾아보기";
            this.notify_error_setPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notify_error_setPath.UseVisualStyleBackColor = false;
            this.notify_error_setPath.Click += new System.EventHandler(this.notify_error_setPath_Click);
            // 
            // notify_success_setPath
            // 
            this.notify_success_setPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.notify_success_setPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notify_success_setPath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notify_success_setPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.notify_success_setPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.notify_success_setPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notify_success_setPath.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.notify_success_setPath.ForeColor = System.Drawing.Color.White;
            this.notify_success_setPath.Image = ((System.Drawing.Image)(resources.GetObject("notify_success_setPath.Image")));
            this.notify_success_setPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notify_success_setPath.Location = new System.Drawing.Point(530, 871);
            this.notify_success_setPath.Name = "notify_success_setPath";
            this.notify_success_setPath.Size = new System.Drawing.Size(99, 25);
            this.notify_success_setPath.TabIndex = 80;
            this.notify_success_setPath.Text = "찾아보기";
            this.notify_success_setPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notify_success_setPath.UseVisualStyleBackColor = false;
            this.notify_success_setPath.Click += new System.EventHandler(this.notify_success_setPath_Click);
            // 
            // notify_error_path
            // 
            this.notify_error_path.Depth = 0;
            this.notify_error_path.Hint = "";
            this.notify_error_path.Location = new System.Drawing.Point(163, 911);
            this.notify_error_path.MaxLength = 999;
            this.notify_error_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.notify_error_path.Name = "notify_error_path";
            this.notify_error_path.PasswordChar = '\0';
            this.notify_error_path.SelectedText = "";
            this.notify_error_path.SelectionLength = 0;
            this.notify_error_path.SelectionStart = 0;
            this.notify_error_path.Size = new System.Drawing.Size(353, 19);
            this.notify_error_path.TabIndex = 79;
            this.notify_error_path.TabStop = false;
            this.notify_error_path.UseSystemPasswordChar = false;
            // 
            // notify_error_title
            // 
            this.notify_error_title.AutoSize = true;
            this.notify_error_title.Location = new System.Drawing.Point(39, 913);
            this.notify_error_title.Name = "notify_error_title";
            this.notify_error_title.Size = new System.Drawing.Size(89, 12);
            this.notify_error_title.TabIndex = 78;
            this.notify_error_title.Text = "오류 알람 경로:";
            // 
            // notify_success_path
            // 
            this.notify_success_path.Depth = 0;
            this.notify_success_path.Hint = "";
            this.notify_success_path.Location = new System.Drawing.Point(163, 877);
            this.notify_success_path.MaxLength = 999;
            this.notify_success_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.notify_success_path.Name = "notify_success_path";
            this.notify_success_path.PasswordChar = '\0';
            this.notify_success_path.SelectedText = "";
            this.notify_success_path.SelectionLength = 0;
            this.notify_success_path.SelectionStart = 0;
            this.notify_success_path.Size = new System.Drawing.Size(353, 19);
            this.notify_success_path.TabIndex = 77;
            this.notify_success_path.TabStop = false;
            this.notify_success_path.UseSystemPasswordChar = false;
            // 
            // notify_success_title
            // 
            this.notify_success_title.AutoSize = true;
            this.notify_success_title.Location = new System.Drawing.Point(39, 879);
            this.notify_success_title.Name = "notify_success_title";
            this.notify_success_title.Size = new System.Drawing.Size(89, 12);
            this.notify_success_title.TabIndex = 76;
            this.notify_success_title.Text = "통과 알람 경로:";
            // 
            // screenshot_path
            // 
            this.screenshot_path.Depth = 0;
            this.screenshot_path.Hint = "";
            this.screenshot_path.Location = new System.Drawing.Point(171, 563);
            this.screenshot_path.MaxLength = 999;
            this.screenshot_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_path.Name = "screenshot_path";
            this.screenshot_path.PasswordChar = '\0';
            this.screenshot_path.SelectedText = "";
            this.screenshot_path.SelectionLength = 0;
            this.screenshot_path.SelectionStart = 0;
            this.screenshot_path.Size = new System.Drawing.Size(345, 19);
            this.screenshot_path.TabIndex = 75;
            this.screenshot_path.TabStop = false;
            this.screenshot_path.UseSystemPasswordChar = false;
            // 
            // screenshot_path_title
            // 
            this.screenshot_path_title.AutoSize = true;
            this.screenshot_path_title.Location = new System.Drawing.Point(39, 563);
            this.screenshot_path_title.Name = "screenshot_path_title";
            this.screenshot_path_title.Size = new System.Drawing.Size(113, 12);
            this.screenshot_path_title.TabIndex = 74;
            this.screenshot_path_title.Text = "스크린샷 저장 경로:";
            // 
            // test_except_bar
            // 
            this.test_except_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.test_except_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.test_except_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.test_except_bar.Location = new System.Drawing.Point(196, 93);
            this.test_except_bar.Max = 2500F;
            this.test_except_bar.Min = 0F;
            this.test_except_bar.Name = "test_except_bar";
            this.test_except_bar.Size = new System.Drawing.Size(319, 18);
            this.test_except_bar.TabIndex = 73;
            this.test_except_bar.UseBox = true;
            this.test_except_bar.Value = 300F;
            this.test_except_bar.ValueChanged += new System.EventHandler(this.test_except_bar_ValueChanged);
            // 
            // test_target_bar
            // 
            this.test_target_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.test_target_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.test_target_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.test_target_bar.Location = new System.Drawing.Point(196, 60);
            this.test_target_bar.Max = 2000F;
            this.test_target_bar.Min = 0F;
            this.test_target_bar.Name = "test_target_bar";
            this.test_target_bar.Size = new System.Drawing.Size(319, 18);
            this.test_target_bar.TabIndex = 72;
            this.test_target_bar.UseBox = true;
            this.test_target_bar.Value = 800F;
            this.test_target_bar.ValueChanged += new System.EventHandler(this.test_target_bar_ValueChanged);
            // 
            // screenshot_cycle_time_bar
            // 
            this.screenshot_cycle_time_bar.BarBackColor = System.Drawing.Color.DimGray;
            this.screenshot_cycle_time_bar.BarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.screenshot_cycle_time_bar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))));
            this.screenshot_cycle_time_bar.Enabled = false;
            this.screenshot_cycle_time_bar.Location = new System.Drawing.Point(196, 477);
            this.screenshot_cycle_time_bar.Max = 180F;
            this.screenshot_cycle_time_bar.Min = 0F;
            this.screenshot_cycle_time_bar.Name = "screenshot_cycle_time_bar";
            this.screenshot_cycle_time_bar.Size = new System.Drawing.Size(320, 18);
            this.screenshot_cycle_time_bar.TabIndex = 71;
            this.screenshot_cycle_time_bar.UseBox = true;
            this.screenshot_cycle_time_bar.Value = 60F;
            this.screenshot_cycle_time_bar.ValueChanged += new System.EventHandler(this.screenshot_cycle_time_bar_ValueChanged);
            // 
            // screenshot_quality_low
            // 
            this.screenshot_quality_low.AutoSize = true;
            this.screenshot_quality_low.Depth = 0;
            this.screenshot_quality_low.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_quality_low.Location = new System.Drawing.Point(341, 516);
            this.screenshot_quality_low.Margin = new System.Windows.Forms.Padding(0);
            this.screenshot_quality_low.MouseLocation = new System.Drawing.Point(-1, -1);
            this.screenshot_quality_low.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_quality_low.Name = "screenshot_quality_low";
            this.screenshot_quality_low.Ripple = true;
            this.screenshot_quality_low.Size = new System.Drawing.Size(42, 30);
            this.screenshot_quality_low.TabIndex = 69;
            this.screenshot_quality_low.Text = "하";
            this.screenshot_quality_low.UseVisualStyleBackColor = true;
            this.screenshot_quality_low.Click += new System.EventHandler(this.screenshot_quality_low_Click);
            // 
            // screenshot_quality_middle
            // 
            this.screenshot_quality_middle.AutoSize = true;
            this.screenshot_quality_middle.Checked = true;
            this.screenshot_quality_middle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.screenshot_quality_middle.Depth = 0;
            this.screenshot_quality_middle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_quality_middle.Location = new System.Drawing.Point(271, 516);
            this.screenshot_quality_middle.Margin = new System.Windows.Forms.Padding(0);
            this.screenshot_quality_middle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.screenshot_quality_middle.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_quality_middle.Name = "screenshot_quality_middle";
            this.screenshot_quality_middle.Ripple = true;
            this.screenshot_quality_middle.Size = new System.Drawing.Size(42, 30);
            this.screenshot_quality_middle.TabIndex = 68;
            this.screenshot_quality_middle.Text = "중";
            this.screenshot_quality_middle.UseVisualStyleBackColor = true;
            this.screenshot_quality_middle.Click += new System.EventHandler(this.screenshot_quality_middle_Click);
            // 
            // screenshot_quality_high
            // 
            this.screenshot_quality_high.AutoSize = true;
            this.screenshot_quality_high.Depth = 0;
            this.screenshot_quality_high.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_quality_high.Location = new System.Drawing.Point(201, 516);
            this.screenshot_quality_high.Margin = new System.Windows.Forms.Padding(0);
            this.screenshot_quality_high.MouseLocation = new System.Drawing.Point(-1, -1);
            this.screenshot_quality_high.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_quality_high.Name = "screenshot_quality_high";
            this.screenshot_quality_high.Ripple = true;
            this.screenshot_quality_high.Size = new System.Drawing.Size(42, 30);
            this.screenshot_quality_high.TabIndex = 67;
            this.screenshot_quality_high.Text = "상";
            this.screenshot_quality_high.UseVisualStyleBackColor = true;
            this.screenshot_quality_high.Click += new System.EventHandler(this.screenshot_quality_high_Click);
            // 
            // screenshot_setPath
            // 
            this.screenshot_setPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.screenshot_setPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screenshot_setPath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.screenshot_setPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.screenshot_setPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.screenshot_setPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenshot_setPath.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_setPath.ForeColor = System.Drawing.Color.White;
            this.screenshot_setPath.Image = ((System.Drawing.Image)(resources.GetObject("screenshot_setPath.Image")));
            this.screenshot_setPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenshot_setPath.Location = new System.Drawing.Point(530, 555);
            this.screenshot_setPath.Name = "screenshot_setPath";
            this.screenshot_setPath.Size = new System.Drawing.Size(99, 25);
            this.screenshot_setPath.TabIndex = 66;
            this.screenshot_setPath.Text = "찾아보기";
            this.screenshot_setPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.screenshot_setPath.UseVisualStyleBackColor = false;
            this.screenshot_setPath.Click += new System.EventHandler(this.screenshot_setPath_Click);
            // 
            // screenshot_quality_title
            // 
            this.screenshot_quality_title.AutoSize = true;
            this.screenshot_quality_title.Location = new System.Drawing.Point(39, 524);
            this.screenshot_quality_title.Name = "screenshot_quality_title";
            this.screenshot_quality_title.Size = new System.Drawing.Size(109, 12);
            this.screenshot_quality_title.TabIndex = 63;
            this.screenshot_quality_title.Text = "스크린샷 색상품질:";
            // 
            // test_manual
            // 
            this.test_manual.AutoSize = true;
            this.test_manual.Depth = 0;
            this.test_manual.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test_manual.Location = new System.Drawing.Point(35, 208);
            this.test_manual.Margin = new System.Windows.Forms.Padding(0);
            this.test_manual.MouseLocation = new System.Drawing.Point(-1, -1);
            this.test_manual.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_manual.Name = "test_manual";
            this.test_manual.Ripple = true;
            this.test_manual.Size = new System.Drawing.Size(95, 30);
            this.test_manual.TabIndex = 62;
            this.test_manual.Text = "수동 테스트";
            this.test_manual.UseVisualStyleBackColor = true;
            this.test_manual.Click += new System.EventHandler(this.test_manual_Click);
            // 
            // test_except_title
            // 
            this.test_except_title.AutoSize = true;
            this.test_except_title.Location = new System.Drawing.Point(39, 98);
            this.test_except_title.Name = "test_except_title";
            this.test_except_title.Size = new System.Drawing.Size(73, 12);
            this.test_except_title.TabIndex = 61;
            this.test_except_title.Text = "예외 메모리:";
            // 
            // test_except
            // 
            this.test_except.Depth = 0;
            this.test_except.Hint = "";
            this.test_except.Location = new System.Drawing.Point(530, 96);
            this.test_except.MaxLength = 7;
            this.test_except.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_except.Name = "test_except";
            this.test_except.PasswordChar = '\0';
            this.test_except.SelectedText = "";
            this.test_except.SelectionLength = 0;
            this.test_except.SelectionStart = 0;
            this.test_except.Size = new System.Drawing.Size(45, 19);
            this.test_except.TabIndex = 60;
            this.test_except.TabStop = false;
            this.test_except.Text = "300";
            this.test_except.UseSystemPasswordChar = false;
            // 
            // test_except_label_1
            // 
            this.test_except_label_1.AutoSize = true;
            this.test_except_label_1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test_except_label_1.Location = new System.Drawing.Point(579, 97);
            this.test_except_label_1.Name = "test_except_label_1";
            this.test_except_label_1.Size = new System.Drawing.Size(26, 12);
            this.test_except_label_1.TabIndex = 59;
            this.test_except_label_1.Text = "MB";
            // 
            // label_for_size
            // 
            this.label_for_size.AutoSize = true;
            this.label_for_size.Location = new System.Drawing.Point(21, 1832);
            this.label_for_size.Name = "label_for_size";
            this.label_for_size.Size = new System.Drawing.Size(65, 12);
            this.label_for_size.TabIndex = 58;
            this.label_for_size.Text = "크기조절용";
            // 
            // transparency_title
            // 
            this.transparency_title.AutoSize = true;
            this.transparency_title.Location = new System.Drawing.Point(39, 1399);
            this.transparency_title.Name = "transparency_title";
            this.transparency_title.Size = new System.Drawing.Size(109, 12);
            this.transparency_title.TabIndex = 55;
            this.transparency_title.Text = "프로그램 불투명도:";
            // 
            // instant
            // 
            this.instant.AutoSize = true;
            this.instant.Depth = 0;
            this.instant.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.instant.Location = new System.Drawing.Point(36, 1690);
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
            // layout_y_label
            // 
            this.layout_y_label.AutoSize = true;
            this.layout_y_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.layout_y_label.Location = new System.Drawing.Point(579, 1345);
            this.layout_y_label.Name = "layout_y_label";
            this.layout_y_label.Size = new System.Drawing.Size(16, 12);
            this.layout_y_label.TabIndex = 50;
            this.layout_y_label.Text = "%";
            // 
            // layout_x_label
            // 
            this.layout_x_label.AutoSize = true;
            this.layout_x_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.layout_x_label.Location = new System.Drawing.Point(578, 1313);
            this.layout_x_label.Name = "layout_x_label";
            this.layout_x_label.Size = new System.Drawing.Size(16, 12);
            this.layout_x_label.TabIndex = 49;
            this.layout_x_label.Text = "%";
            // 
            // layout_y
            // 
            this.layout_y.Depth = 0;
            this.layout_y.Hint = "";
            this.layout_y.Location = new System.Drawing.Point(530, 1344);
            this.layout_y.MaxLength = 4;
            this.layout_y.MouseState = MaterialSkin.MouseState.HOVER;
            this.layout_y.Name = "layout_y";
            this.layout_y.PasswordChar = '\0';
            this.layout_y.SelectedText = "";
            this.layout_y.SelectionLength = 0;
            this.layout_y.SelectionStart = 0;
            this.layout_y.Size = new System.Drawing.Size(45, 19);
            this.layout_y.TabIndex = 48;
            this.layout_y.TabStop = false;
            this.layout_y.Text = "90";
            this.layout_y.UseSystemPasswordChar = false;
            // 
            // layout_x
            // 
            this.layout_x.Depth = 0;
            this.layout_x.Hint = "";
            this.layout_x.Location = new System.Drawing.Point(530, 1312);
            this.layout_x.MaxLength = 4;
            this.layout_x.MouseState = MaterialSkin.MouseState.HOVER;
            this.layout_x.Name = "layout_x";
            this.layout_x.PasswordChar = '\0';
            this.layout_x.SelectedText = "";
            this.layout_x.SelectionLength = 0;
            this.layout_x.SelectionStart = 0;
            this.layout_x.Size = new System.Drawing.Size(45, 19);
            this.layout_x.TabIndex = 47;
            this.layout_x.TabStop = false;
            this.layout_x.Text = "90";
            this.layout_x.UseSystemPasswordChar = false;
            // 
            // layout_title
            // 
            this.layout_title.AutoSize = true;
            this.layout_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.layout_title.ForeColor = System.Drawing.Color.Blue;
            this.layout_title.Location = new System.Drawing.Point(24, 1268);
            this.layout_title.Name = "layout_title";
            this.layout_title.Size = new System.Drawing.Size(88, 25);
            this.layout_title.TabIndex = 44;
            this.layout_title.Text = "레이아웃";
            // 
            // finish_closePC
            // 
            this.finish_closePC.AutoSize = true;
            this.finish_closePC.Depth = 0;
            this.finish_closePC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.finish_closePC.Location = new System.Drawing.Point(36, 1114);
            this.finish_closePC.Margin = new System.Windows.Forms.Padding(0);
            this.finish_closePC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.finish_closePC.MouseState = MaterialSkin.MouseState.HOVER;
            this.finish_closePC.Name = "finish_closePC";
            this.finish_closePC.Ripple = true;
            this.finish_closePC.Size = new System.Drawing.Size(75, 30);
            this.finish_closePC.TabIndex = 43;
            this.finish_closePC.Text = "PC 종료";
            this.finish_closePC.UseVisualStyleBackColor = true;
            this.finish_closePC.Click += new System.EventHandler(this.finish_closePC_Click);
            // 
            // finish_closeTest
            // 
            this.finish_closeTest.AutoSize = true;
            this.finish_closeTest.Checked = true;
            this.finish_closeTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.finish_closeTest.Depth = 0;
            this.finish_closeTest.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.finish_closeTest.Location = new System.Drawing.Point(36, 1064);
            this.finish_closeTest.Margin = new System.Windows.Forms.Padding(0);
            this.finish_closeTest.MouseLocation = new System.Drawing.Point(-1, -1);
            this.finish_closeTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.finish_closeTest.Name = "finish_closeTest";
            this.finish_closeTest.Ripple = true;
            this.finish_closeTest.Size = new System.Drawing.Size(108, 30);
            this.finish_closeTest.TabIndex = 42;
            this.finish_closeTest.Text = "멤테스트 종료";
            this.finish_closeTest.UseVisualStyleBackColor = true;
            // 
            // finish_title
            // 
            this.finish_title.AutoSize = true;
            this.finish_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.finish_title.ForeColor = System.Drawing.Color.Blue;
            this.finish_title.Location = new System.Drawing.Point(24, 1024);
            this.finish_title.Name = "finish_title";
            this.finish_title.Size = new System.Drawing.Size(114, 25);
            this.finish_title.TabIndex = 41;
            this.finish_title.Text = "마지막 행동";
            // 
            // notify_count
            // 
            this.notify_count.Depth = 0;
            this.notify_count.Hint = "";
            this.notify_count.Location = new System.Drawing.Point(530, 722);
            this.notify_count.MaxLength = 5;
            this.notify_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.notify_count.Name = "notify_count";
            this.notify_count.PasswordChar = '\0';
            this.notify_count.SelectedText = "";
            this.notify_count.SelectionLength = 0;
            this.notify_count.SelectionStart = 0;
            this.notify_count.Size = new System.Drawing.Size(45, 19);
            this.notify_count.TabIndex = 38;
            this.notify_count.TabStop = false;
            this.notify_count.Text = "5";
            this.notify_count.UseSystemPasswordChar = false;
            // 
            // notify_count_label
            // 
            this.notify_count_label.AutoSize = true;
            this.notify_count_label.Location = new System.Drawing.Point(39, 723);
            this.notify_count_label.Name = "notify_count_label";
            this.notify_count_label.Size = new System.Drawing.Size(85, 12);
            this.notify_count_label.TabIndex = 37;
            this.notify_count_label.Text = "반복재생 횟수:";
            // 
            // notify_title
            // 
            this.notify_title.AutoSize = true;
            this.notify_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.notify_title.ForeColor = System.Drawing.Color.Blue;
            this.notify_title.Location = new System.Drawing.Point(24, 680);
            this.notify_title.Name = "notify_title";
            this.notify_title.Size = new System.Drawing.Size(95, 25);
            this.notify_title.TabIndex = 36;
            this.notify_title.Text = "소리 알림";
            // 
            // screenshot_cycle_time
            // 
            this.screenshot_cycle_time.Depth = 0;
            this.screenshot_cycle_time.Enabled = false;
            this.screenshot_cycle_time.Hint = "";
            this.screenshot_cycle_time.Location = new System.Drawing.Point(530, 478);
            this.screenshot_cycle_time.MaxLength = 5;
            this.screenshot_cycle_time.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_cycle_time.Name = "screenshot_cycle_time";
            this.screenshot_cycle_time.PasswordChar = '\0';
            this.screenshot_cycle_time.SelectedText = "";
            this.screenshot_cycle_time.SelectionLength = 0;
            this.screenshot_cycle_time.SelectionStart = 0;
            this.screenshot_cycle_time.Size = new System.Drawing.Size(45, 19);
            this.screenshot_cycle_time.TabIndex = 35;
            this.screenshot_cycle_time.TabStop = false;
            this.screenshot_cycle_time.Text = "60";
            this.screenshot_cycle_time.UseSystemPasswordChar = false;
            // 
            // test_manual_count
            // 
            this.test_manual_count.Depth = 0;
            this.test_manual_count.Enabled = false;
            this.test_manual_count.Hint = "";
            this.test_manual_count.Location = new System.Drawing.Point(51, 275);
            this.test_manual_count.MaxLength = 3;
            this.test_manual_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_manual_count.Name = "test_manual_count";
            this.test_manual_count.PasswordChar = '\0';
            this.test_manual_count.SelectedText = "";
            this.test_manual_count.SelectionLength = 0;
            this.test_manual_count.SelectionStart = 0;
            this.test_manual_count.Size = new System.Drawing.Size(45, 19);
            this.test_manual_count.TabIndex = 34;
            this.test_manual_count.TabStop = false;
            this.test_manual_count.Text = "8";
            this.test_manual_count.UseSystemPasswordChar = false;
            // 
            // test_manual_ammount
            // 
            this.test_manual_ammount.Depth = 0;
            this.test_manual_ammount.Enabled = false;
            this.test_manual_ammount.Hint = "";
            this.test_manual_ammount.Location = new System.Drawing.Point(51, 250);
            this.test_manual_ammount.MaxLength = 4;
            this.test_manual_ammount.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_manual_ammount.Name = "test_manual_ammount";
            this.test_manual_ammount.PasswordChar = '\0';
            this.test_manual_ammount.SelectedText = "";
            this.test_manual_ammount.SelectionLength = 0;
            this.test_manual_ammount.SelectionStart = 0;
            this.test_manual_ammount.Size = new System.Drawing.Size(45, 19);
            this.test_manual_ammount.TabIndex = 33;
            this.test_manual_ammount.TabStop = false;
            this.test_manual_ammount.Text = "1750";
            this.test_manual_ammount.UseSystemPasswordChar = false;
            // 
            // test_target
            // 
            this.test_target.Depth = 0;
            this.test_target.Hint = "";
            this.test_target.Location = new System.Drawing.Point(530, 61);
            this.test_target.MaxLength = 5;
            this.test_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.test_target.Name = "test_target";
            this.test_target.PasswordChar = '\0';
            this.test_target.SelectedText = "";
            this.test_target.SelectionLength = 0;
            this.test_target.SelectionStart = 0;
            this.test_target.Size = new System.Drawing.Size(45, 19);
            this.test_target.TabIndex = 32;
            this.test_target.TabStop = false;
            this.test_target.Text = "800";
            this.test_target.UseSystemPasswordChar = false;
            // 
            // test_target_label_1
            // 
            this.test_target_label_1.AutoSize = true;
            this.test_target_label_1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test_target_label_1.Location = new System.Drawing.Point(579, 61);
            this.test_target_label_1.Name = "test_target_label_1";
            this.test_target_label_1.Size = new System.Drawing.Size(16, 12);
            this.test_target_label_1.TabIndex = 31;
            this.test_target_label_1.Text = "%";
            // 
            // test_target_title
            // 
            this.test_target_title.AutoSize = true;
            this.test_target_title.Location = new System.Drawing.Point(39, 66);
            this.test_target_title.Name = "test_target_title";
            this.test_target_title.Size = new System.Drawing.Size(45, 12);
            this.test_target_title.TabIndex = 30;
            this.test_target_title.Text = "목표치:";
            // 
            // screenshot_cycle_label
            // 
            this.screenshot_cycle_label.AutoSize = true;
            this.screenshot_cycle_label.Enabled = false;
            this.screenshot_cycle_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_cycle_label.Location = new System.Drawing.Point(579, 478);
            this.screenshot_cycle_label.Name = "screenshot_cycle_label";
            this.screenshot_cycle_label.Size = new System.Drawing.Size(18, 12);
            this.screenshot_cycle_label.TabIndex = 27;
            this.screenshot_cycle_label.Text = "분";
            // 
            // screenshot_cycle
            // 
            this.screenshot_cycle.AutoSize = true;
            this.screenshot_cycle.Depth = 0;
            this.screenshot_cycle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_cycle.Location = new System.Drawing.Point(36, 474);
            this.screenshot_cycle.Margin = new System.Windows.Forms.Padding(0);
            this.screenshot_cycle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.screenshot_cycle.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_cycle.Name = "screenshot_cycle";
            this.screenshot_cycle.Ripple = true;
            this.screenshot_cycle.Size = new System.Drawing.Size(145, 30);
            this.screenshot_cycle.TabIndex = 25;
            this.screenshot_cycle.Text = "주기적으로 스크린샷";
            this.screenshot_cycle.UseVisualStyleBackColor = true;
            this.screenshot_cycle.Click += new System.EventHandler(this.screenshot_cycle_Click);
            // 
            // screenshot_after
            // 
            this.screenshot_after.AutoSize = true;
            this.screenshot_after.Checked = true;
            this.screenshot_after.CheckState = System.Windows.Forms.CheckState.Checked;
            this.screenshot_after.Depth = 0;
            this.screenshot_after.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.screenshot_after.Location = new System.Drawing.Point(36, 432);
            this.screenshot_after.Margin = new System.Windows.Forms.Padding(0);
            this.screenshot_after.MouseLocation = new System.Drawing.Point(-1, -1);
            this.screenshot_after.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot_after.Name = "screenshot_after";
            this.screenshot_after.Ripple = true;
            this.screenshot_after.Size = new System.Drawing.Size(124, 30);
            this.screenshot_after.TabIndex = 23;
            this.screenshot_after.Text = "끝날 때 스크린샷";
            this.screenshot_after.UseVisualStyleBackColor = true;
            // 
            // screenshot_title
            // 
            this.screenshot_title.AutoSize = true;
            this.screenshot_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.screenshot_title.ForeColor = System.Drawing.Color.Blue;
            this.screenshot_title.Location = new System.Drawing.Point(24, 392);
            this.screenshot_title.Name = "screenshot_title";
            this.screenshot_title.Size = new System.Drawing.Size(88, 25);
            this.screenshot_title.TabIndex = 22;
            this.screenshot_title.Text = "스크린샷";
            // 
            // test_title
            // 
            this.test_title.AutoSize = true;
            this.test_title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_title.ForeColor = System.Drawing.Color.Blue;
            this.test_title.Location = new System.Drawing.Point(24, 21);
            this.test_title.Name = "test_title";
            this.test_title.Size = new System.Drawing.Size(114, 25);
            this.test_title.TabIndex = 21;
            this.test_title.Text = "테스트 설정";
            // 
            // test_manual_label_2
            // 
            this.test_manual_label_2.AutoSize = true;
            this.test_manual_label_2.Enabled = false;
            this.test_manual_label_2.Location = new System.Drawing.Point(102, 275);
            this.test_manual_label_2.Name = "test_manual_label_2";
            this.test_manual_label_2.Size = new System.Drawing.Size(17, 12);
            this.test_manual_label_2.TabIndex = 20;
            this.test_manual_label_2.Text = "개";
            // 
            // test_manual_label_1
            // 
            this.test_manual_label_1.AutoSize = true;
            this.test_manual_label_1.Enabled = false;
            this.test_manual_label_1.Location = new System.Drawing.Point(102, 250);
            this.test_manual_label_1.Name = "test_manual_label_1";
            this.test_manual_label_1.Size = new System.Drawing.Size(24, 12);
            this.test_manual_label_1.TabIndex = 19;
            this.test_manual_label_1.Text = "MB";
            // 
            // dialog_open_file
            // 
            this.dialog_open_file.FileName = "OpenFile";
            this.dialog_open_file.Title = "알림에 사용할 음악파일 선택";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(666, 625);
            this.Controls.Add(this.check_version);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 1300);
            this.MinimumSize = new System.Drawing.Size(322, 250);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "EasyHCI 1.0.8B";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TabMain.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            this.Tab3.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageBar_backColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageBar_foreColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabMain;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.LinkLabel check_version;
        private System.Windows.Forms.Label ram_usage_label;
        private System.Windows.Forms.Label ram_usage_title;
        private System.Windows.Forms.Label passRate_title;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Label screenshot_cycle_label;
        private MaterialSkin.Controls.MaterialCheckBox screenshot_cycle;
        private MaterialSkin.Controls.MaterialCheckBox screenshot_after;
        private System.Windows.Forms.Label screenshot_title;
        private System.Windows.Forms.Label test_title;
        private System.Windows.Forms.Label test_manual_label_2;
        private System.Windows.Forms.Label test_manual_label_1;
        private MaterialSkin.Controls.MaterialCheckBox test_hide;
        private System.Windows.Forms.Label test_target_title;
        private System.Windows.Forms.Label test_target_label_1;
        private MaterialSkin.Controls.MaterialSingleLineTextField test_target;
        private MaterialSkin.Controls.MaterialSingleLineTextField test_manual_ammount;
        private MaterialSkin.Controls.MaterialSingleLineTextField test_manual_count;
        private MaterialSkin.Controls.MaterialSingleLineTextField screenshot_cycle_time;
        internal System.Windows.Forms.FolderBrowserDialog dialog_open_directory;
        internal System.Windows.Forms.OpenFileDialog dialog_open_file;
        private System.Windows.Forms.Label notify_title;
        private MaterialSkin.Controls.MaterialSingleLineTextField notify_count;
        private System.Windows.Forms.Label notify_count_label;
        private System.Windows.Forms.Label layout_y_label;
        private System.Windows.Forms.Label layout_x_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField layout_y;
        private MaterialSkin.Controls.MaterialSingleLineTextField layout_x;
        private System.Windows.Forms.Label layout_title;
        private MaterialSkin.Controls.MaterialCheckBox finish_closePC;
        private MaterialSkin.Controls.MaterialCheckBox finish_closeTest;
        private System.Windows.Forms.Label finish_title;
        private MaterialSkin.Controls.MaterialCheckBox instant;
        private System.Windows.Forms.Label transparency_title;
        private System.Windows.Forms.Label label_for_size;
        private MaterialSkin.Controls.MaterialSingleLineTextField test_except;
        private System.Windows.Forms.Label test_except_label_1;
        private MaterialSkin.Controls.MaterialCheckBox test_manual;
        private System.Windows.Forms.Label test_except_title;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button screenshot_setPath;
        private System.Windows.Forms.Label screenshot_quality_title;
        private MaterialSkin.Controls.MaterialCheckBox screenshot_quality_low;
        private MaterialSkin.Controls.MaterialCheckBox screenshot_quality_middle;
        private MaterialSkin.Controls.MaterialCheckBox screenshot_quality_high;
        private Functions.UI.Slider ram_usage;
        private Functions.UI.Slider screenshot_cycle_time_bar;
        private Functions.UI.Slider test_target_bar;
        private Functions.UI.Slider test_except_bar;
        private MaterialSkin.Controls.MaterialSingleLineTextField screenshot_path;
        private System.Windows.Forms.Label screenshot_path_title;
        private MaterialSkin.Controls.MaterialSingleLineTextField notify_error_path;
        private System.Windows.Forms.Label notify_error_title;
        private MaterialSkin.Controls.MaterialSingleLineTextField notify_success_path;
        private System.Windows.Forms.Label notify_success_title;
        private System.Windows.Forms.Button notify_error_setPath;
        private System.Windows.Forms.Button notify_success_setPath;
        private MaterialSkin.Controls.MaterialCheckBox finish_restartPC;
        private Functions.UI.Slider notify_count_bar;
        private Functions.UI.Slider notify_volume_bar;
        private MaterialSkin.Controls.MaterialSingleLineTextField notify_volume;
        private System.Windows.Forms.Label notify_volume_title;
        private System.Windows.Forms.Button notify_test;
        private Functions.UI.Slider layout_y_bar;
        private Functions.UI.Slider layout_x_bar;
        private System.Windows.Forms.Label layout_y_title;
        private System.Windows.Forms.Label layout_x_title;
        private System.Windows.Forms.PictureBox ramUsageBar_foreColor;
        private System.Windows.Forms.Label ramUsageBar_title;
        private System.Windows.Forms.PictureBox ramUsageBar_backColor;
        private Functions.UI.Slider transparency_bar;
        private System.Windows.Forms.Label extra_title;
        private System.Windows.Forms.Button openProcessList;
        private MaterialSkin.Controls.MaterialCheckBox test_std_avg;
        private MaterialSkin.Controls.MaterialCheckBox test_std_min;
        private System.Windows.Forms.Label test_std_title;
        private System.Windows.Forms.Label elapsed_time;
        private System.Windows.Forms.Label elapsed_time_title;
        private System.Windows.Forms.Label deviation_label;
        private System.Windows.Forms.Label deviation_title;
        private System.Windows.Forms.Label passRate_avg;
        private System.Windows.Forms.Label passRate_min;
        private Functions.UI.Slider interval_test_bar;
        private Functions.UI.Slider interval_memory_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label interval_memory_title;
        private System.Windows.Forms.Label interval_test_label;
        private System.Windows.Forms.Label interval_memory_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField interval_test;
        private MaterialSkin.Controls.MaterialSingleLineTextField interval_memory;
        private System.Windows.Forms.Label remained_time;
        private System.Windows.Forms.Label line_2;
        private System.Windows.Forms.Label line_1;
    }
}

