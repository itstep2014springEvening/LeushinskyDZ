#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a=5,b;
    b=&a;
    int *c=b;
    printf("%d", *c);
    return 0;
}
