#include <stdio.h>
#include <stdlib.h>

int main()
{
    int enteredNumber, simpleMultiplier=2;
    printf("Enter your number(>=2): ");
    scanf("%d", &enteredNumber);
    if(enteredNumber<2)
    {
        printf("WARNING! Enter your number(>=2)!");
    }
    else
    {
        while(enteredNumber>1)
        {
            if(enteredNumber%simpleMultiplier==0)
            {
                printf("%d*", simpleMultiplier);
                enteredNumber/=simpleMultiplier;
            }
            else
            {
                simpleMultiplier++;
            }
        }
        printf("1");
    }
    return 0;
}
