#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int x,y;
float div_result;
printf("input two numbers :");
printf("\nx:");
scanf("%d", &x);
printf("\ny:");
scanf("%d",&y);
if(y!=0)
{
div_result=(float)x/(float)y;
printf("%1f\n",div_result);
}
else
{
printf("division not possible.\n");
}
getch();
}