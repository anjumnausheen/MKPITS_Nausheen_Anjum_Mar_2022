#include<stdio.h>
#include<conio.h>
void main()
{
int num1,num2;
clrscr();
printf("Enter two number to swap \n");
printf("Enter first number :");
scanf("%d",&num1);
printf("Enter second number:");
scanf("%d",&num2);
num1=num1+num2;
num2=num1-num2;
num1=num1-num2;
printf("After swapping \n 1st number=%d\n 2nd number=%d",num1,num2);
getch();
}