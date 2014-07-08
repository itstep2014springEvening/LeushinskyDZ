#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int counter1=1;
    double x=2.0, exponent=1.0, factorial=1.0, epsilon=0.000001, variable=1.0;
    printf("Hello user!\n");
    for(x=-2.0; x<2.0; x=x+0.1)
    {
        for(;fabs(variable)>epsilon;++counter1)
        {
            factorial=factorial*counter1;
            variable=pow(x, counter1)/factorial;
            exponent=exponent+variable;
        }
        printf("e%f\n", exponent);
    }
    return 0;
}
