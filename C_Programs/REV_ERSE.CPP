#include<stdio.h>
#include<conio.h>
void main ()
{
int i,no,mod;
clrscr();
printf("Enter value of no :");
scanf("%d",&no);
while(no!=0)
{
mod=no%10;
printf("%d",mod);
no=no/10;
}
getch();
}