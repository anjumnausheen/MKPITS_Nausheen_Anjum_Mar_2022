#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num,i,fact=1;
printf("enter number");
scanf("%d",&num);
i=5;
while(i>=1)
{
fact=fact*i;
i--;
}
printf("factorial is %d" ,fact);
getch();
}