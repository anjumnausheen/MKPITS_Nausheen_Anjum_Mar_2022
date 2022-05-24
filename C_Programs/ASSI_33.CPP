#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int x,y;
printf("Input the coordinate (x,y):");
printf("\nx:");
scanf("%d",&x);
printf("y:");
scanf("%d",&y);
if(x>0 && y>0)
{
printf("%d%d quadrant -I(+,+)\n",x,y);
}
else if (x>0 && y<0)
{
printf("quadrant-II(+,-)\n");
}
else if(x<0 && y<0)
{
printf("quadrant -III(-,-)\n");
}
else if(x<0 && y>0)
{
printf("quadrant - IV(-,+)\n");
}
getch();
}