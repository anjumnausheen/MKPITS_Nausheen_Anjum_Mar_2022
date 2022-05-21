#include<stdio.h>
#include<conio.h>
void main()
{
clrscr();
int vote_age;
printf("Input the age of the candidate :");
scanf("%d ",&vote_age);
if(vote_age<18)
{
printf("Sorry you are not eligible to caste your vote .");
printf("you would be able to caste your vote after %d year.\n18-vote_age");
}
else
printf("Congratulations !You are eligible for casting your vote :");
getch();
}