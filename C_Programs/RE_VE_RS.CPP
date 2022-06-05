#include<stdio.h>
#include<conio.h>
void main ()
{
int i,no,mod;
clrscr();
printf("Enter value of no  : ");
scanf("%d",&no);
do
{
mod=no%10;
printf("%d",mod);
no=no/10;
}while(no!=0);

getch();
}