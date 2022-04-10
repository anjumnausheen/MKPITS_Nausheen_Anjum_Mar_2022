#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int width=5,height=7,area,perimeter;
perimeter=2*(height+width);
printf("perimeter of the rectangle =%d inches\n",perimeter);
area=height*width;
printf("area of the rectangle=%d inches \n",area);
getch();
}