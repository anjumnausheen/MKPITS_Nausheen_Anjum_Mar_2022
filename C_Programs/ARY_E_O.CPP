#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int n,i,a[50];
int even_cnt=0,odd_cnt=0;
printf("\nenter the size of an array :");
scanf("%d",&n);
printf("\nenter the array elements:\n");
for(i=0;i<n;i++)
{
scanf("%d",&a[i]);
}
for(i=0;i<n;i++)
{
if(a[i]%2==0)
{
even_cnt=even_cnt+1;
}
else
{
odd_cnt=odd_cnt+1;
}
}
printf("\nTotal even no. in array = %d ",even_cnt);
printf("\nTotal odd no.in array = %d ",odd_cnt);
getch();
}
