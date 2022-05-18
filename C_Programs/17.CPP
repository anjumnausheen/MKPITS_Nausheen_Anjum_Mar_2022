#include<stdio.h>
#include<conio.h>
void main ()
{
clrscr();
int num;
printf("enter value of num = ");
scanf("%d" ,&num );
if(num%4==0)
{
printf("num div by 4");
}
if(num%4!=0)
{
printf("not divisible by 4");
}
getch();
}