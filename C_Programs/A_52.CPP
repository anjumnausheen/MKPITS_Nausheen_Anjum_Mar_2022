#include<stdio.h>
#include<conio.h>
void main()
{
int a,b;
clrscr();
printf("Enter value: ");
scanf("%d",&a);
b=a<<=2;
printf("Value after shifting data by 2 bit to the left=%d",b);
getch();
}