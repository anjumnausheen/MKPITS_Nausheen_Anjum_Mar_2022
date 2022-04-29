#include<stdio.h>
#include<conio.h>
void main()
{
int i;
char ch1[78];
printf("enter name in upper case :\n ");
scanf("%s",ch1);
for(i=0;ch1[i]!='0';i++)
{
printf("%c",ch1[i]+32);
}
getch();
}