#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{
char input_str[100],output_str[100];
int i, count=0;
clrscr();
printf("Enter any string ");
gets(input_str);
for(i=0;i<=strlen(input_str);i++)
{
output_str[i]=input_str[i];
count=count+1;
}
count=count-1;
printf("All characters of string are copied \n%s \ntotal character copied= %d",output_str,count);
getch();
}
