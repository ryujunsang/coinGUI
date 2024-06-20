
namespace AUTO_PTP_V01
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_ClearMSG = new System.Windows.Forms.Button();
            this.btn_OpenCommDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBOX_Search_Device = new System.Windows.Forms.ComboBox();
            this.lstBox_MSG = new System.Windows.Forms.ListBox();
            this.tabOperation = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_stop_sens = new System.Windows.Forms.Label();
            this.lbl_input_sens = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chckBox_sens = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_moving_blade = new System.Windows.Forms.Button();
            this.txtBox_distance_blade = new System.Windows.Forms.TextBox();
            this.chckBox_blade_both = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_blade_distance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.chckBox_blade_B = new System.Windows.Forms.CheckBox();
            this.chckBox_blade_A = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chckBox_main_mot = new System.Windows.Forms.CheckBox();
            this.chckBox_input_mot = new System.Windows.Forms.CheckBox();
            this.lbl_main_mot = new System.Windows.Forms.Label();
            this.lbl_input_mot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_main_mot = new System.Windows.Forms.TrackBar();
            this.trackBar_input_mot = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBox_dist_rotate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBox_stepm_speed0 = new System.Windows.Forms.TextBox();
            this.btn_rotation_stepm = new System.Windows.Forms.Button();
            this.txtBox_stepm_speed1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBar_stepm_speed0 = new System.Windows.Forms.TrackBar();
            this.trackBar_stepm_speed1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabOperation.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blade_distance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_main_mot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_input_mot)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_stepm_speed0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_stepm_speed1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_ClearMSG);
            this.splitContainer1.Panel1.Controls.Add(this.btn_OpenCommDevice);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmBOX_Search_Device);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstBox_MSG);
            this.splitContainer1.Panel2.Controls.Add(this.tabOperation);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_ClearMSG
            // 
            this.btn_ClearMSG.Location = new System.Drawing.Point(1160, 29);
            this.btn_ClearMSG.Name = "btn_ClearMSG";
            this.btn_ClearMSG.Size = new System.Drawing.Size(100, 34);
            this.btn_ClearMSG.TabIndex = 3;
            this.btn_ClearMSG.Text = "메시지 클리어";
            this.btn_ClearMSG.UseVisualStyleBackColor = true;
            this.btn_ClearMSG.Click += new System.EventHandler(this.btn_ClearMSG_Click);
            // 
            // btn_OpenCommDevice
            // 
            this.btn_OpenCommDevice.Location = new System.Drawing.Point(149, 12);
            this.btn_OpenCommDevice.Name = "btn_OpenCommDevice";
            this.btn_OpenCommDevice.Size = new System.Drawing.Size(119, 49);
            this.btn_OpenCommDevice.TabIndex = 2;
            this.btn_OpenCommDevice.Text = "통신 포트 열기";
            this.btn_OpenCommDevice.UseVisualStyleBackColor = true;
            this.btn_OpenCommDevice.Click += new System.EventHandler(this.btn_OpenCommDevice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "통신디바이스";
            // 
            // cmBOX_Search_Device
            // 
            this.cmBOX_Search_Device.FormattingEnabled = true;
            this.cmBOX_Search_Device.Location = new System.Drawing.Point(12, 34);
            this.cmBOX_Search_Device.Name = "cmBOX_Search_Device";
            this.cmBOX_Search_Device.Size = new System.Drawing.Size(121, 27);
            this.cmBOX_Search_Device.TabIndex = 0;
            this.cmBOX_Search_Device.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmBOX_Search_Device_MouseClick);
            // 
            // lstBox_MSG
            // 
            this.lstBox_MSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBox_MSG.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstBox_MSG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_MSG.FormattingEnabled = true;
            this.lstBox_MSG.ItemHeight = 15;
            this.lstBox_MSG.Location = new System.Drawing.Point(759, 0);
            this.lstBox_MSG.Name = "lstBox_MSG";
            this.lstBox_MSG.Size = new System.Drawing.Size(505, 609);
            this.lstBox_MSG.TabIndex = 1;
            // 
            // tabOperation
            // 
            this.tabOperation.Controls.Add(this.tabPage1);
            this.tabOperation.Controls.Add(this.tabPage2);
            this.tabOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOperation.Location = new System.Drawing.Point(0, 0);
            this.tabOperation.Name = "tabOperation";
            this.tabOperation.SelectedIndex = 0;
            this.tabOperation.Size = new System.Drawing.Size(1264, 609);
            this.tabOperation.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "단품테스트";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_stop_sens);
            this.groupBox3.Controls.Add(this.lbl_input_sens);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chckBox_sens);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(741, 94);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "테스트 : 센서";
            // 
            // lbl_stop_sens
            // 
            this.lbl_stop_sens.Location = new System.Drawing.Point(550, 60);
            this.lbl_stop_sens.Name = "lbl_stop_sens";
            this.lbl_stop_sens.Size = new System.Drawing.Size(111, 20);
            this.lbl_stop_sens.TabIndex = 21;
            this.lbl_stop_sens.Text = "0";
            this.lbl_stop_sens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_input_sens
            // 
            this.lbl_input_sens.Location = new System.Drawing.Point(268, 60);
            this.lbl_input_sens.Name = "lbl_input_sens";
            this.lbl_input_sens.Size = new System.Drawing.Size(111, 20);
            this.lbl_input_sens.TabIndex = 20;
            this.lbl_input_sens.Text = "0";
            this.lbl_input_sens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(489, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "정지 센서";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(207, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "투입 센서";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chckBox_sens
            // 
            this.chckBox_sens.AutoSize = true;
            this.chckBox_sens.Location = new System.Drawing.Point(9, 46);
            this.chckBox_sens.Name = "chckBox_sens";
            this.chckBox_sens.Size = new System.Drawing.Size(102, 20);
            this.chckBox_sens.TabIndex = 17;
            this.chckBox_sens.Text = "센서 ON/OFF";
            this.chckBox_sens.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBox_dist_rotate);
            this.groupBox2.Controls.Add(this.btn_moving_blade);
            this.groupBox2.Controls.Add(this.txtBox_distance_blade);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.chckBox_blade_both);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trackBar_blade_distance);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chckBox_blade_B);
            this.groupBox2.Controls.Add(this.chckBox_blade_A);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "테스트 : BLADE 위치";
            // 
            // btn_moving_blade
            // 
            this.btn_moving_blade.Location = new System.Drawing.Point(608, 117);
            this.btn_moving_blade.Name = "btn_moving_blade";
            this.btn_moving_blade.Size = new System.Drawing.Size(124, 31);
            this.btn_moving_blade.TabIndex = 22;
            this.btn_moving_blade.Text = "BLADE 동작";
            this.btn_moving_blade.UseVisualStyleBackColor = true;
            this.btn_moving_blade.Click += new System.EventHandler(this.btn_moving_blade_Click);
            // 
            // txtBox_distance_blade
            // 
            this.txtBox_distance_blade.Location = new System.Drawing.Point(596, 20);
            this.txtBox_distance_blade.Name = "txtBox_distance_blade";
            this.txtBox_distance_blade.Size = new System.Drawing.Size(89, 21);
            this.txtBox_distance_blade.TabIndex = 21;
            this.txtBox_distance_blade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox_distance_blade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_distance_blade_KeyDown);
            // 
            // chckBox_blade_both
            // 
            this.chckBox_blade_both.AutoSize = true;
            this.chckBox_blade_both.Location = new System.Drawing.Point(252, 120);
            this.chckBox_blade_both.Name = "chckBox_blade_both";
            this.chckBox_blade_both.Size = new System.Drawing.Size(77, 19);
            this.chckBox_blade_both.TabIndex = 20;
            this.chckBox_blade_both.Text = "동시 동작";
            this.chckBox_blade_both.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(691, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "[mm]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(511, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "이동 거리 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar_blade_distance
            // 
            this.trackBar_blade_distance.Location = new System.Drawing.Point(9, 44);
            this.trackBar_blade_distance.Maximum = 30;
            this.trackBar_blade_distance.Name = "trackBar_blade_distance";
            this.trackBar_blade_distance.Size = new System.Drawing.Size(723, 45);
            this.trackBar_blade_distance.TabIndex = 11;
            this.trackBar_blade_distance.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_blade_distance.Scroll += new System.EventHandler(this.trackBar_blade_distance_Scroll);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "동작 스텝모터";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chckBox_blade_B
            // 
            this.chckBox_blade_B.AutoSize = true;
            this.chckBox_blade_B.Location = new System.Drawing.Point(137, 120);
            this.chckBox_blade_B.Name = "chckBox_blade_B";
            this.chckBox_blade_B.Size = new System.Drawing.Size(75, 19);
            this.chckBox_blade_B.TabIndex = 1;
            this.chckBox_blade_B.Text = "BLADE B";
            this.chckBox_blade_B.UseVisualStyleBackColor = true;
            // 
            // chckBox_blade_A
            // 
            this.chckBox_blade_A.AutoSize = true;
            this.chckBox_blade_A.Location = new System.Drawing.Point(20, 120);
            this.chckBox_blade_A.Name = "chckBox_blade_A";
            this.chckBox_blade_A.Size = new System.Drawing.Size(75, 19);
            this.chckBox_blade_A.TabIndex = 0;
            this.chckBox_blade_A.Text = "BLADE A";
            this.chckBox_blade_A.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chckBox_main_mot);
            this.groupBox1.Controls.Add(this.chckBox_input_mot);
            this.groupBox1.Controls.Add(this.lbl_main_mot);
            this.groupBox1.Controls.Add(this.lbl_input_mot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar_main_mot);
            this.groupBox1.Controls.Add(this.trackBar_input_mot);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "테스트 : 투입/메인";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(566, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "[%]";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(180, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "[%]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chckBox_main_mot
            // 
            this.chckBox_main_mot.AutoSize = true;
            this.chckBox_main_mot.Location = new System.Drawing.Point(608, 20);
            this.chckBox_main_mot.Name = "chckBox_main_mot";
            this.chckBox_main_mot.Size = new System.Drawing.Size(124, 20);
            this.chckBox_main_mot.TabIndex = 17;
            this.chckBox_main_mot.Text = "메인모터 ON/OFF";
            this.chckBox_main_mot.UseVisualStyleBackColor = true;
            this.chckBox_main_mot.CheckedChanged += new System.EventHandler(this.chckBox_main_mot_CheckedChanged);
            // 
            // chckBox_input_mot
            // 
            this.chckBox_input_mot.AutoSize = true;
            this.chckBox_input_mot.Location = new System.Drawing.Point(227, 23);
            this.chckBox_input_mot.Name = "chckBox_input_mot";
            this.chckBox_input_mot.Size = new System.Drawing.Size(124, 20);
            this.chckBox_input_mot.TabIndex = 16;
            this.chckBox_input_mot.Text = "투입모터 ON/OFF";
            this.chckBox_input_mot.UseVisualStyleBackColor = true;
            this.chckBox_input_mot.CheckedChanged += new System.EventHandler(this.chckBox_input_mot_CheckedChanged);
            // 
            // lbl_main_mot
            // 
            this.lbl_main_mot.BackColor = System.Drawing.Color.White;
            this.lbl_main_mot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_main_mot.Location = new System.Drawing.Point(460, 18);
            this.lbl_main_mot.Name = "lbl_main_mot";
            this.lbl_main_mot.Size = new System.Drawing.Size(102, 25);
            this.lbl_main_mot.TabIndex = 15;
            this.lbl_main_mot.Text = "0";
            this.lbl_main_mot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_input_mot
            // 
            this.lbl_input_mot.BackColor = System.Drawing.Color.White;
            this.lbl_input_mot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_input_mot.Location = new System.Drawing.Point(76, 20);
            this.lbl_input_mot.Name = "lbl_input_mot";
            this.lbl_input_mot.Size = new System.Drawing.Size(102, 25);
            this.lbl_input_mot.TabIndex = 14;
            this.lbl_input_mot.Text = "0";
            this.lbl_input_mot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "메인 모터 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "투입 모터 :";
            // 
            // trackBar_main_mot
            // 
            this.trackBar_main_mot.Location = new System.Drawing.Point(387, 58);
            this.trackBar_main_mot.Name = "trackBar_main_mot";
            this.trackBar_main_mot.Size = new System.Drawing.Size(345, 45);
            this.trackBar_main_mot.TabIndex = 11;
            this.trackBar_main_mot.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_main_mot.Scroll += new System.EventHandler(this.trackBar_main_mot_Scroll);
            // 
            // trackBar_input_mot
            // 
            this.trackBar_input_mot.Location = new System.Drawing.Point(6, 58);
            this.trackBar_input_mot.Name = "trackBar_input_mot";
            this.trackBar_input_mot.Size = new System.Drawing.Size(345, 45);
            this.trackBar_input_mot.TabIndex = 1;
            this.trackBar_input_mot.TickFrequency = 10;
            this.trackBar_input_mot.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_input_mot.Scroll += new System.EventHandler(this.trackBar_input_mot_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "통합테스트";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBox_dist_rotate
            // 
            this.txtBox_dist_rotate.Location = new System.Drawing.Point(117, 18);
            this.txtBox_dist_rotate.Name = "txtBox_dist_rotate";
            this.txtBox_dist_rotate.Size = new System.Drawing.Size(89, 21);
            this.txtBox_dist_rotate.TabIndex = 28;
            this.txtBox_dist_rotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(214, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "[mm]";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(17, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "1회전 당 거리: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBar_stepm_speed1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBox_stepm_speed0);
            this.groupBox4.Controls.Add(this.btn_rotation_stepm);
            this.groupBox4.Controls.Add(this.txtBox_stepm_speed1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.trackBar_stepm_speed0);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(741, 139);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "테스트 : 스텝모터";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(158, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "[rpm]";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBox_stepm_speed0
            // 
            this.txtBox_stepm_speed0.Location = new System.Drawing.Point(63, 26);
            this.txtBox_stepm_speed0.Name = "txtBox_stepm_speed0";
            this.txtBox_stepm_speed0.Size = new System.Drawing.Size(89, 21);
            this.txtBox_stepm_speed0.TabIndex = 28;
            this.txtBox_stepm_speed0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_rotation_stepm
            // 
            this.btn_rotation_stepm.Location = new System.Drawing.Point(610, 102);
            this.btn_rotation_stepm.Name = "btn_rotation_stepm";
            this.btn_rotation_stepm.Size = new System.Drawing.Size(124, 31);
            this.btn_rotation_stepm.TabIndex = 22;
            this.btn_rotation_stepm.Text = "스텝모터 동작";
            this.btn_rotation_stepm.UseVisualStyleBackColor = true;
            this.btn_rotation_stepm.Click += new System.EventHandler(this.btn_rotation_stepm_Click);
            // 
            // txtBox_stepm_speed1
            // 
            this.txtBox_stepm_speed1.Location = new System.Drawing.Point(439, 24);
            this.txtBox_stepm_speed1.Name = "txtBox_stepm_speed1";
            this.txtBox_stepm_speed1.Size = new System.Drawing.Size(89, 21);
            this.txtBox_stepm_speed1.TabIndex = 21;
            this.txtBox_stepm_speed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "속도 1 : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(534, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "[rpm]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(377, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 12;
            this.label16.Text = "속도 2 : ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar_stepm_speed0
            // 
            this.trackBar_stepm_speed0.Location = new System.Drawing.Point(9, 51);
            this.trackBar_stepm_speed0.Maximum = 30;
            this.trackBar_stepm_speed0.Name = "trackBar_stepm_speed0";
            this.trackBar_stepm_speed0.Size = new System.Drawing.Size(344, 45);
            this.trackBar_stepm_speed0.TabIndex = 11;
            this.trackBar_stepm_speed0.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_stepm_speed0.Scroll += new System.EventHandler(this.trackBar_stepm_speed0_Scroll);
            // 
            // trackBar_stepm_speed1
            // 
            this.trackBar_stepm_speed1.Location = new System.Drawing.Point(379, 51);
            this.trackBar_stepm_speed1.Maximum = 30;
            this.trackBar_stepm_speed1.Name = "trackBar_stepm_speed1";
            this.trackBar_stepm_speed1.Size = new System.Drawing.Size(344, 45);
            this.trackBar_stepm_speed1.TabIndex = 29;
            this.trackBar_stepm_speed1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_stepm_speed1.Scroll += new System.EventHandler(this.trackBar_stepm_speed1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "자동 제포기 모니터 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabOperation.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blade_distance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_main_mot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_input_mot)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_stepm_speed0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_stepm_speed1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBOX_Search_Device;
        private System.Windows.Forms.Button btn_OpenCommDevice;
        private System.Windows.Forms.TabControl tabOperation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ClearMSG;
        public System.Windows.Forms.ListBox lstBox_MSG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_input_mot;
        private System.Windows.Forms.TrackBar trackBar_main_mot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_main_mot;
        private System.Windows.Forms.Label lbl_input_mot;
        private System.Windows.Forms.CheckBox chckBox_main_mot;
        private System.Windows.Forms.CheckBox chckBox_input_mot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chckBox_blade_B;
        private System.Windows.Forms.CheckBox chckBox_blade_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_blade_distance;
        private System.Windows.Forms.CheckBox chckBox_blade_both;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chckBox_sens;
        private System.Windows.Forms.Label lbl_stop_sens;
        private System.Windows.Forms.Label lbl_input_sens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_distance_blade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_moving_blade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_dist_rotate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar_stepm_speed1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBox_stepm_speed0;
        private System.Windows.Forms.Button btn_rotation_stepm;
        private System.Windows.Forms.TextBox txtBox_stepm_speed1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBar_stepm_speed0;
    }
}

