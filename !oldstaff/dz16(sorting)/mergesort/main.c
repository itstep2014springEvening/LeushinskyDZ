#include <stdio.h>
#include <stdlib.h>
#include "../generelfunctions/generelfunctions.h"
void mergeSort (int array[], int size);

int main()
{
    int ourArray[arrayMaxSize];
    int size=8;
    input(ourArray, size);
    mergeSort(ourArray,size);
    output(ourArray, size);
    return 0;
}

void mergeSort (int array[], int size)
{
    while(size>=2)
    {
        size/=2;
    }
}
