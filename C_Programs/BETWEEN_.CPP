#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int i;
printf("even numbers between 1 to 50 (inclusive):\n");
for(i=1; i<=50; i++)
{
if(i%2==0)
{
printf("%d",i);
}
}
getch();
}