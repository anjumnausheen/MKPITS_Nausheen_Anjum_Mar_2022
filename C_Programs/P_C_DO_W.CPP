#include<stdio.h>
#include<conio.h>
void main ()
{
int i,p,b,f=1;
clrscr();
printf("Enter value of power and base :");
scanf("%d%d",&p,&b);
i=1;
do
{
f=f*b;
i++;
}while(i<=p);
printf("power calculation = %d",f);
getch();
}