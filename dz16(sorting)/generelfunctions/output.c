#include <stdio.h>
#include <stdlib.h>

void output (int array[], int size)
{
    for (int counter=0; counter<size; ++counter)
    {
        printf ("Your %d element: %d", counter+1, array[counter]);
    }
    printf("\n");
}
