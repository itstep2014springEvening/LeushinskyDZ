#include <stdio.h>
#include <stdlib.h>

int main()
{
    const int N = 10000;
    int a[N];
    int n;
    printf("Enter array size: ");
    scanf("%d", &n);
    input(a, n);
    selection(a,n);
    output(a, n);
    return 0;
}

void output(int a[], int size)
{
    for( int i=0; i<size; ++i)
    {
        printf("%d\n",a[i]);

    }
    printf("\n");
}

void input(int a[], int size)
{
    for(int i=0; i<size; ++i)
    {
        a[i]=rand();
    }
}

void selection(int a[], int size)
{
    int min,temp;
    for (int i=0; i<size; ++i)
    {
        min=i;
        for (int j=i+1; j<size; ++j)
        {
            if (a[j]<a[min])
            {
                min=j;
            }
        }
        temp=a[i];
        a[i]=a[min];
        a[min]=temp;
    }
}
