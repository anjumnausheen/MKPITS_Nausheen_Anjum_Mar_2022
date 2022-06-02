#include<stdio.h>
#include<conio.h>
void main()
{
int i,n,a=0,b=1,c=0;
clrscr();
printf("Enter value of n : ");
scanf("%d",&n);
for(i=1;i<=n;i++)
{
printf("%d ",c);
a=b;
b=c;
c=a+b;
}
getch();
}