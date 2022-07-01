#include<stdio.h>
#include<conio.h>
int sum()
{
int num1,num2,res;
printf("Enter 1st number:");
scanf("%d",&num1);
printf("Enter 2nd number:");
scanf("%d",&num2);
res=num1+num2;
if(res>=10 && res<=20)
return 30;
else
return res;
}
void main()
{
int r;
clrscr();
r=sum();
printf("sum=%d",r);
getch();
}
