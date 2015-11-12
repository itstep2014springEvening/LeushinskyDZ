#include <stdio.h>
#include <stdlib.h>

int main()
{
    int result=1, p, L, x;
    printf("Hello user!\n");
    printf("Please, enter X: ");
    scanf("%d", &x);
    printf("Please, enter L: ");
    scanf("%d", &L);
    for(p=0; result<=L; ++p)
    {
        result=result*x;
    }
    printf("P = %d", p-1);
    return 0;
}
