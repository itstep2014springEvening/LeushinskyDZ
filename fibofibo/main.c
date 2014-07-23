#include <stdio.h>
#include <stdlib.h>

long long int fibIter(long long int n);
long long int fibRec(long long int n);

int main()
{
    long long int var;
    scanf("%lld", &var);
    printf("Iter = %lld\n", fibIter(var));
    printf("Rec = %lld\n", fibRec(var));
    return 0;
}

long long int fibIter(long long int n)
{
    long long int a=1,b=0,c;
    for(long long int i=1; i<=n; ++i)
    {
        c=a+b;
        a=b;
        b=c;
    }
    return c;
}

long long int fibRec(long long int n)
{
    if(n==1||n==2)
    {
        return 1;
    }
    return fibRec(n-1)+fibRec(n-2);
}
