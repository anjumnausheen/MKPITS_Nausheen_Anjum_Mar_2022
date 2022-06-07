#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,sum;
int *p,*q,*r;
clrscr();
printf("Enter  a and b value:\n");
scanf("%d%d",&a,&b);
p=&a;
q=&b;
r=&sum;
*r=*p+*q;
printf("sum=%d ",*r);
getch();
}