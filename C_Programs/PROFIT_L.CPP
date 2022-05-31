#include<stdio.h>
#include<conio.h>
void main ()
{
int cp,sp,profit,loss;
clrscr();
printf("Enter any 2 value : ");
scanf("%d%d",&sp,&cp);
if(sp>cp)
{
profit=sp-cp;
printf("profit=%d",profit);
}
else
{
loss=cp-sp;
printf("loss=%d",loss);
}
getch();
}