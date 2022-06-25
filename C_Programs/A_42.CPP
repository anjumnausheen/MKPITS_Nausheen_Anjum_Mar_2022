#include<stdio.h>
#include<conio.h>
void main()
{
double sum=0,i,j=1;
clrscr();
for(i=1;i<8;i=i+2)
{
sum=sum+i/j;
j=j*2;
}
printf("Sum of all elements = %lf",sum);
getch();
}