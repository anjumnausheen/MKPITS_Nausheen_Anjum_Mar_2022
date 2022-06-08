#include<stdio.h>
#include<conio.h>
void main()
{
int i,a[3];
clrscr();
printf("Enter 3 value :\n");
scanf("%d%d%d",&a[0],&a[1],&a[2]);
for (i=0;i<=2;i++)
{
printf("Value at a [%d]=%d\n",i,a[i]);
}
getch();
}