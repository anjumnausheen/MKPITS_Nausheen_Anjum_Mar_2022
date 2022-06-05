#include<stdio.h>
#include<conio.h>
void main()
{
int no,sum=0,mod;
clrscr();
printf("Enter value of no :");
scanf("%d",&no);
do
{
mod=no%10;
sum=sum+mod;
no=no/10;
}while(no!=0);
printf("Sum=%d",sum);
getch();
}