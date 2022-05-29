#include<stdio.h>
#include<conio.h>
//void sub();
void sub()
{
clrscr();
int n1,n2,res;
printf("enter any two num ");
scanf("%d %d",&n1,&n2);
res=n1-n2;
printf("sub=%d",res);
getch();
}
void add()
{
clrscr();
int n1,n2,res;
printf("enter any two num ");
scanf("%d %d",&n1,&n2);
res=n1+n2;
printf("add=%d",res);
getch();
}
void main()
{
add();
sub();
}

