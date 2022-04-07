#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int a,b,area;
printf("enter value of a = ");
scanf("%d",&a);
printf("enter value of b = ");
scanf("%d",&b);
area=(a+b)*(a+b)+(a-b)*(a-b);
printf("area%d",area);
getch();
}
