#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num, n1, n2 , n3 , rev ;
printf("enter 3 digit number ");
scanf("%d",&num);
n1 =num%10;
num=num/10;
n2=num%10;
num=num/10;
n3=num%10;
rev=n1*100+n2*10+n3*1;
printf("reverse=%d",rev);
getch();
}