#include<stdio.h>
#include<conio.h>
void main ()
{
int i,j,a[3];
clrscr();
for (i=0;i<=2;i++)
{
printf("Enter Element at a[%d]=",i+1);
scanf("%d",&a[i]);
}
for(j=0;j<=2;j++)
{
printf("Value at a [%d]=%d\n",j,a[j]);
}
getch();
}