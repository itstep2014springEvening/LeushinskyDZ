#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int degreeder(int X, int P);
    int X, P, degreeResult=1;
    printf("Hello user!\n");
    printf("Please, enter X: ");
    scanf("%d", &X);
    printf("Please, enter P: ");
    scanf("%d", &P);
    degreeResult=degreeder(X, P);
    P>0?printf("Result = %d.", degreeResult):printf("Result = 1/%d.", degreeResult);
    return 0;
}

int degreeder(int X, int P)
{
    int degreeResult=1;
    for(int counter1=0; counter1<abs(P); ++counter1)
    {
        degreeResult=degreeResult*X;
        printf("%d\n",degreeResult);
    }
    return degreeResult;
}
