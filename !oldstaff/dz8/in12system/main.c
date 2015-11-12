#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int tenSystemNumber, twelveSystemNumber=12, summm, counter1;
    printf("Enter your 10system number: ");
    scanf("%d",&tenSystemNumber);
    if(twelveSystemNumber<tenSystemNumber)
    {
        counter1++;
        pow(twelveSystemNumber,counter1);

    }
    printf("Your 12system number = %d", tenSystemNumber%12);
    return 0;
}
