#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num1,num2,l1,l2;
printf("Enter first number");
scanf("%d",&num1);
printf("Enter second number");
scanf("%d",num2);
l1=num1%10;
l2=num2%10;
if(l1==l2)
{
printf("Last digit are same");
}
else
{
printf("Last digit are not same");
}
getch();
}