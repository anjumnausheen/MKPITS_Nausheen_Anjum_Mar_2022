#include<stdio.h>
#include<conio.h>
# define N 5
void main()
{
int a[N],i;
printf("enter %d integer numbers \n ",N);
for(i=0;i<N;i++)
scanf("%d",&a[i]);
printf("elements of array are : \n ");
for(i=N-1;i>=0;i--)
printf("%d \n ",a[i]);
getch ();
}