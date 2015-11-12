#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a,b;
    printf("Simple!\n");
    for(int counter1 = 0;counter1<10;++counter1)
    {
        printf("777\n");
    }

    printf("a=5 and b=7");
    a=5;
    b=7;
    printf("\n%d+%d=%d\n", a,b,a+b);
    printf("%d-%d=%d\n", a,b,a-b);
    printf("%d*%d=%d\n", a,b,a*b);
    a=10;
    float c = 10;
    printf("%d\n", a);
    printf("%.5f", c);
    return 0;


}
