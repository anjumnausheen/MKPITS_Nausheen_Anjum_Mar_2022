#include<stdio.h>
#include<conio.h>
void main()
{
double len_cm,len_inch;
clrscr();
printf("Enter length in centimeters ");
scanf("%lf",&len_cm);
len_inch=len_cm/2.54;
printf("Length in inches = %lf",len_inch);
getch();
}