#include<stdio.h>
#include<conio.h>
void main()
{
int x,y,z;
clrscr();
printf("Enter value of X:");
scanf("%d",&x);
printf("Enter value of Y:");
scanf("%d",&y);
printf("Enter value of Z:");
scanf("%d",&z);
if(y>x && z>y)
printf("True");
else
printf("False");
getch();
}