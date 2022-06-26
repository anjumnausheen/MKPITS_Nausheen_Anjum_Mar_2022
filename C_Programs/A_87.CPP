#include<stdio.h>
#include<conio.h>
void main()
{
int num1,num2,L1,L2;
clrscr();
printf("Enter 1st number :");
scanf("%d",&num1);
printf("Enter 2nd number :");
scanf("%d",&num2);
if(num1>0 && num2>0)
{
L1=num1%10;
L2=num2%10;
if(L1==L2)
printf("Last digits of entered numbers are same ");
else
printf("Last digits of entered numbers are different ");
}
else
{
printf("Invalid Input ");
}
getch();
}