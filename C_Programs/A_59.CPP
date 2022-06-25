#include<stdio.h>
#include<conio.h>
void main()
{
int y=1,x,n;
clrscr();
printf("Enter value of x=");
scanf("%d",&x);
printf("Enter value of n=");
scanf("%d",&n);
for(int i=1;i<=n; i++)
{
y=y*x;
}
printf("y=%d",y);
getch();
}
