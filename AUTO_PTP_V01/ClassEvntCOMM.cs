using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------------------------------------------------------------       사용자 모듈
using System.IO;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;

namespace AUTO_PTP_V01
{
    //---------------------------------------------------------------       사용자 이벤트 클래스
    public class AppRxEvent
    {
        public event EventHandler OnRxDoEvent;
        public class RxDoEventArges : EventArgs
        {
            public byte bRstMsg;
        }
        public void DoEvent(byte cmd)
        {
            RxDoEventArges arg = new RxDoEventArges();
            arg.bRstMsg = cmd;
            this.OnRxDoEvent(this, arg);
        }
    }

    class ClassEvntCOMM
    {
        //===============================================================================
        //      변수 정의
        //===============================================================================
        public static string strRxMsg = string.Empty;
        public static SerialPort commDEVICE;
        public static string commPortNAME;
        //--------------------------------------
        //  사용자 정의 이벤트
        //--------------------------------------
        public static AppRxEvent appEVT = new AppRxEvent();


        //===============================================================================
        //      어플리케이션 명령 처리 이벤트
        //===============================================================================
        public static void appEVT_OnRxDoEvent(object sender, EventArgs e)
        {
            appEVT_AutoCannistor(((AppRxEvent.RxDoEventArges)e).bRstMsg);
        }
        //===============================================================================
        //      통신관련 함수
        //
        //      1.  CRC 체크 : BYTE
        //      2.  CRC 체크 : 16BIT
        //      3.  전송할 이벤트 데이터 생성
        //      4.  전송할 데이터 데이터 생성
        //      5.  이벤트 전송 명령
        //      6.  데이터 전송 명령
        //      7.  수신 데이터 PARSING
        //===============================================================================
        //--------------------------------------------------        CRC 체크
        public static UInt16 CRC8_B(UInt16 _crc_data, byte _by_data)
        {
            return (UInt16)((_crc_data << 8) ^ ClassCodes.xcrc16tab[(_crc_data >> 8) ^ _by_data]);
        }
        public static UInt16 xCRC16_Q(byte[] bybuff, UInt16 nbytes)
        {
            UInt16 i;
            UInt16 crc;
            byte bytemp;
            crc = 0;
            for (i = 0; i < nbytes; i++)
            {
                bytemp = bybuff[i];
                crc = (UInt16)((crc << 8) ^ ClassCodes.xcrc16tab[(crc >> 8) ^ bytemp]);
            }
            return crc;
        }

        private static int Trans_event_to_comdata(byte[] SendData, byte _cmd)
        {
            int si_DataLen = 1;
            int si_sendCount = 0;
            UInt16 u16_tmp = 0;

            SendData[si_sendCount++] = 0x02;
            SendData[si_sendCount++] = (byte)((si_DataLen >> 8) & 0x0FF);
            SendData[si_sendCount++] = (byte)(si_DataLen & 0x0FF);
            SendData[si_sendCount++] = (byte)_cmd;
            u16_tmp = xCRC16_Q(SendData, (UInt16)(si_sendCount));
            SendData[si_sendCount++] = (byte)((u16_tmp >> 8) & 0x0FF);
            SendData[si_sendCount++] = (byte)(u16_tmp & 0x0FF);
            return si_sendCount;
        }

        private static int Trans_data_to_comdata(byte[] SendData, byte _cmd, byte[] _data, int _size)
        {
            int si_DataLen = _size + 1;
            int si_sendCount = 0;
            UInt16 u16_tmp = 0;

            SendData[si_sendCount++] = 0x02;
            SendData[si_sendCount++] = (byte)((si_DataLen >> 8) & 0x0FF);
            SendData[si_sendCount++] = (byte)(si_DataLen & 0x0FF);
            SendData[si_sendCount++] = (byte)_cmd;
            if (_size != 0)
                Buffer.BlockCopy(_data, 0, SendData, si_sendCount, _size);
            si_sendCount += _size;
            u16_tmp = xCRC16_Q(SendData, (UInt16)(si_sendCount));
            SendData[si_sendCount++] = (byte)((u16_tmp >> 8) & 0x0FF);
            SendData[si_sendCount++] = (byte)(u16_tmp & 0x0FF);
            return si_sendCount;
        }

        public static void Send_event_Command(byte _cmd)
        {
            if (commDEVICE.IsOpen)
            {
                int LenOfSend = Trans_event_to_comdata(ClassCodes.by_SendData, _cmd);
                commDEVICE.Write(ClassCodes.by_SendData, 0, LenOfSend);
            }
        }
        public static void Send_command_Data(byte _cmd, byte[] _data, int _size)
        {
            if (commDEVICE.IsOpen)
            {
                int LenOfSend = Trans_data_to_comdata(ClassCodes.by_SendData, _cmd, _data, _size);
                commDEVICE.Write(ClassCodes.by_SendData, 0, LenOfSend);
            }
        }

        public static void Data_Parsing()
        {
            //--------------------------------------------------        연결된 디바이스 : 캐니스터일 때
            byte byteData;
            byte rx_state = 0;
            UInt16 by_Chk_CRC = 0;
            UInt16 by_Rcvd_CRC = 0;
            int si_Uart_Rx_Count = 0;
            while (ClassCodes.si_WriteIndex != ClassCodes.si_ReadIndex)
            {
                byteData = ClassCodes.b_RcvdBUFF[ClassCodes.si_ReadIndex++];
                ClassCodes.si_ReadIndex = (UInt16)(ClassCodes.si_ReadIndex % ClassCodes.UART_BUFFER_LENGTH);
                switch (rx_state)
                {
                    //--------------------------------------------------        수신 데이터 : 메시지 타입
                    case (byte)ClassCodes.rx_data_state.CRM_MSG_TYPE:
                        if (byteData == ClassCodes.STX)
                        {
                            ClassCodes.t_com_rx_data.by_rx_data_type = byteData;
                            by_Chk_CRC = 0;
                            by_Chk_CRC = CRC8_B(by_Chk_CRC, byteData); ;
                            si_Uart_Rx_Count = 0;
                            rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_LEN;
                        }
                        else
                        {
                            if (byteData == 0x0d)
                            {
                                Form1.MForm.lstBox_MSG.Items.Add(strRxMsg);
                                Form1.MForm.lstBox_MSG.SelectedIndex = Form1.MForm.lstBox_MSG.Items.Count - 1;
                                strRxMsg = string.Empty;
                            }
                            else strRxMsg += (char)byteData;
                        }

                        break;
                    //--------------------------------------------------        수신 데이터 : length
                    case (byte)ClassCodes.rx_data_state.CRM_MSG_LEN:
                        by_Chk_CRC = CRC8_B(by_Chk_CRC, byteData);
                        if (si_Uart_Rx_Count++ == 0)
                        {
                            ClassCodes.t_com_rx_data.si_rx_data_len = byteData;
                            ClassCodes.t_com_rx_data.si_rx_data_len = (UInt16)(ClassCodes.t_com_rx_data.si_rx_data_len << 8);
                        }
                        else
                        {
                            si_Uart_Rx_Count = 0;
                            ClassCodes.t_com_rx_data.si_rx_data_len += byteData;
                            rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_CMD;
                        }
                        break;
                    //--------------------------------------------------        수신 데이터 : command
                    case (byte)ClassCodes.rx_data_state.CRM_MSG_CMD:
                        by_Chk_CRC = CRC8_B(by_Chk_CRC, byteData);
                        ClassCodes.t_com_rx_data.by_rx_data_cmd = byteData;
                        ClassCodes.t_com_rx_data.si_rx_data_len -= 1;
                        si_Uart_Rx_Count = 0;
                        if (ClassCodes.t_com_rx_data.si_rx_data_len == 0)
                        {
                            if (ClassCodes.t_com_rx_data.by_rx_data_cmd == ClassCodes.ACK)
                                rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_TYPE;
                            else if (ClassCodes.t_com_rx_data.by_rx_data_cmd == ClassCodes.NACK) { }
                            else
                                rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_CRC;
                        }
                        else
                            rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_DATA;
                        break;
                    //--------------------------------------------------        수신 데이터 : data
                    case (byte)ClassCodes.rx_data_state.CRM_MSG_DATA:
                        by_Chk_CRC = CRC8_B(by_Chk_CRC, byteData);
                        ClassCodes.t_com_rx_data.by_uart_rx_data[si_Uart_Rx_Count++] = byteData;
                        if (si_Uart_Rx_Count >= ClassCodes.t_com_rx_data.si_rx_data_len)
                        {
                            si_Uart_Rx_Count = 0;
                            rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_CRC;
                        }
                        break;
                    //--------------------------------------------------        수신 데이터 : CRC 체크
                    case (byte)ClassCodes.rx_data_state.CRM_MSG_CRC:
                        if (si_Uart_Rx_Count++ == 0)
                        {
                            by_Rcvd_CRC = byteData;
                            by_Rcvd_CRC = (UInt16)(by_Rcvd_CRC << 8);
                        }
                        else
                        {
                            by_Rcvd_CRC += byteData;
                            if (by_Rcvd_CRC == by_Chk_CRC)
                            {
                                appEVT.DoEvent(ClassCodes.t_com_rx_data.by_rx_data_cmd);
                            }
                            else
                            {
                            }
                            rx_state = (byte)ClassCodes.rx_data_state.CRM_MSG_TYPE;
                        }
                        break;
                }
            }
        }

        //===============================================================================
        //      어플리케이션 명령 처리 이벤트    : 자동 캐니스터
        //===============================================================================
        public static void appEVT_AutoCannistor(byte rcvdCommand)
        {
            switch (rcvdCommand)
            {
                //-------------------------------------     통신 설정 후 : 장치 연결 정보 표시
                case (byte)ClassCodes.Cmd_Comm_Code.M2D_REQ_SYSINFO:
                    break;
                //-------------------------------------     테스트 모드 : 센서 값 또는 상태 표시
                case (byte)ClassCodes.Cmd_Comm_Code.D2M_TEST_SENS_STATE:
                    break;
            }
        }
    }
}
