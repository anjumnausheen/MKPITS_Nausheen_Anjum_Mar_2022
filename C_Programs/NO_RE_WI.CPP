//non return type with parameter
#include<stdio.h>
#include<conio.h>
void add(int a,int b)
{
int c;
c=a+b;
printf("add=%d",c);
}
void main()
{
clrscr();
add(30,40);
getch();
}