#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num1,num2,num3;
printf("enter 2 int number");
scanf("%d%d",&num1,&num2);
num3=num1*num2;
printf("the multiplication result=%d",num3);
num3=num1-num2;
printf("\nthe subtraction result=%d",num3);
getch();
}