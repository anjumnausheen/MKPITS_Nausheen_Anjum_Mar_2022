#include<stdio.h>
#include<conio.h>
void fun1();
void add(int x,int y);
void sub(int x,int y);
void mul(int x,int y);
void div(int x,int y);
void main()
{
clrscr();
fun1();
getch();
}
void fun1()
{
int a,b;
printf("enter any two num : ");
scanf("%d%d",&a,&b);
add(a,b);
sub(a,b);
mul(a,b);
div(a,b);
}
void add(int x,int y)
{
int r;
r=x+y;
printf("\n%d",r);
}
void sub(int x,int y)
{
int r;
r=x-y;
printf("\n%d",r);
}
void mul(int x, int y)
{
int r;
r=x*y;
printf("\n%d",r);
}
void div(int x, int y)
{
int r;
r=x/y;
printf("\n%d",r);
}
