#include <stdio.h>
#include <stdlib.h>
#include "../generelfunctions/generelfunctions.h"
int maxIndex (int ourArray[], int size);
void changeMax (int ourArray[], int temporaryVariable1, int temporaryVariable2);

int main()
{
    int size=5;
    int ourArray [arrayMaxSize];
    int temporaryVariable=0, max=0;
    input (ourArray, size);
    for (int i=0; i<size; ++i)
    {
        int index=maxIndex(ourArray, size-i);
        changeMax (ourArray, size-i-1, index);
    }
    output (ourArray, size);
    return 0;
}

int maxIndex (int ourArray[], int size)
{
    int max=0;
    for(int counter=0; counter<size; ++counter)
    {
        if(ourArray[max]<ourArray[counter])
            max=counter;
    }
    return max;
}

void changeMax (int ourArray[], int temporaryVariable1, int temporaryVariable2)
{
    int varForChange=ourArray[temporaryVariable1];
    ourArray[temporaryVariable1]=ourArray[temporaryVariable2];
    ourArray[temporaryVariable2]=varForChange;
}


