#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,c;
clrscr();
printf("Enter 1st number:");
scanf("%d",&a);
printf("Enter 2nd number:");
scanf("%d",&b);
printf("Enter 3rd number:");
scanf("%d",&c);
if(a==20 || b==20 || c==20 || a-b==20 || b-a==20 || b-c==20 || c-b==20 || c-a==20 || a-c==20)
printf("True ");
else
printf("False");
getch();
}