#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int choice;
    printf("Hello user! What you want?\n\n");
    printf("1.Exponent\n");
    printf("2.Sin\n");
    printf("3.Cos\n");
    printf("0.Exit\n");
    printf("Your choice: ");
    scanf("%d", &choice);
    switch(choice)
    {
    case 1:
    {
        double epsilon=0.000001, mathexponent;
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
    }
    break;
    case 2:
    {
        double epsilon=0.000001, mathsin;
        printf("x             our sin      math sin     math-our\n");
        for(double x=-2.0; x<=2.1; x=x+0.1)
        {
            int counter1=1;
            double oursin=0.0;
            double factorial=1.0;
            double plusfactorual1=1.0;
            double variable=1.0;
            while(fabs(variable)>epsilon)
            {
                factorial=factorial*counter1*plusfactorual1;
                variable=pow(x, counter1)/factorial;
                oursin=oursin+variable;
                counter1=(counter1+2);
                plusfactorual1=(counter1-1)*(-1);
            }
            mathsin=sin(x);
            printf("%f,    %f,    %f,    %f\n", x, oursin, mathsin, fabs(mathsin-oursin));
        }
    }
    }
    return 0;
}
