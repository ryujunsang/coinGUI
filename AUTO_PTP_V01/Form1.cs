using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//---------------------------       사용자 모듈
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace AUTO_PTP_V01
{
    public partial class Form1 : Form
    {
        //==========================================
        //      변수 정의
        //==========================================
        public static Form1 MForm;
        //--------------------------------------
        //  시리얼 통신 이벤트, 데이터 변수 및 callback 함수
        //--------------------------------------        
        delegate void SetTextCallBack();
        delegate void TimeEventFiredDelegate();
        //------------------------------------      타이머 
        private static System.Timers.Timer com_rx_Timeout = null;

        bool[] bl_Test_Operation_Enable = new bool[] { false, false, false,false,false};
        bool check_op_blade = false;
        bool check_op_stepm = false;


        //==========================================
        //      프로그램 시작시, 윈도우 Form이 그려질때 호출되는 함수
        //
        //==========================================
        public Form1()
        {
            InitializeComponent();
            //------------------------------------       메인 폼을 자식창에서 사용하기 위함
            MForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*************************
             *  통신 설정
             */
            ClassEvntCOMM.commDEVICE = new SerialPort();
            ClassEvntCOMM.commDEVICE.DataReceived += new SerialDataReceivedEventHandler(ON_COM_DATA_RECEIVED);
            cmBOX_Search_Device.Items.Add("None");
            cmBOX_Search_Device.SelectedIndex = 0;

            /*************************
             *  사용자 정의 이벤트
             */
            ClassEvntCOMM.appEVT.OnRxDoEvent += new EventHandler(ClassEvntCOMM.appEVT_OnRxDoEvent);

            /*************************
             *  그래픽 초기 설정
             */
            //------------------------------------      투입 / 메인 : DC 모터
            lbl_input_mot.Text = "0";
            lbl_main_mot.Text = "0";
            trackBar_input_mot.Value = 0;
            trackBar_main_mot.Value = 0;
            //------------------------------------      BLADE 이동 : 스텝모터
            txtBox_distance_blade.Text = "0";
            trackBar_blade_distance.Value = 0;

            /*************************
             *  타이머 설정
             */
            com_rx_Timeout = new System.Timers.Timer();
            com_rx_Timeout.Interval = 10;   //  10msec
            com_rx_Timeout.Elapsed += new System.Timers.ElapsedEventHandler(ON_RCVD_TIMEOUT);

        }

        //================================================================
        //      통신 함수   :   통신 포트 열기 / 데이터 수신
        //
        //      1.  통신 포트 설정
        //      2.  통신 포트 열기/닫기
        //      3.  통신 수신 타임아웃
        //      4.  통신 데이터 수신
        //      5.  Callback 함수
        //================================================================
        private void cmBOX_Search_Device_MouseClick(object sender, MouseEventArgs e)
        {
            cmBOX_Search_Device.Items.Clear();
            //-------------------------------------     통신 포트 찾기
            foreach (string portnumb in SerialPort.GetPortNames())
            {
                cmBOX_Search_Device.Items.Add(portnumb);
            }
        }

        private void btn_OpenCommDevice_Click(object sender, EventArgs e)
        {
            if (cmBOX_Search_Device.Text != String.Empty)
            {
                if (ClassEvntCOMM.commDEVICE.IsOpen == false)
                {
                    try
                    {
                        //-------------------------------------     통신 포트 설정
                        ClassEvntCOMM.commPortNAME = cmBOX_Search_Device.Text;
                        ClassEvntCOMM.commDEVICE.PortName = ClassEvntCOMM.commPortNAME;
                        ClassEvntCOMM.commDEVICE.BaudRate = 115200;
                        ClassEvntCOMM.commDEVICE.DataBits = 8;
                        ClassEvntCOMM.commDEVICE.StopBits = StopBits.One;
                        ClassEvntCOMM.commDEVICE.Parity = Parity.None;
                        //-------------------------------------     통신 포트 열기
                        ClassEvntCOMM.commDEVICE.Open();
                        btn_OpenCommDevice.Text = "통신포트 닫기";
                    }
                    catch
                    {
                        MessageBox.Show("ERROR : 통신 포트를 열 수 없습니다. !!");
                    }
                }
                else
                {
                    //-------------------------------------     통신 포트 닫기
                    ClassEvntCOMM.commDEVICE.Close();
                    btn_OpenCommDevice.Text = "통신포트 열기";
                }
            }
        }
        //-------------------------------------     통신 데이터 수신
        private void ON_COM_DATA_RECEIVED(object sender, SerialDataReceivedEventArgs e)
        {
            //-------------------------------------     데이터를 수신하여 TIME OUT 정지
            com_rx_Timeout.Stop();

            //-------------------------------------     수신데이터 크기
            int si_recvd_size = ClassEvntCOMM.commDEVICE.BytesToRead;
            byte[] tmpRxData = new byte[si_recvd_size];
            //-------------------------------------     수신 데이터 저장
            ClassEvntCOMM.commDEVICE.Read(tmpRxData, 0, si_recvd_size);
            //-------------------------------------     수신 데이터 저장
            if ((ClassCodes.si_WriteIndex + si_recvd_size) >= ClassCodes.UART_BUFFER_LENGTH)
            {
                int tmpLen = ClassCodes.UART_BUFFER_LENGTH - ClassCodes.si_WriteIndex - 1;
                Buffer.BlockCopy(tmpRxData, 0, ClassCodes.b_RcvdBUFF, ClassCodes.si_WriteIndex, tmpLen);
                ClassCodes.si_WriteIndex = (UInt16)((ClassCodes.si_WriteIndex + tmpLen) % ClassCodes.UART_BUFFER_LENGTH);
                Buffer.BlockCopy(tmpRxData, tmpLen, ClassCodes.b_RcvdBUFF, 0, si_recvd_size - tmpLen);
                ClassCodes.si_WriteIndex = (UInt16)(si_recvd_size - tmpLen);
            }
            else
            {
                Buffer.BlockCopy(tmpRxData, 0, ClassCodes.b_RcvdBUFF, ClassCodes.si_WriteIndex, si_recvd_size);
                ClassCodes.si_WriteIndex = (UInt16)((ClassCodes.si_WriteIndex + si_recvd_size) % ClassCodes.UART_BUFFER_LENGTH);
            }

            //-------------------------------------     데이터를 수신완료하여 TIMEOUT 시작
            com_rx_Timeout.Start();
        }
        //-------------------------------------     통신 데이터 수신 : Time Out(10msec)
        private void ON_RCVD_TIMEOUT(object sender, EventArgs e)
        {
            com_rx_Timeout.Stop();
            BeginInvoke(new TimeEventFiredDelegate(ON_RVD_DATA_PARSING));
        }

        //-------------------------------------     수신데이터 분석
        private void ON_RVD_DATA_PARSING()
        {
            ClassEvntCOMM.Data_Parsing();
        }

        //================================================================
        //      투입/메인 모터 속도 및 BLADE 이동 거리
        //
        //      1.  투입모터 속도 설정
        //      2.  메인모터 속도 설정
        //      3.  BLADE 이동거리 설정(TrackBar)
        //      4.  BLADE 이동거리 설정(TextEdit) 
        //================================================================
        private void trackBar_input_mot_Scroll(object sender, EventArgs e)
        {
            lbl_input_mot.Text = Convert.ToString(trackBar_input_mot.Value * 10) ;
        }

        private void trackBar_main_mot_Scroll(object sender, EventArgs e)
        {
            lbl_main_mot.Text = Convert.ToString(trackBar_main_mot.Value * 10);
        }

        private void trackBar_blade_distance_Scroll(object sender, EventArgs e)
        {
            txtBox_distance_blade.Text = Convert.ToString(trackBar_blade_distance.Value);
        }

        private void txtBox_distance_blade_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtBox_distance_blade.Text == string.Empty)
                {
                    trackBar_blade_distance.Value = 0;
                    txtBox_distance_blade.Text = "0";
                }
                else trackBar_blade_distance.Value = Convert.ToInt32(txtBox_distance_blade.Text);
            }
        }
        //================================================================
        //      명령 전송
        //
        //      1.  투입 모터 동작
        //      2.  메인 모터 동작
        //      3.  BLADE 이동(STEP MOTOR 동작)
        //================================================================
        private void chckBox_input_mot_CheckedChanged(object sender, EventArgs e)
        {
            if(chckBox_input_mot.Checked == true)
            {
               var motSPEED = new byte[] {(byte)(trackBar_input_mot.Value * 10)};
                bl_Test_Operation_Enable[0] = true;
                ClassEvntCOMM.Send_command_Data((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_INPUT_MOT_START, motSPEED, 1);
            }
            else
            {
                bl_Test_Operation_Enable[0] = false;
                ClassEvntCOMM.Send_event_Command((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_INPUT_MOT_STOP);
            }
        }

        private void chckBox_main_mot_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBox_main_mot.Checked == true)
            {
                var motSPEED = new byte[] { (byte)(trackBar_main_mot.Value * 10) };
                bl_Test_Operation_Enable[1] = true;
                ClassEvntCOMM.Send_command_Data((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_MAIN_MOT_START, motSPEED, 1);
            }
            else
            {
                bl_Test_Operation_Enable[1] = false;
                ClassEvntCOMM.Send_event_Command((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_MAIN_MOT_STOP);
            }
        }

        private void btn_moving_blade_Click(object sender, EventArgs e)
        {
            if (check_op_blade == false) 
            {
                check_op_blade = true;
                var senDATA = new byte[] { (byte)ClassCodes.Step_Mot_OPEARTE.MO_CTRL_DIST, (byte)trackBar_blade_distance.Value,0,0,0};
                if (chckBox_blade_A.Checked)    senDATA[2]  =   0x01;
                if (chckBox_blade_B.Checked)    senDATA[3]  =   0x01;
                senDATA[4] = Convert.ToByte(txtBox_dist_rotate.Text);
                bl_Test_Operation_Enable[3] = true;
                btn_moving_blade.Text = "BLADE 정지";
                ClassEvntCOMM.Send_command_Data((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_BLADE_START, senDATA,5);
            }
            else
            {
                check_op_blade = false;
                bl_Test_Operation_Enable[3] = false;
                btn_moving_blade.Text = "BLADE 동작";
                ClassEvntCOMM.Send_event_Command((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_BLADE_STOP);
            }
        }

        private void btn_ClearMSG_Click(object sender, EventArgs e)
        {
            lstBox_MSG.Items.Clear();
        }

        private void trackBar_stepm_speed0_Scroll(object sender, EventArgs e)
        {
            txtBox_stepm_speed0.Text = Convert.ToString(trackBar_stepm_speed0.Value * 10);
        }

        private void trackBar_stepm_speed1_Scroll(object sender, EventArgs e)
        {
            txtBox_stepm_speed1.Text = Convert.ToString(trackBar_stepm_speed1.Value * 10);
        }

        private void btn_rotation_stepm_Click(object sender, EventArgs e)
        {
            if (check_op_stepm == false)
            {
                check_op_stepm = true;
                bl_Test_Operation_Enable[2] = true;
                var senDATA = new byte[] { (byte)ClassCodes.Step_Mot_OPEARTE.MO_CTRL_SPEED, (byte)trackBar_stepm_speed0.Value,(byte)trackBar_stepm_speed1.Value,0,0};
                if (trackBar_stepm_speed0.Value != 0) senDATA[3] = 0x01;
                if (trackBar_stepm_speed1.Value != 0) senDATA[4] = 0x01;
                btn_moving_blade.Text = "스텝모터 정지";
                ClassEvntCOMM.Send_command_Data((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_BLADE_START, senDATA, 5);
            }
            else
            {
                check_op_stepm = false;
                bl_Test_Operation_Enable[2] = false;
                btn_rotation_stepm.Text = "스텝모터 동작";
                ClassEvntCOMM.Send_event_Command((byte)ClassCodes.Cmd_Comm_Code.M2D_TEST_BLADE_STOP);
            }
        }
    }
}
