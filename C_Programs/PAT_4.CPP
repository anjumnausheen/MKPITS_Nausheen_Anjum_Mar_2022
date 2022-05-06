#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
char i,j;
for(i=65;i<=68;i++)
{
for(j=65;j<=i;j++)
{
printf("%c",j);
}
printf("\n");
}
getch();
}