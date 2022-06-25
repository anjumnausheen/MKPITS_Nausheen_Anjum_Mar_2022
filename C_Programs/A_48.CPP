#include<stdio.h>
#include<conio.h>
void main()
{
int num[6],i,min,position;
clrscr();
printf("Enter any 6 numbers\n");
for(i=0;i<6;i++)
{
printf("num[%d]= ",i);
scanf("%d",&num[i]);
}
min=num[0];
for(i=1;i<6;i++)
{
if(num[i]<min)
{
min=num[i];
position=i+1;
}
}
printf("Smallest element is %d at position %d",min,position);
getch();
}