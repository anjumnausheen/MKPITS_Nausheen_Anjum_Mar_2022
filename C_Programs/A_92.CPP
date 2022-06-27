#include<stdio.h>
#include<conio.h>
void main()
{
int num1,num2,add,sub;
clrscr();
printf("Enter First Number:");
scanf("%d",&num1);
printf("Enter Second Number:");
scanf("%d",&num2);
add=num1+num2;
if(num2>num1)
sub=num2-num1;
else
sub=num1-num2;
if(num1==5 || num2==5 || add==5 || sub==5)
printf("True");
else
printf("False");
getch();
}