#include<stdio.h>
#include<conio.h>
void main()
{
int i,n;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
for(i=1;i<=10;i++)
{
printf("%d\n",n*i);
}
getch();
}