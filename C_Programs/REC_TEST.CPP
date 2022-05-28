#include<stdio.h>
#include<conio.h>
int fun(int x)
{

	if(x==0)
	{
	return 0;
	}
	else
	if(x==1)
	{
	return 1;
	}
	else
	{
	return x*fun(x-1);
	}

}
void main()
{
	int y,fact;
	clrscr();
	printf("enter the number: ");
	scanf("%d",&y);
	fact=fun(y);
	printf("factorial= %d\n",fact);
	getch();
}