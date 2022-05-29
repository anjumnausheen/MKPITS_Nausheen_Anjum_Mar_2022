#include<stdio.h>
#include<conio.h>
void main()
{
int m;
clrscr();
printf("Enter Marks :");
scanf("%d",&m);
if(m<100 && m>=80)
{
printf("A grade");
}
else if(m<80 && m>=60)
{
printf("B grade");
}
else if(m<60 && m>=40)
{
printf("C grade");
}
else
{
printf("Fail");
}
getch();
}