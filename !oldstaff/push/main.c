#include <stdio.h>
#include <stdlib.h>
#include <assert.h>

int main()
{
    printf("Hello world!\n");
    return 0;
}

void push(int *stack, int size,int *top, int datum)
{
    assert(top<size-1);
    stack[++(*top)]=datum;
}
