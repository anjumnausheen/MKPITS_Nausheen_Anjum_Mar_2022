#include<stdio.h>
#include<conio.h>
void main ()
{
int i,n;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
i=1;
do
{
if(n%i==0)
{
printf("%d\n",i);
}
i++;
}while(i<=n);
getch();
}