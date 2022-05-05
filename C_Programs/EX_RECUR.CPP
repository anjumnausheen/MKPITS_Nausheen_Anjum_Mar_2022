#include<stdio.h>
#include<conio.h>
void fun(int a);// function prototype
void main()
{
clrscr();
fun (1);//
}
void fun(int a)
{
if (a==10)
return;
//printf("%d",a);
fun(a+1);
printf("%d\n ",a);
getch();

}