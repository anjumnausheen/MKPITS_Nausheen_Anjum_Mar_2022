#include<stdio.h>
#include<conio.h>
void main()
{
int i,p,b,f=1;
clrscr();
printf("Enter power and base value :");
scanf("%d%d",&p,&b);
i=1;
while(i<=p)
{
f=f*b;
i++;
}
printf("power calculation = %d",f);
getch();
}


