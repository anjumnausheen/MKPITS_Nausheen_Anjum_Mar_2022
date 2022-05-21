
#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num,n1,n2,n3,n4,n5,odd_sum=0;
printf("enter 5 digit number=");
scanf("%d",&num);
n1=num%10;
num=num/10;
n2=num%10;
num=num/10;
n3=num%10;
num=num/10;
n4=num%10;
num=num/10;
n5=num%10;
if(n1%2!=0)
{
odd_sum=odd_sum+n1;
}
if(n2%2!=0)
{
odd_sum=odd_sum+n2;
}
if(n3%2!=0)
{
odd_sum=odd_sum+n3;
}
if(n4%2!=0)
{
odd_sum=odd_sum+n4;
}
if(n5%2!=0)
{
odd_sum=odd_sum+n5;
}
printf("sum of all odd valuesis %d",odd_sum);
getch();

}