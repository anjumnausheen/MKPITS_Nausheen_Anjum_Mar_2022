#include<stdio.h>
#include<conio.h>
void main()
{
int num1,num2,num3,res;
clrscr();
printf("Enter 1st number :");
scanf("%d",&num1);
printf("Enter 2nd number :");
scanf("%d",&num2);
printf("Enter 3rd number :");
scanf("%d",&num3);
res=num1*num2*num3;
printf("Multiplication of 3 num=%d",res);
getch();
}