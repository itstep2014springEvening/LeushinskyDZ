#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(void)
{
    FILE *fp;
    size_t count;
    char const *str = "ќфигеть, € записал в файл!\n";

    fp = fopen("test.txt", "a+t");
    if(fp == NULL) {
        printf("error opening test.txt");
        return EXIT_FAILURE;
    }
    count = fwrite(str, strlen(str), 1, fp);
    printf("writing %lu bites. fclose(fp) %s.\n", (unsigned long)count, fclose(fp) == 0 ? "sucsess" : "with error");

    fclose(fp);
    return 0;
}
