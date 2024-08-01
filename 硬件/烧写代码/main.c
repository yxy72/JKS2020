/**********************************************************************

��ͨ�Ƽ�������д����_������_��Ƭ��_A6ģ��_�Ʒ�����_APP

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
#define Buf_Max 	 	  70 
unsigned long HX711_Buffer = 0;
unsigned long Weight_Maopi = 0;
long Weight_Shiwu = 0;
xdata u8 Uart1_Buf[Buf_Max];
unsigned char flag = 0;
bit Flag_ERROR = 0;
idata char server_ip_port_cmd[45];
u8 First_Int = 0;
u16 count_20ms;

u8 s = '0';
u8* r = "cdd";

sbit LED1 = P1^0;
sbit LED2 = P1^1;
sbit LED3 = P1^2;
sbit LED4 = P1^3;
sbit LED5 = P1^4;
sbit LED6 = P1^5;
sbit LED7 = P1^6;
sbit LED8 = P1^7;


void Timer0Init(void){		//20����@115200
	TMOD &= 0xF0;		
	TMOD |= 0x01;		//
	TL0 = (65536-20000)%256;		//
	TH0 = (65536-20000)/256;		//
	TF0 = 0;		//
	ET0 = 1;    	  //
	TR0 = 1;		//��ʼ��ʱ
}
void UART1_SendData(u8 dat){
	ES=0;			//�ش����ж�
	SBUF=dat;			
	while(TI!=1);	//�ȴ����ͳɹ�
	TI=0;			//��������жϱ�־
	ES=1;			//�������ж�
}
void CLR_Buf(void){
	u8 k;
	for(k=0;k<Buf_Max;k++)      //��������������
	{
		Uart1_Buf[k] = 0x00;
	}
    First_Int = 0;              //�����ַ�������ʼ�洢λ��
}


void delay_ms( ms){
	 count_20ms = ms;
	 while(count_20ms);
}

void Timer0_ISR() interrupt 1{
	TR0=0;//�ض�ʱ��
	TL0 = (65536-20000)%256;		//���趨ʱ����ֵ
	TH0 = (65536-20000)/256;		//
	
	if(count_20ms > 0) //20ms��ʱ������
	{
		count_20ms--;
	}	
	
	TR0=1;//����ʱ��
}
void UART1_ISR (void) interrupt 4{
	if (RI)
	{
		RI = 0;                           //���RIλ
		Uart1_Buf[First_Int] = SBUF;  	  //�����յ����ַ����浽������
		First_Int++;                	  //����ָ������ƶ�
		if(First_Int >= Buf_Max)       	  //���������,������ָ��ָ�򻺴���׵�ַ
		{
			First_Int = 0;
		}		
	}
	if (TI)
	{
		TI = 0;                          //���TIλ
	}
}
void UART1_Send_Command(char *s){
	CLR_Buf(); 
	while(*s)//����ַ���������
	{
		UART1_SendData(*s++);//���͵�ǰ�ַ�
	}
    UART1_SendLR();
	//ART1_SendData('\r');
	//UART1_SendData('\n');
}

u8 Find(){ 

	ES = 0;  //�Ľ�����
	
	

	if( strstr(Uart1_Buf,"GV")!=NULL)	
	{
	
		r = strstr(Uart1_Buf,"GV");
		UART1_Send_Command("��");
		LED3 = ~LED3;
		ES = 1;
		

	}else if(strstr(Uart1_Buf,"cnb")!=NULL)
		LED2 = ~LED2;


ES = 1;

	return 0;
	
		
}





u8 UART1_Correspond(u8 *b,u16 interval_time)         {


	CLR_Buf(); 

	
	UART1_Send_Command(b);
	delay_ms(interval_time);
	Find()	;
	return 0;
}






void Get_Weight(){
	Weight_Shiwu = HX711_Read();
	Weight_Shiwu = Weight_Shiwu - Weight_Maopi;		//��ȡ����
	if(Weight_Shiwu > 0)			
	{	
		Weight_Shiwu = (unsigned int)((float)Weight_Shiwu/GapValue); 	//����ʵ���ʵ������
																		
																		
		if(Weight_Shiwu > 100000)		//���ر���
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
		Flag_ERROR = 1;				//���ر���
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
//������
//****************************************************
void main()	
{
	char a[7];
     
	u8 i;	
	Timer0Init();
    Uart_Init();
//	Get_Maopi();				//��ëƤ����
	EA = 1;      //�������ж�
	for(i = 0;i < 30;i++)//�ȴ������ȶ�
	{
		delay_ms(50);
	}


	a[0]='0';
   	a[1]='6';
	a[2]=(0X30);
   	a[3]=(0X30);
	a[5]=(0X30);
	a[6]=(0X30);
	a[4]='.';
	//a[5]='\n';	

	while(1)
	{
	//	EA = 0;
	//	Get_Weight();			
	//	EA = 1;
		LED1 = ~LED1;
	/*	if( Flag_ERROR == 1)
		{
           UART1_Send_Command("0600.00");
		}		
		else
		{				
			a[2]=(Weight_Shiwu/10000 + 0X30);
            a[3]=(Weight_Shiwu%10000/1000 + 0X30);
            a[5]=(Weight_Shiwu%1000/100 + 0X30);	
            a[6]=(Weight_Shiwu%100/10 + 0X30);	
		
			UART1_Send_Command(a);
		}  

	  */
	//	UART1_Send_Command(r)	;
		UART1_Correspond(r,50);
	//	UART1_Send_Command("cnd")	 ;


		Delay_ms1(2000);	
	}	
}


