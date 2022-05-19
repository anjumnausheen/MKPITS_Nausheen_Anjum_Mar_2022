#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
char name[20],address[50],contact_number[20];
printf("Please enter your name ");
scanf("%s",&name);
printf("\n");
printf("please enter your address ");
scanf("%s ",&address);
printf("\n");
fflush(stdin);
printf("please enter your contact_number ");
scanf("%s",contact_number);
printf("\n");
printf("Your number is :%s",name);
printf("\n");
printf("Your address is : %s ",address);
printf("\n");
printf("Your contact number is %s",contact_number);
getch();
}