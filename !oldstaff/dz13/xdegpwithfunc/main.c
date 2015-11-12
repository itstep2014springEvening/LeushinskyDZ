#include <stdio.h>
#include <stdlib.h>
#include <math.h>
double degreeder(double X, int P);
int main()
{
    double X;
    int P;
    printf("Hello user!\n");
    printf("Please, enter X: ");
    scanf("%lf", &X);
    printf("Please, enter P: ");
    scanf("%d", &P);
    printf("Result = %.5f.", degreeder(X, P));
    return 0;
}

double degreeder(double X, int P)
{
    double degreeResult=1.0;
    for(int counter1=0; counter1<abs(P); ++counter1)
    {
        degreeResult=degreeResult*X;
    }
    if(P<0)
    {
        degreeResult=1/degreeResult;
    }
    return degreeResult;
}
