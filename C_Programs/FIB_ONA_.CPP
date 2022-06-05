#include<stdio.h>
#include<conio.h>
void main()
{
int i,n,a=0,b=1,c=0;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
i=1;
while(i<=n)
{
printf("%d ",c);
a=b;
b=c;
c=a+b;
i++;
}
getch();
}