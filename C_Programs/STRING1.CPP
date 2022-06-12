#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{
char s1[50];
char s2[30];
clrscr();
printf("Enter two string :");
scanf("%s%s",&s1,&s2);
printf("strlen(s1)=%d\n",strlen(s1));
printf("strlen(s2)=%d\n",strlen(s2));
printf("strupr(s1)=%s\n",strupr(s1));
printf("strupr(s2)=%s\n",strupr(s2));
printf("strlwr(s1)=%s\n",strlwr(s1));
printf("strlwr(s2)=%s\n",strlwr(s2));
printf("strcat(s1,s2)=%s\n",strcat(s1,s2));
//printf("strcat(s2,s1)=%s\n",strcat(s2,s1));
printf("strcpy(s1,s2)=%s\n",strcpy(s1,s2));
//printf("strcpy(s2,s1)=%s\n",strcpy(s2,s1));
printf("strrev(s1)=%s\n",strrev(s1));
printf("strrev(s2)=%s\n",strrev(s2));
getch();
}
