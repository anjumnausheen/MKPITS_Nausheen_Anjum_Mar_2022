#include<stdio.h>
#include<conio.h>
void main()
{
char ch , n=0;
clrscr();
printf("Upper case alphabets\n");
for(ch=65;ch<=90;ch++)
{
printf("[%d= %c]",ch,ch);
n=n+1;
if(n==4 || n==8 || n==12 || n==16 || n==20 || n==24)
printf("\n");
}
printf("\n\n");
printf("Lower case Alphabets \n");
n=0;
for(ch=97;ch<=122;ch++)
{
printf("[%d = %c] ",ch,ch);
n=n+1;
if(n==4 || n==8 || n==12 || n==16 || n==20 || n==24)
printf("\n");
}
getch();
}