﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTO_PTP_V01
{
    class ClassCodes
    {
        //-----------------------------------------------          명령
        public enum Cmd_Comm_Code
        {
			COM_IDLE = 0,
			//-------------------------------		부팅 및 시스템
			M2D_SYS_RESET,                          //		시스템 리셋
			M2D_POWER_ON_NOTIFY,                    //		POWER ON 알림
			M2D_REQ_SYSINFO,                        //		시스템 정보 요청

			//-------------------------------
			// 제포기 동작 명령	:	PARTS 테스트
			M2D_TEST_INPUT_MOT_START = 0x10,
			M2D_TEST_INPUT_MOT_STOP,
			M2D_TEST_MAIN_MOT_START,
			M2D_TEST_MAIN_MOT_STOP,
			M2D_TEST_BLADE_START,
			M2D_TEST_BLADE_STOP,
			M2D_TEST_SENS_START,
			M2D_TEST_SENS_STOP,
			//-------------------------------
			// 제포기 동작 명령	:	제포기 투입
			M2D_BLADE_HOME = 0x20,
			M2D_BLADE_SET_START,
			M2D_BLADE_SET_STOP,
			M2D_PTP_START,
			M2D_PTP_STOP,
			//-------------------------------
			// 제포기 동작 명령	:	제포기 투입
			//-------------------------------		시스템 상태
			D2M_POWER_ON_NOTIFY = 0x80,
			D2M_SYS_INFO,                           //     	시스템 정보
			D2M_DEV_STATE,                          //		시스템 상태
			D2M_TEST_SENS_STATE,                    //     	센서 상태
			D2M_BLADE_STATE,
			D2M_PTP_INFO,
			COM_CMD_DEFAULT = 0xFF
		};

		public enum Error_State_Code
		{
			ERROR_NONE = 0x00,
			//-------------------------------	에러	:	시스템
			ERROR_NONE_TABLET,
		};

        public enum Step_Mot_OPEARTE
        {
            MO_CTRL_SPEED = 0,
            MO_CTRL_DIST,
            MO_CTRL_ANGLE
        }
        
        //-----------------------------------------------          CRC 데이터
        public static UInt16[] xcrc16tab = new UInt16[] {
            0x0000,  0x1021,  0x2042,  0x3063,  0x4084,  0x50a5,  0x60c6,  0x70e7,
            0x8108,  0x9129,  0xa14a,  0xb16b,  0xc18c,  0xd1ad,  0xe1ce,  0xf1ef,
            0x1231,  0x0210,  0x3273,  0x2252,  0x52b5,  0x4294,  0x72f7,  0x62d6,
            0x9339,  0x8318,  0xb37b,  0xa35a,  0xd3bd,  0xc39c,  0xf3ff,  0xe3de,
            0x2462,  0x3443,  0x0420,  0x1401,  0x64e6,  0x74c7,  0x44a4,  0x5485,
            0xa56a,  0xb54b,  0x8528,  0x9509,  0xe5ee,  0xf5cf,  0xc5ac,  0xd58d,
            0x3653,  0x2672,  0x1611,  0x0630,  0x76d7,  0x66f6,  0x5695,  0x46b4,
            0xb75b,  0xa77a,  0x9719,  0x8738,  0xf7df,  0xe7fe,  0xd79d,  0xc7bc,
            0x48c4,  0x58e5,  0x6886,  0x78a7,  0x0840,  0x1861,  0x2802,  0x3823,
            0xc9cc,  0xd9ed,  0xe98e,  0xf9af,  0x8948,  0x9969,  0xa90a,  0xb92b,
            0x5af5,  0x4ad4,  0x7ab7,  0x6a96,  0x1a71,  0x0a50,  0x3a33,  0x2a12,
            0xdbfd,  0xcbdc,  0xfbbf,  0xeb9e,  0x9b79,  0x8b58,  0xbb3b,  0xab1a,
            0x6ca6,  0x7c87,  0x4ce4,  0x5cc5,  0x2c22,  0x3c03,  0x0c60,  0x1c41,
            0xedae,  0xfd8f,  0xcdec,  0xddcd,  0xad2a,  0xbd0b,  0x8d68,  0x9d49,
            0x7e97,  0x6eb6,  0x5ed5,  0x4ef4,  0x3e13,  0x2e32,  0x1e51,  0x0e70,
            0xff9f,  0xefbe,  0xdfdd,  0xcffc,  0xbf1b,  0xaf3a,  0x9f59,  0x8f78,
            0x9188,  0x81a9,  0xb1ca,  0xa1eb,  0xd10c,  0xc12d,  0xf14e,  0xe16f,
            0x1080,  0x00a1,  0x30c2,  0x20e3,  0x5004,  0x4025,  0x7046,  0x6067,
            0x83b9,  0x9398,  0xa3fb,  0xb3da,  0xc33d,  0xd31c,  0xe37f,  0xf35e,
            0x02b1,  0x1290,  0x22f3,  0x32d2,  0x4235,  0x5214,  0x6277,  0x7256,
            0xb5ea,  0xa5cb,  0x95a8,  0x8589,  0xf56e,  0xe54f,  0xd52c,  0xc50d,
            0x34e2,  0x24c3,  0x14a0,  0x0481,  0x7466,  0x6447,  0x5424,  0x4405,
            0xa7db,  0xb7fa,  0x8799,  0x97b8,  0xe75f,  0xf77e,  0xc71d,  0xd73c,
            0x26d3,  0x36f2,  0x0691,  0x16b0,  0x6657,  0x7676,  0x4615,  0x5634,
            0xd94c,  0xc96d,  0xf90e,  0xe92f,  0x99c8,  0x89e9,  0xb98a,  0xa9ab,
            0x5844,  0x4865,  0x7806,  0x6827,  0x18c0,  0x08e1,  0x3882,  0x28a3,
            0xcb7d,  0xdb5c,  0xeb3f,  0xfb1e,  0x8bf9,  0x9bd8,  0xabbb,  0xbb9a,
            0x4a75,  0x5a54,  0x6a37,  0x7a16,  0x0af1,  0x1ad0,  0x2ab3,  0x3a92,
            0xfd2e,  0xed0f,  0xdd6c,  0xcd4d,  0xbdaa,  0xad8b,  0x9de8,  0x8dc9,
            0x7c26,  0x6c07,  0x5c64,  0x4c45,  0x3ca2,  0x2c83,  0x1ce0,  0x0cc1,
            0xef1f,  0xff3e,  0xcf5d,  0xdf7c,  0xaf9b,  0xbfba,  0x8fd9,  0x9ff8,
            0x6e17,  0x7e36,  0x4e55,  0x5e74,  0x2e93,  0x3eb2,  0x0ed1,  0x1ef0
        };

        /**************************************************************************************
         * 
         *  통신 데이터 변수
         */
        //-----------------------------------------------           상수선언    :   버퍼 및 데이터 크기 
        public const UInt16 SIZE_OF_MSG_HEAD = 5;
        public const UInt16 SIZE_OF_MESSAGE = 1024;
        public const UInt16 UART_BUFFER_LENGTH = SIZE_OF_MESSAGE + SIZE_OF_MSG_HEAD;
        //-----------------------------------------------           상수 선언   :   통신 데이터
        public const byte STX = 0x02;
        public const byte ACK = 0x76;
        public const byte NACK = 0x75;
        //-----------------------------------------------           수신데이터 변수
        public static byte[] b_RcvdBUFF = new byte[UART_BUFFER_LENGTH];
        public static UInt16 si_WriteIndex = 0;
        public static UInt16 si_ReadIndex = 0;
        public struct t_com_rx_data
        {
            public static byte by_rx_data_type;
            public static UInt16 u16_rx_addr;
            public static UInt16 si_rx_data_len;
            public static byte by_rx_data_cmd;
            public static byte[] by_uart_rx_data = new byte[UART_BUFFER_LENGTH];
        };

        //-----------------------------------------------          송신데이터 변수
        public static byte[] by_SendData = new byte[UART_BUFFER_LENGTH];

        //-----------------------------------------------          데이터 수신 상태
        public enum rx_data_state
        {
            CRM_MSG_TYPE = 0,
            CRM_MSG_ADDR,
            CRM_MSG_LEN,
            CRM_MSG_CMD,
            CRM_MSG_DATA,
            CRM_MSG_CRC
        };
    }
}
