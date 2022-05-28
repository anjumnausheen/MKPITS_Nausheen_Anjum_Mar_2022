#include<stdio.h>
#include<conio.h>
void main()
{
int a,i,j=1,n=1;
clrscr();
printf("Input number of lines ");
scanf("%d",&a);
for(i=1;i<=a;i++)
{
for(j=1;j<=3;j++)
{
printf("%d ",n);
n++;
 }
 printf("\n");
}
getch();
}
