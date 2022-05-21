#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int a[6];
int i,choice,x,p;
printf("Input 5 elements in the array  \n");
for(i=0;i<5;i++)
{
printf("Enter element %d : ",i+1);
scanf("%d",&a[i]);
}
printf("Enter element you want to insert : ");
scanf("%d",&x);
printf("\n");
printf("Press 1 for inserting the element at the top \n");
printf("Press 2 for inserting the element at the anywhere in array  \n");
printf("Press 3 for inserting the element at the bottom \n ");
scanf("%d",&choice);
switch(choice)
{
case 1:
for(i=5;i>=0;i--)
{
if(i==0)
a[i]=x;
else
a[i]=a[i-1];
}
break;
case 2:
printf("Enter position you want to insert ");
scanf("%d",&p);
for(i=5;i>=0;i--)
{
if(i==p-1)
a[i]=x;
else
if(i>p-1)
a[i]=a[i-1];
else
a[i]=a[i];
}
break;
case 3:
for(i=0;i<=5;i++)
{
if(i==5)
a[i]=x;
}
break;
default:
printf("Invalid Input");
}
printf("Array after insertion \n");
for(i=0;i<=5;i++)
{
printf("a[%d]=%d \n",i,a[i]);
}
getch();
}
