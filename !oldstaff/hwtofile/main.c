#include <stdio.h>
#include <stdlib.h>

int main()
{
    FILE *file=fopen("sample.txt","w");
    fprintf(file,"%d+%d=%d\n",3,4,3+4);
    fclose(file);
    char str[512];
    sprintf(str, "%d", 27);
    printf("Hello world!\n%s\n", str);
    return 0;
}
