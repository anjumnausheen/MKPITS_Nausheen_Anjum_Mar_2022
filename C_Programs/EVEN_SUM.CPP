#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int i,sum=0;
i=1;
printf("Sum of even no. from 1 to 10= ");
while(i<=10)
{
if(i%2==0)
{
sum=sum+i;
}
i++;
}
printf("%d",sum);
getch();
}


