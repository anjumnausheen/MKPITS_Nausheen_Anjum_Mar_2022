#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int num;
printf("enter any number from 1 to 12=");
scanf("%d",&num);
switch(num)
{
case 1:
{
printf("January");
}
break;
case 2:
{
printf("February");
}
break;
case 3:
{
printf("march");
}
break;
case 4:
{
printf("april");
}
break;
case 5:
{
printf("may");
}
break;
case 6:
{
printf("June");
}
break;
case 7:
{
printf("July");
}
break;
case 8:
{
printf("August");
}
break;
case 9:
{
printf("september");
}
break;
case 10:
{
printf("october");
}
break;
case 11:
{
printf("November");
}
break;
case 12:
{
printf("December");
}
break;
default:
{
printf("invalid choice");
}
}
getch();
 }