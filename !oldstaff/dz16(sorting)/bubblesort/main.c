#include <stdio.h>
#include <stdlib.h>
#include "../generelfunctions/generelfunctions.h"
void bubble (int ourArray[], int size);

int main()
{
    int size=5;
    int ourArray [arrayMaxSize];
    input (ourArray, size);
    for(int counter=0; counter<size; counter++)
    {
        bubble(ourArray, size);
    }
    output (ourArray, size);
    return 0;
}

void bubble (int ourArray[], int size)
{
    int firstElement, secondElement;
    for(int counter=0; counter<size; counter++)
    {
        if(ourArray[counter]>ourArray[counter+1])
        {
            firstElement=ourArray[counter];
            secondElement=ourArray[counter+1];
            ourArray[counter]=secondElement;
            ourArray[counter+1]=firstElement;
        }
    }
}
