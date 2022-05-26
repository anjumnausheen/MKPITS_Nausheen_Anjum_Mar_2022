#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,add,sub,mul,div,mod;
clrscr();
printf("Enter value of a & b:");
scanf("%d%d",&a,&b);
add=a+b;
printf("add=%d\n",add);
sub=a-b;
printf("sub=%d\n",sub);
mul=a*b;
printf("mul=%d\n",mul);
div=a/b;
printf("div=%d\n",div);
mod=a%b;
printf("mod=%d\n",mod);
getch();

}