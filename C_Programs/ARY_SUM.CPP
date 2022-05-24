#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int a[100],i,n,sum=0;
printf("Enter size of the array : ");
scanf("%d",&n);
for(i=0;i<n;i++)
{
printf("Enter elements in array :");
scanf("%d",&a[i]);
}
for(i=0;i<n;i++)
{
sum+=a[i];
}
printf("sum of array is : %d",sum);
getch();
}



