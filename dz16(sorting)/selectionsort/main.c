#include <stdio.h>
#include <stdlib.h>
#include "../generelfunctions/generelfunctions.h"

int main()
{
    int size=5;
    int ourArray [arrayMaxSize];
    int temporaryVariable=0, max=0;
    input (ourArray, size);
    for(int counter=0; counter<size; ++counter)
    {
        if(ourArray[max]<ourArray[counter])
        {
            temporaryVariable=ourArray[counter];
            ourArray[counter]=ourArray[max];
            ourArray[max]=temporaryVariable;
        }
        max++;
    }
    output (ourArray, size);
    return 0;
}
