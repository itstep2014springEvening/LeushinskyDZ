#include <cstdio>

using namespace std;


   /* int strlen(char *str);
    char* strcpi(char *to, char *from);
    char* strcat(char *to, char *from);
    int strcmp(char *a, char*b);*/
char* strtok(char *str, const char *delimiters);

    int main()
    {
        char str[256];
        gets(str);
        printf("%s\n", strtok(str, " "));
        return 0;
    }







