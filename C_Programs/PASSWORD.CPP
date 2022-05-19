#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int pass;
while(1)
{
printf("\n input the password:");
scanf("%d",&pass);
if(pass==1234)
{
printf("correct password");
break;
}
else
{
printf("wrong password , try another");
}
}// while loop close hear
getch();
}