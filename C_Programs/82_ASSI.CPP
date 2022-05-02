#include<stdio.h>
#include<conio.h>
int test (int x, int y, int z);
int main(void)
{
clrscr();
printf("%d",test(11,20,12));
printf("%d",test(30,30,17));
printf("%d",test(25,35,50));
printf("%d",test(15,12,8));
getch();
}
int test (int x,int y, int z)
{
return(x>=20 && x<=50)||(y>=20 && y<=50)||(z>=20 && z<=50);
}