#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num,a,b,c,d;
printf("enter any number = ");
scanf("%d",&num);
a=num/100;
b=num%100;
c=b/10;
d=b%10;
if(a==d)
{
printf("pelindrome");
}
else
{
printf("not pelindrome");
}
getch();
}