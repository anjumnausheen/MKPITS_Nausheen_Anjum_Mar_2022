#include<stdio.h>
#include<conio.h>
void main()
{
int f,l,n;
clrscr();
printf("Enter value of n :");
scanf("%d", &n);
l=n%10;
while(n!=0)
{
f=n%10;
n=n/10;
}
printf("First digit = %d and last digit = %d",f,l);
getch();
}