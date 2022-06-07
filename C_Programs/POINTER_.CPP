#include<stdio.h>
#include<conio.h>
void main()
{
int a=10,*p;
clrscr();
p=&a;
printf("a=%d\n",a);
printf("&a=%d\n",&a);
printf("p=%d\n",p);
printf("&p=%d\n",&p);
printf("*p=%d\n",*p);
getch();
}