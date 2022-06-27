#include<stdio.h>
#include<conio.h>
void main()
{
int num;
clrscr();
printf("Enter Number ");
scanf("%d",&num);
if(num>0)
{
if(num%13==0)
printf("%d is multiple of 13",num);
else
if(num%13==1)
printf("%d is one more than multiple of 13",num);
else
printf("%d is not multiple of 13",num);
}
else
printf("Invalid Input");
getch();
}