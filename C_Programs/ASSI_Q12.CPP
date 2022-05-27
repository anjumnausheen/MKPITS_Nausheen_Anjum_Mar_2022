#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
char id[10];
int hour;
double value ,salary;
printf("Input the employees ID(Max. 10 chars):");
scanf("%s",&id);
printf("\n Input the working hrs:");
scanf("%d",&hour);
printf("\n salary amount /hr:");
scanf("%lf",&value);
salary=value*hour;
printf("/nEmployeesID=%s\n salary =U$%21f\n",id,salary);
getch();
}