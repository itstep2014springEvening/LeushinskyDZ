#include <stdio.h>
#include <stdlib.h>
#include "../../generelfunctions/generelfunctions.h"

int main()
{
    printf("Hello world!\n");
    int size=5;
    int ourArray [arrayMaxSize];
    int varNumberForSort1=0,varNumberForSort2=1, max=0;
    input (ourArray, size);
    for(int counter=0; counter<size; ++counter)
    {
        if(ourArray[counter]>ourArray[max])
        {
            varNumberForSort1=ourArray[counter];
            ourArray[max]=ourArray[counter];
            ourArray[counter]=varNumberForSort1;
        }
    }
output (ourArray, size);
    return 0;
}
