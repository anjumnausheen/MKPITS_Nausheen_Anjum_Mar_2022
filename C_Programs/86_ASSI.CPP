#include<stdio.h>
#include<conio.h>
int test (int x, int y);
void main()
{
clrscr();
printf("%d",test(78,95));
printf("\n%d",test(20,30));
printf("\n%d",test(27,25));
printf("\n%d",test(29,28));
getch();
}
int test(int x,int y)
{
if(x>=20 && x<=30 && y>=20 && y<=30)
{
if(x>=y)
{
return x;
}
else
{
return y;
}
}
{
return 0;
}
}