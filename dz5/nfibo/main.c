#include <stdio.h>
#include <stdlib.h>

int main()
{
    int amountOfFibonachiNumbers, fibo2=1, fibo1=0;
    printf ("Enter amount of Fibonachi numbers: ");
    scanf ("%d", &amountOfFibonachiNumbers);
    printf("%d\n", fibo1);
    while (amountOfFibonachiNumbers-1>0)
    {
        printf ("%d\n", fibo2);
        fibo1+=fibo2;
        --amountOfFibonachiNumbers;
        if (amountOfFibonachiNumbers>0)
        {
            printf ("%d\n", fibo1);
            fibo2+=fibo1;
            --amountOfFibonachiNumbers;
        }
    }
    return 0;
}
