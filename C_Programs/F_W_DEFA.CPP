//function with default value
#include<stdio.h>
#include<conio.h>
void sum(int x=10,int y=20)
{
int result=x+y;
printf("add=%d\n",result);
}
void main()
{
clrscr();
printf("Without value \n");
sum();
printf("With value \n");
sum(5,6);
getch();
}