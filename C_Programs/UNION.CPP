#include<stdio.h>
#include<conio.h>
union stud
{
int id;
char name[20];
}s1;
void main()
{
clrscr();
printf("enter stud id");
scanf("%d",&s1.id);
printf("%d",s1.id);
printf("enter stud name");
scanf("%s",s1.name);
//printf("stud id =%d",s1.id);
printf("stud name =%s",s1.name);
getch();
}