#include <stdio.h>
#include <stdlib.h>
#include "../generelfunctions/input.h"
#include "../generelfunctions/output.h"

int main()
{
    printf("Hello world!\n");
    int size=7;
    int ourArray [size];
    int varNumberForSort1=0,varNumberForSort2=1, max=0;
    void input (int array[], int size);
    for(int counter2=0; counter2<size; ++counter2)
    {
        if(ourArray[counter2]>ourArray[max])
        {
            varNumberForSort1=ourArray[counter2];
            ourArray[max]=ourArray[counter2];
            ourArray[counter2]=varNumberForSort1;
        }
    }
void output (int array[], int size);
    return 0;
}
