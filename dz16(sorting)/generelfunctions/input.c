#include <stdio.h>
#include <stdlib.h>
void input (int array[], int size)
{
    for (int counter=0; counter<size ; ++counter)
    {
        printf("Enter element %d: ", counter+1);
        scanf("%d", &array[counter]);
    }
}
