#include<stdio.h>
#include<conio.h>
void main()
{
int i,n,*p;
clrscr();
printf("Enter n value : ");
scanf("%d",&n);
i=1;
p=&i;
while((*p)<=10)
{
printf("%d\n",n*(*p));
(*p)++;
}
getch();
}