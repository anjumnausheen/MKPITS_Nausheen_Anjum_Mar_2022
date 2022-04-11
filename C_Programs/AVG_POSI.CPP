#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int j,pctr=0;
float numbers[5],total=0,avg;
printf("\n input the first number: ");
scanf("%f",&numbers[0]);
printf("\n input the second number :");
scanf("%f",&numbers[1]);
printf("\n input the third number :");
scanf("%f",&numbers[2]);
printf("\n input the fourth number :");
scanf ("%f",&numbers[3]);
printf("\n input the fifth number:");
scanf("%f", &numbers[4]);
for(j=0; j<5 ; j++)
{
if(numbers[j]>0)
{
pctr++;
total+=numbers[j];
}
}
avg=total/pctr;
printf("\n number of positive numbers:%d",pctr);
printf("\n average value of the said positive numbers:%.2f",avg);
printf("\n");
getch();
}