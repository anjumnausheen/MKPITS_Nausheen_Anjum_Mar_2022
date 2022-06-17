#include<stdio.h>
#include<conio.h>
void add();//declaration
void add()//definition
{
int a=10,b=20,c;
c=a+b;
printf("add=%d",c);
}
void main()
{
clrscr();
add();//function call
getch();
}