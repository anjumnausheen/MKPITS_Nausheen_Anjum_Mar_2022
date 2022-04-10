#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
float x,y,z,p,a;
printf("\n input the first number:");
scanf("%f",&x);
printf("\n input the second number:");
scanf("%f",&y);
printf("\n input the third number:");
scanf("%f",&z);
if( x<(y+z) && y<(x+z) && z<(y+x))
{
p=x+y+z;
printf("\n perimeter = %1f\n",p);
}
else
{
printf("not possible to create a triangle .....!");
}
getch();
}