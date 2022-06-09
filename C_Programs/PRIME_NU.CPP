#include<stdio.h>
#include<conio.h>
void main()
{
int flag=0,m=0,n,i;
clrscr();
printf("Enter any number:");
scanf("%d",&n);
m=n/2;
for(i=2;i<=m;i++)
{
if(n%i==0)
{
flag=1;
printf("Not prime");
break;
}
}
if(flag==0)
{
printf("prime Number");
}
getch();
}
