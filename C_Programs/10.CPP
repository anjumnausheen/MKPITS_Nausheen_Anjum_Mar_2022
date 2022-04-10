
#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,c,area;
printf("enter value of a = ");
scanf("%d",&a);
printf("enter value of b = ");
scanf("%d",&b);
printf("enter value of c = ");
scanf("%d",&c);
area=a*a+b*b+c*c+2*a*b+2*b*c+2*c*a;
printf("area%d",area);
getch();
}