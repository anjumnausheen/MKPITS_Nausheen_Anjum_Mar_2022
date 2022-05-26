#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,c;
clrscr();
printf("Enter a,b value :");
scanf("%d%d",&a,&b);
c=a&b;
printf("a&b=%d\n",c);
c=a|b;
printf("a|b=%d\n",c);
c=a<<b;
printf("a<<b=%d\n",c);
c=a>>b;
printf("a>>b=%d\n",c);
c=a^b;
printf("a^b=%d\n",c);
getch();
}