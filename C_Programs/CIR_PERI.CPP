#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int radius;
float area,perimeter;
radius=6;
perimeter=2*3.14*radius;
printf("perimeter of the circle=%f inches\n",perimeter);
area=3.14*radius*radius;
printf("area of the circle =%f inches\n",area);
getch();
}