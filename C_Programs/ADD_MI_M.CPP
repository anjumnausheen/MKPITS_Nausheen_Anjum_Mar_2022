#include<stdio.h>
#include<conio.h>
void main()
{ //start main block
clrscr();
int choice,num1,num2,res;
printf("press 1 for addition .");
printf(" \n  press 2 for subtraction. " );
printf(" \n press 3 for multiplication .");
printf(" \n press 4 for division .");
scanf("%d",&choice);
if(choice==1)
{ //start if block
printf("enter two number");
scanf("%d%d",&num1,&num2);
res=num1+num2;
printf("addition of two numbers %d",res);
}//end if block
else
if(choice==2)
{ //start if block
printf("enter two number");
scanf("%d%d",&num1,&num2);
res=num1-num2;
printf("subtraction of two numbers %d",res);
}// end if block
else
if(choice== 3)
{ // start if block
printf("enter two number");
scanf("%d%d",&num1,&num2);
res=num1*num2;
printf("multiplication of two numbers %d",res);
} // end if block
else
if(choice== 4)
{ // start if block
printf("enter two number");
scanf("%d%d",&num1,&num2);
res=num1/num2;
printf("division of two numbers %d ",res);
}//end if block
else
{ // start else block
printf("invalid choice");
}// end else block
getch();
} // end main block