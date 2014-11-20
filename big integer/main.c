#include <stdio.h>
#include <stdlib.h>
#include <string.h>

const int maxlen = 500;
const int sys = 10000;

typedef struct _BigInteger
{
    int array[500];
    int possize;

} BigInteger;


int compare(BigInteger a, BigInteger b);
BigInteger add(BigInteger a, BigInteger b);
BigInteger sub(BigInteger a, BigInteger b);
BigInteger multiply (BigInteger a, BigInteger b);
void getlong();
BigInteger printlong(BigInteger a);
void freeArray(BigInteger a);

int main()
{
    BigInteger a, b, c;
    char oper;
    printf("Enter biginteger a: ");
    getlong();
    printf("Enter biginteger b: ");
    getlong();
    printf("Enter operator: ");
    scanf("%c", &oper);
    printf("\n");
    memset(c.array, 0, sizeof(c.array));
    switch(oper)
    {
    case '+':
        c = add(a,b);
        printf("Result = ");
        printlong(c);
        break;
    case '-':
        c = sub(a,b);
        printf("Result = ");
        printlong(c);
        break;
    case '*':
        c = multiply(a,b);
        printf("Result = ");
        printlong(c);
        break;
    default:
        printf("Net operacii\n");
    }
    return 0;
}

int compare(BigInteger a, BigInteger b)
{
    int value;
    for (int i = maxlen; i>=1; --i)
    {
        if (a.array[i]>b.array[i])
            value = 1;
        else if (a.array[i]<b.array[i])
            value = -1;
        else
            value = 0;
    }
    return value;
}

BigInteger add(BigInteger a, BigInteger b)
{
    BigInteger result;

    for (int i = 1; i<maxlen; ++i)
    {
        result.array[i] = a.array[i] + b.array[i];
        b.array[i+1] += result.array[i]/sys;
        result.array[i] %= sys;
    }
    return result;
}

BigInteger sub(BigInteger a, BigInteger b)
{
    BigInteger result;
    int p = compare(a, b);

    for (int i = 1; i<=maxlen; ++i)
    {
        if(p==-1)
        {
            result.array[i] = b.array[i] - a.array[i];
            result.array[i]*=-1;
        }
        else
            result.array[i] = a.array[i] - b.array[i];
    }
    return result;
}

BigInteger multiply (BigInteger a, BigInteger b)
{
    BigInteger result;

    for (int i = 1; i < maxlen; ++i)
    {
        for (int j = 1; j < maxlen; ++j)
        {
            result.array[i + j - 1] += a.array[i] * b.array[j];
            result.array[i + 1] +=  result.array[i] / sys;
            result.array[i] %= sys;
        }
    }
    return result;
}

void getlong()
{
    BigInteger a;
    a.possize=0;
    memset(a.array, 0, sizeof(a.array));
    char str[maxlen];
    gets(str);
    char str2[maxlen];
    memset(str2, 0, sizeof(str2));
    int p=4;
    int sizeStr = strlen(str);
    while (sizeStr>p)
    {
        sizeStr-=p;
        for (int i=sizeStr, j=0; i<sizeStr+p; ++i, ++j)
        {
            str2[j] = str[i];
            str[sizeStr]-=p;
        }
        ++a.possize;
        a.array[a.possize] = atoi(str2);
    }
    if (sizeStr)
        ++a.possize;
    a.array[a.possize] = atoi(str);
    if (str==("-"))
        a.array[a.possize]*=-1;
}

BigInteger printlong(BigInteger a)
{
    a.possize = maxlen;

    while(a.array[a.possize]==0)
        --a.possize;

    if (a.possize==-1)
        printf("0");
    else
        for (int j=a.possize; j>=1; --j)
            printf("%.4d", a.array[j]);
    return a;
}
