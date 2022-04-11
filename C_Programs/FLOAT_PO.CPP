#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
double wi1,ci1,wi2,ci2,result;
printf("weight-item1:");
scanf("%1f",&wi1);
printf("no. of item 1 :");
scanf("%lf",&ci1);
printf("weight-item 2:");
scanf("%lf",&wi2);
printf("no. of item 2:");
scanf("%lf",&ci2);
result= ((wi1*ci1)+(wi2*ci2))/(ci1+ci2);
printf("average value = %f\n",result);
getch();
}
