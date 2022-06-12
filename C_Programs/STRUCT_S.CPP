#include<stdio.h>
#include<conio.h>
#include<string.h>
struct student
{
int rollno;
char name[50];
float marks;
};
void main()
{
clrscr();
struct student obj;
obj.rollno=10;
strcpy(obj.name,"Nausheen");
obj.marks=87.7;
printf("Rollno=%d\n",obj.rollno);
printf("Marks=%f\n",obj.marks);
printf("Name=%s\n",obj.name);
getch();
}
