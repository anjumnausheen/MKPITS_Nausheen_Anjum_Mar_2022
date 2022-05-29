#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,c;
clrscr();
printf("Enter any three Number :");
scanf("%d%d%d",&a,&b,&c);
if(a>b)
{
if(a>c)
{
printf("A greatest");
}
}
if(b>a)
{
if(b>c)
{
printf("B greatest");
}
}
if(c>a)
{
if(c>b)
{
printf("C greatest");
}
}
getch();
}

