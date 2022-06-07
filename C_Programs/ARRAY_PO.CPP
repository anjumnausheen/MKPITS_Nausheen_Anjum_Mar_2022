#include<stdio.h>
#include<conio.h>
void main()
{
int a[5]={10,20,30,40,50};
clrscr();
for(int i=0;i<=4;i++)
{
printf("%d\n",*(a+i));
}
getch();
}