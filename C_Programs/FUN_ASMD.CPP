#include<stdio.h>
#include<conio.h>
void add(int a,int b)
{
int add;
add=a+b;
printf("addition=%d",add);
}
void sub(int a,int b)
{
int sub;
sub=a-b;
printf("\n subtraction=%d",sub);
}
void mul(int a,int b)
{
int mul;
mul=a*b;
printf("\n multiplication=%d",mul);
}
void div(int a, int b)
{
int div;
div=a/b;
printf("\n division=%d",div);

}
void main ()
{
int num1,num2;
clrscr();
printf("enter num1 := ");
scanf("%d",&num1);
printf("enter num2 : =");
scanf("%d",&num2);
add(num1,num2);
sub(num1,num2);
mul(num1,num2);
div(num1,num2);
getch();
}