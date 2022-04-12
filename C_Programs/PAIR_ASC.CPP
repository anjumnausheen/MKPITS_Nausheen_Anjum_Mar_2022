#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int x,y,i;
printf("\n input a pair of numbers(for example 10,2:2,10:");
printf("\n input first number of the pair:");
scanf("%d",&x);
printf("\n input second number of the pair:");
scanf("%d",&y);
if(x>y)
{
printf("the pair is in descending order!");
}
else
{
printf("the pair is in ascending order!");
}
printf("\n");
getch();
}