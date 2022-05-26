#include<stdio.h>
#include<conio.h>
void main()
{
int no;
clrscr();
printf("Enter any no.:");
scanf("%d",&no);
(no%2==0)?printf("even"):printf("odd");
getch();
}