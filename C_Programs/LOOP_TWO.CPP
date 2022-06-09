#include<stdio.h>
#include<conio.h>
void main()
{
int i,j,a[3][3]={10,20,30,40,50,60,70,80,90};
clrscr();
for(i=0;i<=2;i++)
{
for(j=0;j<=2;j++)
{
printf("%d ",a[i][j]);
}
printf("\n");
}
getch();
}