#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num,i,fact =1;
printf("enter any number");
scanf("%d",&num);
i=1;
while(i<=5)
{
fact=fact*i;
i++;
}
printf("factorial number is %d",fact);
getch();
}