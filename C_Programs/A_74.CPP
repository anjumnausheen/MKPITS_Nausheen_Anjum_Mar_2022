#include<stdio.h>
#include<conio.h>
void main()
{
int num,backup,rev=0,n;
clrscr();
printf("Enter a number:");
scanf("%d",&num);
if (num>9999 || num<99999)
{
backup=num;
while(num>0)
{
n=num%10;
rev=rev*10+n;
num=num/10;
}
if(backup==rev)
{
printf("%d is palindrome",backup);
}
else
{
printf("%d is not palindrome",backup);
}
}
else
printf("Invalid Input");
getch();
}