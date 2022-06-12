#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{
char s1[50];
char s2[30];
clrscr();
printf("Enter two string :");
scanf("%s%s",&s1,&s2);
if(strcmpi(s1,s2)==0)
{
printf("Match");
}
else
{
printf("Not Match");
}
getch();
}