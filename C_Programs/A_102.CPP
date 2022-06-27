#include<stdio.h>
#include<conio.h>
void main()
{
int a[50],b[50],n,i;
clrscr();
printf("Enter length of array :");
scanf("%d",&n);
printf("Enter Elements of 1st array :\n");
for(i=0;i<n;i++)
{
printf("a[%d]= ",i);
scanf("%d",&a[i]);
}
printf("Enter Elements of 2nd array :\n");
for(i=0;i<n;i++)
{
printf("b[%d]= ",i);
scanf("%d",&b[i]);
}
if(a[0]==b[0] || a[n-1]==b[n-1])
printf("True");
else
printf("False");
getch();
}