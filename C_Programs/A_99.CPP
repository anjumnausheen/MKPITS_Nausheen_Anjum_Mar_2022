#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,r1,r2;
clrscr();
printf("Enter First Number :");
scanf("%d",&a);
printf("Enter Second Number :");
scanf("%d",&b);
r1=a%5;
r2=b%5;
if(a==b)
{
printf("0");
}
else
if(r1==r2)
{
if(a>b)
printf("Smaller Integer= %d",b);
else
printf("Smaller Integer= %d",a);
}
else
{
if(a>b)
printf("Larger Integer= %d",a);
else
printf("Larger Integer= %d",b);
}
getch();
}