#include <stdio.h>
#include <stdlib.h>
#include "../generelfunctions/generelfunctions.h"

int main()
{
    int size=5;
    int ourArray [arrayMaxSize];
    input (ourArray, size);
    insertsort(ourArray, size);
    output (ourArray, size);
    return 0;
}

void insertsort (int ourArray[], int size)
{
    int firstElement, secondElement, temporaryVariable;
    for(int counter1=1;counter1<size;++counter1)
    {
        for(int counter2=counter1;counter2>=0;--counter2)
        {
            if(ourArray[counter2]>ourArray[counter2+1])
            {
                temporaryVariable=ourArray[counter2+1];
                ourArray[counter2+1]=ourArray[counter2];
                ourArray[counter2]=temporaryVariable;
            }
        }
    }
}
