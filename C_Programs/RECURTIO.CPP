//recursion
#include<stdio.h>
#include<conio.h>
void factorial (int no,int f)
{
if(no>=1)
{
f=f*no;
no--;
factorial(no,f);
}
else
{
printf("Factorial =%d",f);
}
}
void main()
{
int n;
clrscr();
printf("Enter any number");
scanf("%d",&n);
factorial(n,1);
getch();
}