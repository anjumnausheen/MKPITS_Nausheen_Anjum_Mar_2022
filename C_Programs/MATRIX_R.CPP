#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int m1[2][2],i,j;
printf("enter 2*2 matrix ");
for(i=0;i<=1;i++)
{
for(j=0;j<=1;j++)
{
printf("m1[%d][%d] = ",i,j);
scanf("%d",&m1[i][j]);
}
}
//dis
printf("\n");
for(i=0;i<=1;i++)
{
for(j=0;j<=1;j++)
{
printf("m1[%d][%d]= %d\n",i,j,m1[i][j]);
}
}
getch();
}