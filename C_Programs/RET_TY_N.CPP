// return type with no parameter
#include<stdio.h>
#include<conio.h>
int add();
int add()
{
int a=20,b=30,c;
c=a+b;
return c;
}
void main()
{
clrscr();
int rs= add();
printf("add=%d",rs);
getch();
}