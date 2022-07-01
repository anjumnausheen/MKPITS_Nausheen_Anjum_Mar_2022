#include<stdio.h>
#include<conio.h>
void main()
{
int x,y,sum;
clrscr();
printf("Enter 1st value :");
scanf("%d",&x);
printf("Enter 2nd value :");
scanf("%d",&y);
sum=x+y;
if(x==30 || y==30 || sum==30)
{
printf("Sum=%d\nresult=True",sum);
}
else
printf("Sum=%d\nresult=False",sum);
getch();
}