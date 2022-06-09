#include<stdio.h>
#include<conio.h>
void area(int*l,int*b)
{
int ar;
ar=*l * *b;
printf("area=%d ",ar);
}
void main()
{
int a=10,b=20;
clrscr();
area(&a,&b);
getch();
}