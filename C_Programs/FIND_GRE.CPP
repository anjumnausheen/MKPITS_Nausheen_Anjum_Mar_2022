#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int p1,p2,p3;
printf("enter value of p1 =");
scanf("%d",&p1);
printf("enter value of p2 = ");
scanf("%d",&p2);
printf("enter value of p3= ");
scanf("%d",&p3);
if(p1>p2&&p1>p3)
{
printf( "p1 is greater ");
}
else
if(p2>p1&&p2>p3)
{
printf( "p2 is greater");
}
else
{
printf (" p3 is greater");
}
getch();
}