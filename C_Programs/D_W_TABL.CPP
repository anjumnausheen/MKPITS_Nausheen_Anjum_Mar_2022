#include<stdio.h>
#include<conio.h>
void main()
{
int i,n;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
i=1;
do
{
printf("%d\n",n*i);
i++;
}while(i<=10);
getch();
}