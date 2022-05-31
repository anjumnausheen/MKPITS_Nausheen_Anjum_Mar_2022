#include<stdio.h>
#include<conio.h>
void main()
{
int i,n;
clrscr();
printf("Enter value of n : ");
scanf("%d",&n);
i=1;
do
{
printf("%d\n",i);
i=i+2;
}while(i<=n);
getch();
}