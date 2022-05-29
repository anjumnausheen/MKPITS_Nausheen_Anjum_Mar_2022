#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int age;
printf("enter age= ");
scanf("%d",&age);
if(age>=18)
{
printf("age is valid");
}
if(age<18)
{
printf("age is not valid");
}
getch();
}
