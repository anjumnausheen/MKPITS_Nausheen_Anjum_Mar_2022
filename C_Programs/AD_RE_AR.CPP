#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num,n1,add=0;
printf("enter any number ");
scanf("%d",&num);
while(num>=1)
{
n1=num%10;
num=num/10;
add=n1+add;
}
printf("\n sum of digit is %d ",add);
getch();
}