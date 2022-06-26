#include<stdio.h>
#include<conio.h>
void main()
{
int num;
clrscr();
printf("Enter negative integer :");
scanf("%d",&num);
num=-(num);
printf("After removing negative sign :%d",num);
getch();
}