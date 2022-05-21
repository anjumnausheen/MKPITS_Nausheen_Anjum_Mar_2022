#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int a[5],i,ser,s=0;
printf("Enter array element\n");
for(i=0;i<5;i++)
{//for opening
printf("a[%d]= ",i);
scanf("%d ",&a[i]);
}//for close
printf("enter num u want to seacrch : ");
scanf("%d",&ser);
for(i=0;i<5;i++)
{//for opening
if(a[i]==ser)
{//if opening
s=1;
break;
}// if close}
}
if(s==1)
printf("NO. is present");
else
printf("No. is not present");
getch();
}