#include<stdio.h>
#include<conio.h>
void main()
{
double sum=1,i;
clrscr();
for(i=2;i<=50;i++)
{
sum=sum+1/i;
}
printf("Sum of all element =%lf",sum);
getch();
}