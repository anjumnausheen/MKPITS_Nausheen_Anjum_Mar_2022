#include<stdio.h>
#include<conio.h>
void main()
{
int num1,num2,res;
clrscr();
printf("Enter 1st number:");
scanf("%d",&num1);
printf("Enter 2nd number:");
scanf("%d",&num2);
if(num1==num2)
{
res=3*(num1+num2);
}
else
{
res=num1+num2;
}
printf("Result = %d",res);
getch();
}