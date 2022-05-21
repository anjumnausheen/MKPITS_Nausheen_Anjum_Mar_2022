#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int i,add=0;
i=10;
while(i>=1)
{
add=add+i;
printf("\n%d %d",i,add);
i--;
}
printf("\n %d",add);
getch();
}