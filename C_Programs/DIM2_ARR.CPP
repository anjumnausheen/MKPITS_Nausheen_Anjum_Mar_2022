#include<stdio.h>
#include<conio.h>
void main()
{
int i,j,a[3][3];
clrscr();
for(i=0;i<=2;i++)
{
for(j=0;j<=2;j++)
{
printf("Enter Element at a[%d][%d]=",i,j);
scanf("%d",&a[i][j]);
}
}
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