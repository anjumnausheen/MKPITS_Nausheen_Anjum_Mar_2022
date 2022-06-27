#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,c;
clrscr();
printf("Enter first number: ");
scanf("%d",&a);
printf("Enter second number :");
scanf("%d",&b);
printf("Enter third number: ");
scanf("%d",&c);
if(a+b==c || a+c==b || b+c==a)
{
printf("Possible to get one integer by adding other two ");
}
else
printf("Not possible");
getch();
}