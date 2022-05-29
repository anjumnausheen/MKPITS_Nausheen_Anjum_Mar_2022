#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
char choice;
printf("enter an alphabet ");
scanf("%c",&choice);
if(choice=='a'||choice=='e'||choice=='i'||choice=='o'||choice=='u')
{
printf("\n%c is a vowel.",choice);
}
else
{
printf("\n%c is a consonant.",choice);
}
getch();
}