#include<stdio.h>
#include<conio.h>
void main()
{
int i,m=0,n;
clrscr();
printf("Prime numbers from 1 to 200 \n");
for(n=1;n<=200;n++)
{
for(i=1;i<=n;i++)
{
if(n%i==0)
{
m=m+1;
}
}
if(m==2)
{
printf("%d ",n);
}
m=0;
}
getch();
}