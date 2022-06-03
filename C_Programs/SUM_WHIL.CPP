#include<stdio.h>
#include<conio.h>
void main ()
{
int no,sum=0,mod;
clrscr();
printf("Enter value of no :");
scanf("%d",&no);
while(no!=0)
{
mod=no%10;
sum=sum+mod;
no=no/10;
}
printf("sum=%d",sum);
getch();
}