#include<stdio.h>
#include<conio.h>
void swap(int*p,int*q)//definition
{
clrscr();
int temp;
temp=*p;
*p=*q;
*q=temp;
printf("p=%d p=%d\n",*p,*q);
}
int main()
{
int a=100,b=200;
swap(&a,&b);//calling
printf("a=%d b=%d",a,b);
getch();
return 0;
}