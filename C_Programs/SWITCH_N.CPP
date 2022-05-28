#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int a,b,x,choice;
float div;
printf("enter value of a = ");
scanf("%d",&a);
printf("enter value of b = ");
scanf("%d",&b);
printf("press 1 for addition \npress 2 for multiplication \npress 3 for subtraction \npress 4 for division\n");
printf("enter your choice= ");
scanf("%d",&choice);
switch(choice)
{
case 1:
{
x=a+b;
printf("%d",x);
}
break;
case 2:
{
x=a*b;
printf("%d",x);
}
break;
case 3:
{
x=a-b;
printf("%d",x);
}
break;
case 4:
{
div=(float)(a/b);
 printf("%f",div);
 }
 break;
 default:
 {
 printf("invalid choive");
 }
 }
 getch();
 }


