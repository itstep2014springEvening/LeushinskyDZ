#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");
    int size=7;
    int ourArray [size];
    int varNumberForSort1=0,varNumberForSort2=1, max=0;
    for(int counter1=0;counter1<size;++counter1)
    {
        ourArray[counter1]=rand();
    }
    for(int counter2=0;counter2<size;++counter2)
    {
        if(ourArray[counter2]>ourArray[max])
        {
            varNumberForSort1=ourArray[counter2];
            ourArray[max]=ourArray[counter2];
            ourArray[counter2]=varNumberForSort1;
        }
    }
    for(int counter3=0; counter3<size; ++counter3)
    {
        printf("%d element = %d\n", counter3+1, ourArray[counter3]);
    }
    return 0;
}
/**<
void output(int ourArray [], int size)
{
    printf("\nYour array:\n");
    for(int counter3=0; counter3<10; ++counter3)
    {
        printf("%d element = %d\n", counter3+1, ourArray[counter3]);
    }
} */
