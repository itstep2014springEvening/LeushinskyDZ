#include <stdio.h>
#include <stdlib.h>

int main()
{
    int size=10, ourArray [size], usingMassiveLength, max=1, min=1;
    printf("Enter massive length(<10)\n");
    scanf("%d", &usingMassiveLength);
    for(int counter1=0;counter1<usingMassiveLength;++counter1)
    {
        ourArray[counter1]=rand();
    }
    min=ourArray[1];
    for(int counter2=0;counter2<usingMassiveLength;++counter2)
    {
        if(max<ourArray[counter2])
        {
            max=ourArray[counter2];
        }
        if(min>ourArray[counter2])
        {
            min=ourArray[counter2];
        }
        printf("%d\n",ourArray[counter2]);
    }
    printf("Max = %d\n", max);
    printf("Min = %d", min);
    return 0;
}
