#include<stdio.h>
#include<conio.h>
void main()
{
int num,sq=1,cube,i;
clrscr();
printf("Squares and cubes from 1 to 20 \n ");
for(num=1;num<=20;num++)
{
sq=num*num;
cube=num*num*num;
printf("%d %d %d \n ",num,sq,cube);
}
printf("\n");
getch();
}