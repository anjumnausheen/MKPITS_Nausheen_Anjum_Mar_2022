#include<stdio.h>
#include<conio.h>
void main()
{
int a[50],res[2],n,i;
clrscr();
printf("Enter length of array :");
scanf("%d",&n);
printf("Enter element of array :");
for(i=0;i<n;i++)
{
printf("a[%d]= ",i);
scanf("%d",&a[i]);
}
res[0]=a[0];
res[1]=a[n-1];
printf("new array containing 1st and last element \n");
for(i=0;i<2;i++)
{
printf("res[%d]=%d\n",i,res[i]);
}
getch();
}