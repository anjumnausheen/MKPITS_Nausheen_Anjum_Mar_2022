
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
void main()
{
clrscr();
int x,y,z,max;
printf("\nInput value of x:");
scanf("%d",&x);
printf("\nInput value of y:");
scanf("%d",&y);
printf("\nInput value of z:");
scanf("%d",&z);
if(x>y&&x>z)
{
printf("\nx is greatest");
}
if(y>x&&y>z)
{
printf("\ny is greatest");
}
if(z>x&&z>y)
{
printf("\nz is greatest");
}
getch();
}