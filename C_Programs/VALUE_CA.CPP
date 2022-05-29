#include<stdio.h>
#include<conio.h>
void swap(int x,int y)//definition
{
int temp;
temp=x;
x=y;
y=temp;
printf("x=%d\ny=%d",x,y);
}
void main()
{
int a=100,b=200;
clrscr();
swap(a,b);//calling
getch();
}