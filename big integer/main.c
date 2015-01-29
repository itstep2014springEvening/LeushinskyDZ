#include <stdio.h>
#include <stdlib.h>
#include <string.h>

const int maxlen = 10000;
const int sys = 10000;

void getlong (int array[]);
int compare (int *a, int *b);
void printlong (int array[]);
int add (int *a, int *b, int *c);
void freeArray (int array[]);
int sub (int *a, int *b, int *c);
int multiply (int *a, int *b, int *c);

int main()
{
    int a[maxlen], b[maxlen], c[maxlen];
    char oper;
    freeArray(c);
    printf("Enter biginteger a: ");
    getlong(a);
    printf("Enter biginteger b: ");
    getlong(b);
    printf("Enter operator: ");
    scanf("%c", &oper);
    printf("\n");
    switch(oper)
    {
    case '+':
        add(a,b,c);
        printf("Result = ");
        printlong(c);
        break;
    case '-':
        sub(a,b,c);
        printf("Result = ");
        printlong(c);
        break;
    case '*':
        multiply(a,b,c);
        printf("Result = ");
        printlong(c);
        break;
    default:
        printf("Net operacii\n");
    }
    return 0;
}

void getlong (int array[])
{
    freeArray(array);
    char str[maxlen];
    gets(str);
    char str2[maxlen];
    memset(str2, 0, sizeof(str2));
    int p=4;
    int size = strlen(str);
    int r=0;
    while (size>p)
    {
        ++r;
        size-=p;
        for (int i=size, j=0; i<size+p; ++i, ++j)
        {
            str2[j] = str[i];
            str[size]-=p;
        }
        array[r] = atoi(str2);
    }
    if (size)
        ++r;
    array[r] = atoi(str);
    if (str==("-"))
        array[r]*=-1;
}

int compare (int *a, int *b)
{
    int value,i;
    for (i = maxlen; i>=1; --i)
    {
        if (a[i] > b[i])
            value = 1;
        else if (a[i] < b[i])
            value = -1;
        else
            value = 0;
    }

    return value;
}

void printlong (int array[])
{
    int i = maxlen;

    while(array[i]==0)
        --i;

    if (i==-1)
        printf("0");
    else
    {
        if(array[i]<0)
            printf("-");
        for (int j=i; j>=1; --j)
            if (array[j]<0)
            {
                printf("%.4d", abs(array[j]));
            }
            else
                printf("%.4d", array[j]);
    }

}

int add (int *a, int *b, int *c)
{
    int i;
    for (i = 1; i<maxlen; ++i)
    {
        c[i] = a[i] + b[i];
        b[i+1]+= c[i]/sys;
        c[i]%= sys;
    }
    return c[i];
}

int sub (int *a, int *b, int *c)
{
    int i;
    int p=compare(a,b);
    for (i = 1; i<=maxlen; ++i)
    {
        if(p==-1)
        {
            c[i] = b[i] - a[i];
            c[i]*=-1;
        }
        else
            c[i] = a[i] - b[i];
    }
    return c[i];
}

int multiply (int *a, int *b, int *c)
{
    int i, j;
    for (i = 1; i < maxlen; ++i)
    {
        for (j = 1; j < maxlen; ++j)
        {
            c[i + j - 1] += a[i] * b[j];
            c[i + 1] +=  c[i] / sys;
            c[i] %= sys;
        }
    }
    return c[i];
}

void freeArray (int array[])
{
    for (int i=0; i<=maxlen; ++i)
        array[i]=0;
}
