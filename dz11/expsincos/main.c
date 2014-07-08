#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    double epsilon=0.000001, mathexponent;
    printf("Hello user!\n");
    printf("x             our exp      math exp     math-our\n");
    for(double x=-2.0; x<=2.1; x=x+0.1)
    {
        int counter1=1;
        double ourexponent=1.0;
        double factorial=1.0;
        double variable=1.0;
        while(fabs(variable)>epsilon)
        {
            factorial=factorial*counter1;
            variable=pow(x, counter1)/factorial;
            ourexponent=ourexponent+variable;
            ++counter1;
        }
        mathexponent=exp(x);
        printf("%f,    %f,    %f,    %f\n", x, ourexponent, mathexponent, fabs(mathexponent-ourexponent));
    }
    return 0;
}
