#include<stdio.h>
#include<conio.h>
void main()
{
int a[5],i,temp;
clrscr();
printf("Enter Elements of an array \n ");
for(i=0;i<5;i++)
{
printf("a[%d]= ",i);
scanf("%d",&a[i]);
}
printf("\n Reverse of array \n ");
for(i=0;i<5/2;i++)
{
temp=a[i];
a[i]=a[4-i];
a[4-i]=temp;
}
for(i=0;i<5;i++)
{
printf("a[%d]= %d\n",i,a[i]);
}
getch();
}