#include<stdio.h>
#include<conio.h>
void main()
{
double p,r,t,si;
clrscr();
printf("Enter Principle Amount ");
scanf("%lf",&p);
printf("Enter Duration In Year ");
scanf("%lf",&t);
printf("Enter Rate Of Interest Per Year ");
scanf("%lf",&r);
si=(p*t*r)/100;
printf("Simple Interest = %lf",si);
getch();
}