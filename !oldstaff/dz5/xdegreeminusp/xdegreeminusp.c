#include <stdio.h>
#include <stdlib.h>

int main()
{
    int degreeResult = 1, X, P, counter1;
    printf("Hello user!\n");
    printf("Please, enter X: ");
    scanf("%d", &X);
    printf("Please, enter P: ");
    scanf("%d", &P);
    for(counter1=0; counter1<abs(P); ++counter1)
    {
        degreeResult=degreeResult*X;
    }
    if(P<0)
    {
        printf("Result = 1/%d.", degreeResult);
    }
    else
    printf("Result = %d.", degreeResult);
    return 0;
}
