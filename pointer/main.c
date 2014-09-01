#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a=864;
    unsigned char *p;
    p=(unsigned char *)&a;
    printf("%d\n", *p);
    ++p;
     printf("%d\n", *p);
    ++p;
     printf("%d\n", *p);
    ++p;
     printf("%d\n", *p);
    return 0;
}
