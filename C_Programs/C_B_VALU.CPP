//call by value
#include<stdio.h>
#include<conio.h>
void add(int m)
{
m=m+10;
printf("add=%d",m);
}
void main()
{
clrscr();
add(20);
getch();
}