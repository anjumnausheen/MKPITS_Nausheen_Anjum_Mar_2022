#include<stdio.h>
#include<conio.h>
void main()
{
int x;
clrscr();
printf("x\tx+2\tx+4\tx+6\n");
for(x=1;x<=15;x+=3)
{
printf("%d\t%d\t%d\t%d\n",x,(x+2),(x+4),(x+6));
}
getch();
}