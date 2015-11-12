#include <stdio.h>
#include <stdlib.h>

int main()
{
    int dividend, divider;
    printf("Hello user!\n");
    printf("Please, enter the dividend: \n");
    scanf("%d", &dividend);
    printf("Please, enter the divider: \n");
    scanf("%d", &divider);
    for(;dividend>=divider-1;dividend/=divider)
    {
        printf("Dividend=%d\n", dividend);
        if(dividend%divider!=0)
        {
            printf("FINISH");
            break;
        }
    }
    return 0;
}
