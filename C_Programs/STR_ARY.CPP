#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int i;
char name[10];
printf("enter any name");
scanf("%s",name);
for(i=0;name[i]!='\0';i++)
{
printf("%c",name[i]);
}
getch();
}