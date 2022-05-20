#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int a,b,c,d;
float e;
printf("Enter the value of a,b,c,d variables :");
scanf("%d%d%d%d",&a,&b,&c,&d);
e=(a+b+c+d)/4;
printf("%f",e);
getch();
}