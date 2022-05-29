#include<stdio.h>
#include<conio.h>
void main()
{
int i,n;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
for(i=2;i<=n;i=i+2)
{
printf("%d\n",i);
}
getch();
}