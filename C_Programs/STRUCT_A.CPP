#include<stdio.h>
#include<conio.h>
struct arithmetic
{
int x,y,z;
};
void main()
{
struct arithmetic obj;
clrscr();
printf("Enter 2 value :\n");
scanf("%d%d",&obj.x,&obj.y);
obj.z=obj.x+obj.y;
printf("Add=%d",obj.z);
getch();
}