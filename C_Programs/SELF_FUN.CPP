#include<stdio.h>
#include<conio.h>
int i=1;
void fun();// function prototype
void main()
{
clrscr();
fun (); //function called in main
}
void fun()
{
//int i=1;
if (i==10)
return;
printf("%d",i);
i++;
fun();
getch();
}