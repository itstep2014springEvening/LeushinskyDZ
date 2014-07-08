#include <stdio.h>
#include <stdlib.h>

int main()
{
    int counter1, number=64;
    for(counter1=0; counter1<10; ++counter1)
    {
        printf("Hello\n");
    }
    for(counter1=0;counter1<7;++counter1)
    {
        printf("%d\n", number);
        number/=2;
    }
    return 0;
}
