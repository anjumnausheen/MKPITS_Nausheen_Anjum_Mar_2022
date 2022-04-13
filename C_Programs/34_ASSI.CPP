#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int x,y,temp,i,sum=0;
printf("\n input the first integer :");
scanf("%d",&x);
printf("\n input the second integer:");
scanf("%d",&y);
if(x>y)
{
temp=y;
y=x;
x=temp;
}
for(i=x;i<=y;i++)
{
if((i%17)!=0)
{
sum+=i;
}
}
printf("\n sum:%d \n ",sum);
getch();
}