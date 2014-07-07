#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    double x, exponent=1.0, factorial=1.0, epsilon=0.001;
    printf("Hello user!\n");
    for(x=-2.0;x<2.0;x=x+0.1)
    {
        while(exponent>epsilon)
        {
            exponent=exponent pow(factorial)+x/factorial;
            factorial++;
        }
       printf("%d\n", x);

    }
    return 0;
}
