#include "uart.h"

//unsigned char RX_Buffer[30];
unsigned char Num = 0;
bit Flag_Receive_OK = 0;

void Uart_Init()					  			   
{
PCON &= 0x7F;		//
	SCON = 0x50;		//
	TMOD &= 0x0F;		//
	TMOD |= 0x20;		//
	TL1 = 0xFD;		  //
	TH1 = 0xFD;		  //
	ET1 = 0;		    //
	TR1 = 1;		    //
	ES  = 1;
}

