#include<stdio.h>
#include<conio.h>
void main ()
{
int i,n;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
i=n;
while(i>=1)
{
printf("%d",i);
i--;
}
getch();
}