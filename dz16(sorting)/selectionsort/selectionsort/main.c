#include <stdio.h>
#include <stdlib.h>
#include "../../generelfunctions/input.h"
#include "../../generelfunctions/output.h"

int main()
{
    printf("Hello world!\n");
    int size=5;
    int ourArray [arraymaxsize];
    int varNumberForSort1=0,varNumberForSort2=1, max=0;
    input (ourArray, size);
    for(int counter2=0; counter2<size; ++counter2)
    {
        if(ourArray[counter2]>ourArray[max])
        {
            varNumberForSort1=ourArray[counter2];
            ourArray[max]=ourArray[counter2];
            ourArray[counter2]=varNumberForSort1;
        }
    }
output (ourArray, size);
    return 0;
}
