#include<stdio.h>
#include<conio.h>
void main()
{
int i, n;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
i=1;
while(i<=n)
{
if(n%i==0)
{
printf("%d\n",i);
}
i++;
}
getch();
}