#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");
    int a=2;

    int *pa=malloc(sizeof(int));
    *pa=a;

    int *p=malloc(sizeof(int));
    p=&a;

    printf("%d, %d", *p, *pa);
    return 0;
}
