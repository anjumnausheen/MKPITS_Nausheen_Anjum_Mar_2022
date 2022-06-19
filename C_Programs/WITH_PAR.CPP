//return type with parameter
#include<stdio.h>
#include<conio.h>
int add(int a,int b);
int add(int a,int b)
{
int c;
c=a+b;
return c;
}
void main()
{
int rs=add(50,60);
clrscr();
printf("add=%d",rs);
getch();
}