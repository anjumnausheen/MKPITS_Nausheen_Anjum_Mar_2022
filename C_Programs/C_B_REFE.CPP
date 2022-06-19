//call by reference
#include<stdio.h>
#include<conio.h>
void add(int * m)
{
*m=*m+10;
printf("add=%d",*m);
}
void main()
{
int a=12;
clrscr();
add(&a);
getch();
}