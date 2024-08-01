/**********************************************************************

交通科技大赛烧写程序_传感器_单片机_A6模块_云服务器_APP

***********************************************************************/

#include "main.h"
#include "HX711.h"
#include "uart.h"
#include "string.h"
#include <stdio.h>
typedef 	unsigned char	u8;
typedef 	unsigned int	u16;
typedef 	unsigned long	u32;
#define UART1_SendLR() UART1_SendData(0X0D)
#define GapValue 22
#define Buf_Max 70 
unsigned long HX711_Buffer = 0;
unsigned long Weight_Maopi = 0;
long Weight_Shiwu = 0;
xdata u8 Uart1_Buf[Buf_Max];
unsigned char flag = 0;
bit Flag_ERROR = 0;
u8 First_Int = 0;
u16 count_20ms;
u8 TIME = 2;//2ms

void Timer0Init(void){		//20毫秒@115200
	TMOD &= 0xF0;		
	TMOD |= 0x01;		//
	TL0 = (65536-20000)%256;		//
	TH0 = (65536-20000)/256;		//
	TF0 = 0;		//
	ET0 = 1;    	  //
	TR0 = 1;		//开始计时
}
void UART1_SendData(u8 dat){
	ES=0;			//关串口中断
	SBUF=dat;			
	while(TI!=1);	//等待发送成功
	TI=0;			//清除发送中断标志
	ES=1;			//开串口中断
}
void CLR_Buf(void){
	u8 k;
	for(k=0;k<Buf_Max;k++)      //将缓存内容清零
	{
		Uart1_Buf[k] = 0x00;
	}
    First_Int = 0;              //接收字符串的起始存储位置
}


void delay_ms( ms){
	 count_20ms = ms;
	 while(count_20ms);
}

void Timer0_ISR() interrupt 1{
	TR0=0;//关定时器
	TL0 = (65536-20000)%256;		//重设定时器初值
	TH0 = (65536-20000)/256;		//
	
	if(count_20ms > 0) //20ms延时计数器
	{
		count_20ms--;
	}	
	
	TR0=1;//开定时器
}
void UART1_ISR (void) interrupt 4{
	if (RI)
	{
		RI = 0;                           //清除RI位
		Uart1_Buf[First_Int] = SBUF;  	  //将接收到的字符串存到缓存中
		First_Int++;                	  	//缓存指针向后移动
		if(First_Int >= Buf_Max)       	  //如果缓存满,将缓存指针指向缓存的首地址
		{
			First_Int = 0;
		}		
	}
	if (TI)
	{
		TI = 0;                          //清除TI位
	}
}
void UART1_Send_Command(char *s){
	CLR_Buf(); 
	while(*s)//检测字符串结束符
	{
		UART1_SendData(*s++);//发送当前字符
	}
    UART1_SendLR();
}

u8 Find(){ 

	ES = 0;  //改进程序
	
	
	if( strstr(Uart1_Buf,"op")!=NULL)	
	{
		if( strstr(Uart1_Buf,"opmp")!=NULL)	
		{
			Get_Maopi();
		}
		else if(strstr(Uart1_Buf,"opt")!=NULL)//optX
		{	
			switch(Uart1_Buf[3]){
				case '2':TIME = 2; break;
				case '3':TIME = 3; break;
				case '5':TIME = 5; break;
				case 'a':TIME = 10; break;
				default: TIME = 2;
			} 
			
		}
			
	}

	ES = 1;
	

	return 0;
	
		
}



u8 UART1_Correspond(u8 *b,u16 interval_time){
	CLR_Buf(); 
	UART1_Send_Command(b);
	delay_ms(interval_time);
	Find();
	return 0;
}


void Get_Weight(){
	Weight_Shiwu = HX711_Read();
	Weight_Shiwu = Weight_Shiwu - Weight_Maopi;		//获取净重
	if(Weight_Shiwu > 0)			
	{	
		Weight_Shiwu = (unsigned int)((float)Weight_Shiwu/GapValue); 	//计算实物的实际重量
																		
																		
		if(Weight_Shiwu > 100000)		//超重报警
		{
			Flag_ERROR = 1;	
		}
		else
		{
			Flag_ERROR = 0;
		}
	}
	else
	{
		Weight_Shiwu = 0;
		Flag_ERROR = 1;				//负重报警
	}
	
}

void Get_Maopi(){
	Weight_Maopi = HX711_Read();	
} 
void Delay_ms1(unsigned int n){
	unsigned int  i,j;
	for(i=0;i<n;i++)
		for(j=0;j<123;j++);
}
//****************************************************
//主函数
//****************************************************
void main()	
{
	char a[7];
     
	u8 i;	
	Timer0Init();
    Uart_Init();
	Get_Maopi();				//称毛皮重量
	EA = 1;      //开启总中断
	for(i = 0;i < 10;i++)//等待网络稳定
	{
		delay_ms(50);
	}


	a[0]='0';
  a[1]='3';
	a[2]=(0X30);
  a[3]=(0X30);
	a[5]=(0X30);
	a[6]=(0X30);
	a[4]='.';
	//a[5]='\n';	

	while(1)
	{
		EA = 0;
		Get_Weight();			
		EA = 1;
		if( Flag_ERROR == 1)
		{
           UART1_Send_Command("0300.00");
		}		
		else
		{				
			a[2]=(Weight_Shiwu/10000 + 0X30);
           a[3]=(Weight_Shiwu%10000/1000 + 0X30);
           a[5]=(Weight_Shiwu%1000/100 + 0X30);	
           a[6]=(Weight_Shiwu%100/10 + 0X30);	
			UART1_Correspond(a,50);
			Delay_ms1((TIME-1)*1000);
		}  

	  
		


			
	}	
}


