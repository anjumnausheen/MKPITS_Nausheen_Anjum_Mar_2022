#include<stdio.h>
#include<conio.h>
void main ()
{
int multi=1,mod ,no;
clrscr();
printf("Enter value of no :");
scanf("%d",&no);
do
{
mod=no%10;
multi=multi*mod;
no=no/10;
}while(no!=0);
printf("multi=%d",multi);
getch();
}