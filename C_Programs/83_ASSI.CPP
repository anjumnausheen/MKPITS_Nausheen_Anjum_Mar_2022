
#include<stdio.h>
#include<conio.h>
int test (int x, int y);
int main(void)
{
clrscr();
printf("%d",test(20,84));
printf(" \n%d",test(14,50));
printf("\n%d",test(11,45));
printf("\n%d",test(25,40));
getch();
}
int test (int x,int y)
{
return (x<=20||y>=50)||(x<=20||y>=50);
}
