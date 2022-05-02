#include<stdio.h>
#include<conio.h>
int test(int x , int y );
void main()
{
clrscr();
printf("%d",test(100,199));
printf("%d",test(250,300));
printf("%d",test(105,190));
getch();
}
int test(int x,int y)
{
return(x>=100&&x<=200)||(y>=100&&y<=200);
}