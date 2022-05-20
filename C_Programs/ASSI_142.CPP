#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int number,i;
printf("Input the number :");
scanf("%d",&number);
for(i=1;i<=10;i++)
{
printf("%d * %d =%d\n",number,i,(i*number));
}
getchar();
getchar();
}