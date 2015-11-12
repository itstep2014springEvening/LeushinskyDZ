#include <stdio.h>
#include <stdlib.h>

int main()
{
    int estimatedTime, SashaMoney, SashaCount, vasyaMoney, vasyaValue, vasyaCount, counter1, counter2;
    estimatedTime=24;
    printf("Hello user!\n");
    printf("I'm using 24 quarter.");
    printf("\n\n");
    SashaMoney=1000;
    vasyaMoney=1000;
    SashaCount=SashaMoney*estimatedTime*0.6;
    for(counter1=0; counter1<=estimatedTime; counter1++)
    {
        if(vasyaValue>SashaCount)
        {
            printf("\nVasya richer than Sasha in %d quarter.\n\n", counter1);
            break;
        }
        vasyaValue=vasyaMoney*0.4;
        vasyaCount=vasyaMoney+vasyaValue;
        vasyaMoney=vasyaCount;
        if(vasyaValue<SashaCount)
        {
            printf("Vasya count:%d.00$\n", vasyaValue);
            printf("Sasha count:%d.00$\n", SashaCount);
        }
    }
    for(counter2=1;counter2<=3;++counter2)
    {
        vasyaValue=vasyaMoney*0.4;
        vasyaCount=vasyaMoney+vasyaValue;
        vasyaMoney=vasyaCount;
        printf("Vasya count:%d.00$\n", vasyaValue);
        printf("Sasha count:%d.00$\n", SashaCount);
    }

    printf("\nRESULT:\n");
    printf("Sasha count = %.2d.00$\n", SashaCount);
    printf("Vasya count = %.2d.00$\n", vasyaValue);
    return 0;
}
