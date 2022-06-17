#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
void main()
{
int c,n;
clrscr();
printf("Ten random numbers in [1,100\n]");
for(c=1;c<=10;c++)
{
n=rand()%100+1;
printf("%d\n",n);
}
getch();
}