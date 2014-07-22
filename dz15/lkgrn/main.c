#include <stdio.h>
#include <stdlib.h>

int randomWithTableNumbers(int x);
int randomWithMyNumbers(int x);

int main()
{
    int x;
    printf("Enter x (start point for random): ");
    scanf("%d", &x);
    printf("Random number, with table numbers = %d\n", randomWithTableNumbers(x));
    printf("Random number, with my numbers = %d\n", randomWithMyNumbers(x));
    return 0;
}

int randomWithTableNumbers(int x)
{
    int a=4096,c=150889,m=714025,nextRandomNumber;
    nextRandomNumber=(a*x+c)%m;
    return nextRandomNumber;
}

int randomWithMyNumbers(int x)
{
    int a=2049,c=158917,m=352914,nextRandomNumber;
    nextRandomNumber=(a*x+c)%m;
    return nextRandomNumber;
}
