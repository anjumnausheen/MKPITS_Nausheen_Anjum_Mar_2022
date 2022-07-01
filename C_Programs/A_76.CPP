#include<stdio.h>
#include<conio.h>
void main()
{
int x=51,n,res;
clrscr();
printf("Enter value of n :");
scanf("%d",&n);
if(n<51)
{
res=x-n;
}
else
{
res=3*(n-x);
}
printf("result=%d",res);
getch();
}