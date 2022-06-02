#include<stdio.h>
#include<conio.h>
void main ()
{
int i,p,b,f=1;
clrscr();
printf("Enter power and base value :");
scanf("%d%d",&p,&b);
for(i=1;i<=p;i++)
{
f=f*b;
}
printf("Power calculation = %d",f);
getch();
}