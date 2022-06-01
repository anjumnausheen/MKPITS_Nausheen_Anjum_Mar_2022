#include<stdio.h>
#include<conio.h>
void main ()
{
int i,n,fact=1;
clrscr();
printf("Enter value of n : ");
scanf("%d",&n);
i=1;
while(i<=n)
{
fact=fact*i;
i++;
}
printf("factorial = %d",fact);
getch();
}