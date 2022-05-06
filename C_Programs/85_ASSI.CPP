#include<stdio.h>
#include<conio.h>
int test (int x, int y);
int main ()
{
int a;
clrscr();
a= test(55,60);
printf("%d",a);
//printf("%d",test(78,95));
//printf("\n %d",test(25,35));
//printf("\n %d",test(40,50));
//printf("\n %d",test(55,60));
getch();
}
int test (int x,int y)
{
return (x>=40 && x<=50 && y>=40 && y<= 50)||(x>=50 && x<=60 && y>=50 && y<=60);
}