#include <stdio.h>
#include <stdlib.h>

void input(int ourArray[], int size);
void output(int ourArray [], int size);
int arrayFind (int findingNumber, int ourArray[]);

int main()
{
    const int size=10;
    int ourArray [size], findingNumber;
    printf("Hello user!\n");
    input(ourArray, size);
    output(ourArray, size);
    printf("Enter the finding number: ");
    scanf("%d", &findingNumber);
    arrayFind(findingNumber, ourArray);
    return 0;
}

void input(int ourArray[], int size)
{
    printf("Enter array of %d elements\n", size);
    for(int counter1=0; counter1<10; ++counter1)
    {
        printf("Enter %d element of array: ", counter1+1);
        scanf("%d", &ourArray[counter1]);
    }
}

void output(int ourArray [], int size)
{
    printf("\nYour array:\n");
    for(int counter2=0; counter2<10; ++counter2)
    {
        printf("%d element = %d\n", counter2+1, ourArray[counter2]);
    }
}

int arrayFind (int findingNumber, int ourArray[10])
{
    int likeAboolean=0,yourFindingNumberIndex;
    for(int counter3=0; counter3<10; ++counter3)
    {
        if(findingNumber==ourArray[counter3])
        {
            yourFindingNumberIndex=counter3;
            ++likeAboolean;
            break;
        }
    }
    if(likeAboolean>0)
    {
        printf("Your number index = %d", yourFindingNumberIndex);
    }
    else
    {
        printf("-1");
    }
}
