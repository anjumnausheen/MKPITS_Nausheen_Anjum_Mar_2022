
#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int i=1;
int pcount=0;
int ncount=0;
while(i<=5)
{
if(i>=0)
{
pcount++;
}
else
{
ncount++;
}
i++;
}
printf("\n positive count %d",pcount);
printf("\n negative count %d",ncount);
getch();
}
