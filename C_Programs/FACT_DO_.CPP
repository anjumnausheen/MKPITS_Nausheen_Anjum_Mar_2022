#include<stdio.h>
#include<conio.h>
void main()
{
int i,n,fact=1;
clrscr();
printf("Enter value of n : ");
scanf("%d",&n);
i=1;
do
{
fact=fact*i;
i++;
}while(i<=n);
printf("factorial = %d",fact);
getch();
}