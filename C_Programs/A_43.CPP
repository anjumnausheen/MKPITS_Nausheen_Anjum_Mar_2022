#include<stdio.h>
#include<conio.h>
void main()
{
int num,i;
clrscr();
printf("Enter any number ");
scanf("%d",&num);
printf("Divisors of this number are :");
for(i=1;i<=num;i++)
{
if(num%i==0)
{
printf("%d",i);
}
}
getch();
}